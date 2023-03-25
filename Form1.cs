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
            fileName_TextBox.BackColor = Color.LimeGreen;
        }

        private void formatFile(String path) {
            List<string> done = new List<string>();
            List<string> reverse = new List<string>();

            if (File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path)) {
                    string s;
                    while ((s = sr.ReadLine()) != null) {
                        if (s.Contains(",")) {
                            reverse.AddRange(s.Split(",", StringSplitOptions.TrimEntries));
                        }
                        else {
                            done.Add(s);
                        }
                    }
                }
            }
            else {
                Console.Error.WriteLine("File Path Error");
            }

            for(int i = 1; i<reverse.Count -1; i+= 2) {
                done.Add(reverse[i] + " " + reverse[i - 1]);
            }

            File.WriteAllLines(path, done);
            using (StreamWriter sw = File.CreateText(path)) {
                foreach(string s in done) {
                    sw.WriteLine(s);
                }
            }
        }

    }
}