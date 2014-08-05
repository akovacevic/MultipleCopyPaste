namespace HotKeyTestProject
{
    partial class HotKeysForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotKeysForm));
            this.mynotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mynotifyIcon
            // 
            this.mynotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyIcon.BalloonTipText = "Minimized to Tray";
            this.mynotifyIcon.BalloonTipTitle = "Multiple Copy and Paste";
            this.mynotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyIcon.Icon")));
            this.mynotifyIcon.Text = "MultipleCopyPaste";
            this.mynotifyIcon.DoubleClick += new System.EventHandler(this.HotKeysForm_Show);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // PasteTextBox
            // 
            this.PasteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteTextBox.Location = new System.Drawing.Point(121, 70);
            this.PasteTextBox.Name = "PasteTextBox";
            this.PasteTextBox.Size = new System.Drawing.Size(218, 26);
            this.PasteTextBox.TabIndex = 1;
            this.PasteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasteTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copy Hotkey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paste Hotkey:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 113);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(97, 113);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "+ (0-9)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "+ (0-9)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 148);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolLabel
            // 
            this.ToolLabel.ActiveLinkColor = System.Drawing.Color.Purple;
            this.ToolLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ToolLabel.Name = "ToolLabel";
            this.ToolLabel.Size = new System.Drawing.Size(89, 22);
            this.ToolLabel.Text = "Status: Stopped";
            this.ToolLabel.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // HotKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(421, 173);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasteTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotKeysForm";
            this.Text = "Multiple Copy and Paste";
            this.ResizeEnd += new System.EventHandler(this.HotKeysForm_Resize);
            this.SizeChanged += new System.EventHandler(this.HotKeysForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mynotifyIcon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PasteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ToolLabel;
    }
}