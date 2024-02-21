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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();
        public string TC;

        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //Doctor Name-Surname
            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorTC=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppointmentDoctor='" + LblNameSurname.Text + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationEdit fr = new FrmDoctorInformationEdit();
            fr.TCNO = LblTC.Text;
            fr.Show();
        }

        private void BtnAnouncement_Click(object sender, EventArgs e)
        {
            FrmAnouncement fr = new FrmAnouncement();
            fr.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            RchDisease.Text = dataGridView1.Rows[chosen].Cells[7].ToString();
        }
    }
}
