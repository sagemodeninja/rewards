using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Interfaces;

namespace RewardsApp.SQLite.Forms
{
    public partial class TransactionForm : Form
    {
        private readonly int _customerId;
        private List<Transaction> _transactions;

        public TransactionForm(int customerId)
        {
            InitializeComponent();

            _customerId = customerId;
            _transactions = new List<Transaction>();
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
            => await RefreshList();

        private async void RefreshBtn_Click(object sender, EventArgs e)
            => await RefreshList();

        private async Task RefreshList()
        {
            _transactions = await Transaction.GetByCustomer(_customerId);

            transactionsDGV.Rows.Clear();
            _transactions.ForEach(AddRow);
        }

        private void AddRow(Transaction transaction)
        {
            var rowIndex = transactionsDGV.Rows.Add();
            var cells = transactionsDGV.Rows[rowIndex].Cells;

            PopulateCells(transaction, cells);
        }

        private static void PopulateCells(ITransaction transaction, DataGridViewCellCollection cells)
        {
            var singaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            var localTimestamp = TimeZoneInfo.ConvertTimeFromUtc(transaction.Timestamp, singaporeTimeZone);

            cells[0].Value = localTimestamp.ToString("MMM. dd, yyyy hh:mm:ss tt");
            cells[1].Value = transaction.TransactionType.ToString();
            cells[2].Value = transaction.Points.ToString("N");
            cells[3].Value = transaction.Balance.ToString("N");
        }
    }
}
