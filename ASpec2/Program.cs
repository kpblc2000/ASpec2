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

            //AboutView winAbout = new AboutView();
            //winAbout.ShowDialog();

            //ArmatureView winArm = new ArmatureView();
            //winArm.ShowDialog();

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

            SelectAlbumView winSelAlb = new SelectAlbumView();
            winSelAlb.ShowDialog();

            //if (winSelAlb.DialogResult == true)
            //{
            //    AlbumViewModel vm = winSelAlb.DataContext as AlbumViewModel;
            //    album selAlbum = vm.SelectedAlbum;
            //    Console.WriteLine($"{selAlbum.name_alb}");
            //} 

            //AlbumView winAlb = new AlbumView();
            //winAlb.ShowDialog();
            #endregion

            #region NormDocs
            //NormDocView winNormDoc = new NormDocView();
            //winNormDoc.ShowDialog();
            #endregion

            #region EndProductView
            //EndProductView winEndProd = new EndProductView();
            //winEndProd.ShowDialog();
            #endregion

            #region Арматура
            //ArmatureView winArm = new ArmatureView();
            //winArm.ShowDialog();
            #endregion

            #region ZZTop
            //ZZTop winZZ = new ZZTop();
            //winZZ.ShowDialog();
            #endregion

            #region ASpecMainView
            ASpecMainView winASpecMain = new ASpecMainView();
            ASpecMainViewModel winVM = winASpecMain.DataContext as ASpecMainViewModel;
            winVM.EndProdVM.RegisterMatchToCurrentDwgHadler(ConsoleHandler);
            winASpecMain.ShowDialog();
            #endregion

            //Console.WriteLine(typeof(Program).Assembly.GetName().Name);

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        private static bool ConsoleHandler(view_endproduct_cut CurrentEndProduct)
        {
            Console.WriteLine(CurrentEndProduct.id_endprod_ver);
            return true;
        }
    }
}
