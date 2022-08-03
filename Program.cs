string num = Console.ReadLine();

// Задача 10
if (num.Length > 2)
{
    Console.WriteLine(num[1]);
}

    Console.WriteLine("");

// задача 13
if (num.Length > 2)
{
    Console.WriteLine(num[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

    Console.WriteLine("");

// Задача 15
int week;
Int32.TryParse(num, out week);
if (week == 6 || week == 7)
{
    Console.WriteLine("Да");
}
else if(week > 7)
{
    Console.WriteLine("Кажется неделя закончилась :)");
}
else
{
    Console.WriteLine("Нет");

}