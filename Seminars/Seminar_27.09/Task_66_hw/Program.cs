// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(int line)
{
    Console.WriteLine(line);
}
// Рекурсивный метод
int NumbRec(int begin, int end)
{
    if (end == begin-1) return 0;
    return end + NumbRec(begin, end-1);
}

int numberBegin = ReadData("Input number: ");
int numberEnd = ReadData("Input number: ");

int result = NumbRec(numberBegin, numberEnd);
PrintResult(result);