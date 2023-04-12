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
            this.firstLastFormat_RadioButton = new System.Windows.Forms.RadioButton();
            this.lastFirstFormat_RadioButton = new System.Windows.Forms.RadioButton();
            this.emailFormat_RadioButton = new System.Windows.Forms.RadioButton();
            this.selectTarget_Label = new System.Windows.Forms.Label();
            this.emailDomain_Textbox = new System.Windows.Forms.TextBox();
            this.consoleMessage_Label = new System.Windows.Forms.Label();
            this.selectCaps_Label = new System.Windows.Forms.Label();
            this.capitalizedStyle_radioButton = new System.Windows.Forms.RadioButton();
            this.lowercaseStyle_radioButton = new System.Windows.Forms.RadioButton();
            this.standardStyle_radioButton = new System.Windows.Forms.RadioButton();
            this.captializationStyle_Panel = new System.Windows.Forms.Panel();
            this.targetFormat_Panel = new System.Windows.Forms.Panel();
            this.console_Panel = new System.Windows.Forms.Panel();
            this.consoleTitle_Label = new System.Windows.Forms.Label();
            this.captializationStyle_Panel.SuspendLayout();
            this.targetFormat_Panel.SuspendLayout();
            this.console_Panel.SuspendLayout();
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
            this.format_Button.Location = new System.Drawing.Point(55, 360);
            this.format_Button.Name = "format_Button";
            this.format_Button.Size = new System.Drawing.Size(75, 23);
            this.format_Button.TabIndex = 2;
            this.format_Button.Text = "Format";
            this.format_Button.UseVisualStyleBackColor = true;
            this.format_Button.Click += new System.EventHandler(this.format_Button_Click);
            // 
            // firstLastFormat_RadioButton
            // 
            this.firstLastFormat_RadioButton.AutoSize = true;
            this.firstLastFormat_RadioButton.Location = new System.Drawing.Point(7, 20);
            this.firstLastFormat_RadioButton.Name = "firstLastFormat_RadioButton";
            this.firstLastFormat_RadioButton.Size = new System.Drawing.Size(131, 19);
            this.firstLastFormat_RadioButton.TabIndex = 4;
            this.firstLastFormat_RadioButton.TabStop = true;
            this.firstLastFormat_RadioButton.Text = "Firstname Lastname";
            this.firstLastFormat_RadioButton.UseVisualStyleBackColor = true;
            this.firstLastFormat_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.lastFirstFormat_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.emailFormat_RadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
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
            this.emailDomain_Textbox.TextChanged += new System.EventHandler(this.emailDomain_Textbox_TextChanged);
            // 
            // consoleMessage_Label
            // 
            this.consoleMessage_Label.AutoSize = true;
            this.consoleMessage_Label.ForeColor = System.Drawing.Color.Black;
            this.consoleMessage_Label.Location = new System.Drawing.Point(0, 15);
            this.consoleMessage_Label.MinimumSize = new System.Drawing.Size(160, 15);
            this.consoleMessage_Label.Name = "consoleMessage_Label";
            this.consoleMessage_Label.Size = new System.Drawing.Size(160, 15);
            this.consoleMessage_Label.TabIndex = 9;
            this.consoleMessage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectCaps_Label
            // 
            this.selectCaps_Label.AutoSize = true;
            this.selectCaps_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectCaps_Label.Location = new System.Drawing.Point(3, 0);
            this.selectCaps_Label.Name = "selectCaps_Label";
            this.selectCaps_Label.Size = new System.Drawing.Size(150, 15);
            this.selectCaps_Label.TabIndex = 10;
            this.selectCaps_Label.Text = "Select Capitalization Style";
            // 
            // capitalizedStyle_radioButton
            // 
            this.capitalizedStyle_radioButton.AutoSize = true;
            this.capitalizedStyle_radioButton.Location = new System.Drawing.Point(10, 21);
            this.capitalizedStyle_radioButton.Name = "capitalizedStyle_radioButton";
            this.capitalizedStyle_radioButton.Size = new System.Drawing.Size(70, 19);
            this.capitalizedStyle_radioButton.TabIndex = 11;
            this.capitalizedStyle_radioButton.Text = "CAPITAL";
            this.capitalizedStyle_radioButton.UseVisualStyleBackColor = true;
            this.capitalizedStyle_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lowercaseStyle_radioButton
            // 
            this.lowercaseStyle_radioButton.AutoSize = true;
            this.lowercaseStyle_radioButton.Location = new System.Drawing.Point(10, 46);
            this.lowercaseStyle_radioButton.Name = "lowercaseStyle_radioButton";
            this.lowercaseStyle_radioButton.Size = new System.Drawing.Size(77, 19);
            this.lowercaseStyle_radioButton.TabIndex = 12;
            this.lowercaseStyle_radioButton.Text = "lowercase";
            this.lowercaseStyle_radioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lowercaseStyle_radioButton.UseVisualStyleBackColor = true;
            this.lowercaseStyle_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // standardStyle_radioButton
            // 
            this.standardStyle_radioButton.AutoSize = true;
            this.standardStyle_radioButton.Checked = true;
            this.standardStyle_radioButton.Location = new System.Drawing.Point(10, 71);
            this.standardStyle_radioButton.Name = "standardStyle_radioButton";
            this.standardStyle_radioButton.Size = new System.Drawing.Size(72, 19);
            this.standardStyle_radioButton.TabIndex = 13;
            this.standardStyle_radioButton.TabStop = true;
            this.standardStyle_radioButton.Text = "Standard";
            this.standardStyle_radioButton.UseVisualStyleBackColor = true;
            this.standardStyle_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // captializationStyle_Panel
            // 
            this.captializationStyle_Panel.Controls.Add(this.selectCaps_Label);
            this.captializationStyle_Panel.Controls.Add(this.standardStyle_radioButton);
            this.captializationStyle_Panel.Controls.Add(this.capitalizedStyle_radioButton);
            this.captializationStyle_Panel.Controls.Add(this.lowercaseStyle_radioButton);
            this.captializationStyle_Panel.Location = new System.Drawing.Point(12, 85);
            this.captializationStyle_Panel.Name = "captializationStyle_Panel";
            this.captializationStyle_Panel.Size = new System.Drawing.Size(160, 100);
            this.captializationStyle_Panel.TabIndex = 14;
            // 
            // targetFormat_Panel
            // 
            this.targetFormat_Panel.Controls.Add(this.selectTarget_Label);
            this.targetFormat_Panel.Controls.Add(this.firstLastFormat_RadioButton);
            this.targetFormat_Panel.Controls.Add(this.lastFirstFormat_RadioButton);
            this.targetFormat_Panel.Controls.Add(this.emailDomain_Textbox);
            this.targetFormat_Panel.Controls.Add(this.emailFormat_RadioButton);
            this.targetFormat_Panel.Location = new System.Drawing.Point(12, 190);
            this.targetFormat_Panel.Name = "targetFormat_Panel";
            this.targetFormat_Panel.Size = new System.Drawing.Size(160, 118);
            this.targetFormat_Panel.TabIndex = 15;
            // 
            // console_Panel
            // 
            this.console_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.console_Panel.Controls.Add(this.consoleTitle_Label);
            this.console_Panel.Controls.Add(this.consoleMessage_Label);
            this.console_Panel.Location = new System.Drawing.Point(12, 315);
            this.console_Panel.Name = "console_Panel";
            this.console_Panel.Size = new System.Drawing.Size(160, 41);
            this.console_Panel.TabIndex = 16;
            // 
            // consoleTitle_Label
            // 
            this.consoleTitle_Label.AutoSize = true;
            this.consoleTitle_Label.Location = new System.Drawing.Point(0, -2);
            this.consoleTitle_Label.Name = "consoleTitle_Label";
            this.consoleTitle_Label.Size = new System.Drawing.Size(51, 15);
            this.consoleTitle_Label.TabIndex = 10;
            this.consoleTitle_Label.Text = "Preview:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 391);
            this.Controls.Add(this.console_Panel);
            this.Controls.Add(this.targetFormat_Panel);
            this.Controls.Add(this.captializationStyle_Panel);
            this.Controls.Add(this.format_Button);
            this.Controls.Add(this.selectFile_Button);
            this.Controls.Add(this.fileName_TextBox);
            this.Name = "Form1";
            this.captializationStyle_Panel.ResumeLayout(false);
            this.captializationStyle_Panel.PerformLayout();
            this.targetFormat_Panel.ResumeLayout(false);
            this.targetFormat_Panel.PerformLayout();
            this.console_Panel.ResumeLayout(false);
            this.console_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fileName_TextBox;
        private Button selectFile_Button;
        private Button format_Button;
        private RadioButton firstLastFormat_RadioButton;
        private RadioButton lastFirstFormat_RadioButton;
        private RadioButton emailFormat_RadioButton;
        private Label selectTarget_Label;
        private TextBox emailDomain_Textbox;
        private Label consoleMessage_Label;
        private Label selectCaps_Label;
        private RadioButton capitalizedStyle_radioButton;
        private RadioButton lowercaseStyle_radioButton;
        private RadioButton standardStyle_radioButton;
        private Panel captializationStyle_Panel;
        private Panel targetFormat_Panel;
        private Panel console_Panel;
        private Label consoleTitle_Label;
    }
}