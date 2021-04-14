using ASpecCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {

        private List<User> _Users;

        public List<User> Users
        {
            get
            { return _Users; }
            set
            {
                _Users = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        public void Update()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Users)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
