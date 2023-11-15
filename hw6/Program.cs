// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountNumbersMoreThanZeroFromString(string input){
  int sum=0;
  string[] inputs = input.Split(' ');
  int[] num = inputs.Select(x => int.Parse(x.Trim())).ToArray(); 
  for (int i = 0; i < num.Length; i++)
  {
    if(num[i]>0){
      sum++;
    }
  }
  return sum;
}

Console.WriteLine("Enter numbers");
string input = Console.ReadLine();
if(input!=null){
Console.WriteLine("Numbers count more than zero = " + CountNumbersMoreThanZeroFromString(input));
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] IntersectionPointCoordinates(double k1, double b1, double k2, double b2){
  double[] coordinates = new double[2];
  double x = (b2-b1)/(k1-k2);
  double y = k1*x+b1;
  coordinates[0]=x;
  coordinates[1]=y;
  return coordinates;
}


Console.WriteLine("Enter b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double [] coordinates = IntersectionPointCoordinates(k1,b1,k2,b2);
Console.WriteLine("Coordinates of intersection: x=" + coordinates[0]+ ", y="+ coordinates[1]);