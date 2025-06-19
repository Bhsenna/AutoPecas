using System.ComponentModel;

namespace Salomao
{
    public partial class DecimalTextbox : TextBox
    {
        public DecimalTextbox()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (IsDecimal())
                base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)
                && ((Keys)e.KeyChar != Keys.Back)
                && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',' && Text.IndexOf(',') > 0)
                e.Handled = true;

            base.OnKeyPress(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            ResetValueOnFocus();
            base.OnGotFocus(e);
        }

        private void ResetValueOnFocus()
        {
            if (IsDecimal())
            {
                if (!IsDecimalZero())
                    return;
            }
            Text = "";
        }

        private bool IsDecimal()
        {
            decimal result;
            return decimal.TryParse(Text, out result);
        }

        private bool IsDecimalZero()
        {
            return (decimal.Parse(Text) == 0);
        }

        private void DecimalTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            decimal.TryParse(Text, out value);

            const string NUMBER_FORMAT_2_DIGITS = "N2";
            Text = value.ToString(NUMBER_FORMAT_2_DIGITS);
        }

        public decimal Value
        {
            get
            {
                return decimal.Parse(Text);
            }
        }

        public override string Text => base.Text.Replace(",", ".");
    }
}
