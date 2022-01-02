using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinuxController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                string fileContent;
                Stream fileStream;
                string filePath;

                fileStream = openFileDialog1.OpenFile();
                filePath = openFileDialog1.FileName;
                Console.WriteLine(filePath);

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd(); // Gets the data from the file and stores into fileContent
                }
                Console.WriteLine(fileContent);
                Process.Start(@"cmd.exe", String.Format(@"/k {0}", filePath)); // run file
            }
            catch (FileNotFoundException) { Console.WriteLine("Invalid File!");  }
        }
    }
}