namespace TheJonesesScriptWidget
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            showEditorToolStripMenuItem = new ToolStripMenuItem();
            nextStepToolStripMenuItem = new ToolStripMenuItem();
            previousStepToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            panel1 = new Panel();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Alice and bob....";
            notifyIcon1.BalloonTipTitle = "Step 3";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClosed += notifyIcon1_BalloonTipClosed;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showEditorToolStripMenuItem, nextStepToolStripMenuItem, previousStepToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 70);
            // 
            // showEditorToolStripMenuItem
            // 
            showEditorToolStripMenuItem.Name = "showEditorToolStripMenuItem";
            showEditorToolStripMenuItem.Size = new Size(145, 22);
            showEditorToolStripMenuItem.Text = "Show editor";
            // 
            // nextStepToolStripMenuItem
            // 
            nextStepToolStripMenuItem.Name = "nextStepToolStripMenuItem";
            nextStepToolStripMenuItem.Size = new Size(145, 22);
            nextStepToolStripMenuItem.Text = "Next Step";
            // 
            // previousStepToolStripMenuItem
            // 
            previousStepToolStripMenuItem.Name = "previousStepToolStripMenuItem";
            previousStepToolStripMenuItem.Size = new Size(145, 22);
            previousStepToolStripMenuItem.Text = "Previous Step";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(792, 598);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 100);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 698);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "The Jones  demo";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showEditorToolStripMenuItem;
        private ToolStripMenuItem nextStepToolStripMenuItem;
        private ToolStripMenuItem previousStepToolStripMenuItem;
        private TextBox textBox1;
        private Panel panel1;
    }
}