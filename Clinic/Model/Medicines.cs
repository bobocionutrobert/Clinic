using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Model
{
    public class Medicines
    {

        private int id;
        private string name;
        private string type;
        private string description;
        private int cost;

        public Medicines(int id, string name,string type,string description, int cost)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
            this.cost = cost;
        }

        public Medicines(string props)
        {
            string[] prop = props.Split(",");
            this.id = Int32.Parse(prop[0]);
            this.name = prop[1];
            this.type = prop[2];
            this.description = prop[3];
            this.cost = Int32.Parse(prop[4]);
        }

        public Medicines()
        {

        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public override string ToString()
        {

            return this.id + "," + this.type + "," + this.name + "," + this.description + "," + this.cost;

        }


        public override bool Equals(object obj)
        {

            Medicines medicine = obj as Medicines;


            return this.id == medicine.id;
        }
    }
}
