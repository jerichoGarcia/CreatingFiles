using System;
using System.Collections;
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
    public partial class frmRegistration : Form
    {
        
        public frmRegistration()
        {
            InitializeComponent();
        }

     
        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
            ArrayList proglist = new ArrayList();

            proglist.Add("BS in Information Technology");
            proglist.Add("BS in Computer Science");
            proglist.Add("BS in Information System");
            proglist.Add("BS in Computer Engineering");

            foreach (string prog in proglist)
            {
                cbProgram.Items.Add(prog);
            }

            ArrayList gender = new ArrayList();

            gender.Add("Male");
            gender.Add("Female");

            foreach(string gen in gender)
            {
                cbGender.Items.Add(gen);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName = txtStudentNo.Text + ".txt")))
            {
                StreamWriter inputContent;
                inputContent = outputFile;

                ArrayList register = new ArrayList();

                register.Add(lblStudentNo.Text + " " + txtStudentNo.Text);
                register.Add(lblLastName.Text = "Fullname: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMidName.Text);
                register.Add(lblProgram.Text + " " + cbProgram.SelectedItem.ToString());
                register.Add(lblGender.Text + " " + cbGender.SelectedItem.ToString());
                register.Add(lblAge.Text + " " + txtAge.Text);
                register.Add(lblBirthday.Text + " " + dtpBirthday.Value.ToString("yyyy-mm-dd"));
                register.Add(lblContact.Text + " " + txtContact.Text.ToString());

                foreach(string content in register)
                {
                    inputContent.WriteLine(content);
                }

               
                inputContent.Close();
                Clear();
            }
        }

        public void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMidName.Clear();
            txtAge.Clear();
            txtStudentNo.Clear();
            txtContact.Clear();

            txtStudentNo.Focus();
        }

        private void txtStudentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

  
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

          
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
