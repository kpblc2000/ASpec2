using ASpecCore.Models;
using ASpecCore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASpec2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            // ToDo В основном коде проработать добавление пользователя, дополнение начального списка.
            // ToDo Проработать инициализацию - чтение и запись в файл

            #region Вывод польователей в консоль
            //List<User> userList = TestData.Users;

            //foreach (var item in userList)
            //{
            //    Console.WriteLine($"{item.LastName} {item.FirstName.Substring(0, 1)}.{item.MiddleName.Substring(0, 1)}.  => {item.Login}@{item.Domain} => {item.IsDeveloper}");
            //} 
            #endregion

            var albums = Enumerable.Range(1, 10)
                .Select(i => new Album
                {
                    Name = $"Album{i}"
                });

            using(NPConDataContext db = new NPConDataContext())
            {
                foreach (var item in albums)
                {
                    db.Albums.Add(item);
                }
                db.SaveChanges();
            }

            //UserTab win = new UserTab();
            //win.ShowDialog();

            //Console.WriteLine(typeof(Program).Assembly.GetName().Name);

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }
    }
}
