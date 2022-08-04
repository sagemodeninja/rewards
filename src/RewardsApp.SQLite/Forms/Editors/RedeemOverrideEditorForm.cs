using System.Windows.Forms;
using RewardsApp.SQLite.Utilities;
using RewardsApp.SQLite.Utilities.Enums;

namespace RewardsApp.SQLite.Forms.Editors
{
    public partial class RedeemOverrideEditorForm : Form
    {
        private RedeemOverrideResult _result;

        public RedeemOverrideEditorForm()
        {
            InitializeComponent();
        }

        public RedeemOverrideResult ShowOverride()
        {
            this.ShowDialog();
            return _result;
        }

        private void OverridePasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
                return;

            var plainPassword = overridePasswordTxt.Text;
            var challengeHash = Helper.HashPassword(plainPassword);

            var configuration = Configuration.Load();
            var overrideHash = configuration.OverridePassword;

            _result = challengeHash.Equals(overrideHash) ? RedeemOverrideResult.Success : RedeemOverrideResult.Failed;
            this.Close();
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
    }
}
