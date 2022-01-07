using Clinic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clinic.Controller
{
    public class ControllerPerson
    {
        private List<Person> persons;

        public ControllerPerson()
        {
            persons = new List<Person>();
            load();
        }

        public int positionById(int id)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public Person person(int id)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    return person;
                }
            }
            return null;
        }

        public bool addPerson(Person person)
        {
            int poz = positionById(person.Id);

            if (poz != -1)
            {
                return false;
            }
            else
            {
                persons.Add(person);
                return true;
            }
        }

        public bool deletePerson(int personid)
        {
            int poz = positionById(personid);

            if (poz == 1)
            {
                return false;
            }
            else
            {

                persons.RemoveAt(poz);
                return true;
            }
        }

        public void updateName(int id, string name)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    person.Name = name;
                }
            }
        }

        public void updateEmail(int id, string email)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    person.Email = email;
                }
            }
        }

        public void updateAddress(int id, string address)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    person.Address = address;
                }
            }
        }

        public void updatePatientUsername(int id, string username)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    Patient patient = person as Patient;
                    patient.Username = username;

                }
            }
        }

        public void updatePatientPassword(int id, string password)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    Patient patient = person as Patient;
                    patient.Password = password;

                }
            }
        }

        public void updateAdminUsername(int id, string username)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    Admin admin = person as Admin;
                    admin.Username = username;

                }
            }
        }

        public void updateAdminPassword(int id, string password)
        {
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    Admin admin = person as Admin;
                    admin.Password = password;

                }
            }
        }


        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\persons.txt");


            string line = "";


            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                if (prop[1].Equals("Patient"))
                {
                    this.persons.Add(new Patient(line));

                }
                else
                {
                    this.persons.Add(new Admin(line));
                }
            }
            read.Close();
        }

        public override string ToString()
        {
            string text = "";

            this.persons.ForEach((person) =>
            {

                text += person.ToString() + "\n";


            });

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\Asus\Desktop\FullStackC#\Mostenirea\Clinic\Clinic\Resources\persons.txt");
            write.WriteLine(ToString());
            write.Close();
        }
    }
}
