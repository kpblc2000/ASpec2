using ASpecCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.Data
{
    public static class TestData
    {
        private static List<User> _Users;

        public static List<User> Users
        {
            get
            {
                if (_Users == null)
                {
                    _Users = new List<User>();
                    for (int i = 0; i < 20; i++)
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
                return _Users;
            }
            set { _Users = value; }
        }

    }
}
