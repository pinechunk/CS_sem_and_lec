// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write($"{line}: ");
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Находим точку пересечения
double [] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double [] arr = new double [2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    arr[0] = x;
    arr[1] = y;
    return arr;
}

// Расстояние между точками
double RangeBetweenPoints(double [] arrFirst, double [] arrSecond)
{
    return Math.Sqrt((Math.Pow((arrSecond[0] - arrFirst[0]), 2) + Math.Pow((arrSecond[1] - arrFirst[1]), 2)));
}

// Формула Герона
double HeronFormula(double A, double B, double C)
{
    double p = (A + B + C) / 2;
    return Math.Pow((p * (p - A) * (p - B) * (p - C)), 0.5);
}

double b1 = ReadData("Enter number");
double k1 = ReadData("Enter number");
double b2 = ReadData("Enter number");
double k2 = ReadData("Enter number");
double b3 = ReadData("Enter number");
double k3 = ReadData("Enter number");

Console.WriteLine(IntersectionPoint(b1, k1, b2, k2)[0]);
Console.WriteLine(IntersectionPoint(b2, k2, b3, k3)[0]);
Console.WriteLine(IntersectionPoint(b3, k3, b1, k1)[0]);


double firstSide = RangeBetweenPoints(IntersectionPoint(b1, k1, b2, k2), IntersectionPoint(b2, k2, b3, k3));
Console.WriteLine($"First side is {firstSide}");
double secondSide = RangeBetweenPoints(IntersectionPoint(b2, k2, b3, k3), IntersectionPoint(b3, k3, b1, k1));
Console.WriteLine($"Second side is {secondSide}");
double thirdSide = RangeBetweenPoints(IntersectionPoint(b3, k3, b1, k1), IntersectionPoint(b1, k1, b2, k2));
Console.WriteLine($"Third side is {thirdSide}");

Console.WriteLine($"the area of the triangle is {HeronFormula(firstSide, secondSide, thirdSide)}");
