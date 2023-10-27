// See https://aka.ms/new-console-template for more information



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int exp (int number, int exp){
    int res = 1;
    if(exp < 0){
       throw new ArithmeticException("Exp must be more or equal 0!");
    }
    else if (exp ==0 ){
        return 0;
    }
    else if(exp == 1){
        return number;
    }
    else {
    for (int i = 1; i <= exp; i++)
    {
        res *=number;
    }
    }
    return res;
}

try{
Console.WriteLine("5^0 = " + exp(5,0));
Console.WriteLine("5^1 = " + exp(5,1));
Console.WriteLine("5^5 = " + exp(5,5));
Console.WriteLine("5^(-1) = " + exp(5,-1));
}
catch(ArithmeticException e){
    Console.WriteLine(e.Message);
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumDigits (int n) {
    if(n<0){
        n = n*(-1);
    }
   int sum = 0;
   int d;
   while(n>0){
     d = n%10;
     n = n/10;
     sum+=d;
   }
   return sum;
}

Console.WriteLine(sumDigits(-09873));
Console.WriteLine(sumDigits(12353));
Console.WriteLine(sumDigits(0));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] createIntArrayOfEightLenght (){
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

void printArray(int [] array){
      for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int [] newArray = createIntArrayOfEightLenght();
printArray(newArray);
