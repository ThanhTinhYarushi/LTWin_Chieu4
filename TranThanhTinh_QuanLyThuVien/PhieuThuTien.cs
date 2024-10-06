using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    class PhieuThuTien
    {
        Database db;
        public PhieuThuTien()
        {
            db = new Database();
        }
        public DataTable layDSPhieuThuTien()
        {
            string strSQL = "SELECT * FROM PHIEUTHUTIEN";
            DataTable dt = db.Execute(strSQL); 
            return dt;
        }
        //public void ThemPhieuThu(string soTienNo, string soTienThu, string maDocGia, string maNhanVien)
        //{
        //    string strSQL = string.Format("INSERT INTO PHIEUTHUTIEN (SoTienNo, SoTienThu, MaDocGia, MaNhanVien) VALUES ('{0}', '{1}', '{2}', '{3}')", soTienNo, soTienThu, maDocGia, maNhanVien);
        //    db.ExecuteNonQuery(strSQL);
        //}
        public void ThemPhieuThu(string soTienNo, string soTienThu, string maDocGia, string maNhanVien)
        {
            string strSQL = "INSERT INTO PHIEUTHUTIEN (SoTienNo, SoTienThu, MaDocGia, MaNhanVien) VALUES (@soTienNo, @soTienThu, @maDocGia, @maNhanVien)";

            var parameters = new Dictionary<string, object>()
            {
                    { "@soTienNo", soTienNo },
                    { "@soTienThu", soTienThu },
                    { "@maDocGia", maDocGia },
                    { "@maNhanVien", maNhanVien }
            };
            db.ExecuteNonQuery(strSQL, parameters);
        }
        public void CapNhatPhieuThu(string MaPhieuThuTien, string soTienNo, string soTienThu, string maDocGia, string maNhanVien)
        {
            string strSQL = "UPDATE PHIEUTHUTIEN SET SoTienNo = @soTienNo, SoTienThu = @soTienThu, MaDocGia = @maDocGia, MaNhanVien = @maNhanVien WHERE MaPhieuThuTien = @MaPhieuThuTien";

            var parameters = new Dictionary<string, object>()
            {
                    { "@soTienNo", soTienNo },
                    { "@soTienThu", soTienThu },
                    { "@maDocGia", maDocGia },
                    { "@maNhanVien", maNhanVien },
                    { "@MaPhieuThuTien", MaPhieuThuTien }
            };
            db.ExecuteNonQuery(strSQL, parameters);
        }
        public void XoaPhieuThu(string soPhieuThu)
        {
            string strSQL = "DELETE FROM PHIEUTHUTIEN WHERE MaPhieuThuTien = @MaPhieuThuTien";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MaPhieuThuTien", soPhieuThu);
            db.ExecuteNonQuery(strSQL, parameters);
        }

    }
}
