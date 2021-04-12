using ASpecCore.Views;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.AcadCommands
{
    public class ASpecUserManage
    {
        [CommandMethod("ASpecUserManage")]
        public static void AcadCommandUserView()
        {
            UserView win = new UserView();
            Application.ShowModalWindow(win);
        }
    }
}
