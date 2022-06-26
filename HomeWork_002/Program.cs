int ThreeNumber();
{
   Console.WriteLine("введите число");

   int num = Convert.ToInt32(Console.ReadLine());

   if (num < 100)
   {
      Console.Write("Третьей цифры нет");
   }
   else
   {
   while (num >= 1000)
   {
      num = num / 10;
      return num;
   }

   if (num < 1000)
   { 

      int three = num % 100;
      int too = three % 10;
      Console.Write(too);
      return too;
   
   }  
}
}

int trenum = ThreeNumber();

Console.WriteLine(trenum);