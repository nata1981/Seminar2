// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

  int number = int.Parse(Console.ReadLine());
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine("The number is divisible by 7 and 23");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 7 and 23");
                