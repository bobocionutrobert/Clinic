using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    public class Nurse : Personnel
    {
        private int nurseid;
        private string username;
        private string password;

        public Nurse(int nurseid, string username, string password, int id, string type, string name, string email, int salary) : base(id, "Patient", name, email, salary)
        {
            this.nurseid = nurseid;
            this.username = username;
            this.password = password;
        }

        public Nurse(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.nurseid = Int32.Parse(prop[5]);
            this.username = prop[6];
            this.password = prop[7];
        }

        public int Nurseid
        {
            get { return this.nurseid; }
            set { this.nurseid = value; }
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
            return base.ToString() + "," + this.nurseid + "," + this.username + "," + this.password;
        }

    }
}
