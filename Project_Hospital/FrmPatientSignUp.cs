using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrmPatientSignUp : Form
    {
        SqlConnections bgl = new SqlConnections();

        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            connection = bgl.baglanti();

            string query = "INSERT INTO Tbl_Patients (PatientName, PatientSurname, PatientTC, PatientGSM, PatientPassword, PatientGender) " +
                           "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@p1", TxtName.Text);
                command.Parameters.AddWithValue("@p2", TxtSurname.Text);
                command.Parameters.AddWithValue("@p3", MskTC.Text);
                command.Parameters.AddWithValue("@p4", MskPhone.Text);
                command.Parameters.AddWithValue("@p5", TxtPassword.Text);
                command.Parameters.AddWithValue("@p6", CmbGender.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Registration Successful! Your Password : " + TxtPassword.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void FrmPatientSignUp_Load(object sender, EventArgs e)
        {

        }
    } 
}