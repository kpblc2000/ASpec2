using ASpecACAD.Models.DwgData;
using ASpecCore.Models.Data;
using ASpecCore.ViewModels;
using ASpecCore.Views;
using Autodesk.AutoCAD.Runtime;

namespace ASpecACAD.AcadCommands
{
    public class AcadMainView
    {
        [CommandMethod("RunMain")]
        public static void AcadMainView_RunMainCommand()
        {
            AcadMainViewCommand();
        }

        [CommandMethod("RunMo")]
        public static void AcadMainView_RunMainObjectCommand()
        {
            AcadMainViewCommand();
        }

        private static void AcadMainViewCommand()
        {
            ASpecMainView winASpecMain = new ASpecMainView();
            ASpecMainViewModel winVM = winASpecMain.DataContext as ASpecMainViewModel;
            winVM.EndProdVM.RegisterMatchToCurrentDwgHadler(MatchEndProdIdToDwg);
            winASpecMain.ShowDialog();
        }

        private static bool MatchEndProdIdToDwg(view_endproduct_cut CurrentEndProduct)
        {
            EndProduct temp = new EndProduct();
            return temp.Save(CurrentEndProduct.id_endprod_ver.ToString());
        }
    }
}
