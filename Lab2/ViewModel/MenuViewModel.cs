using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab2.Command;
using Lab2.Model;
using Lab2.View;

namespace Lab2.ViewModel
{
    internal class MenuViewModel
    {
        private InfoSauvegardeViewModel childViewModel;
       // private MenuViewModel checkMenuvm;
        public ICommand Save
        { get; set; }

        public ICommand Quit { get; set; }

        public MenuViewModel()
        {
            childViewModel = new InfoSauvegardeViewModel();
            Save = new SauvegarderCommande(this);
            Quit = new QuitterCommande(this);
          
        }
        public bool CanUpdate
        {
            get
            {
                return true;
            }
        }

        public ICommand ConnexionCommand
        {
            get;
            private set;
        }
        public void SaveChanges()
        {                
            MessageBox.Show("Vous avez bien Sauvegardé!");       
        }
        public void QuitChanges()
        {
            MessageBox.Show("Vous devez appuyez sur X en haut a droite pour quiter");
        }

    }
}
