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