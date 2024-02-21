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
    public partial class FrmDoctorInformationEdit : Form
    {
        public FrmDoctorInformationEdit()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        public string TCNO;


        private void FrmDoctorInformationEdit_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNO;

            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbExpertise.Text = dr[3].ToString();
                TxtPassword.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnInformationUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorExpertise=@p3,DoctorPassword=@p4,DoctorTC=@p5", bgl.baglanti());
            command.Parameters.AddWithValue("@p1",TxtName.Text);
            command.Parameters.AddWithValue("@p2",TxtSurname.Text);
            command.Parameters.AddWithValue("@p3",CmbExpertise.Text);
            command.Parameters.AddWithValue("@p4",TxtPassword.Text);
            command.Parameters.AddWithValue("@p5", MskTC.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Record update!");
        }
    }
}
