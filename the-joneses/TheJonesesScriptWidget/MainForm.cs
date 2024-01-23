using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace TheJonesesScriptWidget
{
    public partial class MainForm : Form
    {
        public int CurrentStepIndex { get; private set; } = 0;
        public DemoStep CurrentStep
        {
            get
            {
                var step = default(DemoStep);
                if (this.CurrentStepIndex < this.Steps?.Count)
                {
                    step = this.Steps[this.CurrentStepIndex];
                }
                else { step = new DemoStep("--", "--", "--"); }

                return step;
            }
        }
        public string CurrentStepTitle { get => $"{this.CurrentStep.Title}"; }
        public string CurrentStepText { get => $"{this.CurrentStepIndex}. {this.CurrentStep.SpeakerNotes}."; }

        public string CurrentSlidePrompt { get => $"{this.CurrentStep.ClipboardContent}"; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void NotifyIcon1_BalloonTipClicked(object? sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.CurrentSlidePrompt)) return;
            Clipboard.SetText(this.CurrentSlidePrompt);
            this.ShowingToolTip = false;
            this.CurrentStepIndex++;
            if (this.CurrentStepIndex >= this.Steps?.Count)
            {
                this.CurrentStepIndex = 0;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ResetScript();
        }

        private void ResetScript()
        {
            this.Hide();
            this.PromptEditorIsVisble = false;
            _scriptTextBox.Text = File.ReadAllText(this.PromptFullFileName);
            this.Steps = DemoScriptParser.ParseScriptIntoSteps(_scriptTextBox.Text);
            this.ShowingTipTimeout = 5000;
            this.ShowBalloon();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            this.SaveToTXTFile();
            base.OnClosed(e);
        }

        public List<DemoStep> Steps { get; private set; } = new List<DemoStep>(new DemoStep[]
        {
            new DemoStep("Click to start demo", "--demo not started yet--", "--demo not started yet--")
        });


        #region Private Helper Functions
        public int ShowingTipTimeout { get; private set; }
        public bool ShowingToolTip { get; private set; }
        public bool PromptEditorIsVisble { get; private set; }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.IsHovering || this.contextMenuStrip1.Visible) return;
            this.IsHovering = true;
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                if (this.IsHovering)
                {
                    Debug.WriteLine($"SHOWING BALOON?: {this.IsHovering}");
                    this.IsHovering = false;
                    this.ShowBalloon();
                }
            });
        }

        private void ShowBalloon()
        {
            if (this.ShowingToolTip) return;
            this.notifyIcon1.BalloonTipTitle = this.CurrentStepTitle;
            this.notifyIcon1.BalloonTipText = this.CurrentStepText;
            this.ShowingToolTip = true;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.ShowBalloonTip(this.ShowingTipTimeout);
            Task.Factory.StartNew(() =>
            {
                var startTime = DateTime.Now;
                while (this.ShowingToolTip)
                {
                    Thread.Sleep(100);
                    if (DateTime.Now.Subtract(startTime).TotalMilliseconds > this.ShowingTipTimeout) break;
                }
                this.ShowingToolTip = false;
            });
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (this.PromptEditorIsVisble) return;
            this.Hide();
        }
        private void showEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PromptEditorIsVisble = !this.PromptEditorIsVisble;
            if (this.PromptEditorIsVisble)
            {
                this.Show();
                ((ToolStripMenuItem)sender).Text = "Hide editor";
            }
            else
            {
                this.Hide();
                ((ToolStripMenuItem)sender).Text = "Show editor";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.showEditorToolStripMenuItem_Click(this.showEditorToolStripMenuItem, e);
        }

        private void SaveToTXTFile()
        {
            if (_scriptTextBox.Text.Length < 50) return;

            File.WriteAllText(this.PromptFullFileName, this._scriptTextBox.Text);
            
            this.ResetScript();
        }
        public string PromptFullFileName
        {
            get
            {
                string promptFileName = Path.Combine("c:/users/auto1/go/src/github.com/eejai42/syntax-free-research/the-joneses/prompt.txt");
                var promptFI = new FileInfo(promptFileName);
                if (!promptFI.Exists) throw new Exception($"syntax-free-research/prompt.txt not found in '{promptFI?.Directory?.FullName}'.");
                return promptFI.FullName;
            }
        }

        public bool IsHovering { get; private set; }

        protected override void OnVisibleChanged(EventArgs e)
        {
            this.SaveToTXTFile();
            base.OnVisibleChanged(e);
        }

        #endregion

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine($"LEFT MOUSE CLICK HOVERING: {this.IsHovering}");
            this.CurrentStepIndex = 0;
            this.ShowBalloon();
        }

        private void nextStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentStepIndex++;
        }

        private void previousStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentStepIndex--;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                this.IsHovering = false;
            });
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.IsHovering = false;
        }
    }
}