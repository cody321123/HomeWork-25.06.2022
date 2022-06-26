void DayWeek()
{
          Console.WriteLine("Введите число");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
          Console.Clear();
          Console.WriteLine(day + " -> Нет");
}
if (day == 2)
{
          Console.Clear();
          Console.WriteLine(day + " -> Нет");
}
if (day == 3)
{
          Console.Clear();
          Console.WriteLine(day + " -> Нет");
}
if (day == 4)
{
          Console.Clear();
          Console.WriteLine(day + " -> Нет");
}
if (day == 5)
{
          Console.Clear();
          Console.WriteLine(day + " -> Нет");
}
if (day == 6)
{
          Console.Clear();
          Console.WriteLine(day + " -> Да");
}
if (day == 7)
{
          Console.Clear();
          Console.WriteLine(day + " -> Да");
}

if (day >= 8)
{
          Console.Clear();
          Console.WriteLine("В недели 7 дней!!");
}

}
DayWeek();
