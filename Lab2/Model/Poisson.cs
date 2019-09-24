using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    class Poisson:Animal

    {
        private string couleurPoisson;
        private int prixPoisson;
        public Poisson(string _nomPoisson, int _taillePoisson, string _couleurPoisson, int _prixPoisson):base("Nemo", 16)
        {
            _couleurPoisson = couleurPoisson;
            _prixPoisson = prixPoisson;
        }

        

        public string CouleurPoisson    
        {
            get { return couleurPoisson; }
            set { value = couleurPoisson; }
        }

        public int PrixPoisson
        {
            get { return prixPoisson; }
            set { value = prixPoisson; }
        }
    }
}
