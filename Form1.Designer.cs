namespace FormatNames {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fileName_TextBox = new System.Windows.Forms.TextBox();
            this.selectFile_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileName_TextBox
            // 
            this.fileName_TextBox.Location = new System.Drawing.Point(12, 21);
            this.fileName_TextBox.Name = "fileName_TextBox";
            this.fileName_TextBox.Size = new System.Drawing.Size(160, 23);
            this.fileName_TextBox.TabIndex = 0;
            // 
            // selectFile_button
            // 
            this.selectFile_button.Location = new System.Drawing.Point(43, 50);
            this.selectFile_button.Name = "selectFile_button";
            this.selectFile_button.Size = new System.Drawing.Size(100, 23);
            this.selectFile_button.TabIndex = 1;
            this.selectFile_button.Text = "Select File";
            this.selectFile_button.UseVisualStyleBackColor = true;
            this.selectFile_button.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 211);
            this.Controls.Add(this.selectFile_button);
            this.Controls.Add(this.fileName_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileName_TextBox;
        private Button selectFile_button;
    }
}