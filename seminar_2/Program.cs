// See https://aka.ms/new-console-template for more information


int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num/10;
if (num1>= num2){
    Console.WriteLine(num1);
}
else Console.WriteLine(num2);

int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int last = n%10;
int first = n/100;
int res = first*10+last;
Console.WriteLine(res);
Console.WriteLine("Enter first number");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second  number");
int secondN = Convert.ToInt32(Console.ReadLine());
int ost = firstN%secondN;
if(ost==0){
    Console.WriteLine("кратно");
}
else {
    Console.WriteLine($"не кратно, остаток {ost}");
}
