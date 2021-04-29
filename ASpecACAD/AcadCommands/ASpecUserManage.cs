using ASpecACAD.Infrasructure;
using Autodesk.AutoCAD.Runtime;

namespace ASpecACAD.AcadCommands
{
    public class ASpecUserManage
    {
        [CommandMethod("ASpecUserManage")]
        public static void AcadCommandUserView()
        {
            UserManager.UserManagerCallWindow();
        }
    }
}
