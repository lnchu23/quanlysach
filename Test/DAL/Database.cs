using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Test.DAL
{
    public class Database
    {
        string conString =
    ConfigurationManager.ConnectionStrings["adoConnectionString"].ToString();
        public DataTable Get_Sach()
        {

            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Masach,Tensach, Giaban" +
                    ", Mota, Anhbia, Ngaycapnhat,Soluongton" +
                    " from Sach";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();

                return dt;
            }
        }
        public DataTable Get_Sach_byMasach(string masach)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Masach,Tensach, Giaban" +
                    ", Mota, Anhbia, Ngaycapnhat,Soluongton" +
                    " from Sach";
                connection.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                connection.Close();

                return dt;
            }
        }

        public void Insert_Sach(Sach1 ob)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {

                string sql = "Insert into Sach(Masach,Tensach,Giaban,Mota,Anhbia,Ngaycapnhat,Soluongton) values('"
                       + ob.Masach + "','" + ob.Tensach + "'," + ob.Giaban + ",'" + ob.Mota + "','" + ob.Anhbia + "','" + ob.Ngaycapnhat + "'," + ob.Soluongton + ")";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update_Sach(Sach1 ob)
        {
            using (SqlConnection connection =
                new SqlConnection(conString))
            {
                string sql = "Update Sach set Tensach='" + ob.Tensach + "',Giaban=" + ob.Giaban +
                    ",Mota='" + ob.Mota + "',Anhbia='" + ob.Anhbia + "',Ngaycapnhat='" + ob.Ngaycapnhat + "',Soluongton=" + ob.Soluongton +"  where masach='" + ob.Masach + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete_Sach(string masach)
        {
            using (SqlConnection connection = new
                SqlConnection(conString))
            {

                string sql = "Delete from Sach " +
                "where Masach='" + masach + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

    }
}