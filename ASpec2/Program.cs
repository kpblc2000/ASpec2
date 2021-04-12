using ASpecCore.Data;
using ASpecCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpec2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = TestData.Users;

            foreach (var item in userList)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName.Substring(0,1)}.{item.MiddleName.Substring(0,1)}.  => {item.Login}@{item.Domain} => {item.IsDeveloper}");
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }
    }
}
