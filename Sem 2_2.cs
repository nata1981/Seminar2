 // Напишите программу, которая принимает на вход координаты точки (X и Y),
   //причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
   // в которой находится эта точка         

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
      
           