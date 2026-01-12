using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccine
{
    public class PacientInfo
    {
        private string firstName;
        private string lastName;
        private int age;
        private string egn;
        private string birthday;
        private string vaccine;
        private string gender;

        public PacientInfo(string firstName,string lastName,string egn,int age,string birthdate, string gender) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.egn = egn;
            this.birthday = birthdate;
            this.age = age;
            this.gender = gender;
        }
        public void setVaccine(string vaccine)
        {
            this.vaccine = vaccine;
        }

        public int getAge()
        {
            return age; 
        }

        public string printPacientInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First name: ");
            sb.Append(firstName);
            sb.Append(",Last name: ");
            sb.Append(lastName);
            sb.Append(",EGN: ");
            sb.Append(egn);
            sb.Append(",Age: ");
            sb.Append(age);
            sb.Append(",Birthday: ");
            sb.Append(birthday);
            sb.Append(",Gender: "); 
            sb.Append(gender);
            sb.Append(",Vaccine ");
            sb.Append(vaccine);
            sb.Append(" ; ");

            return sb.ToString();
        }
    }
}
