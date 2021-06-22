using ASpecCore.Models.Data;
using ASpecCore.ViewModels;
using ASpecCore.Views;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.AcadCommands
{
    public class ASpecMainWindow
    {
        [CommandMethod("RunMain")]
        public static void AcadCommandASpecMainView()
        {
            ASpecMainView winASpec = new ASpecMainView();
            ASpecMainViewModel aspecVM = winASpec.DataContext as ASpecMainViewModel;
            aspecVM.EndProdVM.RegisterMatchToCurrentDwgHandler(MatchSelEndProdToCurrentDwg);
            winASpec.Show();
        }

        private static bool MatchSelEndProdToCurrentDwg(view_endproduct_cut SelectedEndProduct)
        {
            Application.ShowAlertDialog(SelectedEndProduct.id_endprod_ver.ToString());
            return true;
        }
    }
}
