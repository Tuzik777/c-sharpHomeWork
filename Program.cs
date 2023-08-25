         //Задача 2: напишите программу, которая на ввод принимает два числа и выдает, какое число больше, а какое меньше
           /*
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
            //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
            /*
            
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
            //Задача 6: Напишите програму, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).
            /*
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
             //Задача 8: Напишите програму, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
             /*
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
             //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
             /*
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
            //Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            /*
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
            */
            //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            /*
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
             
            */
            //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            /*
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
            */
            //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            /*
            Console.Write("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
            }
            */
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму Цифр в числе.
            /*
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
            */
            //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (А и В) и возводит число А в степень B.
            /*
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
            /*
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
            */
            //задача 34: задайте массив заполненныи случайными положительными трёхзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.
            /*
            Console.WriteLine("введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(100,1000);
                }
            Console.WriteLine("наш массив: ");
            PrintArray(numbers);
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                count++;
            }
            Console.Write("четных чисел:" + count);
            */
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
            /*
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            FillArrayRandomNumbers(numbers);
            for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = new Random().Next(1,10);
                }
            Console.WriteLine("наш массив: ");
            PrintArray(numbers);
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                count++;
            }
            int sum = 0;
            for (int z = 0; z < numbers.Length; z+=2)
                sum = sum + numbers[z];
                Console.WriteLine($" сумма нечетных чисел = {sum}");
            */
           // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
            /*
            Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine("Массив: ");
            PrintArray(numbers);
            double min = Int32.MaxValue;
            double max = Int32.MinValue;
            for (int z = 0; z < numbers.Length; z++)
            {
                 
                if (numbers[z] > max)
                    {
                        max = numbers[z];
                    }
                if (numbers[z] < min)
                    {
                        min = numbers[z]; 
                    }
            }
            Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
            Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
            void FillArrayRandomNumbers(double[] numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
                    }
            }
            void PrintArray(double[] numbers)
            {
                Console.Write("[ ");
                for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                Console.Write("]");
                Console.Wrriteline();
            }
            */
            //Задача 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            /*
            Console.Write("Введите количество элементов массива:");
             int m = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[m];
            void mas(int m) 
            {
                 for (int i = 0; i < m; i++)
              {
                 Console.WriteLine($"Введите {i+1} элемент массива");
                  Array[i] = Convert.ToInt32(Console.ReadLine());
              }
            }
            int kol(int[] Array) 
            {
                 int i=0; int sum = 0;
                  while (i < Array.Length) 
                 {
                     if(Array[i]>0) sum = sum + 1; i = i + 1; 
                 }
                    return sum;
             }
            mas(m);
            Console.Write($"\n Чисел больше нуля: {kol(Array)}");
            */
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями у = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            /*
            Console.WriteLine("включить значение b1");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число k1");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("включить значение b2");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число k2");
            double k2 = Convert.ToInt32(Console.ReadLine());
            double x = (-b2 + b1)/(-k1 + k2);
            double y = k2 * x + b2;
            Console.WriteLine($"прямо пересекаются с координатами X: {x}, {y}");
            */
            //Задача 47: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами, округлёнными до одного знака.
            /*
            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);
            void FillArrayRandomNumbers(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                    }
                }
            }
            void PrintArray(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
            */
            //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            /*
            Console.WriteLine("введите номер строки");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер столбца");
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] numbers = new int [10,10];
            FillArrayRandomNumbers(numbers);
            if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
            }
            PrintArray(numbers);
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                    {        
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array [i,j] = new Random().Next(-100, 100)/10;
                        }   
                    }
            } 
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + " ");
                    }   
                    Console.Write("]"); 
                    Console.WriteLine(""); 
                }
            }
            */
            // Задача 52: задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            /*
            Console.WriteLine("введите количество строк");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[n, m];
            FillArrayRandomNumbers(numbers);
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                double avarage = 0;
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    avarage = (avarage + numbers[i, j]);
                }
                avarage = avarage / n;
                Console.Write(avarage + "; ");
            }
            Console.WriteLine();
            PrintArray(numbers);
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
            */
            // Задача Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            /*
            Console.WriteLine($"ввидите размер массива m * n и диапазон случайных значений:");
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            int range = InputNumbers("Введите диапазон: от 1 до ");
            int[,] array = new int[m, n];
            CreateArray(array);
            WriteArray(array);
            Console.WriteLine($"отсортированный массив: ");
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
             //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
                /*
                Console.WriteLine($"Введите размер массива m * n и диапозон случайных значений: ");
                int m = InputNumbers("Введите m: ");
                int n = InputNumbers("Введите n: ");
                int range = InputNumbers("Введите диапазон: от 1 до ");
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
                Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
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
                //Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
                /*
                Console.Write("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
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
                //задача 66: задайте значения M и N. Напишите рекурсивный метод, который найдет сумму натуральных элементов в промежутке от M до N.
                /*
                Console.Write("Введите значение M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение M: ");
                int sum(int m, int n)
                {
                if (m==n)
                return n;
                else return m + sum(m + 1, n);
                }
                Console.Write($"сумма натуральных элементов = {sum(m,n)}");
                */
                //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
                /*
                Console.Write("Введите значение M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                void num(int m, int n)
                    {
                    if (m > n) return;
                    if (m % 3 == 0) 
                        {
                        Console.Write($"{m}, "); 
                        }
                    num(m+1,n);
                    }
                num(m,n);
                */
                //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
                /*
                Console.Write("Введите число M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int akkerman(int m, int n)
                {
                if (m == 0)
                {
                     return n + 1;
                }
                else if (n == 0)
                {
                    return akkerman(m - 1, 1);
                }
                else
                {
                 return akkerman(m - 1, akkerman(m, n - 1));
                }
                }
                Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
                */
