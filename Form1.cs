namespace FormatNames {
    public partial class Form1 : Form {

        private OpenFileDialog openfiledialog1;

        public Form1() {
            InitializeComponent();
            openfiledialog1 = new OpenFileDialog();

        }

        private void FileSelectButton_Click(object sender, EventArgs e) {
            if (openfiledialog1.ShowDialog() == DialogResult.OK) {
                String path = openfiledialog1.FileName;
                formatFile(path);
            }
        }

        private void formatFile(String path) {
            List<string> done = new List<string>();
            List<string> reverse = new List<string>();

            if (!File.Exists(path)) {
                using (StreamReader sr = File.OpenText(path)) {
                    string s;
                    while((s = sr.ReadLine()) != null) {
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
        }

    }
}