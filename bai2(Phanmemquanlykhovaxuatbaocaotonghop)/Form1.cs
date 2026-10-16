#nullable disable
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2_Phanmemquanlykhovaxuatbaocaotonghop_
{
    // ==========================================
    // 1. CLASS XỬ LÝ FORM
    // ==========================================
    public partial class Form1 : Form
    {
        private BindingList<Product> _productList;
        private BindingSource _productBindingSource;
        private ErrorProvider _errorProvider;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            _errorProvider = new ErrorProvider();
            _productList = new BindingList<Product>();
            _productBindingSource = new BindingSource();

            _productList.ListChanged += (s, e) => UpdateStatusStrip();

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(new string[] { "Điện tử", "Gia dụng", "Thời trang", "Thực phẩm", "Thiết bị văn phòng" });

            SetupDataGridView();
            LoadSampleData();

            _productBindingSource.DataSource = _productList;
            dgvProducts.DataSource = _productBindingSource;

            SetupDataBinding();

            _productBindingSource.CurrentChanged += ProductBindingSource_CurrentChanged;

            btnSelectImage.Click += BtnSelectImage_Click;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            mnuOpen.Click += (s, e) => ImportCSV();
            mnuImportCsv.Click += (s, e) => ImportCSV();
            btnToolImport.Click += (s, e) => ImportCSV();

            mnuSaveReport.Click += (s, e) => ExportCSV();
            mnuExportCsv.Click += (s, e) => ExportCSV();
            btnToolExport.Click += (s, e) => ExportCSV();

            mnuExit.Click += (s, e) => Close();
            btnToolExit.Click += (s, e) => Close();

            timerRealTime.Tick += (s, e) =>
            {
                lblRealTime.Text = $"Thời gian: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
            };

            FormClosing += FrmInventoryManager_FormClosing;

            txtProductId.Text = GenerateNewProductId();
            UpdateStatusStrip();
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductId),
                HeaderText = "Mã SP",
                Width = 100
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ProductName),
                HeaderText = "Tên Sản Phẩm",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Category),
                HeaderText = "Loại SP",
                Width = 130
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Price),
                HeaderText = "Đơn Giá (VNĐ)",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.Quantity),
                HeaderText = "Số Lượng",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Product.ImagePath),
                HeaderText = "Đường Dẫn Ảnh",
                Width = 200
            });
        }

        private void LoadSampleData()
        {
            _productList.Add(new Product("SP001", "Tủ lạnh Panasonic 300L", "Gia dụng", 12500000, 5, ""));
            _productList.Add(new Product("SP002", "Smart TV Samsung 55 inch", "Điện tử", 15900000, 8, ""));
            _productList.Add(new Product("SP003", "Máy giặt LG Inverter 9kg", "Gia dụng", 8900000, 12, ""));
        }

        private void SetupDataBinding()
        {
            txtProductId.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            cboCategory.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            numQuantity.DataBindings.Clear();
            txtImagePath.DataBindings.Clear();

            txtProductId.DataBindings.Add("Text", _productBindingSource, nameof(Product.ProductId), true, DataSourceUpdateMode.Never);
            txtProductName.DataBindings.Add("Text", _productBindingSource, nameof(Product.ProductName), true, DataSourceUpdateMode.Never);
            cboCategory.DataBindings.Add("SelectedItem", _productBindingSource, nameof(Product.Category), true, DataSourceUpdateMode.Never);

            Binding priceBinding = new Binding("Text", _productBindingSource, nameof(Product.Price), true, DataSourceUpdateMode.Never);
            priceBinding.Format += (s, e) =>
            {
                if (e.Value is decimal val) e.Value = val.ToString("G0");
            };
            txtPrice.DataBindings.Add(priceBinding);

            numQuantity.DataBindings.Add("Value", _productBindingSource, nameof(Product.Quantity), true, DataSourceUpdateMode.Never);
            txtImagePath.DataBindings.Add("Text", _productBindingSource, nameof(Product.ImagePath), true, DataSourceUpdateMode.Never);
        }

        private void ProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is Product currentProduct)
            {
                LoadImageToPictureBox(currentProduct.ImagePath);
            }
            else
            {
                picProductImage.Image = null;
            }
        }

        private void LoadImageToPictureBox(string path)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picProductImage.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    picProductImage.Image = null;
                }
            }
            catch
            {
                picProductImage.Image = null;
            }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện sản phẩm";
                ofd.Filter = "File hình ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Tất cả các file (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                    LoadImageToPictureBox(ofd.FileName);
                }
            }
        }

        private bool ValidateInput()
        {
            _errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                _errorProvider.SetError(txtProductName, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            if (cboCategory.SelectedIndex < 0 || cboCategory.SelectedItem == null)
            {
                _errorProvider.SetError(cboCategory, "Vui lòng chọn loại sản phẩm!");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                _errorProvider.SetError(txtPrice, "Đơn giá phải là số hợp lệ và >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private string GenerateNewProductId()
        {
            int maxId = 0;
            foreach (var p in _productList)
            {
                if (p.ProductId != null && p.ProductId.StartsWith("SP") && int.TryParse(p.ProductId.Substring(2), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"SP{(maxId + 1):D3}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string newId = GenerateNewProductId();
            Product newProduct = new Product(
                newId,
                txtProductName.Text.Trim(),
                cboCategory.SelectedItem.ToString(),
                decimal.Parse(txtPrice.Text.Trim()),
                (int)numQuantity.Value,
                txtImagePath.Text.Trim()
            );

            _productList.Add(newProduct);
            _productBindingSource.MoveLast();

            MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is Product currentProduct)
            {
                if (!ValidateInput()) return;

                currentProduct.ProductName = txtProductName.Text.Trim();
                currentProduct.Category = cboCategory.SelectedItem.ToString();
                currentProduct.Price = decimal.Parse(txtPrice.Text.Trim());
                currentProduct.Quantity = (int)numQuantity.Value;
                currentProduct.ImagePath = txtImagePath.Text.Trim();

                _productBindingSource.ResetCurrentItem();
                UpdateStatusStrip();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is Product currentProduct)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm '{currentProduct.ProductName}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    _productBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _errorProvider.Clear();
            txtProductId.Text = GenerateNewProductId();
            txtProductName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            numQuantity.Value = 0;
            txtImagePath.Clear();
            picProductImage.Image = null;
            txtProductName.Focus();
        }

        private void UpdateStatusStrip()
        {
            int totalQuantity = _productList.Sum(p => p.Quantity);
            decimal totalValue = _productList.Sum(p => p.TotalValue);

            lblTotalProducts.Text = $"Tổng sản phẩm: {_productList.Count} (Tổng SL: {totalQuantity})";
            lblTotalValue.Text = $"Tổng giá trị kho: {totalValue:N0} VNĐ";
        }

        private void ExportCSV()
        {
            if (_productList.Count == 0)
            {
                MessageBox.Show("Kho hàng đang trống, không thể xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất báo cáo tổng hợp kho hàng";
                sfd.Filter = "CSV File (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.FileName = $"BaoCaoKho_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mã SP,Tên Sản Phẩm,Loại SP,Đơn Giá,Số Lượng,Đường Dẫn Ảnh");

                        foreach (var item in _productList)
                        {
                            string name = item.ProductName.Replace("\"", "\"\"");
                            sb.AppendLine($"\"{item.ProductId}\",\"{name}\",\"{item.Category}\",{item.Price},{item.Quantity},\"{item.ImagePath}\"");
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất báo cáo CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ImportCSV()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file CSV để đọc dữ liệu";
                ofd.Filter = "CSV File (*.csv)|*.csv|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                        if (lines.Length <= 1)
                        {
                            MessageBox.Show("File CSV không có dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        _productList.Clear();

                        for (int i = 1; i < lines.Length; i++)
                        {
                            string line = lines[i].Trim();
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            string[] parts = ParseCsvLine(line);
                            if (parts.Length >= 5)
                            {
                                string id = parts[0].Trim('"');
                                string name = parts[1].Trim('"');
                                string cat = parts[2].Trim('"');
                                decimal.TryParse(parts[3], out decimal price);
                                int.TryParse(parts[4], out int qty);
                                string imgPath = parts.Length >= 6 ? parts[5].Trim('"') : "";

                                _productList.Add(new Product(id, name, cat, price, qty, imgPath));
                            }
                        }

                        _productBindingSource.ResetBindings(false);
                        UpdateStatusStrip();
                        MessageBox.Show($"Nhập thành công {_productList.Count} sản phẩm từ file CSV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string[] ParseCsvLine(string line)
        {
            var parts = new System.Collections.Generic.List<string>();
            bool inQuotes = false;
            StringBuilder current = new StringBuilder();

            foreach (char c in line)
            {
                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    parts.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
            parts.Add(current.ToString());
            return parts.ToArray();
        }

        private void FrmInventoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }


    public class Product : INotifyPropertyChanged
    {
        private string _productId = string.Empty;
        private string _productName = string.Empty;
        private string _category = string.Empty;
        private decimal _price;
        private int _quantity;
        private string _imagePath = string.Empty;

        public string ProductId
        {
            get => _productId;
            set { _productId = value; OnPropertyChanged(nameof(ProductId)); }
        }

        public string ProductName
        {
            get => _productName;
            set { _productName = value; OnPropertyChanged(nameof(ProductName)); }
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

        public string ImagePath
        {
            get => _imagePath;
            set { _imagePath = value; OnPropertyChanged(nameof(ImagePath)); }
        }

        public decimal TotalValue => Price * Quantity;

        public Product() { }

        public Product(string id, string name, string category, decimal price, int quantity, string imagePath = "")
        {
            ProductId = id;
            ProductName = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            ImagePath = imagePath;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}