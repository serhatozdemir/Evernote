using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Evernote.ViewModel.Commands
{
    public class NewNotebook : ICommand
    {
        public NotesVm VM { get; set; }

        public event EventHandler? CanExecuteChanged;

        public NewNotebook(NotesVm vm)
        {
            VM = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            VM.CreateNotebook();
            //TODO: functionality: Create New notebook
        }
    }

    
}
