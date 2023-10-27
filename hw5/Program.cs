// See https://aka.ms/new-console-template for more information
 double FindMax(double[] array)
    {     double max = array[0];
          for(int i = 0; i < array.Length; i++ ){
            if(array[i]>max){
                max = array[i];
            }
          }
      return max;   
    }

   double FindMin(double[] array)
    {      double min = array[0];
          for(int i = 0; i < array.Length; i++ ){
            if(array[i]<min){
                min = array[i];
            }
          }
      return min;  


    }

  double CalcDifferenceBetweenMaxMin(double[] array)
    {
double max = FindMax(array);
double min = FindMin(array);
    
      return max-min; 
    }

    void PrintArray(double[] array)
    {
 for (int i = 0; i < array.Length; i++)
   {
    Console.Write(array[i]);
          if(i<array.Length-1){
            Console.Write("\t");
          }
   }
   Console.Write("\n");

    }
 // Не удаляйте и не меняйте метод Main! 


   
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] {3.17,8.94,2.36,5.72, 0.85  };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    