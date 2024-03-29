using System.CodeDom;

namespace FormatNames {

    /*
    Add function to sort the data file? 
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
                    if (emailDomain_Textbox.Text.Contains(".")) { //changed this
                        formatFile(path, 2);
                        //probably should write a regex for this
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

        private void formatFile(String path, int target) {
            List<string> correctFormat = new List<string>();
            List<string> incorrectFormat = new List<string>();
            Boolean badData = false;
            int inputLineCount = 0;

            using (StreamReader sr = File.OpenText(path)) {
                string inputLine;

                while ((inputLine = sr.ReadLine()) != null) {
                    try {
                        inputLineCount++;
                        incorrectFormat.Clear();
                        inputLine = inputLine.Trim();
                        incorrectFormat.AddRange(inputLine.Split());

                        //this block removes empty elements from the list /bad data
                        List<string> temp = new List<string>();
                        foreach (string line in incorrectFormat) {
                            if (line.Length > 0) {
                                temp.Add(line);
                            }
                        }
                        incorrectFormat = temp;


                        for (int i = 0; i < incorrectFormat.Count; i++) {
                            incorrectFormat[i] = incorrectFormat[i].First().ToString().ToUpper() + incorrectFormat[i].Substring(1).ToLower();
                        }

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
                                correctFormat.Add(incorrectFormat[1] + incorrectFormat[2] + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
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
                                correctFormat.Add(incorrectFormat[1] + incorrectFormat[2].ElementAt(0) + "." + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
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
                                correctFormat.Add(incorrectFormat[1] + incorrectFormat[2] + "." + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1) + "@" + emailDomain_Textbox.Text);
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
                                correctFormat.Add(incorrectFormat[0] + incorrectFormat[1] + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
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
                                correctFormat.Add(incorrectFormat[0] + incorrectFormat[1].ElementAt(0) + "." + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
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
                                correctFormat.Add(incorrectFormat[0] + incorrectFormat[1] + "." + incorrectFormat[2] + "@" + emailDomain_Textbox.Text);
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
                    catch (ArgumentOutOfRangeException e) {
                        badData = true;
                        consoleTitle_Label.ForeColor = Color.Red;
                        consoleTitle_Label.Text = "Error: ";
                        fileName_TextBox.BackColor = Color.Firebrick;
                        fileName_TextBox.ForeColor = Color.White;
                        consoleMessage_Label.ForeColor = Color.Red;
                        consoleMessage_Label.Text = "Bad data at input line: " + inputLineCount;
                    }
                }
            }

            //manage duplicates here
            if (removeDuplicate_RadioButton.Checked) {
                List<string> temp = new List<string>();
                for (int i = 0; i < correctFormat.Count; i++) {
                    if (i == correctFormat.Count - 1) {
                        temp.Add(correctFormat[i]);
                        break;
                    }
                    for (int j = i + 1; j < correctFormat.Count; j++) {
                        if (correctFormat[i].Equals(correctFormat[j])) {
                            break;
                        }
                        else if (j == correctFormat.Count - 1) {
                            temp.Add(correctFormat[i]);
                        }
                    }
                }
                correctFormat = temp;
            }

            //write to file with user defined style
            //do not modify the file if it contains bad data
            if (badData == false) {
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
                            sw.WriteLine(s);
                        }
                    }
                }
                fileName_TextBox.BackColor = Color.LimeGreen;
            }
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
            fileName_TextBox.BackColor = System.Drawing.SystemColors.Control;
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