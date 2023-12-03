// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int num = int.Parse(Console.ReadLine());
            int max = 0;
            while (num > 0)
            {
                if (num % 10 > max)
                    max = num % 10;
                num /= 10;
            }
            Console.WriteLine(max);
        