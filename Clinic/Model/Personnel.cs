using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    public class Personnel
    {
        private int id;
        private string type;
        private string name;
        private string mobile;
        private int salary;

        public Personnel(int id, string type,string name,string mobile,int salary)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.mobile = mobile;
            this.salary = salary;
        }

        public Personnel(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.type = prop[1];
            this.name = prop[2];
            this.mobile = prop[3];
            this.salary = Int32.Parse(prop[4]);
        }

        public Personnel()
        {

        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public override string ToString()
        {

            return this.id + "," + this.type + "," + this.name + "," + this.mobile + "," + this.salary;

        }


        public override bool Equals(object obj)
        {

            Personnel personnel = obj as Personnel;


            return this.id == personnel.id;
        }
    }
}
