﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    class Database
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL
        SqlDataAdapter da;//Bo dieu phoi du lieu
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep
        public Database()
        {
            // TenServer, 
            string strCnn = "Data Source=ITSYARUSHI\\SQLEXPRESS01; Database=QLTHUVIEN; Integrated Security = True";
            sqlConn = new SqlConnection(strCnn);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        // hàm này như trên nhưng được dùng 2 tham số,
        public DataTable Execute(string sqlStr, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand sqlcmd = new SqlCommand(sqlStr, sqlConn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                da = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua
            sqlConn.Close();//Dong ket noi
        }

        // hàm này như trên nhưng được dùng 2 tham số, 
        public void ExecuteNonQuery(string strSQL, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn))
            {
                // Kiểm tra và thêm các tham số (nếu có)
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                sqlConn.Open(); // Mở kết nối
                sqlcmd.ExecuteNonQuery(); // Thực thi lệnh
                sqlConn.Close(); // Đóng kết nối
            }
        }

        // Trả về giá trị đơn
        public object ExecuteScalar(string sqlStr)
        {
            SqlCommand sqlcmd = new SqlCommand(sqlStr, sqlConn);
            sqlConn.Open(); // Mở kết nối
            object result = sqlcmd.ExecuteScalar(); // Thực thi truy vấn và nhận giá trị đầu tiên
            sqlConn.Close(); // Đóng kết nối
            return result; // Trả về kết quả
        }
        // trả về giá trị đơn
        public object ExecuteScalar(string sqlStr, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand sqlcmd = new SqlCommand(sqlStr, sqlConn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        sqlcmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                sqlConn.Open();
                object result = sqlcmd.ExecuteScalar();
                sqlConn.Close();
                return result;
            }
        }

        // Dành riêng cho độc giả
        public void Update(string query, DataTable dataTable)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConn))
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
            }
        }
        public Database(string serverName, string databaseName, bool integratedSecurity, string userName = "", string password = "")
        {
            string strCnn;

            if (integratedSecurity)
            {
                strCnn = $"Data Source={serverName}; Initial Catalog={databaseName}; Integrated Security=True";
            }
            else
            {
                strCnn = $"Data Source={serverName}; Initial Catalog={databaseName}; User ID={userName}; Password={password}";
            }

            sqlConn = new SqlConnection(strCnn);
        }
    }
}
