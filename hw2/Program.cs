// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1




Console.WriteLine("Enter three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number/10%10;
Console.WriteLine("Second digit is " + secondDigit);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int n2 = new Random().Next(1, 100000);
char [] mass = n2.ToString().ToCharArray();
Console.WriteLine(n2);
if(mass.Length<3){
    Console.WriteLine("Number "+ n2 +" doesn't have third digit");
}
else{
    Console.WriteLine("third digit is " + mass[2]);
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter day of week number");
int day = Convert.ToInt32(Console.ReadLine());
if(day==6||day==7){
    Console.WriteLine("Yes");
}
else if(day<=5&&day>0){
     Console.WriteLine("No");
}
else {
    Console.WriteLine("Wrong number");
}