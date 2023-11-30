using System.Diagnostics;
using System.Text;
using PasswordGenerator;

namespace RandomPasswordGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var settings = new PasswordSettings(IncludeLowerCase.Checked, IncludeUpperCase.Checked, IncludeNumbers.Checked, IncludeSymbols.Checked,
                int.Parse(PasswordLength.Text), 5, false);

            //settings.CharacterSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            if (IncludeSymbols.Checked)
            {
                settings.AddSpecial(SymbolsToInclude.Text);
            }

            var available = settings.CharacterSet;

            var pwd = new Password(settings);
            var quantity = int.Parse(Quantity.Text);
            var sb = new StringBuilder();

            while (quantity > 0)
            {
                var password = pwd.Next();
                Debug.WriteLine(password);
                if (password != null && password != "Try again")
                {
                    sb.AppendLine(password);
                    quantity--;
                }
            }
            Result.Text = sb.ToString();
        }
    }
}
