
        Console.Clear();

        // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        // a = 5; b = 7 -> max = 7
        // a = 2 b = 10 -> max = 10
        // a = -9 b = -3 -> max = -3

        // Console.WriteLine("Get number 1, please");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Get number 2, please");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // if (num1>num2)
        // {
        //     Console.WriteLine("Max number:");
        //     Console.WriteLine(num1);
        // }
        // else
        // {
        //     Console.WriteLine("Max number:");
        //     Console.WriteLine(num2);
        // }

        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // 2, 3, 7 -> 7
        // 44 5 78 -> 78
        // 22 3 9 -> 22

        // Console.WriteLine("Hi!");
        // Console.WriteLine("Get number 1, please");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Get number 2, please");
        // int num2 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Get number 3, please");
        // int num3 = Convert.ToInt32(Console.ReadLine());

        // int max = 0;

        // if (num1>num2)
        // {
        //     max = num1;
        // }
        // else
        // {
        //     max = num2;
        // }

        // if (max>num3)
        // {
        //     Console.WriteLine("Max number:");
        //     Console.WriteLine(max);
        // }
        // else
        // {
        //     Console.WriteLine("Max number:");
        //     Console.WriteLine(num3);
        // }

        // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        // 4 -> да
        // -3 -> нет
        // 7 -> нет

        // Console.WriteLine("Hi!");
        // Console.WriteLine("Get number, please");
        // int num1 = Convert.ToInt32(Console.ReadLine());

        // if (num1%2==1)
        // {
        //     Console.WriteLine("Odd number(NO)");
        // }
        // else
        // {
        //     Console.WriteLine("An even number(YES)");
        // }

        // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        // 5 -> 2, 4
        // 8 -> 2, 4, 6, 8

        Console.WriteLine("Hi!");
        Console.WriteLine("Get number, please");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        while (num1>1);
        {
            if (num1%2==1)
            {
                Console.WriteLine(num1);
                num1--;
            }
            else
            {
                num1--;
            }
        }
        //Не смог добиться успеха
        