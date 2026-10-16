#nullable disable
namespace bai2_Phanmemquanlykhovaxuatbaocaotonghop_
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSaveReport = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuTools = new ToolStripMenuItem();
            mnuImportCsv = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnToolImport = new ToolStripButton();
            btnToolExport = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnToolExit = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblTotalProducts = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblRealTime = new ToolStripStatusLabel();
            grpInput = new GroupBox();
            btnSelectImage = new Button();
            picProductImage = new PictureBox();
            txtImagePath = new TextBox();
            lblImagePath = new Label();
            numQuantity = new NumericUpDown();
            cboCategory = new ComboBox();
            txtPrice = new TextBox();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblProductName = new Label();
            lblProductId = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            timerRealTime = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuTools });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 0;
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuOpen, mnuSaveReport, toolStripSeparator1, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(70, 24);
            mnuSystem.Text = "System";
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(173, 26);
            mnuOpen.Text = "Open File";
            // 
            // mnuSaveReport
            // 
            mnuSaveReport.Name = "mnuSaveReport";
            mnuSaveReport.Size = new Size(173, 26);
            mnuSaveReport.Text = "Save Report";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(173, 26);
            mnuExit.Text = "Exit";
            // 
            // mnuTools
            // 
            mnuTools.DropDownItems.AddRange(new ToolStripItem[] { mnuImportCsv, mnuExportCsv });
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new Size(58, 24);
            mnuTools.Text = "Tools";
            // 
            // mnuImportCsv
            // 
            mnuImportCsv.Name = "mnuImportCsv";
            mnuImportCsv.Size = new Size(166, 26);
            mnuImportCsv.Text = "Import CSV";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.Size = new Size(166, 26);
            mnuExportCsv.Text = "Export CSV";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolImport, btnToolExport, toolStripSeparator2, btnToolExit });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 27);
            toolStrip1.TabIndex = 1;
            // 
            // btnToolImport
            // 
            btnToolImport.ImageTransparentColor = Color.Magenta;
            btnToolImport.Name = "btnToolImport";
            btnToolImport.Size = new Size(87, 24);
            btnToolImport.Text = "Import CSV";
            // 
            // btnToolExport
            // 
            btnToolExport.ImageTransparentColor = Color.Magenta;
            btnToolExport.Name = "btnToolExport";
            btnToolExport.Size = new Size(85, 24);
            btnToolExport.Text = "Export CSV";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnToolExit
            // 
            btnToolExit.ImageTransparentColor = Color.Magenta;
            btnToolExit.Name = "btnToolExit";
            btnToolExit.Size = new Size(51, 24);
            btnToolExit.Text = "Thoát";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotalProducts, lblTotalValue, lblRealTime });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 2;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(130, 20);
            lblTotalProducts.Text = "Tổng sản phẩm: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(160, 20);
            lblTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";
            // 
            // lblRealTime
            // 
            lblRealTime.Name = "lblRealTime";
            lblRealTime.Size = new Size(677, 20);
            lblRealTime.Spring = true;
            lblRealTime.Text = "Thời gian: --/--/---- --:--:--";
            lblRealTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(btnSelectImage);
            grpInput.Controls.Add(picProductImage);
            grpInput.Controls.Add(txtImagePath);
            grpInput.Controls.Add(lblImagePath);
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(txtProductId);
            grpInput.Controls.Add(txtProductName);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(lblProductName);
            grpInput.Controls.Add(lblProductId);
            grpInput.Location = new Point(12, 60);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(958, 200);
            grpInput.TabIndex = 3;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sản phẩm trong kho";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(580, 112);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(85, 29);
            btnSelectImage.TabIndex = 6;
            btnSelectImage.Text = "Chọn ảnh";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // picProductImage
            // 
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(680, 25);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(260, 160);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 7;
            picProductImage.TabStop = false;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(450, 113);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(124, 27);
            txtImagePath.TabIndex = 5;
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(350, 116);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(76, 20);
            lblImagePath.TabIndex = 0;
            lblImagePath.Text = "Ảnh đ.diện:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(450, 70);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(215, 27);
            numQuantity.TabIndex = 4;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(110, 113);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(220, 28);
            cboCategory.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(450, 27);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(215, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(110, 27);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(220, 27);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(110, 70);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(220, 27);
            txtProductName.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(350, 73);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 20);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "Số lượng tồn:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(350, 30);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 20);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Đơn giá:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 116);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Loại SP:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(15, 73);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(55, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên SP:";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(15, 30);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 32);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 32);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(342, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 32);
            btnClear.TabIndex = 10;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 312);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(958, 205);
            dgvProducts.TabIndex = 11;
            // 
            // timerRealTime
            // 
            timerRealTime.Enabled = true;
            timerRealTime.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(850, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần Mềm Quản Lý Kho Và Xuất Báo Cáo Tổng Hợp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSaveReport;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuImportCsv;
        private ToolStripMenuItem mnuExportCsv;
        private ToolStrip toolStrip1;
        private ToolStripButton btnToolImport;
        private ToolStripButton btnToolExport;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnToolExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalProducts;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblRealTime;
        private GroupBox grpInput;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblImagePath;
        private TextBox txtImagePath;
        private Button btnSelectImage;
        private PictureBox picProductImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private System.Windows.Forms.Timer timerRealTime;
    }
}