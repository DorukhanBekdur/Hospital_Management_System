using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            FrmPatientEnter fr = new FrmPatientEnter();
            fr.Show();
            this.Hide();
        }

        private void BtnDoctorLogin_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin fr = new FrmDoctorLogin();
            fr.Show();
            this.Hide();
        }

        private void BtnSecretaryLogin_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin fr = new FrmSecretaryLogin();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
