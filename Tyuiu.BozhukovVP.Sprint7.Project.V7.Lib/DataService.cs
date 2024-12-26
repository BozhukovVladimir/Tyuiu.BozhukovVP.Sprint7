namespace Tyuiu.BozhukovVP.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public string[,] GetBase(string path)
        { 
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }
            string file = File.ReadAllText(path);
            string[] lines = file.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            if (rows == 0)
            {
                throw new InvalidOperationException("Файл пуст.");
            }

            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');

                if (line_mas.Length != columns)
                {
                    throw new InvalidOperationException($"Строка {i + 1} имеет некорректное количество столбцов.");
                }

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }

            return array;
        }
    }
}
