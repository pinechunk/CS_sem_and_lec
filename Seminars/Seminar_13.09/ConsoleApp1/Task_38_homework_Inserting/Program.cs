// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

class RealNumberArray
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
                                // длинна  // нижняя граница  // верхняя граница
        int[] CreateRandomArray(int length, int bottomBorder, int topBorder)
        {
            var rand = new Random();
            var arr = new int[length];
            if (bottomBorder >= topBorder) return arr;
            for (int element = 0; element < arr.Length; element++)
            {
                arr[element] = rand.Next(bottomBorder, topBorder + 1);
            }

            return arr;
        }

        // Реализуем метод сортировки выбором
        int[] InsertingSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int firstElement = array[i];
                int flag = 0;
                
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (firstElement < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = firstElement;
                    }
                    else flag = 1;
                }
            }
            return array;
        }
        
        // Находим разницу между максимальным и минимальным элементами
        void DifferenceBetweenElements(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[^1]);
            Console.Write($"The difference between {array.Max()} and {array.Min()} is {array.Max()-array.Min()}");
        }

        int length = ReadData("Array length is");
        int bottomBorder = ReadData("Array bottom border is");
        int topBorder = ReadData("Array top border is");

        DifferenceBetweenElements(InsertingSort(CreateRandomArray(length, bottomBorder, topBorder)));
    }
}