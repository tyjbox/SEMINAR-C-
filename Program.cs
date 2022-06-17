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

  // Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

  int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Enter number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Result: " + exponentiation);

  */

  // Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

  Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  {
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Sum of the digits in a number: " + sumNumber);

*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

Console.Write("Enter string of numbers, comma separated : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}


void СheckNumber2 (int  series)
{

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Character input error. Enter numbers.");

      }
}


int[] ArrayOfNumbers(string seriesNew)
{ 

  int[] arrayOfNumbers = new int[1];

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbers;
}


void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);

*/

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

Console.Write($"Enter number М(amount number): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Enter {i+1} number: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"More numbers entered 0: {Comparison(massiveNumbers)} ");

*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*

Console.Write($"Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
string Binarynumber = string.Empty;

while(number > 0)
{
  Binarynumber = (number % 2) + Binarynumber;
  number/=2;
}


Console.Write((Binarynumber) + "  Your binary number");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

/*

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Enter odds {i+1} equations (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Enter odds  k: ");
      else Console.Write($"Enter odds b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nDirect match");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nStraight lines are parallel");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nPoint of intersection of lines: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);

*/


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("\nWe take the array from the task (№ 47).\n");
Console.Write("Enter element position coordinates via , : ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Element value: {result}");
}
else Console.Write($"There is no such element in the array.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("\nWe take the array from the task (№ 47).\n, translating double в int32.\n");
int[,] arrayWhole = new int[m, n];
arrayWhole = TransformationArrayWhole(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nArithmetic mean:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"column № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}

*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

/*

Console.WriteLine($"\nEnter the size of the array m X n and a range of random values:");
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int range = InputNumbers("Enter range:  1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nOrdered array: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

Console.WriteLine($"\nEnter the size of the array m X n and a range of random values:");
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int range = InputNumbers("Enter range:  1 to ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - row with the smallest sum ({sumLine}) element ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

*/

// Задача 62. Заполните спирально массив 4 на 4.

/*

Console.Clear();
Console.WriteLine($"Fill array spirally 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

Console.Clear();
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Summ element= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

*/


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void SummOfNumbers(int num)
{
    if (num != 0)
    {
        sum += num % 10;
        num = num / 10;
        SummOfNumbers(num);
    }
}

SummOfNumbers(number);
Console.Write($"Summ digital of number {sum}");

*/
