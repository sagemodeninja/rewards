using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Entities;
using System;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class CardEditorForm : Form
    {
        private bool _isEdit;

        private readonly Card _card;

        public Action<Card> CardAddedAction { get; private set; }

        public Action<Card> CardEditedAction { get; private set; }

        public CardEditorForm()
        {
            InitializeComponent();
            _isEdit = false;
        }

        public CardEditorForm(Card card)
            : this()
        {
            _isEdit = true;
            _card = card;
            this.Text = "Edit Number";
            cardNumberTxt.Text = card.Number;
            keyboardShortcutsLbl.Text = "Press Enter to edit or Esc to cancel.";
        }

        private async void CardNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            var cardNumber = cardNumberTxt.Text;
            try
            {

                if(!_isEdit)
                {
                    var card = new Card(cardNumber);
                    await card.Create();

                    cardNumberTxt.Clear();
                    CardAddedAction.Invoke(card);
                }
                else
                {
                    _card.Number = cardNumber;
                    await _card.Update();
                    CardEditedAction.Invoke(_card);
                    this.Close();
                }
            }
            catch (DbUpdateException ex)
            {
                var innerEx = (SqliteException)ex.InnerException;

                if (innerEx.SqliteErrorCode == 19)
                    MessageBox.Show($"Card #{cardNumber} already exists!");
                else
                    MessageBox.Show(innerEx.Message);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void OnCardAdded(Action<Card> action)
        {
            CardAddedAction = action;
        }

        public void OnCardEdited(Action<Card> action)
        {
            CardEditedAction = action;
        }
    }
}
