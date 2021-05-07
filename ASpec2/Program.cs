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

            #region CodeFirst
            /*
            var albums = Enumerable.Range(1, 10)
                   .Select(i => new Album
                   {
                       Name = $"Album{i}",
                       Description = $"Descr {i}"
                   });
            var factories = Enumerable.Range(1, 5)
                .Select(i => new Factory
                {
                    Name = $"Factory{i}"
                }
                )
                .ToList();

            foreach (var item in albums)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in factories)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("*********************************");

            using (NPConDataContext db = new NPConDataContext())
            {
                for (int i = 0; i < factories.ToList().Count; i++)
                {
                    Factory item = factories[i];

                    item.Albums = new List<Album>();

                    for (int j = 0; j < db.Albums.Count(); j++)
                    {
                        if (j == 2 * i)
                        {
                            item.Albums.Add(db.Albums.ToList()[j]);
                        }
                    }

                    db.Factories.Add(item);
                }
                db.SaveChanges();
            }

            using (NPConDataContext db = new NPConDataContext())
            {
                foreach (var item in db.Albums)
                {
                    Console.WriteLine($"{item.Id} : {item.Name} {item.Description}");
                }
            }
            */
            #endregion

            //UserTab win = new UserTab();
            //win.ShowDialog();

            //Console.WriteLine(typeof(Program).Assembly.GetName().Name);

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }
    }
}
