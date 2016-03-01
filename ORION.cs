using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KAALib;

namespace ORION
{
    public partial class ORION : Form
    {
        
        List<Dictionary<String, String>> Attributes = new List<Dictionary<String, String>>();

        public ORION()
        {
            InitializeComponent();
        }

        private void importCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileForm openFileForm = new OpenFileForm();
            openFileForm.ShowDialog();
        }
    }
}
