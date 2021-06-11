using ASpecCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ASpecCore.Views.Messages
{
    internal static class Messages
    {
        public static void ErrorMessage(string MessageText, string Title)
        {
            MessageBox.Show(MessageText, Title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ErrorMessage(string MessageText)
        {
            ErrorMessage(MessageText, GeneralFunc.MakeDialogTitle("Ошибка"));
        }

        public static void InfoMessage(string MessageText, string Title)
        {
            MessageBox.Show(MessageText, Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void InfoMessage(string MessageText)
        {
            InfoMessage(MessageText, GeneralFunc.MakeDialogTitle("Внимание"));
        }

    }
}
