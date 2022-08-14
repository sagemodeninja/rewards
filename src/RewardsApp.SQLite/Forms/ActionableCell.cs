using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace RewardsApp.SQLite.Forms
{
    public partial class ActionableCell : UserControl
    {
        private Keys _actionKey;
        private string _actionText;
        private EventHandler _actionInvoked;

        public ActionableCell() => InitializeComponent();

        [Category("Appearance"), Description("Desciption of action shown on the cell.")]
        public Keys ActionKey
        {
            get => _actionKey;
            set
            {
                _actionKey = value;
                actionKeyLbl.Text = value.ToString();
            }
        }

        [Category("Appearance"),
         Description("Desciption of action shown on the cell."),
         Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ActionText
        {
            get => _actionText;
            set
            {
                _actionText = value;
                actionTextLbl.Text = value;
            }
        }

        [Category("Action"), Description("Occures when control's action is invoked.")]
        public event EventHandler ActionInvoked
        {
            add => _actionInvoked += value;
            remove => _actionInvoked -= value;
        }

        /// <inheritdoc />
        protected override void OnForeColorChanged(EventArgs e)
        {
            actionKeyLbl.ForeColor = ForeColor;
            actionTextLbl.ForeColor = ForeColor;

            base.OnForeColorChanged(e);
        }

        private void ActionableCell_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = DarkenColor(BackColor, 0.9f);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                borderColor, 2, ButtonBorderStyle.Solid,
                borderColor, 2, ButtonBorderStyle.Solid,
                borderColor, 2, ButtonBorderStyle.Solid,
                borderColor, 2, ButtonBorderStyle.Solid);
        }

        private void ActionLbl_Click(object sender, EventArgs e)
            => InvokeAction();

        private void InvokeAction() => _actionInvoked?.Invoke(this, EventArgs.Empty);

        private static Color DarkenColor(Color color, float percent)
        {
            var r = (int)(color.R * percent);
            var g = (int)(color.G * percent);
            var b = (int)(color.B * percent);

            return Color.FromArgb(255, r, g, b);
        }
    }
}
