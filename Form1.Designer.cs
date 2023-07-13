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
            fileName_TextBox = new TextBox();
            selectFile_Button = new Button();
            format_Button = new Button();
            firstLastFormat_RadioButton = new RadioButton();
            lastFirstFormat_RadioButton = new RadioButton();
            emailFormat_RadioButton = new RadioButton();
            selectTarget_Label = new Label();
            emailDomain_Textbox = new TextBox();
            consoleMessage_Label = new Label();
            selectCaps_Label = new Label();
            capitalizedStyle_radioButton = new RadioButton();
            lowercaseStyle_radioButton = new RadioButton();
            standardStyle_radioButton = new RadioButton();
            captializationStyle_Panel = new Panel();
            targetFormat_Panel = new Panel();
            console_Panel = new Panel();
            consoleTitle_Label = new Label();
            panel1 = new Panel();
            removeDulicate_Label = new Label();
            removeDuplicate_RadioButton = new RadioButton();
            keepDuplicates_RadioButton = new RadioButton();
            captializationStyle_Panel.SuspendLayout();
            targetFormat_Panel.SuspendLayout();
            console_Panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileName_TextBox
            // 
            fileName_TextBox.BackColor = SystemColors.Control;
            fileName_TextBox.ForeColor = SystemColors.WindowText;
            fileName_TextBox.Location = new Point(12, 21);
            fileName_TextBox.Name = "fileName_TextBox";
            fileName_TextBox.ReadOnly = true;
            fileName_TextBox.Size = new Size(160, 23);
            fileName_TextBox.TabIndex = 0;
            // 
            // selectFile_Button
            // 
            selectFile_Button.Location = new Point(43, 50);
            selectFile_Button.Name = "selectFile_Button";
            selectFile_Button.Size = new Size(100, 23);
            selectFile_Button.TabIndex = 1;
            selectFile_Button.Text = "Select File";
            selectFile_Button.UseVisualStyleBackColor = true;
            selectFile_Button.Click += FileSelectButton_Click;
            // 
            // format_Button
            // 
            format_Button.Location = new Point(55, 415);
            format_Button.Name = "format_Button";
            format_Button.Size = new Size(75, 23);
            format_Button.TabIndex = 2;
            format_Button.Text = "Format";
            format_Button.UseVisualStyleBackColor = true;
            format_Button.Click += format_Button_Click;
            // 
            // firstLastFormat_RadioButton
            // 
            firstLastFormat_RadioButton.AutoSize = true;
            firstLastFormat_RadioButton.Location = new Point(7, 20);
            firstLastFormat_RadioButton.Name = "firstLastFormat_RadioButton";
            firstLastFormat_RadioButton.Size = new Size(131, 19);
            firstLastFormat_RadioButton.TabIndex = 4;
            firstLastFormat_RadioButton.TabStop = true;
            firstLastFormat_RadioButton.Text = "Firstname Lastname";
            firstLastFormat_RadioButton.UseVisualStyleBackColor = true;
            firstLastFormat_RadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // lastFirstFormat_RadioButton
            // 
            lastFirstFormat_RadioButton.AutoSize = true;
            lastFirstFormat_RadioButton.Location = new Point(7, 45);
            lastFirstFormat_RadioButton.Name = "lastFirstFormat_RadioButton";
            lastFirstFormat_RadioButton.Size = new Size(134, 19);
            lastFirstFormat_RadioButton.TabIndex = 5;
            lastFirstFormat_RadioButton.TabStop = true;
            lastFirstFormat_RadioButton.Text = "Lastname, Firstname";
            lastFirstFormat_RadioButton.UseVisualStyleBackColor = true;
            lastFirstFormat_RadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // emailFormat_RadioButton
            // 
            emailFormat_RadioButton.AutoSize = true;
            emailFormat_RadioButton.Location = new Point(7, 70);
            emailFormat_RadioButton.Name = "emailFormat_RadioButton";
            emailFormat_RadioButton.Size = new Size(138, 19);
            emailFormat_RadioButton.TabIndex = 6;
            emailFormat_RadioButton.TabStop = true;
            emailFormat_RadioButton.Text = "First.Last@email.com";
            emailFormat_RadioButton.UseVisualStyleBackColor = true;
            emailFormat_RadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // selectTarget_Label
            // 
            selectTarget_Label.AutoSize = true;
            selectTarget_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectTarget_Label.Location = new Point(0, 0);
            selectTarget_Label.Name = "selectTarget_Label";
            selectTarget_Label.Size = new Size(124, 15);
            selectTarget_Label.TabIndex = 7;
            selectTarget_Label.Text = "Select Target Format";
            // 
            // emailDomain_Textbox
            // 
            emailDomain_Textbox.Location = new Point(0, 95);
            emailDomain_Textbox.Name = "emailDomain_Textbox";
            emailDomain_Textbox.PlaceholderText = "Email.com";
            emailDomain_Textbox.Size = new Size(160, 23);
            emailDomain_Textbox.TabIndex = 8;
            emailDomain_Textbox.Visible = false;
            emailDomain_Textbox.TextChanged += emailDomain_Textbox_TextChanged;
            // 
            // consoleMessage_Label
            // 
            consoleMessage_Label.AutoSize = true;
            consoleMessage_Label.ForeColor = Color.Black;
            consoleMessage_Label.Location = new Point(0, 15);
            consoleMessage_Label.MinimumSize = new Size(160, 15);
            consoleMessage_Label.Name = "consoleMessage_Label";
            consoleMessage_Label.Size = new Size(160, 15);
            consoleMessage_Label.TabIndex = 9;
            consoleMessage_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectCaps_Label
            // 
            selectCaps_Label.AutoSize = true;
            selectCaps_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectCaps_Label.Location = new Point(3, 0);
            selectCaps_Label.Name = "selectCaps_Label";
            selectCaps_Label.Size = new Size(150, 15);
            selectCaps_Label.TabIndex = 10;
            selectCaps_Label.Text = "Select Capitalization Style";
            // 
            // capitalizedStyle_radioButton
            // 
            capitalizedStyle_radioButton.AutoSize = true;
            capitalizedStyle_radioButton.Location = new Point(10, 21);
            capitalizedStyle_radioButton.Name = "capitalizedStyle_radioButton";
            capitalizedStyle_radioButton.Size = new Size(70, 19);
            capitalizedStyle_radioButton.TabIndex = 11;
            capitalizedStyle_radioButton.Text = "CAPITAL";
            capitalizedStyle_radioButton.UseVisualStyleBackColor = true;
            capitalizedStyle_radioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // lowercaseStyle_radioButton
            // 
            lowercaseStyle_radioButton.AutoSize = true;
            lowercaseStyle_radioButton.Location = new Point(10, 46);
            lowercaseStyle_radioButton.Name = "lowercaseStyle_radioButton";
            lowercaseStyle_radioButton.Size = new Size(77, 19);
            lowercaseStyle_radioButton.TabIndex = 12;
            lowercaseStyle_radioButton.Text = "lowercase";
            lowercaseStyle_radioButton.TextAlign = ContentAlignment.MiddleCenter;
            lowercaseStyle_radioButton.UseVisualStyleBackColor = true;
            lowercaseStyle_radioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // standardStyle_radioButton
            // 
            standardStyle_radioButton.AutoSize = true;
            standardStyle_radioButton.Checked = true;
            standardStyle_radioButton.Location = new Point(10, 71);
            standardStyle_radioButton.Name = "standardStyle_radioButton";
            standardStyle_radioButton.Size = new Size(72, 19);
            standardStyle_radioButton.TabIndex = 13;
            standardStyle_radioButton.TabStop = true;
            standardStyle_radioButton.Text = "Standard";
            standardStyle_radioButton.UseVisualStyleBackColor = true;
            standardStyle_radioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // captializationStyle_Panel
            // 
            captializationStyle_Panel.Controls.Add(selectCaps_Label);
            captializationStyle_Panel.Controls.Add(standardStyle_radioButton);
            captializationStyle_Panel.Controls.Add(capitalizedStyle_radioButton);
            captializationStyle_Panel.Controls.Add(lowercaseStyle_radioButton);
            captializationStyle_Panel.Location = new Point(12, 85);
            captializationStyle_Panel.Name = "captializationStyle_Panel";
            captializationStyle_Panel.Size = new Size(160, 100);
            captializationStyle_Panel.TabIndex = 14;
            // 
            // targetFormat_Panel
            // 
            targetFormat_Panel.Controls.Add(selectTarget_Label);
            targetFormat_Panel.Controls.Add(firstLastFormat_RadioButton);
            targetFormat_Panel.Controls.Add(lastFirstFormat_RadioButton);
            targetFormat_Panel.Controls.Add(emailDomain_Textbox);
            targetFormat_Panel.Controls.Add(emailFormat_RadioButton);
            targetFormat_Panel.Location = new Point(12, 190);
            targetFormat_Panel.Name = "targetFormat_Panel";
            targetFormat_Panel.Size = new Size(160, 118);
            targetFormat_Panel.TabIndex = 15;
            // 
            // console_Panel
            // 
            console_Panel.BackColor = SystemColors.ControlLight;
            console_Panel.Controls.Add(consoleTitle_Label);
            console_Panel.Controls.Add(consoleMessage_Label);
            console_Panel.Location = new Point(12, 370);
            console_Panel.Name = "console_Panel";
            console_Panel.Size = new Size(160, 41);
            console_Panel.TabIndex = 16;
            // 
            // consoleTitle_Label
            // 
            consoleTitle_Label.AutoSize = true;
            consoleTitle_Label.Location = new Point(0, -2);
            consoleTitle_Label.Name = "consoleTitle_Label";
            consoleTitle_Label.Size = new Size(51, 15);
            consoleTitle_Label.TabIndex = 10;
            consoleTitle_Label.Text = "Preview:";
            // 
            // panel1
            // 
            panel1.Controls.Add(removeDulicate_Label);
            panel1.Controls.Add(removeDuplicate_RadioButton);
            panel1.Controls.Add(keepDuplicates_RadioButton);
            panel1.Location = new Point(12, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 50);
            panel1.TabIndex = 15;
            // 
            // removeDulicate_Label
            // 
            removeDulicate_Label.AutoSize = true;
            removeDulicate_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeDulicate_Label.Location = new Point(3, 0);
            removeDulicate_Label.Name = "removeDulicate_Label";
            removeDulicate_Label.Size = new Size(120, 15);
            removeDulicate_Label.TabIndex = 10;
            removeDulicate_Label.Text = "Remove Duplicates?";
            // 
            // removeDuplicate_RadioButton
            // 
            removeDuplicate_RadioButton.AutoSize = true;
            removeDuplicate_RadioButton.Location = new Point(10, 21);
            removeDuplicate_RadioButton.Name = "removeDuplicate_RadioButton";
            removeDuplicate_RadioButton.Size = new Size(42, 19);
            removeDuplicate_RadioButton.TabIndex = 11;
            removeDuplicate_RadioButton.Text = "Yes";
            removeDuplicate_RadioButton.UseVisualStyleBackColor = true;
            removeDuplicate_RadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // keepDuplicates_RadioButton
            // 
            keepDuplicates_RadioButton.AutoSize = true;
            keepDuplicates_RadioButton.Location = new Point(77, 21);
            keepDuplicates_RadioButton.Name = "keepDuplicates_RadioButton";
            keepDuplicates_RadioButton.Size = new Size(41, 19);
            keepDuplicates_RadioButton.TabIndex = 12;
            keepDuplicates_RadioButton.Text = "No";
            keepDuplicates_RadioButton.TextAlign = ContentAlignment.MiddleCenter;
            keepDuplicates_RadioButton.UseVisualStyleBackColor = true;
            keepDuplicates_RadioButton.CheckedChanged += radioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 446);
            Controls.Add(panel1);
            Controls.Add(console_Panel);
            Controls.Add(targetFormat_Panel);
            Controls.Add(captializationStyle_Panel);
            Controls.Add(format_Button);
            Controls.Add(selectFile_Button);
            Controls.Add(fileName_TextBox);
            Name = "Form1";
            captializationStyle_Panel.ResumeLayout(false);
            captializationStyle_Panel.PerformLayout();
            targetFormat_Panel.ResumeLayout(false);
            targetFormat_Panel.PerformLayout();
            console_Panel.ResumeLayout(false);
            console_Panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
        private Label removeDulicate_Label;
        private RadioButton removeDuplicate_RadioButton;
        private RadioButton keepDuplicates_RadioButton;
    }
}