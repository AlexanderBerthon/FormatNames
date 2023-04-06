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
            verifyFile(path);

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

        private void verifyFile(String path) {
            if (File.Exists(path) && path.Contains(".txt")) {}
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


        //**********************************************************************************************************************todo*****************************************************
        //I need to write this same exact thing 2 more times for the other 2 formats
        //last, first
        //first.last@email.com
        //**********************************************************************************************************************todo*****************************************************

        private void formatFile(String path, int target) {
            List<string> correctFormat = new List<string>();
            List<string> incorrectFormat = new List<string>();
            using (StreamReader sr = File.OpenText(path)) {
                string inputLine;
                //its ugly but it should work..
                while ((inputLine = sr.ReadLine()) != null) {
                    incorrectFormat.Clear();
                    incorrectFormat.AddRange(inputLine.Split());

                    if (incorrectFormat.Count() > 3) {
                        //delete this shit
                    }
                    //lastname, firstname m.
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Contains(".")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if(target == 1){
                        }
                        else if(target == 2){
                        }
                    }
                    //lastname, firstname middle
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Count() > 1) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2].ElementAt(0) + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //lastname, firstname m
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //lastname, firstname
                    else if (incorrectFormat[0].Contains(",")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //first m. last
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Contains(".")) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //first middle last
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Count() > 1) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1].ElementAt(0) + ". " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //first m last
                    else if (incorrectFormat.Count() == 3) {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + ". " + incorrectFormat[2]);
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                    //first last
                    else {
                        if (target == 0) {
                            correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1]);
                        }
                        else if (target == 1) {
                        }
                        else if (target == 2) {
                        }
                    }
                }
            }

            File.WriteAllLines(path, correctFormat);
            using (StreamWriter sw = File.CreateText(path)) {
                foreach (string s in correctFormat) {
                    sw.WriteLine(s);
                }
            }

            fileName_TextBox.BackColor = Color.LimeGreen;

        }
    }
}

/*
improvement / ideas

add a preview label that presents an example for each option when selected
*/