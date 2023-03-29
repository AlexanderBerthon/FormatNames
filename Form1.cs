namespace FormatNames {

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
            }
            else {
                Console.Error.WriteLine("File Path Error");
                fileName_TextBox.BackColor = Color.Firebrick;
            }

            for (int i = 1; i< incorrectFormat.Count; i+= 2) {
                correctFormat.Add(incorrectFormat[i] + " " + incorrectFormat[i - 1]);
            }

            File.WriteAllLines(path, correctFormat);
            using (StreamWriter sw = File.CreateText(path)) {
                foreach(string s in correctFormat) {
                    sw.WriteLine(s);
                }
            }
        }

    }
}