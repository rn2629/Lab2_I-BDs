using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab2.Model;
using Lab2.ViewModel;

namespace Lab2.View
{
    /// <summary>
    /// Logique d'interaction pour AnimalView.xaml
    /// </summary>
    public partial class AnimalView : UserControl
    {
        public List<Animal> items;
        public AnimalView()
        {
            InitializeComponent();

            //items = new List<Animal>();

            //Animal animal1 = new Animal();
            //animal1.Nom = "Tom";
            //animal1.Age = 79;
            //animal1.Type = "Chat";

            //Animal animal2 = new Animal();
            //animal2.Nom = "Nemo";
            //animal2.Age = 16;
            //animal2.Type = "Poisson";

            //Animal animal3 = new Animal();
            //animal3.Nom = "Zazou";
            //animal3.Age = 79;
            //animal3.Type = "Oiseau";

            //items.Add(animal1);
            //items.Add(animal2);
            //items.Add(animal3);
            //Animals.ItemsSource = items;


            DataContext = new AnimalViewModel();
         
        }

     
    }
}
