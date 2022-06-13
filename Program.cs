// Задача 1.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Imput a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Result is max a: ");
    Console.WriteLine("Result is min b: ");
}    

else
{
    Console.WriteLine("Result is max b: ");
    Console.WriteLine("Result is min a: "); 
}



// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.



Console.Write("Imput a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput c: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
    Console.WriteLine("Result is max a: ");
    if(b > a && b > c)
        Console.WriteLine("Result is max b: ");
        if(c >a && c >b)
            Console.WriteLine("Result is max c: ");



// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



Console.Write("Imput integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 2;

if(num2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");



// Задача 4.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


int num = 2;
for (int i=0; i<50; i++)
{
    Console.Write(num);
    num = (-(~num)); num = (-(~num));
}
*/

// Задача 10.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void ShowNunber()
{
int num = new Random().Next(100, 999);
Console.Write(num + " -> ");
int num1 = num / 10;
int n = num1 % 10;

Console.Write(n);
}
ShowNunber();
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ShowNunber2(int num)

{
    if (num  > 99 )
    {
        int num1 = num % 10;
        Console.Write(num1 + "third number");
        
    }
    else 
    {
        Console.Write("No third number");
    }
    }

Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNunber2(num);
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void SowDayOff(int num)
{
    if(num <= 7 && num >= 6)
    {
        Console.Write("It's a day off");
    }
    else
    {
        Console.Write("It's not a day off");
    }
}

Console.Write("Imput day number: ");
int num = Convert.ToInt32(Console.ReadLine());
SowDayOff(num);
*/

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Enter your number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Your number is: {number} - polindrom.");
  }
  else Console.WriteLine($"Your number is: {number} - not polindrom.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Enter the correct number  ");

*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Enter your coordinate {coorName} point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Segment length  {segmentLength}");

*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Clear();
void Cube(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while(count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    Cube(num);
else
    Console.Write("Enter positiv number");    

*/


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] numbers = new int[3];

void RandomArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 ==0)
    {
      quantity++;
    }
  }
  return quantity;
}

RandomArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Amount of positive numbers in array: {quantity}");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

Console.Write($"Enter the number of array elements: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Received array: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nSum of elements in odd positions: {randomNumbers}");

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

double[] arrayRealNumbers = new double[4];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(10, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nDifferens between maximum ({maxNumber}) and minimum ({minNumber}) element: {decision}");

  */