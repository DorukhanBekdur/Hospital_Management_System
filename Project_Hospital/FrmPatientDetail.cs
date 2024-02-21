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
    
    public partial class FrmPatientDetail : Form
    {
        
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        public string tc;

        SqlConnections bgl = new SqlConnections();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            SqlCommand command = new SqlCommand("Select PatientName,PatientSurname From Tbl_Patients where PatientTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1" , LblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where PatientTC=" + tc , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand command1 = new SqlCommand ("Select ExpertiseName from Tbl_Expertise",bgl.baglanti());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                CmbExpertise.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set AppointmentStatus=1,PatientTC=@p1,PatientComplaint=@p2 where Appointmentid=@p3", bgl.baglanti());
            command.Parameters.AddWithValue("@p1",LblTC.Text);
            command.Parameters.AddWithValue("@p2",RchDisease.Text);
            command.Parameters.AddWithValue("@p3",TxtID.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment take is succesfull!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CmbExpertise_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorExpertise=@p1",bgl.baglanti());
            command3.Parameters.AddWithValue("@p1",CmbExpertise.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppointmentExpertise='" + CmbExpertise.Text + "'" + "and AppointmentDoctor='" + CmbDoctor.Text + "' and AppointmentStatus=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkInformationEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInformationEdit fr = new FrmInformationEdit();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }
    }
}

