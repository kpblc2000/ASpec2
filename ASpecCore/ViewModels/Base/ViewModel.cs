﻿using ASpecCore.Infrastructure;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        public virtual bool Set<T>(ref T Field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(Field, value))
            {
                return false;
            }
            Field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }

        public virtual string Title
        {
            get { return _Title; }
            set
            {
                Set(ref _Title, GeneralFunc.MakeDialogTitle(value));
            }
        }

        private string _Title;

    }
}
