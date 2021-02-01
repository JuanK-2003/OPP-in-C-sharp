using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Person
    {
        string name;
        string direction;
        DateTime dateNaci;

        public string Name { get => name; set => name = value; }
        public string Direction { get => direction; set => direction = value; }
        public DateTime DateNaci { get => dateNaci; set => dateNaci = value; }

        public int calcAge()
        {
            int age = DateTime.Today.AddTicks(-DateNaci.Ticks).Year - 1;
            return age;
        }
        public string normName()
        {
            System.Text.StringBuilder n = new System.Text.StringBuilder(Name);
            for (int i = 0; i < n.Length; i++)
            {
                if (System.Char.IsLower(n[i]) == true)
                {
                    n[j] = System.Char.ToUpper(n[j]);
                }
                else if (System.Char.IsUpper(n[j]) == true)
                {
                    n[j] = System.Char.ToLower(n[j]);
                }
            }

            String corrected = n.ToString();
            return corrected;
        }

    }
}
