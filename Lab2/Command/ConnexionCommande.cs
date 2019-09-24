using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Lab2.ViewModel;

namespace Lab2.Command
{
    internal class ConnexionCommande : ICommand
    {
        private MenuViewModel _viewModel;
        private MainViewModel mainViewModel;

        public ConnexionCommande(MenuViewModel viewModel)
        { _viewModel = viewModel; }

        public ConnexionCommande(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        #region ICommand Members

        public event System.EventHandler CanExecuteChanged // peut etre ajouter partt dans notre code
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(Object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _viewModel.SaveChanges();
        }
        #endregion
    }
}
