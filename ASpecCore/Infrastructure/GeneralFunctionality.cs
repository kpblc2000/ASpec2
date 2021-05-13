using System;
using System.Data.SqlClient;

namespace ASpecCore.Infrastructure
{
    public class GeneralFunctionality
    {
        /// <summary>
        /// Создание стандартизированного заголовка окна
        /// </summary>
        /// <param name="Title">Исходная строка заголовка</param>
        /// <returns>Строка заголовка с указанием имени и текущий версии сборки</returns>
        public static string MakeDialogTitle(string Title)
        {
            Version temp = typeof(GeneralFunctionality).Assembly.GetName().Version;
            Title = Title.Trim();

            return $"ASpec {temp.Major}.{temp.Minor}.{temp.Build} : {Title}";
        }

        public static string GetNPConConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
#if DEBUG
            builder.DataSource = Environment.GetEnvironmentVariable("computername").ToString();
#else
            builder.DataSource = "sql03dsk2.picompany.ru.9492";
#endif
            builder.InitialCatalog = "NPCon";
            builder.IntegratedSecurity = true;
            builder.MultipleActiveResultSets = true;
            builder.ApplicationName = "EntityFramework";
            
            return builder.ToString();
        }
    }
}
