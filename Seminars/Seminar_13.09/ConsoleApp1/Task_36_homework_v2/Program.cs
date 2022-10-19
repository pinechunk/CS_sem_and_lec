class SecondVersion
{
        public static void Main()
    {
        // Считываем и преобразуем данные
        int ReadData(string line)
        {
            Console.Write($"{line}: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        
        // Задаем массив случайных значений
                                // длинна  // нижняя граница // верхняя граница
        int[] CreateRandomArray(int length, int bottomBorder, int topBorder)
        {
            var rand = new Random();
            var arr = new int[length];
            if (bottomBorder >= topBorder) return arr;
            for(int element = 0; element < arr.Length; element++)
            {
                arr[element] = rand.Next(bottomBorder, topBorder + 1);
            }

            return arr;
        }
        
        // Реализуем метод сортировки выбором
        int [] SelectionSorting(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minPosition = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPosition]) minPosition = j;
                }
                (array[i], array[minPosition]) = (array[minPosition], array[i]);
            }
            return array;
        }
        
        // Вывод элементов попарно
        void CouplesElements(int [] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);

            if (array.Length % 2 == 1)
            {
                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    {
                        Console.Write(array[i] + " ");
                        Console.Write(array[i+1]);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine(array[^1]);
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i += 2)
                {
                    {
                        Console.Write(array[i] + " ");
                        Console.Write(array[i+1]);
                        Console.WriteLine();
                    }
                }
            }
        }
        int length = ReadData("Array length is");
        int bottomBorder = ReadData("Array bottom border is");
        int topBorder = ReadData("Array top border is");
        
        CouplesElements(SelectionSorting(CreateRandomArray(length, bottomBorder, topBorder)));
    }
}