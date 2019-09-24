using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Animal
    {

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public string Nom
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Type
        {
            get { return this.GetType().Name; }
            
        }
        
    }
}  



