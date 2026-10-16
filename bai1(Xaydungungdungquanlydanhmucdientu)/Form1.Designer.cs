#nullable disable
namespace bai1_Xaydungungdungquanlydanhmucdientu_
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
            grpInput = new GroupBox();
            numQuantity = new NumericUpDown();
            cboCategory = new ComboBox();
            txtPrice = new TextBox();
            txtDeviceId = new TextBox();
            txtDeviceName = new TextBox();
            btnDelete = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblDeviceName = new Label();
            lblDeviceId = new Label();
            dgvDevices = new DataGridView();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(txtDeviceId);
            grpInput.Controls.Add(txtDeviceName);
            grpInput.Controls.Add(btnDelete);
            grpInput.Controls.Add(btnClear);
            grpInput.Controls.Add(btnUpdate);
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(lblDeviceName);
            grpInput.Controls.Add(lblDeviceId);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(776, 230);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin thiết bị";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(160, 178);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 27);
            numQuantity.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 140);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 28);
            cboCategory.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 102);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 27);
            txtPrice.TabIndex = 3;
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(160, 27);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.ReadOnly = true;
            txtDeviceId.Size = new Size(200, 27);
            txtDeviceId.TabIndex = 1;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(160, 64);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(200, 27);
            txtDeviceName.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(410, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 32);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(530, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 32);
            btnClear.TabIndex = 9;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(530, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 32);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(410, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(40, 180);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Số lượng tồn:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(40, 105);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 20);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Đơn giá:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(40, 143);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Loại thiết bị:";
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Location = new Point(40, 67);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(86, 20);
            lblDeviceName.TabIndex = 0;
            lblDeviceName.Text = "Tên thiết bị:";
            // 
            // lblDeviceId
            // 
            lblDeviceId.AutoSize = true;
            lblDeviceId.Location = new Point(40, 30);
            lblDeviceId.Name = "lblDeviceId";
            lblDeviceId.Size = new Size(84, 20);
            lblDeviceId.TabIndex = 0;
            lblDeviceId.Text = "Mã thiết bị:";
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Location = new Point(12, 250);
            dgvDevices.MultiSelect = false;
            dgvDevices.Name = "dgvDevices";
            dgvDevices.ReadOnly = true;
            dgvDevices.RowHeadersWidth = 51;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.Size = new Size(776, 188);
            dgvDevices.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDevices);
            Controls.Add(grpInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Danh Mục Thiết Bị Điện Tử";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblDeviceId;
        private TextBox txtDeviceId;
        private Label lblDeviceName;
        private TextBox txtDeviceName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvDevices;
    }
}