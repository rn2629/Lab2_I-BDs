    using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Model;

namespace Lab2.ViewModel
{
    class AnimalViewModel
    {

        object selectMenu;

        public AnimalViewModel()
        {
            SelectMenu = new MenuViewModel();
            Animals = new ObservableCollection<Animal>
            {
                new Chat("Tom", 79, "Gris"),
                new Poisson("Nemo", 16, "Rouge et noir", 10),
                new Oiseau("Zazou", 25, "Bleu et blanc", true)
            };
        }

        public object SelectMenu { get => selectMenu; set => selectMenu = value; }
        public ObservableCollection<Animal> Animals { get => animals; set => animals = value; }

        private ObservableCollection<Animal> animals;
    }
}
