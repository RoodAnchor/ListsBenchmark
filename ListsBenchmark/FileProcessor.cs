namespace ListsBenchmark
{
    /// <summary>
    /// Класс предоставляющий доступ к методам обработки файлов
    /// </summary>
    internal class FileProcessor
    {
        /// <summary>
        /// Метод считывает содеержимоей текстового файла,
        /// разбивает на слова и возращает их в виде массива
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Массив слов</returns>
        internal static String[] GetWordsArr(String filePath)
        {
            if (String.IsNullOrEmpty(filePath)) return new String[] { };

            String content = File.ReadAllText(filePath);

            return content.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
