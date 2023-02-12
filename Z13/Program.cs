int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
{
int num3 = a%100;
int num33 = num3%10;
Console.WriteLine(num33);    
}

else
{
  Console.WriteLine("Третьей цифры нет"); 
}