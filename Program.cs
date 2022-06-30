/*int CutNumber()                          // Задача № 10
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int desjat = num / 10;
    int ed = desjat % 10;

    int result = ed;
    return result;
}


int number = CutNumber();
Console.WriteLine("Result number is " + number);*/

/*
void CutNumberVoid()                  // Задача №13
{
    Console.Write("Input a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num > 99)
    {
        Console.WriteLine((num / 100) % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
    
}

CutNumberVoid(); */


void DayNumVoid()                   // Задача №15
{
    Console.Write("Введите день недели (1 до 7): ");
    int day = Convert.ToInt32(Console.ReadLine());

    if(day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день : да");
    }
    else if(day > 7)
    {
        Console.WriteLine("Не является днем недели");
    }
    else
    {
         Console.WriteLine("Выходной день : нет");
    }
    
    
}

DayNumVoid();