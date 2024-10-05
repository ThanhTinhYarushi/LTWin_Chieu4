using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranThanhTinh_QuanLyThuVien
{
    
    class DocGia
    {
        Database db;
        public DocGia()
        {
            db = new Database();
        }
        public DataTable layDSDocGia()
        {
            string strSQL = "";
            DataTable dt = db.Execute(strSQL);
            
            return dt;
        }
    }
}
