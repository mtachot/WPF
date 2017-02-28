using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.Classes.Commands
{
    public class RelayCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            if (MayExecute == null)
                return true;
            return MayExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            Action(parameter);
        }

        public void FireCanExecuteChanged()
        {
            EventHandler canExecuteChanged = CanExecuteChanged;
            if (canExecuteChanged != null)
                canExecuteChanged(this, new EventArgs());
        }

        public Action<object> Action { get; set; }
        public Predicate<object> MayExecute { get; set; }
        public string Label { get; set; }
        public string Image { get; set; }
    }
}
