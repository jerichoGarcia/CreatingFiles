using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLab1
{
    public partial class frmFileName : Form
    {
        public static string SetFileName ="";
        public frmFileName()
        {
            InitializeComponent();
        }
        
        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFileName_Load(object sender, EventArgs e)
        {

        }
    }
}
