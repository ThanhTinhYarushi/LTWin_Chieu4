using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhTinh_QuanLyThuVien
{
    public partial class frmDocGia : Form
    {
        DocGia dg = new DocGia();
        Database db = new Database();
        DataTable dt = new DataTable();
        public frmDocGia()
        {
            InitializeComponent();
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            dt = dg.layDSDocGia();
            dgv_DocGia.DataSource = dt; //gán dữ liệu cho datagrid
                                       //Thiết lập độ rộng các cột
            dgv_DocGia.Columns[0].Visible = false;
            dgv_DocGia.Columns[1].Width = 180;
            dgv_DocGia.Columns[3].Width = 200;
            dgv_DocGia.Columns[4].Width = 200;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                db.Update("Select * from DocGia", dt);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (DataException de)
            {
                MessageBox.Show("Có lỗi khi cập nhật \n" + de.ToString(), "lỗi", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            // mình không biết nữa các cậu đoán xem
        }
        private void dgv_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DocGia.Rows[e.RowIndex];

                txt_HoTenDocGia.Text = row.Cells["HoTenDocGia"].Value.ToString();
                txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();     
                txt_Email.Text = row.Cells["Email"].Value.ToString();       
                txt_TienNo.Text = row.Cells["TienNo"].Value.ToString();     
                dtp_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value); 
                dtp_NgayLapThe.Value = Convert.ToDateTime(row.Cells["NgayLapThe"].Value); 
                dtp_NgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value); 
            }
        }
        private void setNull()
        {
            txt_HoTenDocGia.Text = "";
            txt_DiaChi.Text = "";
            txt_Email.Text = "";
            txt_TienNo.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            dtp_NgayLapThe.Value = DateTime.Now;
            dtp_NgayHetHan.Value = DateTime.Now;
        }
        private void setButton(bool val)
        {
            btn_Them.Enabled = val;
            btn_Xoa.Enabled = val;
            btn_Sua.Enabled = val;
            btn_Luu.Enabled = !val;
            btn_Huy.Enabled = !val;
            btn_Tim.Enabled = val;
        }
    }
}
