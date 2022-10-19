// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве

class BubbleSorting
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
        
        // Реализуем метод пузырьковой сортировки
        int[] BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }
            return array;
        }
        
        // Вывод отсортированного массива и кол-ва положительных чисел
        int HowMuchPositive(int[] array)
        {
            int count = 0;
            foreach (var number in array)
            {
                if (number % 2 == 0) count++;
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);
            return count;
        }

        int length = ReadData("Array length is");
        int bottomBorder = ReadData("Array bottom border is");
        int topBorder = ReadData("Array top border is");

        Console.WriteLine($"There are {HowMuchPositive(BubbleSort(CreateRandomArray(length, bottomBorder, topBorder)))} positive numbers");
    }
}