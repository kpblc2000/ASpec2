using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.Infrastrucure
{
    /// <summary>
    /// В этом классе - статические данные и методы
    /// </summary>
    public static class StaticData
    {
        public static string MakeDialogTitle(string Title)
        {
            return $"ASpec v.{typeof(StaticData).Assembly.GetName().Version}: {Title}";
        }
    }
}
