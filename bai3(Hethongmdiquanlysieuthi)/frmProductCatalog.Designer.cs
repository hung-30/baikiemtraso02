#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    partial class frmProductCatalog
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
            grpInput = new GroupBox();
            numStockQuantity = new NumericUpDown();
            cboCategory = new ComboBox();
            txtUnitPrice = new TextBox();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblStockQuantity = new Label();
            lblUnitPrice = new Label();
            lblCategory = new Label();
            lblProductName = new Label();
            lblProductId = new Label();
            dgvProducts = new DataGridView();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(numStockQuantity);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(txtUnitPrice);
            grpInput.Controls.Add(txtProductId);
            grpInput.Controls.Add(txtProductName);
            grpInput.Controls.Add(btnDelete);
            grpInput.Controls.Add(btnClear);
            grpInput.Controls.Add(btnUpdate);
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(lblStockQuantity);
            grpInput.Controls.Add(lblUnitPrice);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(lblProductName);
            grpInput.Controls.Add(lblProductId);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(860, 230);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sản phẩm siêu thị";
            // 
            // numStockQuantity
            // 
            numStockQuantity.Location = new Point(160, 178);
            numStockQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStockQuantity.Name = "numStockQuantity";
            numStockQuantity.Size = new Size(220, 27);
            numStockQuantity.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 140);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(220, 28);
            cboCategory.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(160, 102);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(220, 27);
            txtUnitPrice.TabIndex = 3;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(160, 27);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(220, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(160, 64);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(220, 27);
            txtProductName.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(430, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa sản phẩm";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(560, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(560, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 35);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(430, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(30, 180);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(95, 20);
            lblStockQuantity.TabIndex = 0;
            lblStockQuantity.Text = "Số lượng tồn:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(30, 105);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(65, 20);
            lblUnitPrice.TabIndex = 0;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(30, 143);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Danh mục:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(30, 67);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(30, 30);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(101, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã sản phẩm:";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 250);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(860, 220);
            dgvProducts.TabIndex = 10;
            // 
            // frmProductCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 483);
            Controls.Add(dgvProducts);
            Controls.Add(grpInput);
            Name = "frmProductCatalog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Danh Mục Sản Phẩm Siêu Thị";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStockQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblStockQuantity;
        private NumericUpDown numStockQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
    }
}