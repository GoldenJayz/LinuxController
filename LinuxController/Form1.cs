using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd(); // Gets the data from the file and stores into fileContent
                }
                Console.WriteLine(fileContent);
            }
            catch (FileNotFoundException) { Console.WriteLine("Invalid File!");  }
        }
    }
}