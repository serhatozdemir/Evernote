using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Evernote.ViewModel.Commands
{
    public class Edit : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public NotesVm ViewModel { get; set; }

        public Edit(NotesVm vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ViewModel.StartEditing();
        }
    }
}
