using System;

namespace project
{
    class program
    {
        static void Main(string[] args)
        {
            
            /*
            Задача 2
            напишите программу, которая на ввод принимает два числа и выдает, какое число больше, а какое меньше
           
            int max = 0;
            int min = 0;

            Console.Write("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

             if (a > b)
                {
                max = a;
                min = b;
                }

            else
                 {
                 max = b;
                 min = a;
                 }
           Console.WriteLine("max = " + max + " и " + "min = " + min);
            */
            /*
            Задача 4
            Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
            
            int max = 0;

            Console.Write("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a > max)
            {
                max = a;
            }

            if(b > max)
            {
                max = b;
            }

            if(c > max)
            {
                max = c;
            }
            Console.WriteLine("max = " + max);
             */
            /*
            Задача 6: Напишите програму, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).
            
            Console.Write("Введите число");
             int a = Convert.ToInt32(Console.ReadLine());
             int remains = a % 2;
             if (remains == 0)
             {
                Console.WriteLine("четное");
             }
             else
             {
                Console.WriteLine("не четное");
             }
              */
            /*
             Задача 8: Напишите програму, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
             
             Console.Write("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());
             int counter = 1;
             while (counter <= N)
             {
                if (counter % 2 ==0) 
                Console.WriteLine($"{counter}");
                counter++;
             }
             
              Console.Write("Введите номер дня недели:");
              int number = Convert.ToInt32(Console.ReadLine());

             if (number <= 5 & number >= 1)
             {
                Console.WriteLine("рабочий день");
             }
             if (number <= 7 & number >= 6) 
             {
                Console.WriteLine("выходной");
             }
              */
            /*
             //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
             
            Console.Write("Введите трехзначное число:");
            int number  = Convert.ToInt32(Console.ReadLine());
            if (number > 99 & number < 1000)
            {
            Console.WriteLine($"вторая цифра числа {number / 10 % 10}");
            }
            else
            {
            Console.WriteLine($"второй цифры нет");    
            }
            */
            /*
            //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            Console.Write("Введите число:");
            int number  = Convert.ToInt32(Console.ReadLine());
            if (number > 99)
            {
                while (number > 999)
                {
                    number /= 10;
                }
            Console.WriteLine($"третья цифра числа {number % 10}");
            }
            else
            {
            Console.WriteLine($"третьей цифры нет"); 
            }   
            /*
            //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

            Console.Write("Введите пятизначное число:"); 
            int number  = Convert.ToInt32(Console.ReadLine());
            string numberStr = Convert.ToString(number);
            if (numberStr [0] == numberStr [4] & numberStr [1] == numberStr [3])
            {
                Console.WriteLine($"число {number} палиндром");
            }
            else
            {
                Console.WriteLine($"число {number} не палиндром");
            }
             
            
            //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            

            
            Console.Write("Введите координаты первой точки по оси (x):");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты первой точки по оси (y):");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты первой точки по оси (z):");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координаты второй точки по оси (x):");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй точки по оси (y):");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй точки по оси (z):");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            
            Console.WriteLine($"расстояние между точек {result}");
            
            //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            
            Console.Write("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
            }
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму Цифр в числе.
            
            Console.WriteLine("Введите число:");
            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (i > 0)
            {
            int number = i % 10;
            i = i / 10;
            sum = sum + number;
            }
            Console.WriteLine( + sum);
            
            //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (А и В) и возводит число А в степень B.
            Console.Write("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int degree = a;
            for (int i = 1; i < b; i++)
            {
                degree = degree * a;
            }
            Console.WriteLine( + degree);
            */
            //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            int size = 8;
            int[] numbers = new int[size];
            FillArray(numbers);
            PrintArray(numbers);
            int lastIndex = numbers.Length - 1;
            for (int i =0; i < lastIndex; i++)
            {
                for (int k = 0; k < lastIndex - i; k++)
                {
                    if(Math.Abs(numbers[k]) > Math.Abs(numbers[k + 1]))
                    {
                        int temp = numbers [k];
                        numbers [k] = numbers [k+1];
                        numbers [k+1] = temp;
                    }
                }
            }
            Console.WriteLine();
            PrintArray(numbers);









        }
    }
}