//----------------------------------------------------------------
//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.
//----------------------------------------------------------------


// Вариант 1

// Конвертируем данные в формат int
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine());
    return number;
}                                 
// Вычисляем расстояние
double ColculateData(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double preResult = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2);
    double finalResult = Math.Sqrt(preResult);
    return Math.Round(finalResult, 2);
}

int x1 = ReadData("Input x1");
int y1 = ReadData("Input y1");
int z1 = ReadData("Input z1");
int x2 = ReadData("Input x2");
int y2 = ReadData("Input y2");
int z2 = ReadData("Input z2");
// Вывод результата
Console.WriteLine($"Ответ равен {ColculateData(x1, y1, z1, x2, y2, z2)}");



//=========================================================================
//=========================================================================

// Вариант 2
string inputLine = Console.ReadLine();
// В этом методе я удаляю лишние символы из строки
string RemoveChars(string inputLine)
{
    string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&",
        "*", "'", "\"", ";","_", "(", ")", ":", "|", "[", "]", "a", "b", " ", "-" };
    for (int i = 0; i < chars.Length; i++)
    {
        if (inputLine.ToLower().Contains(chars[i]))
        {
            inputLine = inputLine.Replace(chars[i], String.Empty);  // Замена старого символа на пустое
                                                                                    // значение     
        }
    }
    
    return inputLine;
}

// Конвертирую данные 
int x3 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[0]);
int y3 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[1]);
int z3 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[2]);
int x4 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[3]);
int y4 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[4]);
int z4 = Convert.ToInt32(RemoveChars(inputLine).ToLower()[5]);

double Colculate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double preResult = Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2);
    double finalResult = Math.Sqrt(preResult);
    return Math.Round(finalResult, 2);
}

Console.WriteLine($"Ответ равен {Colculate(x3, y3, z3, x4, y4, z4)}");