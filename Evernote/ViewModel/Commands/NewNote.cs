using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Evernote.Model;

namespace Evernote.ViewModel.Commands
{
    public class NewNote : ICommand
    {
        public NotesVm ViewModel { get; set; }

        public event EventHandler? CanExecuteChanged;
        

        public NewNote(NotesVm vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object? parameter)
        {
            Notebook selectedNotebook = parameter as Notebook;
            return selectedNotebook != null ? true : false;
        }

        public void Execute(object? parameter)
        {
            Notebook selectedNotebook = parameter as Notebook;
            ViewModel.CreateNote(selectedNotebook.Id);
            //TODO: functionality: Create New notebook
        }
    }
}
