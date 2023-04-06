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

    BUGS
    middle names break the program.
    can go from..
    first last
    last, first
    to..
    first last
    first last
    first last
    no issue with middle name
    because , is the delimeter 
    and last, first m. works that way since it splits like this
    [last, first m., last, first m.] etc. 
    but when it is reversed
    first m. last --> last, first

    so I need a test case, bingo.
    if line.contains(".") then split "." 
    else split " "

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
            //fixBadData(path);
            //check for valid path here first
            //get rid of "fix bad data function"

            //this switch to control each of the three mega functions
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

        //rewrite this into a monster
        private void formatFile(String path, double target) {
            List<string> correctFormat = new List<string>(); 
            List<string> incorrectFormat = new List<string>();
            //first last
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
            //last, first
            else if (target == 1) {
                using (StreamReader sr = File.OpenText(path)) {
                    string inputLine;
                    while ((inputLine = sr.ReadLine()) != null) {
                        if (inputLine.Contains(",")) {
                            correctFormat.Add(inputLine);
                        }
                        else if (inputLine.Contains(".")) {
                            incorrectFormat.AddRange(inputLine.Split(".", StringSplitOptions.TrimEntries));
                        }
                        else {
                            incorrectFormat.AddRange(inputLine.Split(" ", StringSplitOptions.TrimEntries));
                        }    
                    }
                }
                fileName_TextBox.Text = "";
                fileName_TextBox.Text = incorrectFormat.Count.ToString();
                    
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
            //email
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

        private void fixBadData(String path) {
            List<string> correctFormat = new List<string>();
            List<string> incorrectFormat = new List<string>();

            if (File.Exists(path) && path.Contains(".txt")) {
                using (StreamReader sr = File.OpenText(path)) {
                    string inputLine;
                    while ((inputLine = sr.ReadLine()) != null) {
                        if (inputLine.Contains(" ")) {
                            int count = 0;
                            foreach (char c in inputLine) {
                                if (c == ' ') {
                                    count++;
                                }
                            }
                            if (count == 2) {
                                //first m. last
                                //first middle last
                                incorrectFormat.AddRange(inputLine.Split(" ", StringSplitOptions.TrimEntries));
                            }
                            else if (count > 2) {
                                //delete
                            }
                            else {
                                correctFormat.Add(inputLine);
                            }
                        }
                    }
                }

                ///Everything above this is good
                ///now just need to fix the data
                ///before feeding it back in and replacing the data in the file
                ///
                ///turn [first, m., last]    --> [first m. last, ..., ...]
                ///turn [first, m, last]     --> [first m. last, ..., ...]
                ///turn [first, middle, last --> [first m. last, ..., ...]
                ///
                ///last, first will be passed through already
                ///first last will be passed through already
                ///
                ///what about [last, first m] --> []
                ///
                
                //first loop fixes all middle name fields
                for (int i = 1; i < incorrectFormat.Count; i += 3) {
                    if (incorrectFormat[i].Count() == 2 && incorrectFormat[i].Contains(".")) {
                        //do nothing
                    }
                    else if (incorrectFormat[i].Count() == 1) {
                        string format = incorrectFormat[i] + ".";
                        incorrectFormat[i] = format;
                    }
                    else {
                        string format = incorrectFormat[i].ElementAt(0) + ".";
                        incorrectFormat[i] = format;
                    }
                }

                //second loop sews the three elements into one string
                for (int i = 0; i < incorrectFormat.Count; i += 3) {
                    correctFormat.Add(incorrectFormat[i] + " " + incorrectFormat[i + 1] + " " + incorrectFormat[i + 2]);
                }

                //write to file
                File.WriteAllLines(path, correctFormat);
                using (StreamWriter sw = File.CreateText(path)) {
                    foreach (string s in correctFormat) {
                        sw.WriteLine(s);
                    }
                }                
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

        private void formatFile(String path, int target) { //change string target into int target when done
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
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Contains(".")) {
                        //lastname, firstname m.
                        correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                    }
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3 && incorrectFormat[2].Count() > 1) {
                        //lastname, firstname middle
                        correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2].ElementAt(0) + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                    }
                    else if (incorrectFormat[0].Contains(",") && incorrectFormat.Count() == 3) {
                        //lastname, firstname m
                        correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[2] + ". " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                    }
                    else if (incorrectFormat[0].Contains(",")) {
                        //lastname, firstname
                        correctFormat.Add(incorrectFormat[1] + " " + incorrectFormat[0].Substring(0, incorrectFormat[0].Length - 1));
                    }
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Contains(".")) {
                        //first m. last
                        correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1] + " " + incorrectFormat[2]);
                    }
                    else if (incorrectFormat.Count() == 3 && incorrectFormat[1].Count() > 1) {
                        //first middle last
                        correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1].ElementAt(0) + ". " + incorrectFormat[2]);
                    }
                    else if (incorrectFormat.Count() == 3) {
                        //first m last
                        correctFormat.Add(incorrectFormat[0]+ " " + incorrectFormat[1]+ ". " + incorrectFormat[2]);
                    }
                    else {
                        //first last
                        correctFormat.Add(incorrectFormat[0] + " " + incorrectFormat[1]);
                    }
                }
            }

            File.WriteAllLines(path, correctFormat);
            using (StreamWriter sw = File.CreateText(path)) {
                foreach (string s in correctFormat) {
                    sw.WriteLine(s);
                }
            }
        }

        /*
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

        */
    }
}

/*
improvement / ideas

add a preview label that presents an example for each option when selected


BUGS
1.
with middle name conversion
program will work on the first go around
change all data to match this format: first m. last
but
when converting to last, first format. data loss occurs
changes it to..

initial input

firstone middleone lastone
firsttwo m lasttwo
firstthree m. lastthree

-> first last

firstone m. lastone
firsttwo m. lasttwo
firstthree m. lastthree

-> last, first

lastone, firstone m
lasttwo, firsttwo m
lastthree, firstthree m

--> first last
data loss

I think I just need to make sure that the m. maintains the . when converting to last, first
*/


