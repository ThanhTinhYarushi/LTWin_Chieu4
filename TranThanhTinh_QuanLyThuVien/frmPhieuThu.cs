using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhTinh_QuanLyThuVien
{
    public partial class frmPhieuThu : Form
    {
        public bool themMoi = false;
        PhieuThuTien phieuThu = new PhieuThuTien();

        // db
        Database db;

        public frmPhieuThu()
        {
            InitializeComponent();
            lsv_PhieuThu.Columns.Add("Mã Phiếu", 100, HorizontalAlignment.Left);
            lsv_PhieuThu.Columns.Add("Số Tiền Nợ", 140, HorizontalAlignment.Left);
            lsv_PhieuThu.Columns.Add("Số Tiền Thu", 140, HorizontalAlignment.Left);
            lsv_PhieuThu.Columns.Add("Mã Độc Giả", 80, HorizontalAlignment.Left);
            lsv_PhieuThu.Columns.Add("Mã Nhân Viên", 80, HorizontalAlignment.Left);
            HienThiPhieuThu();
            setNull();
            setButton(true);
        }

        private void HienThiPhieuThu()
        {
            DataTable dt = phieuThu.layDSPhieuThuTien();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsv_PhieuThu.Items.Add(dt.Rows[i][0].ToString());

                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        void setNull()
        {
            txt_MaPhieuThu.Text = "";
            txt_SoTienNo.Text = "";
            txt_SoTienThu.Text = "";
            txt_MaDocGia.Text = "";
            txt_MaNhanVien.Text = "";
        }

        void setButton(bool val)
        {
            btn_Them.Enabled = val;
            btn_Xoa.Enabled = val;
            btn_Sua.Enabled = val;
            btn_Luu.Enabled = !val;
            btn_Huy.Enabled = !val;
        }

        private void lsv_PhieuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_PhieuThu.SelectedIndices.Count > 0)
            {
                txt_MaPhieuThu.Text = lsv_PhieuThu.SelectedItems[0].SubItems[0].Text;
                txt_SoTienNo.Text = lsv_PhieuThu.SelectedItems[0].SubItems[1].Text;
                txt_SoTienThu.Text = lsv_PhieuThu.SelectedItems[0].SubItems[2].Text;
                txt_MaDocGia.Text = lsv_PhieuThu.SelectedItems[0].SubItems[3].Text;
                txt_MaNhanVien.Text = lsv_PhieuThu.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            themMoi = true;
            setButton(false);
            txt_MaPhieuThu.Enabled = false;
            setNull();
            txt_SoTienNo.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_PhieuThu.SelectedIndices.Count > 0)
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
            if (lsv_PhieuThu.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa Phiếu Thu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    phieuThu.XoaPhieuThu(lsv_PhieuThu.SelectedItems[0].SubItems[0].Text);
                    lsv_PhieuThu.Items.RemoveAt(lsv_PhieuThu.SelectedIndices[0]);
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
            if (string.IsNullOrWhiteSpace(txt_SoTienNo.Text) || string.IsNullOrWhiteSpace(txt_SoTienThu.Text) || string.IsNullOrWhiteSpace(txt_MaDocGia.Text) || string.IsNullOrWhiteSpace(txt_MaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraKhoaNgoai(txt_MaNhanVien.Text, txt_MaDocGia.Text))
            {
                return;
            }

            if (themMoi)
            {
                phieuThu.ThemPhieuThu(txt_SoTienNo.Text, txt_SoTienThu.Text, txt_MaDocGia.Text, txt_MaNhanVien.Text);
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string maPhieu = lsv_PhieuThu.SelectedItems[0].SubItems[0].Text;
                phieuThu.CapNhatPhieuThu(maPhieu, txt_SoTienNo.Text, txt_SoTienThu.Text, txt_MaDocGia.Text, txt_MaNhanVien.Text);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lsv_PhieuThu.Items.Clear();
            HienThiPhieuThu();
            setButton(true);
            setNull();
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
        }
        private void loadImage(string pic, PictureBox pictureBox)
        {
            if (File.Exists(pic))
            {
                pictureBox.Image = Image.FromFile(pic);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Không tìm thấy file ảnh!");
            }
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            loadImage("D:\\Ảnh\\Hình Nền\\10 tips on how to study effectively.jpg", pic1);
            loadImage("D:\\Ảnh\\Hình Nền\\1324827.png", pic2);
        }
        private bool KiemTraKhoaNgoai(string maNhanVien, string maDocGia)
        {
            // Truy vấn để kiểm tra sự tồn tại của khóa ngoại
            string sqlNhanVien = "SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            string sqlDocGia = "SELECT COUNT(*) FROM DocGia WHERE MaDocGia = @MaDocGia";

            Dictionary<string, object> parametersNhanVien = new Dictionary<string, object>
            {
                { "@MaNhanVien", maNhanVien }
            };

            Dictionary<string, object> parametersDocGia = new Dictionary<string, object>
            {
                { "@MaDocGia", maDocGia }
            };

            int countNhanVien = Convert.ToInt32(db.ExecuteScalar(sqlNhanVien, parametersNhanVien));
            int countDocGia = Convert.ToInt32(db.ExecuteScalar(sqlDocGia, parametersDocGia));

            // Kiểm tra nếu tồn tại ít nhất 1 bản ghi cho cả hai khóa ngoại
            if (countNhanVien == 0)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (countDocGia == 0)
            {
                MessageBox.Show("Mã độc giả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
