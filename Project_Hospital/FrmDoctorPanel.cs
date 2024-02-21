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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doctors", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            //Expertise Connect to ComboBox
            SqlCommand command2 = new SqlCommand("Select ExpertiseName from Tbl_Expertise", bgl.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbExpertise.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorExpertise,DoctorTC,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2",TxtSurname.Text);
            command.Parameters.AddWithValue("@d3",CmbExpertise.Text);
            command.Parameters.AddWithValue("@d4",MskTC.Text);
            command.Parameters.AddWithValue("@d5",TxtPassword.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor add process is succesfull!","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            CmbExpertise.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Doctors where DoctorTC=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",MskTC.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctors delete process is Succesfull!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorExpertise=@d3,DoctorPassword=@d5 where DoctorTC=@d4",bgl.baglanti());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2", TxtSurname.Text);
            command.Parameters.AddWithValue("@d3", CmbExpertise.Text);
            command.Parameters.AddWithValue("@d4", MskTC.Text);
            command.Parameters.AddWithValue("@d5", TxtPassword.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor update process is succesfull!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
