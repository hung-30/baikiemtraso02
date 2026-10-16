#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuCategory = new ToolStripMenuItem();
            mnuProductCatalog = new ToolStripMenuItem();
            mnuInventory = new ToolStripMenuItem();
            mnuReports = new ToolStripMenuItem();
            mnuAsyncReport = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            statusStripMain = new StatusStrip();
            lblUserLogin = new ToolStripStatusLabel();
            lblStatusText = new ToolStripStatusLabel();
            prgGlobal = new ToolStripProgressBar();
            menuStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuCategory, mnuReports, mnuWindows });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1182, 28);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, toolStripSeparator1, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(85, 24);
            mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(160, 26);
            mnuLogout.Text = "Đăng xuất";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(160, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuCategory
            // 
            mnuCategory.DropDownItems.AddRange(new ToolStripItem[] { mnuProductCatalog, mnuInventory });
            mnuCategory.Name = "mnuCategory";
            mnuCategory.Size = new Size(90, 24);
            mnuCategory.Text = "Danh mục";
            // 
            // mnuProductCatalog
            // 
            mnuProductCatalog.Name = "mnuProductCatalog";
            mnuProductCatalog.Size = new Size(210, 26);
            mnuProductCatalog.Text = "Quản lý Sản phẩm";
            // 
            // mnuInventory
            // 
            mnuInventory.Name = "mnuInventory";
            mnuInventory.Size = new Size(210, 26);
            mnuInventory.Text = "Quản lý Nhập xuất";
            // 
            // mnuReports
            // 
            mnuReports.DropDownItems.AddRange(new ToolStripItem[] { mnuAsyncReport });
            mnuReports.Name = "mnuReports";
            mnuReports.Size = new Size(77, 24);
            mnuReports.Text = "Báo cáo";
            // 
            // mnuAsyncReport
            // 
            mnuAsyncReport.Name = "mnuAsyncReport";
            mnuAsyncReport.Size = new Size(276, 26);
            mnuAsyncReport.Text = "Thống kê Doanh thu & Đồng bộ";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(72, 24);
            mnuWindows.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(190, 26);
            mnuTileHorizontal.Text = "Tile Horizontal";
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(190, 26);
            mnuTileVertical.Text = "Tile Vertical";
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { lblUserLogin, lblStatusText, prgGlobal });
            statusStripMain.Location = new Point(0, 647);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(1182, 26);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "statusStrip1";
            // 
            // lblUserLogin
            // 
            lblUserLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(183, 20);
            lblUserLogin.Text = "Người dùng: Admin_SieuThi";
            // 
            // lblStatusText
            // 
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(784, 20);
            lblStatusText.Spring = true;
            lblStatusText.Text = "Sẵn sàng";
            lblStatusText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // prgGlobal
            // 
            prgGlobal.Name = "prgGlobal";
            prgGlobal.Size = new Size(200, 18);
            prgGlobal.Style = ProgressBarStyle.Marquee;
            prgGlobal.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Siêu Thị - MDI Master Form";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuCategory;
        private ToolStripMenuItem mnuProductCatalog;
        private ToolStripMenuItem mnuInventory;
        private ToolStripMenuItem mnuReports;
        private ToolStripMenuItem mnuAsyncReport;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel lblUserLogin;
        private ToolStripStatusLabel lblStatusText;
        private ToolStripProgressBar prgGlobal;
    }
}