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
            UserTab win = new UserTab();
            Application.ShowModalWindow(win);
        }
    }
}
