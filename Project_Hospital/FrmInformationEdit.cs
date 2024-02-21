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
    public partial class FrmInformationEdit : Form
    {
        public FrmInformationEdit()
        {
            InitializeComponent();
        }

        public string TCno;

        SqlConnections bgl = new SqlConnections();
        private void FrmInformationEdit_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskPhone.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnInformationUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Update Tbl_Patients set PatientName=@p1,PatientSurname=@p2,PatientGSM=@p3,PatientPassword=@p4,PatientGender=@p5 Where PatientTC=@p6",bgl.baglanti());
            command2.Parameters.AddWithValue("@p1",TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command2.Parameters.AddWithValue("@p3",MskPhone.Text);
            command2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command2.Parameters.AddWithValue("@p5", CmbGender.Text);
            command2.Parameters.AddWithValue("@p6", MskTC.Text);
            command2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Information is update!","information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
