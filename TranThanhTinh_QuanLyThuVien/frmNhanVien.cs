using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranThanhTinh_QuanLyThuVien
{
    public partial class frmNhanVien : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
            // Thêm sẵn nv
            lsv_NhanVien.Columns.Add("Mã NV", 110, HorizontalAlignment.Left);
            lsv_NhanVien.Columns.Add("Họ Tên", 220, HorizontalAlignment.Left);
            lsv_NhanVien.Columns.Add("Ngày Sinh", 110, HorizontalAlignment.Left);
            lsv_NhanVien.Columns.Add("Địa Chỉ", 280, HorizontalAlignment.Left);
            lsv_NhanVien.Columns.Add("Điện Thoại", 110, HorizontalAlignment.Left);
            lsv_NhanVien.Columns.Add("Bằng Cấp", 120, HorizontalAlignment.Left);
            HienThiNhanVien();
            HienthiBangcap();
            setButton(true);
            setNull();
        }
        private void HienThiNhanVien()
        {
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                ListViewItem lvi = lsv_NhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void setNull()
        {
            txt_HoTen.Text = "";
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
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
        void HienthiBangcap()
        {
            DataTable dt = nv.layBangCap();
            cbo_BangCap.DataSource = dt;
            cbo_BangCap.DisplayMember = "TenBangcap";
            cbo_BangCap.ValueMember = "MaBangcap";
        }

        private void lsv_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_NhanVien.SelectedIndices.Count > 0)
            {
                txt_HoTen.Text =
                lsv_NhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtp_NgaySinh.Value =
                DateTime.Parse(lsv_NhanVien.SelectedItems[0].SubItems[2].Text);
                txt_DiaChi.Text =
                lsv_NhanVien.SelectedItems[0].SubItems[3].Text;
                txt_SoDienThoai.Text =
                lsv_NhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cbo_BangCap.SelectedIndex =
                cbo_BangCap.FindString(lsv_NhanVien.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txt_HoTen.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_NhanVien.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật",
                "Sửa mẫu tin");
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_NhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsv_NhanVien.SelectedItems[0].SubItems[0].Text);
                    lsv_NhanVien.Items.RemoveAt(lsv_NhanVien.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}",dtp_NgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            if (themmoi)
            {
                nv.ThemNhanVien(txt_HoTen.Text, ngay, txt_DiaChi.Text,txt_SoDienThoai.Text, cbo_BangCap.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsv_NhanVien.SelectedItems[0].SubItems[0].Text,txt_HoTen.Text, ngay, txt_DiaChi.Text, txt_SoDienThoai.Text,cbo_BangCap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienThiNhanVien();
            setNull();
        }
    }
}
