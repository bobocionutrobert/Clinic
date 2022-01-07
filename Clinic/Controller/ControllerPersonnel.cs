using Clinic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clinic.Controller
{
    public class ControllerPersonnel
    {
        private List<Personnel> personnels;

        public ControllerPersonnel()
        {
            personnels = new List<Personnel>();

            load();
        }

        public int positionById(int id)
        {
            for (int i = 0; i < personnels.Count; i++)
            {
                if (personnels[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Personnel personnel(int id)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    return personnel;
                }
            }
            return null;
        }

        public bool addPersonnel(Personnel personnel)
        {
            int poz = positionById(personnel.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                personnels.Add(personnel);
                return true;
            }
        }

        public bool deletePerson(int personnelid)
        {
            int poz = positionById(personnelid);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                personnels.RemoveAt(poz);
                return true;
            }
        }

        public void updateName(int id, string name)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    personnel.Name = name;
                }
            }
        }

        public void updateMobile(int id, string mobile)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    personnel.Mobile = mobile;
                }
            }
        }

        public void updateSalary(int id, int salary)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    personnel.Salary = salary;
                }
            }
        }

        public void updateNurseUsername(int id, string username)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    Nurse nurse = personnel as Nurse;
                    nurse.Username = username;
                }
            }
        }

        public void updateNursePassword(int id, string password)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    Nurse nurse = personnel as Nurse;
                    nurse.Password = password;
                }
            }
        }
        public void updateDoctorUsername(int id, string username)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    Doctor doctor = personnel as Doctor;
                    doctor.Username = username;
                }
            }
        }
        public void updateDoctorPassword(int id, string password)
        {
            foreach (Personnel personnel in personnels)
            {
                if (personnel.Id == id)
                {
                    Doctor doctor = personnel as Doctor;
                    doctor.Password = password;
                }
            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\personnel.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Doctor"))
                {
                    this.personnels.Add(new Doctor(line));

                }
                else
                {
                    this.personnels.Add(new Nurse(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.personnels.ForEach((personnel) =>
            {

                text += personnel.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\personnel.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
