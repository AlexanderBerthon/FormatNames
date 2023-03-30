namespace FormatNames {
    /*
    NOTE: 
    This program only works on .txt files (as far as I know)
    if you select a file that isn't a .txt file it will 100% corrupt the file
    :)
    I should probably prevent this from happening.. BUT that functionality might be handy?
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

            if (File.Exists(path)) {
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