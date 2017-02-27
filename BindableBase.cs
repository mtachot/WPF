using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Classes
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public bool SetProperty<T>(T value, ref T storage, [CallerMemberName]string propName = null)
        {
            if (!Object.Equals(storage, value))
            {
                storage = value;
                OnPropertyChanged(propName);
                return true;
            }
            return false;
        }
    }
}
