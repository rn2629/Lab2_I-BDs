using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    class Oiseau : Animal
    {
        private string couleurOiseau;
        private bool valeurOiseau;
        public Oiseau(string _nomOiseau, int _tailleOiseau, string _couleurOiseau, bool _valeurOiseau):base("Zazou", 79)
        {
           _couleurOiseau = couleurOiseau;
            _valeurOiseau = valeurOiseau;
        }

     

        public string CouleurOiseau
        {
            get { return couleurOiseau; }
            set { value = couleurOiseau; }
        }

        public bool ValeurOiseau
        {
            get { return valeurOiseau; }
            set { value = true; }
        }
    }
}
