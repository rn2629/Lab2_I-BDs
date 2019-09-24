using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab2.Command;
using Lab2.Model;
using Lab2.View;

namespace Lab2.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Usager usager;
        object selectControl;
        object selectMenu;

        public ICommand commandeAnimal { get; set; }

        public MainViewModel()
        {
            Usager = new Usager("");
            commandeAnimal = new BaseCommand(LoadAnimal, obj => true);
            selectControl = this;
            selectMenu = new Menu();
            UpdateCommand = new ConnexionCommande(this);
        }
        public void LoadAnimal(object parameter)
        {
            if(CanUpdate)
                SelectControl = new AnimalViewModel();
        }
      
         public ICommand UpdateCommand
        {
            get;
            private set;
        }   

        public bool CanUpdate
        {
            get
            {
                if (Usager == null)
                {
                    return false;
                }
                return Usager.Name == "Rodrigue";
            }
        }

        public void LoadMenu(object parameter)
        {
            SelectControl = new Menu();
        }

        
        public void LoadControl(object paramater)
        {
            SelectControl = new UsagerView();
        }

        public object SelectControl
        {
            get => selectControl;
            set { selectControl = value; OnPropertyChanged("SelectControl"); }
        }

        public object SelectMenu
        {
            get => selectMenu;
            set { SelectControl = value; OnPropertyChanged("SelectMenu"); }
        }

        public Usager Usager { get => usager; set => usager = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    
}
}
