using System.CodeDom;

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


    TODO:
    - implement ALL CAPS style
    - implement all lower style
    - implement standard style
    - ensure these styles can be changed to and from each while maintaining current functionality 
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
            preview();

            if (openfiledialog1.ShowDialog() == DialogResult.OK) {
                path = openfiledialog1.FileName;
                fileName_TextBox.ForeColor = Color.Black;
                fileName_TextBox.Text = openfiledialog1.SafeFileName;
            }
        }

        private void format_Button_Click(object sender, EventArgs e) {
            if (verifyFile(path)) {
                if (firstLastFormat_RadioButton.Checked) {
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
                        consoleTitle_Label.ForeColor = Color.Red;
                        consoleTitle_Label.Text = "Error: ";

                        consoleMessage_Label.ForeColor = Color.Red;
                        consoleMessage_Label.Text = "Invalid Email Domain";
                    }
                }
                else {
                    consoleTitle_Label.ForeColor = Color.Red;
                    consoleTitle_Label.Text = "Error: ";

                    consoleMessage_Label.ForeColor = Color.Red;
                    consoleMessage_Label.Text = "Select a Target Format";
                }

                //separate code to format capitalization here?

            }
        }

        private Boolean verifyFile(String path) {
            Boolean status = false;
            if (File.Exists(path) && path.Contains(".txt")) {
                status = true;
            }
            else if (File.Exists(path)) {
                consoleTitle_Label.ForeColor = Color.Red;
                consoleTitle_Label.Text = "Error: ";
                consoleMessage_Label.ForeColor = Color.Red;
                consoleMessage_Label.Text = "Select a .txt file";
                fileName_TextBox.Text = "Invalid file type";
                fileName_TextBox.BackColor = Color.Firebrick;
                fileName_TextBox.ForeColor = Color.White;
            }
            else {
                consoleTitle_Label.ForeColor = Color.Red;
                consoleTitle_Label.Text = "Error: ";
                fileName_TextBox.BackColor = Color.Firebrick;
                fileName_TextBox.ForeColor = Color.White;
                consoleMessage_Label.ForeColor = Color.Red;
                if (path == "") {
                    consoleMessage_Label.Text = "Select a file first";
                }
                else {
                    consoleMessage_Label.Text = "Bad file path";
                }
            }
            return status;
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

        private void formatFile(String path, int target) {
            List<string> correctFormat = new List<string>();
            List<string> incorrectFormat = new List<string>();
            using (StreamReader sr = File.OpenText(path)) {
                string inputLine;
                //its ugly but it should work..
                while ((inputLine = sr.ReadLine()) != null) {
                    incorrectFormat.Clear();
                    inputLine = inputLine.Trim();
                    incorrectFormat.AddRange(inputLine.Split());
                    if (inputLine.Contains("@")) {
                        //delete bad data
                    }
                    else if (incorrectFormat.Count() > 3) {
                        //delete bad data
                    }
                    //lastname, firstname m.
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Contains(".")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2]);
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[1] + incorrectFormat[2].ToUpper() + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //lastname, firstname middle
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Count() > 1) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2].ElementAt(0) + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2].ElementAt(0) + ".");
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[1] + incorrectFormat[2].ToUpper().ElementAt(0) + "." + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //lastname, firstname m
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2] + ".");
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[1] + incorrectFormat[2].ToUpper() + "." + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //lastname, firstname
                    else if (incorrectFormat[0].Contains(",")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1]);
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[1] + "." + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //first m. last
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Contains(".")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[2] + ", " + incorrectFormat[0] + " " + incorrectFormat[1]);
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[0] + incorrectFormat[1].ToUpper() + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //first middle last
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Count() > 1) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1].ElementAt(0) + ". " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[2] + ", " + incorrectFormat[0] + " " + incorrectFormat[1].ElementAt(0) + ".");
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[0] + incorrectFormat[1].ToUpper().ElementAt(0) + "." + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //first m last
                    else if (incorrectFormat.Count() == 3) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + ". " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[2] + ", " + incorrectFormat[0] + " " + incorrectFormat[1] + ".");
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[0] + incorrectFormat[1].ToUpper() + "." + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
                        }
                    }
                    //first last
                    else {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1]);
                        }
                        else if (target == 1) {
                            correctFormat.Add(incorrectFormat[1] + ", " + incorrectFormat[0]);
                        }
                        else if (target == 2) {
                            correctFormat.Add(incorrectFormat[0] + "." + incorrectFormat[1] + "@" + emailDomain_Textbox.Text);
                        }
                    }
                }
            }

            //do it here to be more efficient? 

            //File.WriteAllLines(path, correctFormat);

            using (StreamWriter sw = File.CreateText(path)) {
                if (capitalizedStyle_radioButton.Checked) {
                    foreach (string s in correctFormat) {
                        sw.WriteLine(s.ToUpper());
                    }
                }
                else if (lowercaseStyle_radioButton.Checked) {
                    foreach (string s in correctFormat) {
                        sw.WriteLine(s.ToLower());
                    }
                }
                else {
                    foreach (string s in correctFormat) {
                        sw.WriteLine(s); //this will need additional work..
                    }
                }
            }

            fileName_TextBox.BackColor = Color.LimeGreen;

        }

        private void preview() {
            consoleTitle_Label.ForeColor = Color.Black;
            consoleTitle_Label.Text = "Preview: ";
            consoleMessage_Label.ForeColor = Color.Black;

            if (capitalizedStyle_radioButton.Checked && firstLastFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("FIRSTNAME LASTNAME");
            }
            else if (capitalizedStyle_radioButton.Checked && lastFirstFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("LASTNAME, FIRSTNAME");
            }
            else if (capitalizedStyle_radioButton.Checked && emailFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("FIRST.LAST@" + emailDomain_Textbox.Text);
            }
            else if (lowercaseStyle_radioButton.Checked && firstLastFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("firstname lastname");
            }
            else if (lowercaseStyle_radioButton.Checked && lastFirstFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("lastname, firstname");
            }
            else if (lowercaseStyle_radioButton.Checked && emailFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("first.last@" + emailDomain_Textbox.Text);
            }
            else if (standardStyle_radioButton.Checked && firstLastFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("Firstname Lastname");
            }
            else if (standardStyle_radioButton.Checked && lastFirstFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("Lastname, Firstname");
            }
            else if (standardStyle_radioButton.Checked && emailFormat_RadioButton.Checked) {
                consoleMessage_Label.Text = ("First.Last@" + emailDomain_Textbox.Text);
            }

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            preview();

            if (emailFormat_RadioButton.Checked) {
                emailDomain_Textbox.Visible = true;
            }
            else {
                emailDomain_Textbox.Visible = false;
                emailDomain_Textbox.Text = "";
            }

        }

        private void emailDomain_Textbox_TextChanged(object sender, EventArgs e) {
            preview();
        }
    }
}

/*
improvement / ideas

add a preview label that presents an example for each option when selected

more format options
can be a second set of options? As this doesn't really affect the format at all just capitalization?
 - all lowercase
 - all caps (regardless of the format)
 - convert to gramatically correct //normal/undo the above options
    - how to achieve this across different formats? 
    - probably have to loop the entire list, break by whitespace, and capitalze first entry, then sew back together and writeline
    - it should work regardless of the format though including multiple formats
*/