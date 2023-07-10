using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Evernote.Model;

namespace Evernote.ViewModel.Commands
{
    public class EndEditing : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public NotesVm ViewModel{ get; set; }

        public EndEditing(NotesVm vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Notebook notebook = parameter as Notebook;
            if(notebook != null)
                ViewModel.StopEditing(notebook);
        }
    }
}
