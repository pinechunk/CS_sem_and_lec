// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write($"{line}: ");
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// Заполняю матрицу вещественными числами
void FillMatrix(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().NextDouble() * 100;
        }
    }
}
// Массив с цветами
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
    ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
    ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
    ConsoleColor.Yellow};
// Распечатываю матрицу
void PrintMatrix(double [,] matr)
{
    int count = 0; 
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.ForegroundColor = col[count];
            Console.Write("{0,6:F2}", matr[rows, columns]);
            Console.ResetColor();
            count ++;
            if (count >= 15) count = 0;  // Убрал ограничение на повтор цветов
        }
        Console.WriteLine();
        
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double [,] matrix = new double [row, column];
FillMatrix(matrix);
PrintMatrix(matrix);