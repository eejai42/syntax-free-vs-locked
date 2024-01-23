namespace TheJonesesScriptWidget
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            showEditorToolStripMenuItem = new ToolStripMenuItem();
            nextStepToolStripMenuItem = new ToolStripMenuItem();
            previousStepToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            _scriptTextBox = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = " -- next step not identified yet --";
            notifyIcon1.BalloonTipTitle = "-- title not set yet --";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Next Demo Step";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            notifyIcon1.MouseDown += notifyIcon1_MouseDown;
            notifyIcon1.MouseMove += notifyIcon1_MouseMove;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showEditorToolStripMenuItem, nextStepToolStripMenuItem, previousStepToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 98);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showEditorToolStripMenuItem
            // 
            showEditorToolStripMenuItem.Name = "showEditorToolStripMenuItem";
            showEditorToolStripMenuItem.Size = new Size(145, 22);
            showEditorToolStripMenuItem.Text = "Show editor";
            showEditorToolStripMenuItem.Click += showEditorToolStripMenuItem_Click;
            // 
            // nextStepToolStripMenuItem
            // 
            nextStepToolStripMenuItem.Name = "nextStepToolStripMenuItem";
            nextStepToolStripMenuItem.Size = new Size(145, 22);
            nextStepToolStripMenuItem.Text = "Next Step";
            nextStepToolStripMenuItem.Click += nextStepToolStripMenuItem_Click;
            // 
            // previousStepToolStripMenuItem
            // 
            previousStepToolStripMenuItem.Name = "previousStepToolStripMenuItem";
            previousStepToolStripMenuItem.Size = new Size(145, 22);
            previousStepToolStripMenuItem.Text = "Previous Step";
            previousStepToolStripMenuItem.Click += previousStepToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // _scriptTextBox
            // 
            _scriptTextBox.Dock = DockStyle.Fill;
            _scriptTextBox.Location = new Point(0, 43);
            _scriptTextBox.Multiline = true;
            _scriptTextBox.Name = "_scriptTextBox";
            _scriptTextBox.ScrollBars = ScrollBars.Vertical;
            _scriptTextBox.Size = new Size(1133, 655);
            _scriptTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 43);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1046, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 698);
            Controls.Add(_scriptTextBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "The Jones  demo";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showEditorToolStripMenuItem;
        private ToolStripMenuItem nextStepToolStripMenuItem;
        private ToolStripMenuItem previousStepToolStripMenuItem;
        private TextBox _scriptTextBox;
        private Panel panel1;
        private Button button1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}