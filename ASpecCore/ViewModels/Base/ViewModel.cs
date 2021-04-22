using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        protected virtual bool Set<T>(ref T Field, T value, string PropertyName)
        {
            if (Equals(Field, value)) return false;
            Field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
