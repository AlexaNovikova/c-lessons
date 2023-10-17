// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number");
int q = Convert.ToInt32(Console.ReadLine());
int result = num * num;
if (q == result)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
