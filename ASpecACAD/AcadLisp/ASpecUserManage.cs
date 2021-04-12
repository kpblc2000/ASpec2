using ASpecCore.Views;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.AcadLisp
{
   public class ASpecUserManage
    {
        [LispFunction("ASpecUserManage")]
        public static void AcadLispUserView(ResultBuffer args)
        {
            UserView win = new UserView();
            Application.ShowModalWindow(win);
        }
    }
}
