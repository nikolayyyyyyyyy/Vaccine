using System.Text.RegularExpressions;

namespace Vaccine
{
    public partial class Login : Form
    {
        private PersonalInfoForm personalInfoForm;
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(username.Text, @"^[A-Z][A-Z1-5]{4,9}$"))
            {
                MessageBox.Show("Първият символ на USERNAME трябва да е буква (A–Z), дължина 5–10 само главни латински букви.",
                    "Грешка при валидация.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(password.Text, @"^.{5,8}$"))
            {
                MessageBox.Show("Паролата трябва да е между 5 и 8 символа.", "Грешка при валидация.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Regex.IsMatch(username.Text, @"^[A-Z][A-Z1-5]{4,9}$") && Regex.IsMatch(password.Text, @"^.{5,8}$"))
            {
                DialogResult result = MessageBox.Show("Успешно влизане.", "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    personalInfoForm = new PersonalInfoForm();
                    personalInfoForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
