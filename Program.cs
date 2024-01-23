/*
    while(true)
    {
        Console.WriteLine("Введите число или q для выхода:");
        string input = Console.ReadLine();

        if (input == "q")
        {
            break;
        }
        int num;
        if (int.TryParse(input, out num))
        {
            int sum = 0;
            while (num > 0)
            {
                sum = num % 10;
                num = num / 10;
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("[STOP]");
                break;
            }
        }
        else 
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
        }

    }
    */


/*  int[] num = new int[10];
  Random rnd = new Random();
  int EvenCount = 0;
  for (int i = 0; i < num.Length; i++)
  {
      num[i] = rnd.Next(100, 1000);
      if (num[i] % 2 == 0)
      {
          EvenCount++;
      }


  }

Console.WriteLine($"\nКоличество четных чисел в массиве: {EvenCount}");
*/

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
int temp;

Console.Write("Исходный массив: ");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}

for (int i = 0; i < numbers.Length / 2; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

Console.Write("\nПеревернутый массив: ");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}