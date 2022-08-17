using System;

class Program
{
    public static void Main(string[] args)
    {

        void FillArray(double[,] array)
        {
            Random random = new Random();
            for (int m = 0; m < array.GetLength(0); m++)
            {
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    array[m, n] = random.Next(-100, 101);
                }
            }
        }

        void WriteArray(double[,] array)
        {
            for (int m = 0; m < array.GetLength(0); m++)
            {
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    Console.Write(array[m, n] + " ");
                }
                Console.WriteLine();
            }
        }

        void Task47()
        {
            // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

            Console.WriteLine("Укажите количество строк");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите количество столбцов");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[m, n];
            if (m < 1)
            {
                Console.WriteLine("Указанно неверное кол-во строк");
            }
            else if (n < 1)
            {
                Console.WriteLine("Указанно неверное кол-во столбцов");
            }
            else
            {
                FillArray(array);
                WriteArray(array);
            }

        }



        void Task50()
        {
            // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемента нет.

            int reply, line, column;
            int repit = 1;
            int m = 0;
            int n = 0;
            while (repit == 1)
            {
                Console.WriteLine("Желаете сами указать количество строк и столбцов в массиве? (1 - да, 2 - нет).");
                reply = Convert.ToInt32(Console.ReadLine());
                if (reply == 1)
                {
                    Console.WriteLine("Укажите количество строк (для правильной работы программы пожалуйста не вводите число больше 9).");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите количество столбцов (для правильной работы программы пожалуйста не вводите число больше 9).");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (m < 1)
                    {
                        Console.WriteLine("Указанно неверное кол-во строк.");
                    }
                    else if (n < 1)
                    {
                        Console.WriteLine("Указанно неверное кол-во столбцов.");
                    }
                    else if (m > 10)
                    {
                        Console.WriteLine("Указанное кол-во строк превышает допустимое значение.");
                    }
                    else if (n > 10)
                    {
                        Console.WriteLine("Указанное кол-во столбцов превышает допустимое значение.");
                    }
                    else
                    {
                        repit = 0;
                    }

                }
                else if (reply == 2)
                {
                    Console.WriteLine("Для простоты эксперемента будет создан массив с высотой и шириной в 5 значений.");
                    m = 5;
                    n = 5;
                    repit = 0;
                }
                else
                {
                    Console.WriteLine("Введен неправильный ответ.");

                }
            }
            double[,] array = new double[m, n];
            FillArray(array);
            Console.WriteLine("Получился следующий массив - ");
            WriteArray(array);
            Console.WriteLine("Введите позицию элемента который хотите вывести.");
            Console.WriteLine("ПРИМЕР: позиции 12 соответствует число " + array[0,1] + ", так как 1 - номер строки, а 2 номер стобца.");
            int pos = Convert.ToInt32(Console.ReadLine());
            if (pos > 99)
            {
                Console.WriteLine("Такого числа нет");
            }
            else if (pos < 11)
            {
                Console.WriteLine("Такого числа нет");
            }
            else
            {
                line = pos / 10 - 1;
                column = pos % 10 - 1;
                Console.WriteLine("На данной позиции находится следующее сило - " + array[line, column] + ".");
            }

        }


        void Task52()
        {
            // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            int reply;
            int repit = 1;
            int m = 0;
            int n = 0;
            double summ = 0;
            double average;
            while (repit == 1)
            {
                Console.WriteLine("Желаете сами указать количество строк и столбцов в массиве? (1 - да, 2 - нет).");
                reply = Convert.ToInt32(Console.ReadLine());
                if (reply == 1)
                {
                    Console.WriteLine("Укажите количество строк (для правильной работы программы пожалуйста не вводите число больше 9).");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите количество столбцов (для правильной работы программы пожалуйста не вводите число больше 9).");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (m < 1)
                    {
                        Console.WriteLine("Указанно неверное кол-во строк.");
                    }
                    else if (n < 1)
                    {
                        Console.WriteLine("Указанно неверное кол-во столбцов.");
                    }
                    else if (m > 10)
                    {
                        Console.WriteLine("Указанное кол-во строк превышает допустимое значение.");
                    }
                    else if (n > 10)
                    {
                        Console.WriteLine("Указанное кол-во столбцов превышает допустимое значение.");
                    }
                    else
                    {
                        repit = 0;
                    }

                }
                else if (reply == 2)
                {
                    Console.WriteLine("Для простоты эксперемента будет создан массив с высотой и шириной в 5 значений.");
                    m = 5;
                    n = 5;
                    repit = 0;
                }
                else
                {
                    Console.WriteLine("Введен неправильный ответ.");

                }
            }
            double[,] array = new double[m, n];
            FillArray(array);
            Console.WriteLine("Получился следующий массив - ");
            WriteArray(array);
            Console.Write ("Среднее арифметическое каждого столбца: ");
            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < m; l++)
                {
                    summ += array[l,i];
                }
                average = summ / m;
                if (i + 1 == n)
                {
                    Console.Write (average + ".");
                }
                else
                {
                    Console.Write (average + "; ");
                }
                summ = 0;
            }
        }



        //Меню для более легкой проверки.

        Console.WriteLine("Укажите какое задание хотите проверить (47, 50, 52)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 47)
        {
            Task47();
        }
        else if (task == 50)
        {
            Task50();
        }
        else if (task == 52)
        {
            Task52();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }
    }
}