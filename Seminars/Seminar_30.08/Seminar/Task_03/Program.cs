string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    /*string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("Такого дня нет!");
    }
    else
    {
        
    }
    Console.WriteLine(dayOfWeek[inputDayOfWeek-1]);*/
    
    string outDayOfWeek = string.Empty;//""    
    
    /*switch (inputDayOfWeek)
    {
        case 1: outDayOfWeek = "понедельник"; break;
        case 2: outDayOfWeek = "вторник"; break;
        case 3: outDayOfWeek = "среда"; break;
        case 4: outDayOfWeek = "четверг"; break;
        case 5: outDayOfWeek = "пятница"; break;
        case 6: outDayOfWeek = "суббота"; break;
        case 7: outDayOfWeek = "воскресенье"; break;
        default: outDayOfWeek = "Такого дня нет"; break;
    }
    
    Console.WriteLine(outDayOfWeek);*/
    
    
    outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat
        .GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));

    Console.WriteLine(outDayOfWeek);
    
    
}



