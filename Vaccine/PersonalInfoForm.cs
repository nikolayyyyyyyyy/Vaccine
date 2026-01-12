using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Vaccine
{
    public partial class PersonalInfoForm : Form
    {
        Vaccine vaccine;
        public PersonalInfoForm()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(first_name.Text, @"^[А-Я][а-я]") || !Regex.IsMatch(last_name.Text, @"^[А-Я][а-я]"))
            {
                MessageBox.Show("Имената трябва да започват с главна буква а останалите да са малки букви (на Кирилица!).",
                    "Грешка при валидиране.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(egn.Text, @"^\d{10}$"))
            {
                MessageBox.Show("ЕГН трябва да съдържа точно 10 цифри.",
                    "Грешка при валидиране.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(years.Text == "")
            {
                MessageBox.Show("Полето (години) трябва да е попълнено!","Грешка при валидиране.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PacientInfo pacientInfo = new PacientInfo(first_name.Text,
                last_name.Text,
                egn.Text,
                int.Parse(years.Text),
                dateTimePicker1.Text,
                male.Checked ? "Male" : "Female");

            vaccine = new Vaccine(this, pacientInfo);
            vaccine.Show();
        }

        private void egn_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(egn.Text, @"^\d{10}$"))
                return;

            try
            {
                int year = int.Parse(egn.Text.Substring(0, 2));
                int month = int.Parse(egn.Text.Substring(2, 2));
                int day = int.Parse(egn.Text.Substring(4, 2));

                if (month >= 1 && month <= 12)
                {
                    year += 1900;
                }
                else if (month >= 21 && month <= 32)
                {
                    month -= 20;
                    year += 1800;
                }
                else if (month >= 41 && month <= 52)
                {
                    month -= 40;
                    year += 2000;
                }
                else
                {
                    throw new Exception();
                }

                DateTime birthDate = new DateTime(year, month, day);
                dateTimePicker1.Value = birthDate;

                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;
                years.Text = age.ToString();

                int genderDigit = int.Parse(egn.Text[8].ToString());

                if (genderDigit % 2 == 0)
                {
                    male.Checked = true;
                }
                else
                {
                    female.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Невалидно ЕГН!", "Грешен формат на ЕГН.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
