using System;
using System.Reflection;

namespace ASpecCore.Infrastructure
{
    public class GeneralFunc
    {
        /// <summary>
        /// Создание стандартизированного заголовка окна
        /// </summary>
        /// <param name="Title">Исходная строка заголовка</param>
        /// <returns>Строка заголовка с указанием имени и текущий версии сборки</returns>
        public static string MakeDialogTitle(string Title)
        {
            Version temp = typeof(GeneralFunc).Assembly.GetName().Version;
            Title = Title.Trim();

            return $"ASpec {temp.Major}.{temp.Minor}.{temp.Build} : {Title}";
        }
    }
}
