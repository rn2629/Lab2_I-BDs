using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab2.Command;
using Lab2.Model;
using Lab2.View;

namespace Lab2.ViewModel
{
    internal class MenuViewModel
    {
        private Usager _Usager;
        private InfoSauvegardeViewModel childViewModel;
        private MenuViewModel checkMenuvm;

        public MenuViewModel()
        {
            _Usager = new Usager("Rodrigue");
            childViewModel = new InfoSauvegardeViewModel();
          
        }
        public bool CanUpdate
        {
            get
            {
                if (Usager == null)
                {
                    return false;
                }
                return !string.IsNullOrWhiteSpace(Usager.Name);
            }
        }
        public Usager Usager
        {
            get { return Usager; }
        }
        public ICommand ConnexionCommand
        {
            get;
            private set;
        }
        public void SaveChanges()
        {
            Sauvegarde view = new Sauvegarde();
            view.DataContext = childViewModel;
        }

    }
}
