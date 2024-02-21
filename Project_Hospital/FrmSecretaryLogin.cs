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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Secretary where SecretaryTC=@p1 and SecretaryPassword=@p2",bgl.baglanti());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2",TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                FrmSecretaryDetails frs = new FrmSecretaryDetails();
                frs.TCnumber = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect TC & Password!");
            }
            bgl.baglanti().Close();
        }

        private void FrmSecretaryLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
