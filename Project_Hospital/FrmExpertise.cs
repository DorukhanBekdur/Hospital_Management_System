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
    public partial class FrmExpertise : Form
    {
        public FrmExpertise()
        {
            InitializeComponent();
        }

        SqlConnections bgl = new SqlConnections();

        private void FrmExpertise_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Expertise",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Expertise (ExpertiseName) values (@b1)",bgl.baglanti());
            command.Parameters.AddWithValue("@b1",TxtExpertise.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Expertise Add process is succesfull!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            TxtExpertise.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Expertise where Expertiseid=@b1",bgl.baglanti());
            command.Parameters.AddWithValue("@b1",TxtID.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Expertise is deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Expertise set ExpertiseName=@p1 where Expertiseid=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", TxtExpertise.Text);
            command.Parameters.AddWithValue("@p2", TxtID.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Expertise updated!");
        }
    }
}
