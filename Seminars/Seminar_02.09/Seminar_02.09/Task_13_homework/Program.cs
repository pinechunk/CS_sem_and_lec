//--------------------------------------------------------
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//--------------------------------------------------------
void FirstVar()
{
    string? inputLine = Console.ReadLine();
    int count = 0;                           
    if (inputLine != null)
    {
        var inputNumbers = inputLine.ToCharArray();              // Сделал из строки массив
        var reverse = inputNumbers.Reverse();         // Развернул массив
        if (inputLine.Length <= 2)
        {
            Console.WriteLine("третьей цифры нет");
        }
        else
        {
            foreach (var i in reverse)                         // Прохожусь по каждому элементу массива
            {
                count++;
                if (count == 3)
                {
                    Console.WriteLine(i);

                    break;
                }
            }
        }
    }
}
FirstVar();

