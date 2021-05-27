using ASpecCore.Infrastructure;
using ASpecCore.Infrastructure.Commands;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ASpecCore.ViewModels.Base
{
    public abstract class ViewModel : INotifyPropertyChanged
    {

        public ViewModel()
        {
            AcceptCommand = new RelayCommand(OnAcceptCommandExecuted, CanAcceptCommandExecute);
            CancelCommand = new RelayCommand(OnCancelCommandExecuted, CanCancelCommandExecute);
        }

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

        #region Commands
        #region AcceptCommand
        public virtual ICommand AcceptCommand { get; protected set; }

        private void OnAcceptCommandExecuted(object p)
        {
            CloseCurrentWindow(p);
            MessageBox.Show("ok");
            DialogResult = true;
        }

        private bool CanAcceptCommandExecute(object p) => true;
        #endregion

        #region CancelCommand
        public virtual ICommand CancelCommand { get; protected set; }

        private void OnCancelCommandExecuted(object p)
        {
            CloseCurrentWindow(p);
            MessageBox.Show("cancel");
            DialogResult = false;
        }

        private bool CanCancelCommandExecute(object p) => true;
        #endregion

        private void CloseCurrentWindow(object parameter)
        {
            var win = parameter as Window;
            if (win == null)
            {
                win = Application.Current.Windows.Cast<Window>().FirstOrDefault(i => i.IsFocused);
            }
            if (win == null)
            {
                win = Application.Current.Windows.Cast<Window>().FirstOrDefault(i => i.IsActive);
            }
            win?.Close();
        } 
        #endregion

        public virtual string Title
        {
            get { return _Title; }
            set { Set(ref _Title, GeneralFunctionality.MakeDialogTitle(value)); }
        }

        public bool? DialogResult
        {
            get { return _DialogResult; }
            set { Set(ref _DialogResult, value); }
        }

        private string _Title;
        private bool? _DialogResult;

    }
}
