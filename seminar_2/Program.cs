// See https://aka.ms/new-console-template for more information


int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num/10;
if (num1>= num2){
    Console.WriteLine(num1);
}
else Console.WriteLine(num2);