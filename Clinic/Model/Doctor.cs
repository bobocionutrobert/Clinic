using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    public class Doctor : Personnel
    {

        private int doctorid;
        private string username;
        private string password;

        public Doctor(int doctorid, string username, string password, int id, string type, string name, string email, int salary) : base(id, "Patient", name, email, salary)
        {
            this.doctorid = doctorid;
            this.username = username;
            this.password = password;
        }

        public Doctor(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.doctorid = Int32.Parse(prop[5]);
            this.username = prop[6];
            this.password = prop[7];
        }

        public int Doctorid
        {
            get { return this.doctorid; }
            set { this.doctorid = value; }
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
            return base.ToString() + "," + this.doctorid + "," + this.username + "," + this.password;
        }
    }
}
