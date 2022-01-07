using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    public class Admin : Person
    {

        private int adminid;
        private string username;
        private string password;

        public Admin(int adminid, string username, string password, int id, string type, string name, string email, string address) : base(id, "Patient", name, email, address)
        {
            this.adminid = adminid;
            this.username = username;
            this.password = password;
        }

        public Admin(string props) : base(props)
        {
            string[] prop = props.Split(",");
            this.adminid = Int32.Parse(prop[5]);
            this.username = prop[6];
            this.password = prop[7];
        }

        public int Adminid
        {
            get { return this.adminid; }
            set { this.adminid = value; }
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
            return base.ToString() + "," + this.adminid + "," + this.username + "," + this.password;
        }


    }
}
