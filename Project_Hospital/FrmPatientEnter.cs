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
    public partial class FrmPatientEnter : Form
    {
        public FrmPatientEnter()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp fr = new FrmPatientSignUp();
            fr.Show();
        }

        private void FrmPatientEnter_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = bgl.baglanti();
            

            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Patients WHERE PatientTC = @p1 AND PatientPassword = @p2", bgl.baglanti());
                
                    command.Parameters.AddWithValue("@p1", MskTC.Text);
                    command.Parameters.AddWithValue("@p2", TxtPassword.Text);

                SqlDataReader dr = command.ExecuteReader();
                    
                        if (dr.Read())
                        {
                            FrmPatientDetail fr = new FrmPatientDetail();
                            fr.tc=MskTC.Text;
                            fr.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect ID & Password!");
                        }
            bgl.baglanti().Close();
        }
    }
}
