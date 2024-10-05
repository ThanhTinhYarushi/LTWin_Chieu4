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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }

        private void tsb_NhanVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.Name=="frmNhanVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.MdiParent = this;
            frmNV.WindowState = FormWindowState.Maximized;
            frmNV.Show();
        }

        private void tsb_DocGia_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmDocGia")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmDocGia frm = new frmDocGia();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_Sach_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSach")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmSach frm = new frmSach();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_BangCap_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmBangCap")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmBangCap frm = new frmBangCap();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_PhieuMuon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmPhieuMuonSach")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmPhieuMuonSach frm = new frmPhieuMuonSach();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_PhieuThu_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmPhieuThu")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmPhieuThu frm = new frmPhieuThu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_ChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmChiTietPhieuMuon")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();
                    return;
                }
            }
            frmChiTietPhieuMuon frm = new frmChiTietPhieuMuon();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
