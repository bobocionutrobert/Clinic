using Clinic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clinic.Controller
{
    public class ControllerMedicine
    {

        private List<Medicines> medicines;

        public ControllerMedicine()
        {
            medicines = new List<Medicines>();
            load();
        }

        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\medicine.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                this.medicines.Add(new Medicines(line));
            }

            read.Close();


        }
        public override string ToString()
        {
            string text = "";

            this.medicines.ForEach((medicine) =>
            {
                text += medicines.ToString() + "\n";

            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\medicine.txt");

            write.WriteLine(ToString());
            write.Close();

        }
    }
}
