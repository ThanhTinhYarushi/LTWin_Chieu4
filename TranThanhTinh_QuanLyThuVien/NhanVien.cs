using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    class NhanVien
    {
        Database db;
        public NhanVien() {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select Manhanvien, HoTenNhanVien, Ngaysinh,Diachi,Dienthoai, TenBangcap From Nhanvien N, BANGCAP B Where N.MaBangCap = B.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable layBangCap()
        {
            string strSQL = "Select * from bangcap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        // Xoá Nhân Viên
        public void XoaNhanVien(string index_nv)
        {
            //string sql = "Delete from NhanVien where MaNhanVien = " + index_nv;
            string sql = string.Format("Delete from NhanVien where MaNhanVien = '{0}'", index_nv);
            db.ExecuteNonQuery(sql);
        }
        // Thêm Nhân Viên
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            string sql = string.Format("Insert Into NhanVien Values(N'{0}', '{1}', N'{2}', '{3}','{4}')", ten, ngaysinh, diachi, dienthoai, index_bc);
            
            db.ExecuteNonQuery(sql);
        }
        // Cập Nhật Nhân Viên
        public void CapNhatNhanVien(string index_nv, string hoten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {
            //string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', diachi = N'{2}',dienthoai = '{3}', MaBangCap = '{4}' where MaNhanVien = { 5 }", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);
            //db.ExecuteNonQuery(str);
            string str = "Update NhanVien set HoTenNhanVien = @hoten, NgaySinh = @ngaysinh, DiaChi = @diachi, DienThoai = @dienthoai, MaBangCap = @index_bc where MaNhanVien = @index_nv";
            var parameters = new Dictionary<string, object>()
                {
                    { "@hoten", hoten },
                    { "@ngaysinh", ngaysinh },
                    { "@diachi", diachi },
                    { "@dienthoai", dienthoai },
                    { "@index_bc", index_bc },
                    { "@index_nv", index_nv }
                };
            db.ExecuteNonQuery(str, parameters);
        }
    }
}
