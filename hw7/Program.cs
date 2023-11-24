// See https://aka.ms/new-console-template for more information


// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void printNumbers(int N){
    if(N>=1) {
    Console.Write(N);
    if(N>1){
     Console.Write(", "); 
    }
    N--;
    printNumbers(N);
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sumNumbers (int M, int N){
    if (M < N) {
        return M + sumNumbers((M+1), N);
    }
    else {
     return N; 
   } 
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int akkerman(int m, int n){
      if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return akkerman(m - 1, 1);
    else
      return akkerman(m - 1, akkerman(m, n - 1));
}

Console.WriteLine("First task");

int N;
Console.WriteLine("Enter N (N>1)");
N = Convert.ToInt32(Console.ReadLine());
if(N>1){
printNumbers(N);
Console.WriteLine();
}
else Console.WriteLine("N should be more than 1!");

Console.WriteLine("Second task");
int M;
Console.WriteLine("Enter M (M>0)");
M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N (N>0 and N>M)");
N = Convert.ToInt32(Console.ReadLine());
if(N>0 && N>M){
Console.WriteLine(sumNumbers(M, N));
}
else Console.WriteLine("Input error!");

Console.WriteLine("Third task");
Console.WriteLine("Enter M (M>0)");
M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N (N>0)");
N = Convert.ToInt32(Console.ReadLine());
if(N>0 && M>0){
Console.WriteLine(akkerman(M,N));
}
else Console.WriteLine("Input error!");