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
            this.selectFile_Button = new System.Windows.Forms.Button();
            this.format_Button = new System.Windows.Forms.Button();
            this.format1_RadioButton = new System.Windows.Forms.RadioButton();
            this.format2_RadioButton = new System.Windows.Forms.RadioButton();
            this.format3_RadioButton = new System.Windows.Forms.RadioButton();
            this.selectTarget_Label = new System.Windows.Forms.Label();
            this.emailDomain_Textbox = new System.Windows.Forms.TextBox();
            this.errorMessage_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileName_TextBox
            // 
            this.fileName_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fileName_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileName_TextBox.Location = new System.Drawing.Point(12, 21);
            this.fileName_TextBox.Name = "fileName_TextBox";
            this.fileName_TextBox.ReadOnly = true;
            this.fileName_TextBox.Size = new System.Drawing.Size(160, 23);
            this.fileName_TextBox.TabIndex = 0;
            // 
            // selectFile_Button
            // 
            this.selectFile_Button.Location = new System.Drawing.Point(43, 50);
            this.selectFile_Button.Name = "selectFile_Button";
            this.selectFile_Button.Size = new System.Drawing.Size(100, 23);
            this.selectFile_Button.TabIndex = 1;
            this.selectFile_Button.Text = "Select File";
            this.selectFile_Button.UseVisualStyleBackColor = true;
            this.selectFile_Button.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // format_Button
            // 
            this.format_Button.Location = new System.Drawing.Point(55, 230);
            this.format_Button.Name = "format_Button";
            this.format_Button.Size = new System.Drawing.Size(75, 23);
            this.format_Button.TabIndex = 2;
            this.format_Button.Text = "Format";
            this.format_Button.UseVisualStyleBackColor = true;
            this.format_Button.Click += new System.EventHandler(this.format_Button_Click);
            // 
            // format1_RadioButton
            // 
            this.format1_RadioButton.AutoSize = true;
            this.format1_RadioButton.Location = new System.Drawing.Point(19, 105);
            this.format1_RadioButton.Name = "format1_RadioButton";
            this.format1_RadioButton.Size = new System.Drawing.Size(131, 19);
            this.format1_RadioButton.TabIndex = 4;
            this.format1_RadioButton.TabStop = true;
            this.format1_RadioButton.Text = "Firstname Lastname";
            this.format1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // format2_RadioButton
            // 
            this.format2_RadioButton.AutoSize = true;
            this.format2_RadioButton.Location = new System.Drawing.Point(19, 130);
            this.format2_RadioButton.Name = "format2_RadioButton";
            this.format2_RadioButton.Size = new System.Drawing.Size(134, 19);
            this.format2_RadioButton.TabIndex = 5;
            this.format2_RadioButton.TabStop = true;
            this.format2_RadioButton.Text = "Lastname, Firstname";
            this.format2_RadioButton.UseVisualStyleBackColor = true;
            // 
            // format3_RadioButton
            // 
            this.format3_RadioButton.AutoSize = true;
            this.format3_RadioButton.Location = new System.Drawing.Point(19, 155);
            this.format3_RadioButton.Name = "format3_RadioButton";
            this.format3_RadioButton.Size = new System.Drawing.Size(138, 19);
            this.format3_RadioButton.TabIndex = 6;
            this.format3_RadioButton.TabStop = true;
            this.format3_RadioButton.Text = "First.Last@email.com";
            this.format3_RadioButton.UseVisualStyleBackColor = true;
            // 
            // selectTarget_Label
            // 
            this.selectTarget_Label.AutoSize = true;
            this.selectTarget_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectTarget_Label.Location = new System.Drawing.Point(12, 85);
            this.selectTarget_Label.Name = "selectTarget_Label";
            this.selectTarget_Label.Size = new System.Drawing.Size(124, 15);
            this.selectTarget_Label.TabIndex = 7;
            this.selectTarget_Label.Text = "Select Target Format";
            // 
            // emailDomain_Textbox
            // 
            this.emailDomain_Textbox.Location = new System.Drawing.Point(12, 180);
            this.emailDomain_Textbox.Name = "emailDomain_Textbox";
            this.emailDomain_Textbox.PlaceholderText = "Email.com";
            this.emailDomain_Textbox.Size = new System.Drawing.Size(160, 23);
            this.emailDomain_Textbox.TabIndex = 8;
            this.emailDomain_Textbox.Visible = false;
            // 
            // errorMessage_Label
            // 
            this.errorMessage_Label.AutoSize = true;
            this.errorMessage_Label.ForeColor = System.Drawing.Color.Red;
            this.errorMessage_Label.Location = new System.Drawing.Point(12, 209);
            this.errorMessage_Label.Name = "errorMessage_Label";
            this.errorMessage_Label.Size = new System.Drawing.Size(35, 15);
            this.errorMessage_Label.TabIndex = 9;
            this.errorMessage_Label.Text = "Error:";
            this.errorMessage_Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.errorMessage_Label);
            this.Controls.Add(this.emailDomain_Textbox);
            this.Controls.Add(this.selectTarget_Label);
            this.Controls.Add(this.format3_RadioButton);
            this.Controls.Add(this.format2_RadioButton);
            this.Controls.Add(this.format1_RadioButton);
            this.Controls.Add(this.format_Button);
            this.Controls.Add(this.selectFile_Button);
            this.Controls.Add(this.fileName_TextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileName_TextBox;
        private Button selectFile_Button;
        private Button format_Button;
        private RadioButton format1_RadioButton;
        private RadioButton format2_RadioButton;
        private RadioButton format3_RadioButton;
        private Label selectTarget_Label;
        private TextBox emailDomain_Textbox;
        private Label errorMessage_Label;
    }
}