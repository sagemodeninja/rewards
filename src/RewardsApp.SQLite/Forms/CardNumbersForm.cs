using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Forms.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class CardNumbersForm : Form
    {
        public List<Card> Cards { get; private set; }

        public CardNumbersForm()
        {
            InitializeComponent();
            Cards = new List<Card>();
        }

        private void AddNumberBtn_Click(object sender, EventArgs e)
        {
            var editor = new CardEditorForm();
            editor.OnCardAdded(card =>
            {
                Cards.Add(card);
                AddRow(card);
            });
            editor.ShowDialog();
        }

        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            Cards = await Card.GetAll();

            cardsDGV.Rows.Clear();
            Cards.ForEach(AddRow);
        }

        private void AddRow(Card card)
        {
            var customer = card.Customer;
            var isTaken = customer is null ? "No" : "Yes";
            var owner = customer is null ? "None" : $"{customer.LastName}, {customer.FirstName}";

            cardsDGV.Rows.Add(card.Id, card.Number, isTaken, owner);
        }

        private void RowContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var row = cardsDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int)cells[0].Value;
            var card = Cards.FirstOrDefault(c => c.Id == id);

            var isTaken = card.Customer is not null;
            editMenuItem.Enabled = !isTaken;
            deleteMenuItem.Enabled = !isTaken;
        }

        private async void RowContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var menuItem = e.ClickedItem;
            var row = cardsDGV.SelectedRows[0];
            var cells = row.Cells;
            var id = (int)cells[0].Value;
            var card = Cards.FirstOrDefault(c => c.Id == id);

            if(menuItem == editMenuItem)
            {
                var editor = new CardEditorForm(card);
                editor.OnCardEdited(c => cells[1].Value = c.Number);
                editor.ShowDialog();
            }
            else if(menuItem == deleteMenuItem)
            {
                var response = MessageBox.Show($"You are about to delete #{card.Number}!\nContinue?", "Confirm", MessageBoxButtons.YesNo);

                if(response == DialogResult.Yes)
                {
                    await card.Delete();
                    Cards.Remove(card);
                    cardsDGV.Rows.Remove(row);
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                AddNumberBtn_Click(null, null);
                return true;
            }

            if (keyData == (Keys.Control | Keys.R))
            {
                RefreshBtn_Click(null, null);
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
