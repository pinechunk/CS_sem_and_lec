class Program
{
    // Объявляю глобальные переменные для цикла
    struct Direction
    {
        public int i;
        public int j;
    }
 
    static void Main(string[] args)
    {
        int ReadData(string line)
        {
            Console.Write(line);
            int number = int.Parse(Console.ReadLine() ?? "0");
            return number;
        }

        int rows = ReadData("Количество рядов: ");
        int columns = ReadData("Количество колонн: ");
 
        int[,] array = new int[rows, columns];
        Direction direct = new Direction() { i = 0, j = 1 };
        int count = 0;
 
        int i = 0, j = 0;
        while (count < rows * columns)
        {
            while ((i < rows) && (i >= 0) && (j < columns) && (j >=0))
            {
                if (array[i, j] == 0)
                {
                    count++;
                    array[i, j] = count;
                    i += direct.i;
                    j += direct.j;
                }
                else
                {
                    if (count == columns * rows) break;
                    i -= direct.i;
                    j -= direct.j;
                    ChangeDirection(ref direct);
                    i += direct.i;
                    j += direct.j;
                }
            }
 
            if (i < 0) i = 0;
            if (i >= rows) i = rows - 1;
            if (j < 0) j = 0;
            if (j >= columns) j = columns - 1;
            ChangeDirection(ref direct);
            i += direct.i;
            j += direct.j;
        }
 
        Console.WriteLine("Результат:");
        for (i = 0; i < rows; i++)
        {
            for (j = 0; j < columns; j++)
            {
                Console.Write("{0:00} ",array[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
 
    static void ChangeDirection(ref Direction direct)
    {
        switch (direct.i)
        {
            case -1:
                direct.i = 0;
                direct.j = 1;
                break;
            case 1:
                direct.i = 0;
                direct.j = -1;
                break;
            case 0:
                if (direct.j > 0)
                {
                    direct.i = 1;
                    direct.j = 0;
                }
                else
                {
                    direct.i = -1;
                    direct.j = 0;
                }
                break;
        }
    }
}