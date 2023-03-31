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
            formatFile(path);
        }

        private void formatFile(String path) {
            List<string> correctFormat = new List<string>(); 
            List<string> incorrectFormat = new List<string>();

            if (File.Exists(path) && path.Contains(".txt")) {
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
                fileName_TextBox.BackColor = Color.LimeGreen;

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
                    fileName_TextBox.Text = "Error: Select a file first";
                }
                else {
                    fileName_TextBox.Text = "Error: Bad file path";
                }
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