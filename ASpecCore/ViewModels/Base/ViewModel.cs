using System.ComponentModel;

namespace ASpecCore.ViewModels.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public virtual bool Set<T>(ref T Field, T value, string PropertyName)
        {
            if (Equals(Field, value))
            {
                return false;
            }
            Field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }

    }
}
