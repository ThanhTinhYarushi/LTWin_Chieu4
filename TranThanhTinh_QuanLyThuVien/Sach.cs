using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    class Sach
    {
        Database db;
        public Sach()
        {
            db = new Database();
        }
        public DataTable layDSSach()
        {
            string strSQL = "SELECT * FROM SACH";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void ThemSach(string tenSach, string tenTacGia, string namXuatBan, string nhaXuatBan, string triGia, string ngayNhap )
        {
            string sql = string.Format("INSERT INTO SACH (TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap) VALUES (N'{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')", tenSach, tenTacGia, namXuatBan, nhaXuatBan, triGia, ngayNhap);
            db.ExecuteNonQuery(sql);
        }

        public void XoaSach(string index_Sach)
        {
            string sql = "DELETE FROM SACH WHERE MaSach = " + index_Sach;
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatSach(string maSach, string tenSach, string tenTacGia, string namXuatBan, string nhaXuatBan, string triGia, string ngayNhap)
        {
            string sql = string.Format("UPDATE SACH SET TenSach = N'{0}', TacGia = N'{1}', NamXuatBan = '{2}', NhaXuatBan = N'{3}', TriGia = '{4}', NgayNhap = '{5}' WHERE MaSach = {6}", tenSach, tenTacGia, namXuatBan, nhaXuatBan, triGia, ngayNhap, maSach);
            db.ExecuteNonQuery(sql);
        }
    }
}
