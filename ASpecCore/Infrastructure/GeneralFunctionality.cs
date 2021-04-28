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
            var temp = typeof(GeneralFunctionality).Assembly.GetName();

            return $"ASpec {temp.Version} : {Title}";
        }
    }
}
