//---------------------------------------------------------------------------
// Задача 10:Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//---------------------------------------------------------------------------


string? inputLine = Console.ReadLine();
bool flag = false;                                         
int inputNumber = 0;                              // Объявил глоб. переменные
if (inputLine != null && inputLine.Length == 3)   // Установил условие, исходя из задания
{
    flag = true;
    inputNumber = int.Parse(inputLine);
}
//Вариант 1
void FirstVar()
{
    if (flag)
    {
        Console.WriteLine((inputNumber / 10) % 10);
    }
}
//Вариант 2
void SecondVar()
{
    if (flag)
    {
        char[] cArr = inputLine.ToCharArray();   //Конвертировал строку в массив
        Console.WriteLine(cArr[1]);              //Сделал вывод 2ой цифры в массиве по индексу
    }
}
//Вариант 3
void ThirdVar()
{
    char[] cArr = inputLine.ToCharArray();     //Конвертировал строку в массив
    int count = 0;                             //Завёл счётчик
    while (true)                               //Цикл длится, пока не прерву
    {
        if (count == 1)                        //Пробегаемся по массиву, используя счётчик
        {                                      //для перехода между индексами
            Console.WriteLine(cArr[count]);    //Когда нужный индекс найдет, завершаем цикл
            break;
        }
        else
        {
            count++;
        }
    }
}
//Вариант 4 "Со звёздочкой"
void FourthVar()
{
    string? inputLine2 = Console.ReadLine();
    if (inputLine2 != null)
    {
        char[] inputArray = inputLine2.ToCharArray();
        Console.WriteLine(inputArray[2]);

    }
}