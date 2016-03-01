using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using KAALib;

namespace ORION
{
    public partial class OpenFileForm : Form
    {
        List<List<Type>> Attributes = new List<List<Type>>();
        string sourceFile;
        string directoryPath;

        public OpenFileForm()
        {
            InitializeComponent();
        }

        private void importCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse csv Files";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFile = openFileDialog1.FileName;
                directoryPath = Path.GetDirectoryName(sourceFile);
                Console.WriteLine(sourceFile);
                
            }
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            io.read_csvFile(sourceFile, ',');
            this.Close();
        }
    }
}
