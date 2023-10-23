public class Answer
{
   static void ShowCube(int N)
    {
      for (int i = 1; i <= N; i++)
      {
        Console.WriteLine(i*i*i);
      }

    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}