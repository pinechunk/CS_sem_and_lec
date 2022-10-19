int A = 0;
int B = 0;
bool result = false;
//Получаем два числа от пользователя
void ReadData()
{
    string? inputA = Console.ReadLine();
    string? inputB = Console.ReadLine();

    A = int.Parse(inputA);
    B = int.Parse(inputB);
}
//Определяем кратноость
void ColculateData()
{
    result = (B % A == 0);
}
//Выводим данные
void PrintData()
{
    if (result)
    {
        Console.WriteLine($"Число {B} кратно числу {A}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления равен: {B % A}");
    }
}

ReadData();
ColculateData();
PrintData();





void FirstVar()
{
    Console.WriteLine("Method 1:");
    string? inputA = Console.ReadLine();
    string? inputB = Console.ReadLine();

    int A = int.Parse(inputA);
    int B = int.Parse(inputB);

    bool result = (B % A == 0);

    if (result)
    {
        Console.WriteLine($"Число {B} кратно числу {A}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления равен: {B % A}");
    }
}

