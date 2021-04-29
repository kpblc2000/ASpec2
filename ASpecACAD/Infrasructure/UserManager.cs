using ASpecCore.Views;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.Infrasructure
{
    internal static class UserManager
    {
        public static void UserManagerCallWindow()
        {
            UserTab win = new UserTab();
            Application.ShowModalWindow(win);
        }

    }
}
