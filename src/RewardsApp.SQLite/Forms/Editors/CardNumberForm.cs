using RewardsApp.SQLite.Entities;
using RewardsApp.SQLite.Utilities.Enums;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class CardNumberForm : Form
    {
        private PromptResult? _result;

        public CardNumberForm() => InitializeComponent();

        public Card SelectedCard { get; private set; }

        public PromptResult ShowOverride()
        {
            ShowDialog();
            return _result ?? PromptResult.Failed;
        }

        private async void CardNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;

            var cardNumber = cardNumberTxt.Text;
            var card = await Card.GetByNumber(cardNumber);

            if (card is null)
            {
                // ReSharper disable once LocalizableElement
                MessageBox.Show("Card not registered!");
                return;
            }

            SelectedCard = card;

            _result = PromptResult.Success;
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys != Keys.None || keyData != Keys.Escape) 
                return base.ProcessDialogKey(keyData);

            _result = PromptResult.Failed;
            Close();

            return true;
        }
    }
}
