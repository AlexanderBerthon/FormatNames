namespace FormatNames {
    //works on..
    /*
    .txt
    .torrent
    .diz
    .sfm
    .theme
    .stp
    .air
    .ies
    .srt
    .m3u8
    .m3u
    .pls
    .reg
    .xml
    .bat

    does it need to though? Out of scope? Just force .txt files to modify and they can always just copy paste
    the data back into whatever file they are working
    */

    public partial class Form1 : Form {
        private OpenFileDialog openfiledialog1;
        string path;

        public Form1() {
            InitializeComponent();
            openfiledialog1 = new OpenFileDialog();
            path = "";
        }

        private void FileSelectButton_Click(object sender, EventArgs e) {
            fileName_TextBox.BackColor = System.Drawing.SystemColors.Control;
            if (openfiledialog1.ShowDialog() == DialogResult.OK) {
                path = openfiledialog1.FileName;
                fileName_TextBox.ForeColor = Color.Black;
                fileName_TextBox.Text = openfiledialog1.SafeFileName;
            }
        }

        private void format_Button_Click(object sender, EventArgs e) {
            if (firstLastFormat1_RadioButton.Checked) {
                formatFile(path, 0);
            }
            else if (lastFirstFormat_RadioButton.Checked) {
                formatFile(path, 1);
            }
            else if (emailFormat_RadioButton.Checked) {
                if (emailFormat_RadioButton.Text.Contains(".")) {
                    formatFile(path, 2);
                    //probably need to write a regex for this
                    //match pattern, min 2 char before . and 2 char after . and . must be included
                    //xx.xx
                }
                else {
                    errorMessage_Label.Visible = true;
                    errorMessage_Label.Text = "Error: Invalid Email Domain";
                }
            }
            else {
                errorMessage_Label.Visible = true;
                errorMessage_Label.Text = "Error: Select a Target Format";
            }
        }

        private void formatFile(String path, int target) {
            List<string> correctFormat = new List<string>(); 
            List<string> incorrectFormat = new List<string>();

            if (File.Exists(path) && path.Contains(".txt")) {
                if (target == 0) {
                    using (StreamReader sr = File.OpenText(path)) {
                        string inputLine;
                        while ((inputLine = sr.ReadLine()) != null) {
                            if (inputLine.Contains(",")) {
                                incorrectFormat.AddRange(inputLine.Split(",", StringSplitOptions.TrimEntries));
                            }
                            else {
                                correctFormat.Add(inputLine);
                            }
                        }
                    }

                    for (int i = 1; i < incorrectFormat.Count; i += 2) {
                        correctFormat.Add(incorrectFormat[i] + " " + incorrectFormat[i - 1]);
                    }

                    File.WriteAllLines(path, correctFormat);
                    using (StreamWriter sw = File.CreateText(path)) {
                        foreach (string s in correctFormat) {
                            sw.WriteLine(s);
                        }
                    }
                }
                else if (target == 1) {
                    using (StreamReader sr = File.OpenText(path)) {
                        string inputLine;
                        while ((inputLine = sr.ReadLine()) != null) {
                            if (inputLine.Contains(",")) {
                                correctFormat.Add(inputLine);
                            }
                            else {
                                incorrectFormat.AddRange(inputLine.Split(" ", StringSplitOptions.TrimEntries));
                            }
                        }
                    }

                    for (int i = 0; i < incorrectFormat.Count; i += 2) {
                        correctFormat.Add(incorrectFormat[i + 1] + ", " + incorrectFormat[i]);
                    }

                    File.WriteAllLines(path, correctFormat);
                    using (StreamWriter sw = File.CreateText(path)) {
                        foreach (string s in correctFormat) {
                            sw.WriteLine(s);
                        }
                    }
                }
                else if (target == 2) {
                    //first read doc and separate first last from last, first
                    using (StreamReader sr = File.OpenText(path)) {
                        string inputLine;
                        while ((inputLine = sr.ReadLine()) != null) {
                            if (inputLine.Contains(",")) {
                                incorrectFormat.AddRange(inputLine.Split(",", StringSplitOptions.TrimEntries));
                            }
                            else {
                                correctFormat.Add(inputLine);
                            }
                        }
                    }

                    for (int i = 1; i < incorrectFormat.Count; i += 2) {
                        correctFormat.Add(incorrectFormat[i] + " " + incorrectFormat[i - 1]);
                    }

                    incorrectFormat.Clear();

                    //now all names are formatted the same; first last
                    //break names apart again
                    foreach (string s in correctFormat) {
                        incorrectFormat.AddRange(s.Split(" "));
                    }

                    //format names into target format
                    for (int i = 0; i < incorrectFormat.Count; i += 2) {
                        correctFormat.Add(incorrectFormat[i] + "." + incorrectFormat[i+1] + emailDomain_Textbox.Text);
                    }

                    File.WriteAllLines(path, correctFormat);
                    using (StreamWriter sw = File.CreateText(path)) {
                        foreach (string s in correctFormat) {
                            sw.WriteLine(s);
                        }
                    }
                }
                fileName_TextBox.BackColor = Color.LimeGreen;
            }
            else if (File.Exists(path)) {
                Console.Error.WriteLine("Error: Invalid file type");
                fileName_TextBox.Text = "Error: Invalid file type";
                fileName_TextBox.BackColor = Color.Firebrick;
                fileName_TextBox.ForeColor = Color.White;
            }
            else {
                Console.Error.WriteLine("File Path Error");
                fileName_TextBox.BackColor = Color.Firebrick;
                fileName_TextBox.ForeColor = Color.White;
                if (path == "") {
                    errorMessage_Label.Text = "Error: Select a file first";
                }
                else {
                    errorMessage_Label.Text = "Error: Bad file path";
                }
            }
        }

        private void emailFormat_RadioButton_CheckedChanged(object sender, EventArgs e) {
            if (emailFormat_RadioButton.Checked) {
                emailDomain_Textbox.Visible = true;
            }
            else {
                emailDomain_Textbox.Visible = false;
                emailDomain_Textbox.Text = "";
            }
        }
    }
}

/*
improvement / ideas
add option to select target format
 - only 1 option can be selected, so it needs to be a drop down selection UI element
firstname lastname --> lastname, firstname
lastname, firstname --> firstname lastname
firstname lastname --> firstname.lastname@email.com
 - make a text box visible if this option is selected so user can specify the domain to add @____

add a preview label that presents an example for each option when selected

*/