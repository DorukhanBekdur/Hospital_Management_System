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
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }

        public string TCnumber;
        SqlConnections bgl = new SqlConnections();

        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumber;
            

            //Name-Surname
            SqlCommand command1 = new SqlCommand("Select SecretaryNameSurname from Tbl_Secretary where SecretaryTC=@p1",bgl.baglanti());
            command1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                LblNameSurname.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //Expertise-Connect To DataGrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Expertise", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doctors-Connect To DataGrid
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as 'Doctors',DoctorExpertise From Tbl_Doctors", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Expertise-Connect To ComboBox
            SqlCommand command2 = new SqlCommand("Select ExpertiseName from Tbl_Expertise", bgl.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbExpertise.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandSave = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentTime,AppointmentExpertise,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            commandSave.Parameters.AddWithValue("@r1", MskDate.Text);
            commandSave.Parameters.AddWithValue("@r2", MskTime.Text);
            commandSave.Parameters.AddWithValue("@r3", CmbExpertise.Text);
            commandSave.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            commandSave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Appointment create is succesfull!");
        }

        private void CmbExpertise_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorExpertise=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", CmbExpertise.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnCreateAnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Anouncement (Anouncement) values (@d1)",bgl.baglanti());
            command.Parameters.AddWithValue("@d1",RchAnouncement.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Anouncement create succesfull!");
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drp = new FrmDoctorPanel();
            drp.Show();
        }

        private void BtnExpertisePanel_Click(object sender, EventArgs e)
        {
            FrmExpertise fre = new FrmExpertise();
            fre.Show();
        }

        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frl = new FrmAppointmentList();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnouncement fr = new FrmAnouncement();
            fr.Show();
        }
    }
}
