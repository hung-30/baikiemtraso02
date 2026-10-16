#nullable disable
using System;
using System.Linq;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            // Mở các Form con MDI
            mnuProductCatalog.Click += (s, e) => OpenChildForm<frmProductCatalog>();
            mnuInventory.Click += (s, e) => OpenChildForm<frmInventory>();
            mnuAsyncReport.Click += (s, e) => OpenChildForm<frmAsyncReport>();

            // Sắp xếp cửa sổ MDI
            mnuCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            mnuTileHorizontal.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            mnuTileVertical.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);

            mnuLogout.Click += MnuLogout_Click;
            mnuExit.Click += (s, e) => Close();

            FormClosing += Form1_FormClosing;
        }

        public void OpenChildForm<T>() where T : Form, new()
        {
            try
            {
                Form childForm = MdiChildren.FirstOrDefault(f => f is T);

                if (childForm != null)
                {
                    childForm.Activate();
                }
                else
                {
                    childForm = new T
                    {
                        MdiParent = this
                    };
                    childForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở cửa sổ: {ex.InnerException?.Message ?? ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetLoadingState(bool isLoading, string statusMessage = "Sẵn sàng")
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetLoadingState(isLoading, statusMessage)));
                return;
            }

            prgGlobal.Visible = isLoading;
            prgGlobal.Style = isLoading ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
            lblStatusText.Text = statusMessage;
        }

        private void MnuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form child in MdiChildren)
                {
                    child.Close();
                }
                lblUserLogin.Text = "Người dùng: [Chưa đăng nhập]";
                MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi Hệ Thống Quản Lý Siêu Thị?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}