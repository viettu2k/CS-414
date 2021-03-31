using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuanLyBanDoGomLuuNiem
{
    class LOPDUNGCHUNG
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\QLBanHang.mdf;Integrated Security=True";
        SqlConnection conn;

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(connectionString);
        }

        public void editData(string query)
        {
            SqlCommand comm = new SqlCommand(query, conn);
            conn.Open();
            int result = comm.ExecuteNonQuery();
            conn.Close();
            if (result >= 1)
            {
                MessageBox.Show("Thao tác thành công!!!");
            }
            else
            {
                MessageBox.Show("Thao tác thất bại!!!");
            }
        }

        public DataTable loadDataTable (String query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
