using System.Diagnostics;
using System.Text;

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
            var pwd = new Password
            {
                IncludeLowerCase = IncludeLowerCase.Checked,
                IncludeUpperCase = IncludeUpperCase.Checked,
                IncludeNumbers = IncludeNumbers.Checked,
                IncludeSymbols = IncludeSymbols.Checked,
                Length = int.Parse(PasswordLength.Text),
                NoDuplicateCharacters = NoDuplicateCharacters.Checked,
                NoSequentialCharacters = NoSequentialCharacters.Checked,
                NoSimilarCharacters = NoSimilarCharacters.Checked,
                BeginsWithLetter = BeginsWithLetter.Checked,
                Symbols = SymbolsToInclude.Text
            };

            var quantity = int.Parse(Quantity.Text);
            var sb = new StringBuilder();

            while (quantity > 0)
            {
                var password = pwd.Next();
                Debug.WriteLine(password);
                if (!string.IsNullOrWhiteSpace(password))
                {
                    sb.AppendLine(password);
                    quantity--;
                }
            }
            Result.Text = sb.ToString();
        }
    }
}
