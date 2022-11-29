// Homework 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Please, enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter secound number: ");
int secoundNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secoundNum) 
   Console.Write("Maximum number is first and it equals - " + firstNum);
else Console.Write("Maximum number is secound and it equals - " + secoundNum);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Please, enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter secound number: ");
int secoundNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter third number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secoundNum)
{
   if (firstNum > thirdNum)
      Console.Write("Maximum number is first and it equals - " + firstNum);
   else Console.Write("Maximum number is third and it equals - " + thirdNum);
} else 
{
   if (secoundNum > thirdNum)
      Console.Write("Maximum number is second and it equals - " + secoundNum);
   else Console.Write("Maximum number is third and it equals - " + thirdNum);
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Please, enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 ==0) Console.WriteLine("Your number is even");
else Console.WriteLine("Your number is not even");