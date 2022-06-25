int SecondNumber()
{
          Console.WriteLine("Введите трехзначное число");
          
          int number = Convert.ToInt32(Console.ReadLine());

          int dec = number / 10;

          int ed = dec % 10;

          return ed;
}

int secnumber = SecondNumber();

Console.WriteLine("Вторая цифра этого числа = " + secnumber);