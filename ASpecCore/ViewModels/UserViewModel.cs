using ASpecCore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private static ObservableCollection<User> _Users;
        static UserViewModel()
        {
            _Users = new ObservableCollection<User>();
            for (int i = 0; i < 5; i++)
            {
                _Users.Add(new User()
                {
                    FirstName = $"FirstName - {i}",
                    MiddleName = $"MidName{i}",
                    LastName = $"LastName{i}-{i}",
                    Login = $"Login-{i}",
                    Domain = $"server{i}.com",
                    IsDeveloper = i % 3 == 0
                });
            }
        }

        public ObservableCollection<User> Users
        {
            get
            { return _Users; }
            set
            {
                _Users = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
