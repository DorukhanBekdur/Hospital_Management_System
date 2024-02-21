using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            command.Parameters.AddWithValue("@p2",TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.TC = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
            bgl.baglanti().Close();
        }

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
