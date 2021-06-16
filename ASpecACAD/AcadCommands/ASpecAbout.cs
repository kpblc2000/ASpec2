using ASpecCore.Views;
using Autodesk.AutoCAD.Runtime;

namespace ASpecACAD.AcadCommands
{
    public class ASpecAbout
    {
        [CommandMethod("ASpecAbout")]
        public static void AcadCommandAboutView()
        {
            AboutView winAbout = new AboutView();
            winAbout.ShowDialog();
        }
    }
}
