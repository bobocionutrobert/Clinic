using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    class Patient : Person
    {

        private int patientid;
        private string username;
        private string password;

        public Patient(int patientid,string username,string password, int id,string type,string name,string email,string address) : base(id, "Patient", name, email, address)
        {
            this.patientid = patientid;
            this.username = username;
            this.password = password;
        }

        public Patient(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.patientid = Int32.Parse(prop[5]);
            this.username = prop[6];
            this.password = prop[7];
        }

        public int Patientid
        {
            get { return this.patientid; }
            set { this.patientid = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.password = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.patientid + "," + this.username + "," + this.password;
        }
    }
}
