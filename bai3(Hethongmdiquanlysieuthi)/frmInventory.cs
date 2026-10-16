#nullable disable
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bai3_Hethongmdiquanlysieuthi_
{
    public partial class frmInventory : Form
    {
        private BindingList<InventoryTransaction> _transactionList;

        public frmInventory()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            _transactionList = new BindingList<InventoryTransaction>
            {
                new InventoryTransaction("PN001", "SP001", "Gạo Tám Thái 5kg", "Nhập kho", 100, DateTime.Now.AddDays(-2)),
                new InventoryTransaction("PX001", "SP002", "Nước Tương Maggi 700ml", "Xuất kho", 30, DateTime.Now.AddDays(-1)),
                new InventoryTransaction("PN002", "SP003", "Nồi Cơm Điện Sunhouse", "Nhập kho", 20, DateTime.Now)
            };

            dgvTransactions.DataSource = _transactionList;
        }
    }

    public class InventoryTransaction
    {
        public string TicketId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }

        public InventoryTransaction(string ticketId, string productId, string productName, string type, int quantity, DateTime date)
        {
            TicketId = ticketId;
            ProductId = productId;
            ProductName = productName;
            Type = type;
            Quantity = quantity;
            TransactionDate = date;
        }
    }
}