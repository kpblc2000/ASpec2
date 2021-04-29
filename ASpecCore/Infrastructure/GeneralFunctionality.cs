namespace ASpecCore.Infrastructure
{
    public class GeneralFunctionality
    {
        /// <summary>
        /// Делегат для запроса имени блока
        /// </summary>
        /// <param name="Message">Выводимое приглашение</param>
        /// <returns>Имя блока или null, если был отказ</returns>
        public delegate string GetBlockNameHandler(string Message);

        private GetBlockNameHandler _GetBlockNameHandler;

        public void RegisterGetBlockNameHandler(GetBlockNameHandler Handler)
        {
            _GetBlockNameHandler += Handler;
        }

        public void UnregisterGetBlockNameHandler(GetBlockNameHandler Handler)
        {
            _GetBlockNameHandler -= Handler;
        }

        /// <summary>
        /// Получение имени блока
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        public string GetBlockName(string Message)
        {
            return _GetBlockNameHandler?.Invoke(Message);
        }

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
