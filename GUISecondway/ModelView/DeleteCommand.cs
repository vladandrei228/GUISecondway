using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GUISecondway.Model;
using GUISecondway.ModelView;

namespace GUISecondway.ViewModel
{
    public class DeleteCommand : ICommand
    {
        private ContactCatalog _catalog;
        private ContactViewModel _viewModel;

        /// <inheritdoc />
        public DeleteCommand(ContactCatalog catalog, ContactViewModel viewModel)
        {
            _catalog = catalog;
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.SelectedContact != null;
        }

        public void Execute(object parameter)
        {
           _catalog.Delete(_viewModel.SelectedContact.PhoneNumber);
           _viewModel.SelectedContact = null;
        }

        

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
