﻿// Homework 1

// Task2. You recieve 2 numbers. Find max
Console.Write("Please, enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter secound number: ");
int secoundNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secoundNum) 
   Console.Write("Maximum number is first and it equals - " + firstNum);
else Console.Write("Maximum number is secound and it equals - " + secoundNum);