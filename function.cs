using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bbms
{
    internal class function
    {
        protected SqlConnection getConnection()                //not going to use this outside the class.     
        {
            SqlConnection con = new SqlConnection();
        con.ConnectionString = "data source = DESKTOP-EG6UETN\\SQLEXPRESS;database = bloodbank;integrated security = True";
            return con;
        }

        public DataSet getData(String query)     
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query)   
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Procesed Successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
