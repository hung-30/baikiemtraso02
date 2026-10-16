#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    partial class frmAsyncReport
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
            grpScenarioB = new GroupBox();
            lblReportStatus = new Label();
            btnLoadRevenueReport = new Button();
            dgvReportResult = new DataGridView();
            grpScenarioC = new GroupBox();
            lblLastSyncTime = new Label();
            lblLiveOrdersCount = new Label();
            btnToggleRealtimeSync = new Button();
            dgvRealtimeOrders = new DataGridView();
            grpScenarioB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResult).BeginInit();
            grpScenarioC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRealtimeOrders).BeginInit();
            SuspendLayout();
            // 
            // grpScenarioB
            // 
            grpScenarioB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpScenarioB.Controls.Add(lblReportStatus);
            grpScenarioB.Controls.Add(btnLoadRevenueReport);
            grpScenarioB.Controls.Add(dgvReportResult);
            grpScenarioB.Location = new Point(12, 12);
            grpScenarioB.Name = "grpScenarioB";
            grpScenarioB.Size = new Size(860, 220);
            grpScenarioB.TabIndex = 0;
            grpScenarioB.TabStop = false;
            grpScenarioB.Text = "Scenario B: Tải Báo Cáo Doanh Thu Bất Đồng Bộ (Async/Await)";
            // 
            // lblReportStatus
            // 
            lblReportStatus.AutoSize = true;
            lblReportStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblReportStatus.ForeColor = Color.Blue;
            lblReportStatus.Location = new Point(230, 32);
            lblReportStatus.Name = "lblReportStatus";
            lblReportStatus.Size = new Size(160, 20);
            lblReportStatus.TabIndex = 2;
            lblReportStatus.Text = "Trạng thái: Chưa tải data";
            // 
            // btnLoadRevenueReport
            // 
            btnLoadRevenueReport.Location = new Point(15, 26);
            btnLoadRevenueReport.Name = "btnLoadRevenueReport";
            btnLoadRevenueReport.Size = new Size(200, 32);
            btnLoadRevenueReport.TabIndex = 1;
            btnLoadRevenueReport.Text = "Tải Báo Cáo Doanh Thu";
            btnLoadRevenueReport.UseVisualStyleBackColor = true;
            // 
            // dgvReportResult
            // 
            dgvReportResult.AllowUserToAddRows = false;
            dgvReportResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportResult.Location = new Point(15, 68);
            dgvReportResult.Name = "dgvReportResult";
            dgvReportResult.ReadOnly = true;
            dgvReportResult.RowHeadersWidth = 51;
            dgvReportResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportResult.Size = new Size(830, 140);
            dgvReportResult.TabIndex = 0;
            // 
            // grpScenarioC
            // 
            grpScenarioC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpScenarioC.Controls.Add(lblLastSyncTime);
            grpScenarioC.Controls.Add(lblLiveOrdersCount);
            grpScenarioC.Controls.Add(btnToggleRealtimeSync);
            grpScenarioC.Controls.Add(dgvRealtimeOrders);
            grpScenarioC.Location = new Point(12, 240);
            grpScenarioC.Name = "grpScenarioC";
            grpScenarioC.Size = new Size(860, 230);
            grpScenarioC.TabIndex = 1;
            grpScenarioC.TabStop = false;
            grpScenarioC.Text = "Scenario C: Đồng Bộ Đơn Hàng Mới Theo Thời Gian Thực (Safe Cross-Thread Invoke)";
            // 
            // lblLastSyncTime
            // 
            lblLastSyncTime.AutoSize = true;
            lblLastSyncTime.Location = new Point(450, 32);
            lblLastSyncTime.Name = "lblLastSyncTime";
            lblLastSyncTime.Size = new Size(189, 20);
            lblLastSyncTime.TabIndex = 3;
            lblLastSyncTime.Text = "Lần đồng bộ cuối: --:--:----";
            // 
            // lblLiveOrdersCount
            // 
            lblLiveOrdersCount.AutoSize = true;
            lblLiveOrdersCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLiveOrdersCount.ForeColor = Color.DarkGreen;
            lblLiveOrdersCount.Location = new Point(230, 32);
            lblLiveOrdersCount.Name = "lblLiveOrdersCount";
            lblLiveOrdersCount.Size = new Size(198, 20);
            lblLiveOrdersCount.TabIndex = 2;
            lblLiveOrdersCount.Text = "Tổng số đơn hàng mới: 0";
            // 
            // btnToggleRealtimeSync
            // 
            btnToggleRealtimeSync.Location = new Point(15, 26);
            btnToggleRealtimeSync.Name = "btnToggleRealtimeSync";
            btnToggleRealtimeSync.Size = new Size(200, 32);
            btnToggleRealtimeSync.TabIndex = 1;
            btnToggleRealtimeSync.Text = "Bật Đồng Bộ Thời Gian Thực";
            btnToggleRealtimeSync.UseVisualStyleBackColor = true;
            // 
            // dgvRealtimeOrders
            // 
            dgvRealtimeOrders.AllowUserToAddRows = false;
            dgvRealtimeOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRealtimeOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRealtimeOrders.Location = new Point(15, 68);
            dgvRealtimeOrders.Name = "dgvRealtimeOrders";
            dgvRealtimeOrders.ReadOnly = true;
            dgvRealtimeOrders.RowHeadersWidth = 51;
            dgvRealtimeOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRealtimeOrders.Size = new Size(830, 150);
            dgvRealtimeOrders.TabIndex = 0;
            // 
            // frmAsyncReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 483);
            Controls.Add(grpScenarioC);
            Controls.Add(grpScenarioB);
            Name = "frmAsyncReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thống Kê Doanh Thu & Đồng Bộ Bất Đồng Bộ";
            grpScenarioB.ResumeLayout(false);
            grpScenarioB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportResult).EndInit();
            grpScenarioC.ResumeLayout(false);
            grpScenarioC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRealtimeOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpScenarioB;
        private Button btnLoadRevenueReport;
        private DataGridView dgvReportResult;
        private Label lblReportStatus;
        private GroupBox grpScenarioC;
        private Button btnToggleRealtimeSync;
        private DataGridView dgvRealtimeOrders;
        private Label lblLiveOrdersCount;
        private Label lblLastSyncTime;
    }
}