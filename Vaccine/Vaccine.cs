using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vaccine
{
    public partial class Vaccine : Form
    {
        PacientInfo pacient;
        Form prevForm;
        public Vaccine(Form form,PacientInfo pacientInfo)
        {
            InitializeComponent();
            pacient = pacientInfo;
            prevForm = form;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (hepatit.Checked == true)
            {
                pacient.setVaccine("Хепатит");
            }
            else if (bcj.Checked == true)
            {
                pacient.setVaccine("БЦЖ");
            }
            else if (tetafid.Checked == true)
            {
                pacient.setVaccine("ТетаФид");
            }

            using (StreamWriter writer = new StreamWriter("pacients.txt", true))
            {
                writer.Write(pacient.printPacientInfo());
            }

            foreach(Control c in prevForm.Controls)
            {
                if(c is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            this.Hide();
        }

        private void Vaccine_Load(object sender, EventArgs e)
        {
            if (pacient.getAge() >= 1 && pacient.getAge() <= 6)
            {
                hepatit.Checked = true;
                pacient.setVaccine("Хепатит");
            }
            else if (pacient.getAge() >= 7 && pacient.getAge() <= 12)
            {
                bcj.Checked = true;
                pacient.setVaccine("БЦЖ");
            }
            else if (pacient.getAge() >= 13 && pacient.getAge() <= 18)
            {
                tetafid.Checked = true;
                pacient.setVaccine("ТетаФид");
            }
        }
    }
}
