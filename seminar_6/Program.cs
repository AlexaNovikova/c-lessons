// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 string NumbersRec(int a, int b){
    if(a<b){
        return a+ " " + (a+1)+ " "+ NumbersRec(a+2, b);
    }
    else return "";
 }

 int PowerRecMath(int a, int n){
    if(n==0){
        return 1;
    }
    else if(n%2==0) return PowerRecMath(a*a, n/2);
    else return a*PowerRecMath(a, n-1);
 }

void FindWords(string alphabet, char[] word, int lenght = 0){
    if(lenght == word.Length){
        Console.WriteLine(new String (word));
        return;
    }

        for (int i = 0; i < alphabet.Length; i++)
        {
            word[lenght] = alphabet[i];
            FindWords(alphabet, word, lenght+1);
        }
    
}
// Console.WriteLine(NumbersRec(1,10));
// Console.WriteLine(PowerRecMath(2, 8));
// Console.WriteLine(PowerRecMath(3, 9));
// FindWords("аисв", new char[5]);

// string s = "C:/Users/AlexNovikova/Desktop/SibGuti";
//  DirectoryInfo directoryInfo = new DirectoryInfo(s);
//  Console.WriteLine(directoryInfo.CreationTime);
//  DirectoryInfo [] fi = directoryInfo.GetDirectories();
//  for (int i = 0; i < fi.Length; i++)
//  {
//     Console.WriteLine(fi[i].Name);
//  }

void Towers (string with = "1", string on = "2", string some = "3", int count = 4){
    if(count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with}>>{on}");
    if(count > 1) Towers(some, on, with, count-1);
}




    void PrintArray (int [,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}");
    
               Console.Write("\t");
            
        }
        Console.WriteLine();
      }


    }
  
 int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n,m];
        int number= 1;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            matrix[i,j] = number;
            number+=k;
        }
      }
      return matrix;

    }
  
    int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  int [] result = new int[2];
      if(rowPosition<matrix.GetLength(0)&& columnPosition<matrix.GetLength(1)
      &&rowPosition>=0&&columnPosition>=0){
        result[0] = matrix[rowPosition, columnPosition];
        result[1] = 0;
        
      }
       return result;
    }

    void PrintCheckIfError (int[] results, int X, int Y)
    {
      if(results[0]!=0){
       Console.WriteLine("The number in ["+X+","+Y+"] is "+results[0]);
      }
      else{
        Console.WriteLine("There is no such index");
      }
   }

    void PrintListAvr (double [] list)
    {
      Console.WriteLine("The averages in columns are:");
      for (int i = 0; i < list.Length; i++)
      {
        Console.Write("{0:f2}", list[i]); 
        Console.Write("\t");
      }
    }

     double [] FindAverageInColumns (int [,] matrix)
    { 
      double [] avg = new double[matrix.GetLength(1)];
      for (int j = 0; j < matrix.GetLength(1); j++)
      { double avgColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avgColumn+=matrix[i, j];
        }
        avgColumn = avgColumn/matrix.GetLength(0);
        avg[j] = avgColumn;
      }
      return avg;
    }


      int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));