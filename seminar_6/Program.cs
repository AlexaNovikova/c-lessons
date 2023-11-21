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


    void PrintMatrix(int[,] matrix)
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


  void SortRowsDescending(int[,] matrix)
    {
     for (int i = 0; i < matrix.GetLength(0); i++)
      {  int temp;
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {  
          for(int k = 1; k < matrix.GetLength(1)-j; k++){
             if(matrix[i, k]>matrix[i, k-1]){           
              temp = matrix[i,k];
              matrix[i,k] = matrix[i, k-1];
              matrix[i, k-1] = temp;
             }
          }         
        }
      }
    }


 int SumOfRow(int[,] matrix, int row)
    {
      int sum = 0;
    
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
         sum +=matrix[row,j];         
        }
      return sum;
    }

 int[] MinimumSumRow(int[,] matrix)
    {
      int[] sum = new int[matrix.GetLength(0)];

     for (int i = 0; i < matrix.GetLength(0); i++)
      {
       sum[i] = SumOfRow(matrix, i);
      }

      int minRow = 0;
      int minValue = sum[0];
      for (int i = 0; i < sum.Length; i++)
      {
        if(sum[i] < minValue){
          minValue = sum[i];
          minRow = i;
        }
      }
      int [] result = new int[2];
      result[0] = minRow;
      result[1] = minValue;
      return result;
    }

  void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    {  
      if(matrixA.GetLength(1)!=matrixB.GetLength(0))
    {
      Console.WriteLine("It is impossible to multiply.");
    }
    else {
      int [,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
      result = MatrixMultiplication(matrixA, matrixB);
      PrintMatrix(result);
    }
    }

   int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  
       int [,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
       for (int i = 0; i < matrixA.GetLength(0); i++)
       {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {  int multi = 0;
          for (int k = 0; k < matrixB.GetLength(1); k++)
          {
             multi += matrixA[i, k]*matrixB[k, j];
          }
          result[i, j] = multi;
        }
       }
       return result;
    }

   
    
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {1, 2},
                {3, 4}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
