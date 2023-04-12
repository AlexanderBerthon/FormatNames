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
            this.firstLastFormat1_RadioButton = new System.Windows.Forms.RadioButton();
            this.lastFirstFormat_RadioButton = new System.Windows.Forms.RadioButton();
            this.emailFormat_RadioButton = new System.Windows.Forms.RadioButton();
            this.selectTarget_Label = new System.Windows.Forms.Label();
            this.emailDomain_Textbox = new System.Windows.Forms.TextBox();
            this.errorMessage_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.format_Button.Location = new System.Drawing.Point(55, 330);
            this.format_Button.Name = "format_Button";
            this.format_Button.Size = new System.Drawing.Size(75, 23);
            this.format_Button.TabIndex = 2;
            this.format_Button.Text = "Format";
            this.format_Button.UseVisualStyleBackColor = true;
            this.format_Button.Click += new System.EventHandler(this.format_Button_Click);
            // 
            // firstLastFormat1_RadioButton
            // 
            this.firstLastFormat1_RadioButton.AutoSize = true;
            this.firstLastFormat1_RadioButton.Location = new System.Drawing.Point(7, 20);
            this.firstLastFormat1_RadioButton.Name = "firstLastFormat1_RadioButton";
            this.firstLastFormat1_RadioButton.Size = new System.Drawing.Size(131, 19);
            this.firstLastFormat1_RadioButton.TabIndex = 4;
            this.firstLastFormat1_RadioButton.TabStop = true;
            this.firstLastFormat1_RadioButton.Text = "Firstname Lastname";
            this.firstLastFormat1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // lastFirstFormat_RadioButton
            // 
            this.lastFirstFormat_RadioButton.AutoSize = true;
            this.lastFirstFormat_RadioButton.Location = new System.Drawing.Point(7, 45);
            this.lastFirstFormat_RadioButton.Name = "lastFirstFormat_RadioButton";
            this.lastFirstFormat_RadioButton.Size = new System.Drawing.Size(134, 19);
            this.lastFirstFormat_RadioButton.TabIndex = 5;
            this.lastFirstFormat_RadioButton.TabStop = true;
            this.lastFirstFormat_RadioButton.Text = "Lastname, Firstname";
            this.lastFirstFormat_RadioButton.UseVisualStyleBackColor = true;
            // 
            // emailFormat_RadioButton
            // 
            this.emailFormat_RadioButton.AutoSize = true;
            this.emailFormat_RadioButton.Location = new System.Drawing.Point(7, 70);
            this.emailFormat_RadioButton.Name = "emailFormat_RadioButton";
            this.emailFormat_RadioButton.Size = new System.Drawing.Size(138, 19);
            this.emailFormat_RadioButton.TabIndex = 6;
            this.emailFormat_RadioButton.TabStop = true;
            this.emailFormat_RadioButton.Text = "First.Last@email.com";
            this.emailFormat_RadioButton.UseVisualStyleBackColor = true;
            this.emailFormat_RadioButton.CheckedChanged += new System.EventHandler(this.emailFormat_RadioButton_CheckedChanged);
            // 
            // selectTarget_Label
            // 
            this.selectTarget_Label.AutoSize = true;
            this.selectTarget_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectTarget_Label.Location = new System.Drawing.Point(0, 0);
            this.selectTarget_Label.Name = "selectTarget_Label";
            this.selectTarget_Label.Size = new System.Drawing.Size(124, 15);
            this.selectTarget_Label.TabIndex = 7;
            this.selectTarget_Label.Text = "Select Target Format";
            // 
            // emailDomain_Textbox
            // 
            this.emailDomain_Textbox.Location = new System.Drawing.Point(0, 95);
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
            this.errorMessage_Label.Location = new System.Drawing.Point(12, 309);
            this.errorMessage_Label.Name = "errorMessage_Label";
            this.errorMessage_Label.Size = new System.Drawing.Size(35, 15);
            this.errorMessage_Label.TabIndex = 9;
            this.errorMessage_Label.Text = "Error:";
            this.errorMessage_Label.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Capitalization Style";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 19);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ALL CAPITAL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "all lower";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 19);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Gramatically correct";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 100);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectTarget_Label);
            this.panel2.Controls.Add(this.firstLastFormat1_RadioButton);
            this.panel2.Controls.Add(this.lastFirstFormat_RadioButton);
            this.panel2.Controls.Add(this.emailDomain_Textbox);
            this.panel2.Controls.Add(this.emailFormat_RadioButton);
            this.panel2.Location = new System.Drawing.Point(12, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 118);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorMessage_Label);
            this.Controls.Add(this.format_Button);
            this.Controls.Add(this.selectFile_Button);
            this.Controls.Add(this.fileName_TextBox);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileName_TextBox;
        private Button selectFile_Button;
        private Button format_Button;
        private RadioButton firstLastFormat1_RadioButton;
        private RadioButton lastFirstFormat_RadioButton;
        private RadioButton emailFormat_RadioButton;
        private Label selectTarget_Label;
        private TextBox emailDomain_Textbox;
        private Label errorMessage_Label;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel panel1;
        private Panel panel2;
    }
}