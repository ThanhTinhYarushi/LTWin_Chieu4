using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    class BangCap
    {
        Database db;
        public BangCap() 
        {
            db = new Database();
        }    
        public DataTable layDanhSachBangCap()
        {
            string strSQL = "SELECT * FROM BANGCAP";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaBangCap(string index_bc)
        {
            //string strSQL = "DELETE FROM BANGCAP WHERE MaBangCap = " + index_bc;
            string strSQL = string.Format("DELETE FROM BANGCAP WHERE MaBangCap = '{0}'", index_bc);
            db.ExecuteNonQuery(strSQL);
        }
        public void ThemBangCap( string name_bc)
        {
            //string sql = string.Format("INSERT INTO BANGCAP VALUES ('{0}', N'{1}')", index_bc, name_bc);
            //string sql = string.Format("INSERT INTO BANGCAP (TenBangCap) VALUES (N'{0}')", name_bc);
            string sql = string.Format("INSERT INTO BANGCAP (TenBangCap) VALUES (N'{0}')", name_bc);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatBangCap(string index_bc, string name_bc)
        {
            string sql = string.Format("UPDATE BANGCAP SET TenBangCap = N'{0}' WHERE MaBangCap = '{1}'", name_bc, index_bc);
            db.ExecuteNonQuery(sql);
        }
        public bool KiemTraBangCapTonTai(string maBangCap)
        {
            string sql = string.Format("SELECT COUNT(*) FROM BANGCAP WHERE MaBangCap = '{0}'", maBangCap);
            int result = (int)db.ExecuteScalar(sql);
            return result > 0;
        }
        public bool KiemTraTenBangCapTonTai(string tenBangCap)
        {
            string sql = string.Format("SELECT COUNT(*) FROM BANGCAP WHERE TenBangCap = N'{0}'", tenBangCap);
            int result = (int)db.ExecuteScalar(sql);
            return result > 0; // Trả về true nếu tên bằng cấp tồn tại
        }

    }
}
