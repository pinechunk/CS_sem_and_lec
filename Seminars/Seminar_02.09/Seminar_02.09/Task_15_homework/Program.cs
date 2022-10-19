//--------------------------------------------------------------------------
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
//--------------------------------------------------------------------------
// Вариант 1
void FirstVar()
{
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        int inputDayOfWeek = int.Parse(inputLine);
        if (1 <= inputDayOfWeek && inputDayOfWeek <= 7)
        {
            if (inputDayOfWeek == 6 || inputDayOfWeek == 7)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
        else
        {
            Console.WriteLine("некорректный день недели");
        }
    }
}
// Вариант "Со звёздочкой"
void SecondVar()
{
    IDictionary<int, string> numberDays = new Dictionary<int, string>();
    numberDays.Add(1, "Monday");  //Заполняю пары key-value
    numberDays.Add(2, "Tuesday");
    numberDays.Add(3, "Wednesday");
    numberDays.Add(4, "Thursday");
    numberDays.Add(5, "Friday");
    numberDays.Add(6, "Saturday");
    numberDays.Add(7, "Sunday");
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);
        {
            if (inputNumber >= 1 && inputNumber <= 7)               // Если введено число от 1 до 7
            {
                Console.WriteLine(numberDays[inputNumber]);         // Вывод дня недели по индексу
            }
            else
            {
                Console.WriteLine("Неверный день недели");  
            }
        } 
    }
}
SecondVar();