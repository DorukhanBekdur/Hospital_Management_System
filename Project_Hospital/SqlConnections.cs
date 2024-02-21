using System;
using System.Data.SqlClient;

namespace Project_Hospital
{
    class SqlConnections
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = Dorukhan\\SQLEXPRESS;Initial Catalog = HospitalProject; Integrated Security = True; TrustServerCertificate=True;");
            baglan.Open();
            return baglan;
        }
    }
}

//SqlConnection baglan = new SqlConnection("Data Source=Dorukhan\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True;TrustServerCertificate=True;Encrypt=True");
//SqlConnection baglan = new SqlConnection("Data Source=Dorukhan\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True;");
