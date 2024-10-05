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
    public partial class frmBangCap : Form
    {
        BangCap bangCap = new BangCap();
        public bool themMoi = false;
        public frmBangCap()
        {
            InitializeComponent();
            lsv_BangCap.Columns.Add("Mã Bằng Cấp", 220, HorizontalAlignment.Center);
            lsv_BangCap.Columns.Add("Bằng Cấp", 220, HorizontalAlignment.Center);

            HienThiBangCap();
            setButton(true);
            setNull();
        }
        private void HienThiBangCap()
        {
            DataTable dataTable = bangCap.layDanhSachBangCap();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ListViewItem lvi = lsv_BangCap.Items.Add(dataTable.Rows[i][0].ToString());
                lvi.SubItems.Add(dataTable.Rows[i][1].ToString());
            }
        }
        private void loadImage(string pic, PictureBox pictureBox)
        {
            //string imagePath = "D:\\Ảnh\\Lưu\\368197950_589925430019255_6194530745406130187_n.jpg";

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

        private void setNull()
        {
            txt_MaBangCap.Text = "";
            txt_TenBangCap.Text = "";
        }

        private void setButton(bool val)
        {
            btn_Thêm.Enabled = val;
            btn_Xoa.Enabled = val;
            btn_Sửa.Enabled = val;
            btn_Luu.Enabled = !val;
            btn_Huy.Enabled = !val;
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            themMoi = true;
            setButton(false);
            txt_MaBangCap.Enabled = false;
            txt_MaBangCap.Text = "";
            txt_TenBangCap.Focus();
        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            if(lsv_BangCap.SelectedIndices.Count > 0)
            {
                themMoi = false;
                setButton(false);
                txt_MaBangCap.Enabled = true;
                txt_TenBangCap.Focus();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_BangCap.SelectedIndices.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Bằng Cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    bangCap.XoaBangCap(lsv_BangCap.SelectedItems[0].SubItems[0].Text);
                    lsv_BangCap.Items.RemoveAt(lsv_BangCap.SelectedIndices[0]);
                    setNull();
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
                }
            }
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenBangCap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (themMoi)
            {
                bangCap.ThemBangCap(txt_TenBangCap.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                if (lsv_BangCap.SelectedItems.Count > 0)
                {
                    string maBangCap = txt_MaBangCap.Text;

                    if (bangCap.KiemTraBangCapTonTai(maBangCap))
                    {
                        bangCap.CapNhatBangCap(maBangCap, txt_TenBangCap.Text);
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Mã bằng cấp không tồn tại. Vui lòng kiểm tra lại!", "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin để cập nhật");
                }
            }
            lsv_BangCap.Items.Clear();
            HienThiBangCap();
            setButton(true);
            setNull();
            txt_MaBangCap.Enabled = true;
        }
        private void frmBangCap_Load(object sender, EventArgs e)
        {
            loadImage("D:\\Ảnh\\Lưu\\368197950_589925430019255_6194530745406130187_n.jpg", pictureBox1);
            loadImage("D:\\Ảnh\\Lưu\\benzemaaaaaaaaaaaaa.jpeg", pictureBox2);
        }

        private void lsv_BangCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_BangCap.SelectedIndices.Count > 0)
            {
                txt_MaBangCap.Text = lsv_BangCap.SelectedItems[0].SubItems[0].Text;
                txt_TenBangCap.Text = lsv_BangCap.SelectedItems[0].SubItems[1].Text;
            }
        }

    }
}
