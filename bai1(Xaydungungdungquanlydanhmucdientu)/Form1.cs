#nullable disable
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bai1_Xaydungungdungquanlydanhmucdientu_
{
    // ==========================================
    // 1. CLASS FORM1 (XỬ LÝ GIAO DIỆN & LOGIC)
    // ==========================================
    public partial class Form1 : Form
    {
        private BindingList<Device> _deviceList;
        private BindingSource _deviceBindingSource;
        private ErrorProvider _errorProvider;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            _errorProvider = new ErrorProvider();
            _deviceList = new BindingList<Device>();
            _deviceBindingSource = new BindingSource();

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new string[] { "Điện thoại", "Laptop", "Máy tính bảng", "Màn hình", "Phụ kiện" });

            SetupDataGridView();
            LoadSampleData();

            _deviceBindingSource.DataSource = _deviceList;
            dgvDevices.DataSource = _deviceBindingSource;

            _deviceBindingSource.CurrentChanged += DeviceBindingSource_CurrentChanged;

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            _deviceBindingSource.ResetBindings(false);
            if (_deviceList.Count > 0)
            {
                DeviceBindingSource_CurrentChanged(null, null);
            }
            else
            {
                txtDeviceId.Text = GenerateNewDeviceId();
            }
        }

        private void SetupDataGridView()
        {
            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.ReadOnly = true;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.MultiSelect = false;
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Device.DeviceId), HeaderText = "Mã Thiết Bị", Width = 110 });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Device.DeviceName), HeaderText = "Tên Thiết Bị", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Device.Category), HeaderText = "Loại Thiết Bị", Width = 130 });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Device.Price), HeaderText = "Đơn Giá (VNĐ)", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Device.Quantity), HeaderText = "Số Lượng Tồn", Width = 110, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight } });
        }

        private void LoadSampleData()
        {
            _deviceList.Add(new Device("DEV001", "Laptop Dell XPS 15", "Laptop", 35000000, 10));
            _deviceList.Add(new Device("DEV002", "iPhone 15 Pro Max", "Điện thoại", 30000000, 15));
            _deviceList.Add(new Device("DEV003", "iPad Air 5", "Máy tính bảng", 18000000, 8));
        }

        private void DeviceBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (_deviceBindingSource.Current is Device current)
            {
                txtDeviceId.Text = current.DeviceId ?? string.Empty;
                txtDeviceName.Text = current.DeviceName ?? string.Empty;
                cboCategory.SelectedItem = current.Category;
                txtPrice.Text = current.Price.ToString("G0");
                numQuantity.Value = Math.Min(Math.Max(numQuantity.Minimum, current.Quantity), numQuantity.Maximum);
            }
        }

        private bool ValidateInput()
        {
            _errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                _errorProvider.SetError(txtDeviceName, "Tên thiết bị không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex < 0 || cboCategory.SelectedItem == null)
            {
                _errorProvider.SetError(cboCategory, "Vui lòng chọn loại thiết bị!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                _errorProvider.SetError(txtPrice, "Đơn giá phải là số hợp lệ và >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private string GenerateNewDeviceId()
        {
            int maxId = 0;
            foreach (var dev in _deviceList)
            {
                if (dev.DeviceId != null && dev.DeviceId.StartsWith("DEV") && int.TryParse(dev.DeviceId.Substring(3), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"DEV{(maxId + 1):D3}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string newId = GenerateNewDeviceId();
            Device newDevice = new Device(
                newId,
                txtDeviceName.Text.Trim(),
                cboCategory.SelectedItem.ToString(),
                decimal.Parse(txtPrice.Text.Trim()),
                (int)numQuantity.Value
            );

            _deviceList.Add(newDevice);
            _deviceBindingSource.MoveLast();
            MessageBox.Show("Thêm thiết bị mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_deviceBindingSource.Current is Device currentDevice)
            {
                if (!ValidateInput()) return;

                currentDevice.DeviceName = txtDeviceName.Text.Trim();
                currentDevice.Category = cboCategory.SelectedItem.ToString();
                currentDevice.Price = decimal.Parse(txtPrice.Text.Trim());
                currentDevice.Quantity = (int)numQuantity.Value;

                _deviceBindingSource.ResetCurrentItem();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_deviceBindingSource.Current is Device currentDevice)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa thiết bị '{currentDevice.DeviceName}' (Mã: {currentDevice.DeviceId}) không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    _deviceBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();
            txtDeviceId.Text = GenerateNewDeviceId();
            txtDeviceName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            numQuantity.Value = 0;
            txtDeviceName.Focus();
        }
    }

    // ==========================================
    // 2. CLASS MODEL DEVICE (ĐẶT Ở CUỐI FILE FORM1.CS)
    // ==========================================
    public class Device : INotifyPropertyChanged
    {
        private string _deviceId = string.Empty;
        private string _deviceName = string.Empty;
        private string _category = string.Empty;
        private decimal _price;
        private int _quantity;

        public string DeviceId
        {
            get => _deviceId;
            set { _deviceId = value; OnPropertyChanged(nameof(DeviceId)); }
        }

        public string DeviceName
        {
            get => _deviceName;
            set { _deviceName = value; OnPropertyChanged(nameof(DeviceName)); }
        }

        public string Category
        {
            get => _category;
            set { _category = value; OnPropertyChanged(nameof(Category)); }
        }

        public decimal Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(nameof(Price)); }
        }

        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(nameof(Quantity)); }
        }

        public Device() { }

        public Device(string id, string name, string category, decimal price, int quantity)
        {
            DeviceId = id;
            DeviceName = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}