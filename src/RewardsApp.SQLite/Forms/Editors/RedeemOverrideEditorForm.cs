using System.Windows.Forms;
using RewardsApp.SQLite.Utilities;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class RedeemOverrideEditorForm : Form
    {
        private PromptResult? _result;

        public RedeemOverrideEditorForm()
        {
            InitializeComponent();
        }

        public PromptResult ShowOverride()
        {
            ShowDialog();
            return _result ?? PromptResult.Failed;
        }

        private void OverridePasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            var plainPassword = overridePasswordTxt.Text;
            var challengeHash = Helper.HashPassword(plainPassword);

            var configuration = Configuration.Load();
            var overrideHash = configuration.OverridePassword;

            _result = challengeHash.Equals(overrideHash) ? PromptResult.Success : PromptResult.Failed;
            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
