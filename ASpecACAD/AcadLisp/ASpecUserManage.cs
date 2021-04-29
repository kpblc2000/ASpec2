using ASpecACAD.Infrasructure;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

namespace ASpecACAD.AcadLisp
{
    public class ASpecUserManage
    {
        [LispFunction("ASpecUserManage")]
        public static void AcadLispUserView(ResultBuffer args)
        {
            UserManager.UserManagerCallWindow();
        }
    }
}
