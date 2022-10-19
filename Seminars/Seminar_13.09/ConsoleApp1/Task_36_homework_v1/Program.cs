// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

class SelectionSort
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
        
        // Нахожу сумму элементов, стоящих на нечетных позициях
        int SumOfOddElements(int [] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 1 || i % 2 == 1)
                {
                    total += array[i];
                }
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);
            return total;
        }
        int length = ReadData("Array length is");
        int bottomBorder = ReadData("Array bottom border is");
        int topBorder = ReadData("Array top border is");

        Console.WriteLine($"The total sum of odd elements is {SumOfOddElements(SelectionSorting(CreateRandomArray(length, bottomBorder, topBorder)))} positive numbers");
    }  
}