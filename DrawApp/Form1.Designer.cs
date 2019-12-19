namespace DrawApp
{
    partial class Form1
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
            this.textCommand = new System.Windows.Forms.TextBox();
            this.commandBox = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.drawSpace = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCommand
            // 
            this.textCommand.Location = new System.Drawing.Point(12, 26);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(301, 20);
            this.textCommand.TabIndex = 0;
            this.textCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCommand_KeyDown);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(12, 55);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(402, 597);
            this.commandBox.TabIndex = 1;
            this.commandBox.Text = "";
            this.commandBox.TextChanged += new System.EventHandler(this.commandBox_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(320, 26);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(93, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 659);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(196, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(218, 659);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(196, 23);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset Position";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // drawSpace
            // 
            this.drawSpace.Location = new System.Drawing.Point(430, 13);
            this.drawSpace.Name = "drawSpace";
            this.drawSpace.Size = new System.Drawing.Size(584, 667);
            this.drawSpace.TabIndex = 5;
            this.drawSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.drawSpace_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 692);
            this.Controls.Add(this.drawSpace);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.textCommand);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Command Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCommand;
        private System.Windows.Forms.RichTextBox commandBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel drawSpace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

