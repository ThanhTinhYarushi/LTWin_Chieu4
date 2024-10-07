using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhTinh_QuanLyThuVien
{
    
    class DocGia
    {
        Database db;
        public DocGia()
        {
            db = new Database();
        }
        //public DataTable layDSDocGia()
        //{
        //    string strSQL = "Select * FROM DOCGIA";
        //    DataTable dt = db.Execute(strSQL);
        //    return dt;
        //}
        public DataTable layDSDocGia()
        {
            string strSQL = "SELECT * FROM DOCGIA";
            DataTable dt = db.Execute(strSQL);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng DOCGIA.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dt;
        }

        public void themDocGia(string hoTen, DateTime ngaySinh, string diaChi, string email, DateTime ngayLapThe, DateTime ngayHetHan, float tienNo)
        {
            string strSQL = "INSERT INTO DOCGIA (HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo) " +
                            "VALUES (@hoTen, @ngaySinh, @diaChi, @email, @ngayLapThe, @ngayHetHan, @tienNo)";

            var parameters = new Dictionary<string, object>()
            {
                { "@hoTen", hoTen },
                { "@ngaySinh", ngaySinh },
                { "@diaChi", diaChi },
                { "@email", email },
                { "@ngayLapThe", ngayLapThe },
                { "@ngayHetHan", ngayHetHan },
                { "@tienNo", tienNo }
            };

            db.ExecuteNonQuery(strSQL, parameters);
        }
        public void capNhatDocGia(int maDocGia, string hoTen, DateTime ngaySinh, string diaChi, string email, DateTime ngayLapThe, DateTime ngayHetHan, float tienNo)
        {
            string strSQL = "UPDATE DOCGIA SET HoTenDocGia = @hoTen, NgaySinh = @ngaySinh, DiaChi = @diaChi, Email = @email, " +
                            "NgayLapThe = @ngayLapThe, NgayHetHan = @ngayHetHan, TienNo = @tienNo WHERE MaDocGia = @maDocGia";

            var parameters = new Dictionary<string, object>()
            {
                { "@hoTen", hoTen },
                { "@ngaySinh", ngaySinh },
                { "@diaChi", diaChi },
                { "@email", email },
                { "@ngayLapThe", ngayLapThe },
                { "@ngayHetHan", ngayHetHan },
                { "@tienNo", tienNo },
                { "@maDocGia", maDocGia }
            };

            db.ExecuteNonQuery(strSQL, parameters);
        }
        public void xoaDocGia(int maDocGia)
        {
            string strSQL = "DELETE FROM DOCGIA WHERE MaDocGia = @maDocGia";
            var parameters = new Dictionary<string, object>()
            {
                { "@maDocGia", maDocGia }
            };

            db.ExecuteNonQuery(strSQL, parameters);
        }
        public DataTable timKiemDocGiaTheoMa(int maDocGia)
        {
            string strSQL = "SELECT * FROM DOCGIA WHERE MaDocGia = @maDocGia";
            var parameters = new Dictionary<string, object>()
            {
                { "@maDocGia", maDocGia }
            };

            return db.Execute(strSQL, parameters);
        }
        public DataTable timKiemDocGiaTheoTen(string tenDocGia)
        {
            string strSQL = "SELECT * FROM DOCGIA WHERE HoTenDocGia LIKE @tenDocGia";
            var parameters = new Dictionary<string, object>()
            {
                { "@tenDocGia", "%" + tenDocGia + "%" } // Tìm kiếm theo tên giống nhau
            };

            return db.Execute(strSQL, parameters);
        }
    }
}
