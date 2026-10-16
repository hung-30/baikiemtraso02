#nullable disable
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    public partial class frmProductCatalog : Form
    {
        private BindingList<ProductModel> _productList;
        private BindingSource _productBindingSource;
        private ErrorProvider _errorProvider;

        public frmProductCatalog()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            _errorProvider = new ErrorProvider();
            _productList = new BindingList<ProductModel>();
            _productBindingSource = new BindingSource();

            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new string[] { "Thực Phẩm", "Đồ Gia Dụng", "Hóa Mỹ Phẩm", "Nước Giải Khát", "Đồ Điện Tử" });

            SetupDataGridView();
            LoadSampleData();

            _productBindingSource.DataSource = _productList;
            dgvProducts.DataSource = _productBindingSource;

            _productBindingSource.CurrentChanged += ProductBindingSource_CurrentChanged;

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            _productBindingSource.ResetBindings(false);
            if (_productList.Count > 0)
            {
                ProductBindingSource_CurrentChanged(null, null);
            }
            else
            {
                txtProductId.Text = GenerateNewProductId();
            }
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(ProductModel.ProductId), HeaderText = "Mã Sản Phẩm", Width = 110 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(ProductModel.ProductName), HeaderText = "Tên Sản Phẩm", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(ProductModel.Category), HeaderText = "Danh Mục", Width = 130 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(ProductModel.UnitPrice), HeaderText = "Đơn Giá (VNĐ)", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(ProductModel.StockQuantity), HeaderText = "Tồn Kho", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight } });
        }

        private void LoadSampleData()
        {
            _productList.Add(new ProductModel("SP001", "Gạo Tám Thái 5kg", "Thực Phẩm", 175000, 50));
            _productList.Add(new ProductModel("SP002", "Nước Tương Maggi 700ml", "Thực Phẩm", 28000, 120));
            _productList.Add(new ProductModel("SP003", "Nồi Cơm Điện Sunhouse", "Đồ Gia Dụng", 650000, 15));
            _productList.Add(new ProductModel("SP004", "Dầu Gội Head & Shoulders", "Hóa Mỹ Phẩm", 145000, 40));
        }

        private void ProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is ProductModel current)
            {
                txtProductId.Text = current.ProductId ?? string.Empty;
                txtProductName.Text = current.ProductName ?? string.Empty;
                cboCategory.SelectedItem = current.Category;
                txtUnitPrice.Text = current.UnitPrice.ToString("G0");
                numStockQuantity.Value = Math.Min(Math.Max(numStockQuantity.Minimum, current.StockQuantity), numStockQuantity.Maximum);
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
                _errorProvider.SetError(cboCategory, "Vui lòng chọn danh mục sản phẩm!");
                isValid = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out decimal price) || price < 0)
            {
                _errorProvider.SetError(txtUnitPrice, "Đơn giá phải là số hợp lệ và >= 0!");
                isValid = false;
            }

            return isValid;
        }

        private string GenerateNewProductId()
        {
            int maxId = 0;
            foreach (var item in _productList)
            {
                if (item.ProductId != null && item.ProductId.StartsWith("SP") && int.TryParse(item.ProductId.Substring(2), out int num))
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
            ProductModel newProduct = new ProductModel(
                newId,
                txtProductName.Text.Trim(),
                cboCategory.SelectedItem.ToString(),
                decimal.Parse(txtUnitPrice.Text.Trim()),
                (int)numStockQuantity.Value
            );

            _productList.Add(newProduct);
            _productBindingSource.MoveLast();
            MessageBox.Show("Thêm sản phẩm mới vào danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is ProductModel currentProduct)
            {
                if (!ValidateInput()) return;

                currentProduct.ProductName = txtProductName.Text.Trim();
                currentProduct.Category = cboCategory.SelectedItem.ToString();
                currentProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim());
                currentProduct.StockQuantity = (int)numStockQuantity.Value;

                _productBindingSource.ResetCurrentItem();
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_productBindingSource.Current is ProductModel currentProduct)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm '{currentProduct.ProductName}' (Mã: {currentProduct.ProductId}) không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
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
            txtUnitPrice.Clear();
            numStockQuantity.Value = 0;
            txtProductName.Focus();
        }
    }

    public class ProductModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; }

        public ProductModel() { }

        public ProductModel(string id, string name, string category, decimal unitPrice, int stockQuantity)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
            UnitPrice = unitPrice;
            StockQuantity = stockQuantity;
        }
    }
}