using ASpecCore.Infrastructure.Enums;
using ASpecCore.Models;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels;
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

            //UserTab win = new UserTab();
            //win.ShowDialog();

            //AlbumView winAlb = new AlbumView();
            //winAlb.ShowDialog();

            #region Albums

            //SelectAlbumView winSelAlb = new SelectAlbumView();
            //winSelAlb.ShowDialog();

            //if (winSelAlb.DialogResult == true)
            //{
            //    AlbumViewModel vm = winSelAlb.DataContext as AlbumViewModel;
            //    album selAlbum = vm.SelectedAlbum;
            //    Console.WriteLine($"{selAlbum.name_alb}");
            //} 
            #endregion

            #region NormDocs
            //NormDocView winNormDoc = new NormDocView();
            //winNormDoc.ShowDialog();
            #endregion

            #region ZZTop
            //ZZTop winZZ = new ZZTop();
            //winZZ.ShowDialog();
            #endregion


            SqlUserRole role = SqlUserRole.Unknown;

            using (NPConDataModel db = new NPConDataModel())
            {
                if (db.Database.SqlQuery<int>("select dbo.isuserrw()").Single() == 1)
                {
                    role |= SqlUserRole.ReadWrite;
                }
                if (db.Database.SqlQuery<int>("select dbo.isUserROnly()").Single() == 1)
                {
                    role |= SqlUserRole.ReadOnly;
                }
                if (db.Database.SqlQuery<int>("select dbo.isUser_EndProdAdmin()").Single() == 1)
                {
                    role |= SqlUserRole.EndProdAdmin;
                }
                if (db.Database.SqlQuery<int>("select dbo.isUser_RoleEqual(@roleName)",
                    new System.Data.SqlClient.SqlParameter("@roleName", "NPCon_confirm_element")).Single() == 1)
                {
                    role |= SqlUserRole.ConfirmElements;
                }
                if (db.Database.SqlQuery<int>("select dbo.isUser_RoleEqual(@roleName)",
                    new System.Data.SqlClient.SqlParameter("@roleName", "NPCon_DesignTeam")).Single() == 1)
                {
                    role |= SqlUserRole.DesignTeam;
                }
                if (db.Database.SqlQuery<int>("select dbo.isUser_RoleEqual(@roleName)",
                    new System.Data.SqlClient.SqlParameter("@roleName", "NPCon_album_admin")).Single() == 1)
                {
                    role |= SqlUserRole.AlbumAdmin;
                }
#if DEBUG
                role |= SqlUserRole.NetDeveloper;
#endif
            }

            

            //Console.WriteLine(typeof(Program).Assembly.GetName().Name);

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }
    }
}
