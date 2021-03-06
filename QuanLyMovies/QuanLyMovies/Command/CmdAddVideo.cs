using QuanLyMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyMovies.Command
{
    public class CmdAddVideo : ICommand
    {
        UtilViewModel vm;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }

        public CmdAddVideo(UtilViewModel vm)
        {
            this.vm = vm;
        }
    }
}
