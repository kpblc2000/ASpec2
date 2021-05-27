using ASpecCore.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ASpecCore.Infrastructure.Commands
{
    class CloseWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var win = parameter as Window;
            if (win == null)
            {
                win = Application.Current.Windows.Cast<Window>().FirstOrDefault(i => i.IsFocused);
            }
            if (win == null)
            {
                win = Application.Current.Windows.Cast<Window>().FirstOrDefault(i => i.IsActive);
            }
            win?.Close();
        }
    }
}
