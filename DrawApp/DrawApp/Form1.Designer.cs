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
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCommand
            // 
            this.textCommand.Location = new System.Drawing.Point(13, 36);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(301, 20);
            this.textCommand.TabIndex = 0;
            this.textCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCommand_KeyDown);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(12, 62);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(402, 591);
            this.commandBox.TabIndex = 1;
            this.commandBox.Text = "";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(321, 36);
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
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 7);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(94, 7);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 7;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 692);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.drawSpace);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.textCommand);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Command Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}

