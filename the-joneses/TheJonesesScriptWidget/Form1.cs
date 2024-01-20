namespace TheJonesesScriptWidget
{
    public partial class Form1 : Form
    {
        private string _nextSlidePrompt;

        public string Script { get; set;  }
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

        public string NextSlidePrompt { get
            {
                return _nextSlidePrompt;
            }
        }

        public Form1()
        {
            _nextSlidePrompt = "slidshow not started yet.";
            this.Script = File.ReadAllText(this.PromptFullFileName);
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            File.WriteAllText(this.PromptFullFileName, this.Script);
            base.OnClosed(e);
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            Clipboard.SetText(this.NextSlidePrompt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
            this.Hide();
            this.textBox1.Text = this.Script;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Script = this.textBox1.Text;
        }
    }
}