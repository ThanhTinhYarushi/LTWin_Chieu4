using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhTinh_QuanLyThuVien
{
    public partial class frmSach : Form
    {
        public bool themMoi = false;
        Sach sach = new Sach();

        public frmSach()
        {
            InitializeComponent();
            lsv_Sach.Columns.Add("Mã Sách", 110,HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Tên Sách", 260, HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Tác Giả", 200, HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Nhà Xuất Bản", 190, HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Trị Giá", 140, HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Ngày Nhập", 130, HorizontalAlignment.Left);
            lsv_Sach.Columns.Add("Năm Xuất Bản", 110, HorizontalAlignment.Left);
            HienThiSach();
            setNull();
            setButton(true);
        }
        private void HienThiSach()
        {
            DataTable dt = sach.layDSSach();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsv_Sach.Items.Add(dt.Rows[i][0].ToString());

                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void setNull()
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_TacGia.Text = "";
            txt_NhaXuatBan.Text = "";
            txt_TriGia.Text = "";
            txt_NamXuatBan.Text = "";
            // ngày nhập
            dtp_NgayNhap.Value = DateTime.Now;
        }
        void setButton(bool val)
        {
            btn_Them.Enabled = val;
            btn_Xoa.Enabled = val;
            btn_Sua.Enabled = val;
            btn_Thoat.Enabled = val;
            btn_Luu.Enabled = !val;
            btn_Huy.Enabled = !val;
        }

        private void lsv_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Sach.SelectedIndices.Count > 0) 
            {
                txt_TenSach.Text = lsv_Sach.SelectedItems[0].SubItems[1].Text;
                txt_MaSach.Text = lsv_Sach.SelectedItems[0].SubItems[2].Text;
                txt_TacGia.Text = lsv_Sach.SelectedItems[0].SubItems[3].Text;
                txt_NhaXuatBan.Text = lsv_Sach.SelectedItems[0].SubItems[4].Text;
                txt_TriGia.Text = lsv_Sach.SelectedItems[0].SubItems[5].Text;
                dtp_NgayNhap.Value = DateTime.Parse(lsv_Sach.SelectedItems[0].SubItems[6].Text);
                txt_NamXuatBan.Text = lsv_Sach.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            themMoi = true;
            setButton(false);
            txt_MaSach.Enabled = false;
            txt_MaSach.Text = "";
            txt_TenSach.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_Sach.SelectedIndices.Count > 0)
            {
                themMoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(lsv_Sach.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sach.XoaSach(lsv_Sach.SelectedItems[0].SubItems[0].Text);
                    lsv_Sach.Items.RemoveAt(lsv_Sach.SelectedIndices[0]);
                    setNull();
                }
            } 
            else
            {
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenSach.Text) || string.IsNullOrWhiteSpace(txt_TacGia.Text) || string.IsNullOrWhiteSpace(txt_NhaXuatBan.Text) || string.IsNullOrWhiteSpace(txt_TriGia.Text) || string.IsNullOrWhiteSpace(txt_NamXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (themMoi)
            {
                sach.ThemSach(txt_TenSach.Text, txt_TacGia.Text, txt_NamXuatBan.Text, txt_NhaXuatBan.Text, txt_TriGia.Text, dtp_NgayNhap.Value.ToString("yyyy-MM-dd"));
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // update
            {
                if (lsv_Sach.SelectedItems.Count > 0)
                {
                    string maSach = lsv_Sach.SelectedItems[0].SubItems[0].Text; 
                    sach.CapNhatSach(maSach, txt_TenSach.Text, txt_TacGia.Text, txt_NamXuatBan.Text, txt_NhaXuatBan.Text, txt_TriGia.Text, dtp_NgayNhap.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có thông tin để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            lsv_Sach.Items.Clear();
            HienThiSach();
            setButton(true);
            setNull();
            txt_MaSach.Enabled = true;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            txt_MaSach.Enabled = true;
        }
    }
}
