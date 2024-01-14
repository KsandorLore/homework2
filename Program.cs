//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/*void ABC(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.Write("да");
    }
    else System.Console.Write("нет");
}
System.Console.WriteLine("Inpun num:");
int number = Convert.ToInt32(Console.ReadLine());

ABC(number);*/

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/*void Coordinates(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("2");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("4");
    }
}

System.Console.WriteLine("Inpun x coordinate:");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Inpun y coordinate:");
int y = Convert.ToInt32(Console.ReadLine());

Coordinates(x, y);*/

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*Console.WriteLine("Input num from 10 to 99:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec)
    {
        Console.WriteLine(ed);
    }
    else Console.WriteLine(dec);

}
else Console.WriteLine("Num is not from 10 to 99");*/

//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Input num:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 10)
{
    while (num > 0)
    {
        int dig = num % 10;
        num = num / 10;
        if (num > 0)
        {
            Console.Write(dig + ",");
        }
        else
        {
            Console.Write(dig);
        }
    
    }
}
else 
{
    Console.WriteLine(num);
}