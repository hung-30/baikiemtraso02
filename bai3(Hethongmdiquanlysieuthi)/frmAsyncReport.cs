#nullable disable
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    public partial class frmAsyncReport : Form
    {
        private BindingList<RevenueReportModel> _reportList;
        private BindingList<OrderModel> _realtimeOrderList;

        private CancellationTokenSource _ctsRealtimeSync;
        private bool _isSyncRunning = false;

        public frmAsyncReport()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            _reportList = new BindingList<RevenueReportModel>();
            _realtimeOrderList = new BindingList<OrderModel>();

            dgvReportResult.DataSource = _reportList;
            dgvRealtimeOrders.DataSource = _realtimeOrderList;

            btnLoadRevenueReport.Click += BtnLoadRevenueReport_Click;
            btnToggleRealtimeSync.Click += BtnToggleRealtimeSync_Click;

            FormClosing += FrmAsyncReport_FormClosing;
        }

        #region SCENARIO B: ASYNC / AWAIT (TẢI BÁO CÁO 4 GIÂY KHÔNG ĐƠ UI)

        private async void BtnLoadRevenueReport_Click(object sender, EventArgs e)
        {
            btnLoadRevenueReport.Enabled = false;
            lblReportStatus.Text = "Trạng thái: Đang truy xuất dữ liệu lớn từ CSDL (4 giây)...";

            // Khai báo 1 lần duy nhất biến mainForm cho toàn bộ phương thức
            Form1 mainForm = MdiParent as Form1;
            mainForm?.SetLoadingState(true, "Đang tính toán báo cáo doanh thu siêu thị...");

            try
            {
                var data = await Task.Run(() => FetchHeavyRevenueData());

                _reportList.Clear();
                foreach (var item in data)
                {
                    _reportList.Add(item);
                }

                lblReportStatus.Text = $"Trạng thái: Hoàn tất tải {data.Length} mục báo cáo lúc {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoadRevenueReport.Enabled = true;
                // Tái sử dụng mainForm an toàn không bị trùng scope
                mainForm?.SetLoadingState(false, "Sẵn sàng");
            }
        }

        private RevenueReportModel[] FetchHeavyRevenueData()
        {
            Thread.Sleep(4000);

            return new RevenueReportModel[]
            {
                new RevenueReportModel("Khu Vực A - Thực Phẩm", 1450, 452000000),
                new RevenueReportModel("Khu Vực B - Đồ Gia Dụng", 820, 230500000),
                new RevenueReportModel("Khu Vực C - Hóa Mỹ Phẩm", 1100, 189000000),
                new RevenueReportModel("Khu Vực D - Nước Giải Khát", 2300, 310000000)
            };
        }

        #endregion

        #region SCENARIO C: SAFE CROSS-THREAD INVOKE (ĐỒNG BỘ 2 GIÂY/LẦN)

        private void BtnToggleRealtimeSync_Click(object sender, EventArgs e)
        {
            if (!_isSyncRunning)
            {
                StartRealtimeSync();
            }
            else
            {
                StopRealtimeSync();
            }
        }

        private void StartRealtimeSync()
        {
            _isSyncRunning = true;
            btnToggleRealtimeSync.Text = "Tắt Đồng Bộ Thời Gian Thực";
            btnToggleRealtimeSync.BackColor = System.Drawing.Color.LightPink;

            _ctsRealtimeSync = new CancellationTokenSource();
            var token = _ctsRealtimeSync.Token;

            Task.Run(async () =>
            {
                int orderCounter = _realtimeOrderList.Count;

                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(2000, token);
                    orderCounter++;

                    OrderModel newOrder = new OrderModel(
                        $"HD{orderCounter:D4}",
                        $"Khách hàng #{orderCounter}",
                        (decimal)(new Random().Next(50, 2000) * 1000),
                        DateTime.Now.ToString("HH:mm:ss")
                    );

                    SafeUpdateUI(newOrder);
                }
            }, token);
        }

        private void SafeUpdateUI(OrderModel order)
        {
            if (IsDisposed || !IsHandleCreated) return;

            if (InvokeRequired)
            {
                Invoke(new Action(() => SafeUpdateUI(order)));
                return;
            }

            _realtimeOrderList.Insert(0, order);
            lblLiveOrdersCount.Text = $"Tổng số đơn hàng mới: {_realtimeOrderList.Count}";
            lblLastSyncTime.Text = $"Lần đồng bộ cuối: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private void StopRealtimeSync()
        {
            if (_ctsRealtimeSync != null)
            {
                _ctsRealtimeSync.Cancel();
                _ctsRealtimeSync.Dispose();
                _ctsRealtimeSync = null;
            }

            _isSyncRunning = false;
            btnToggleRealtimeSync.Text = "Bật Đồng Bộ Thời Gian Thực";
            btnToggleRealtimeSync.UseVisualStyleBackColor = true;
        }

        private void FrmAsyncReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopRealtimeSync();
        }

        #endregion
    }

    public class RevenueReportModel
    {
        public string CategoryName { get; set; }
        public int TotalItemsSold { get; set; }
        public decimal TotalRevenue { get; set; }

        public RevenueReportModel(string name, int count, decimal revenue)
        {
            CategoryName = name;
            TotalItemsSold = count;
            TotalRevenue = revenue;
        }
    }

    public class OrderModel
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string CreatedTime { get; set; }

        public OrderModel(string id, string customer, decimal amount, string time)
        {
            OrderId = id;
            CustomerName = customer;
            TotalAmount = amount;
            CreatedTime = time;
        }
    }
}