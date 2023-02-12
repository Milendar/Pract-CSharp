int b = Convert.ToInt32(Console.ReadLine());
char[] arr = b.ToString().ToCharArray();
Console.WriteLine(arr);
int num1 = 0;
for(int i = 0; i < arr.Length; i++)
{
    num1 += Convert.ToInt32(arr[i]-'0');
    Console.WriteLine(arr[i]);
}
Console.WriteLine(num1);