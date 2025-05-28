using System;

public class Program()
{
    static void Program1()
    {
        var rand = new Random();
        int[] a = new int[5];
        int[,] b = new int[3, 4];
        int max = int.MinValue, min = int.MaxValue, sum = 0, product = 1, sumOfEven = 0, sumOfOdd = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Введите число: ");
            a[i] = Convert.ToInt32(Console.ReadLine());

            // Условие, чтобы найти наименьший элемент в массиве A
            if (a[i] < min)
            {
                min = a[i];
            }

            // Условие, чтобы найти наибольший элемент в массиве B
            if (a[i] > max)
            {
                max = a[i];
            }

            // Сумма всех элементов
            sum += a[i];

            // Произведение всех элементов
            product *= a[i];

            // Условие, чтобы найти сумму всех четных чисел в массиве A
            if (a[i] % 2 == 0)
            {
                sumOfEven += a[i];
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                // Заполнение массива случайными числами
                b[i, j] = rand.Next(9);

                // Условие, чтобы найти элемент в массиве B, который будет меньше наименьшего элемента в массиве A
                if (b[i, j] < min)
                {
                    min = b[i, j];
                }

                // Условие, чтобы найти элемент в массиве B, который будет больше наибольшего элемента в массиве A
                if (b[i, j] > max)
                {
                    max = b[i, j];
                }

                // Сумма всех элементов
                sum += b[i, j];

                // Произведение всех элементов
                product *= b[i, j];

                // Условие, чтобы найти сумму всех нечетных столбцов в массиве B
                if (j % 2 != 0)
                {
                    sumOfOdd += b[i, j];
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{a[i]} ");
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j != 3)
                {
                    Console.Write($"{b[i, j]} ");
                }

                else
                {
                    Console.WriteLine($"{b[i, j]} ");
                }
            }
        }

        Console.WriteLine($"Максимальное значение среди элементов массива A и B: {max}");
        Console.WriteLine($"Минимальное значение среди элементов массива A и B: {min}");
        Console.WriteLine($"Сумма всех элементов массива A и B: {sum}");
        Console.WriteLine($"Произведение всех элементов массива A и B: {product}");
        Console.WriteLine($"Сумма всех четных элементов в массиве A: {sumOfEven}");
        Console.WriteLine($"Сумма всех нечетных столбцов в массиве B: {sumOfOdd}");
    }
    // Задание 2
    static void Program2()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();
        int min = 101, max = -101, sum = 0, minI = 0, minJ = 0, maxI = 0, maxJ = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101);
                if (array[i, j] < min) { min = array[i, j]; minI = i; minJ = j; }
                if (array[i, j] > max) { max = array[i, j]; maxI = i; maxJ = j; }
            }
        }

        bool between = false, endSum = false;
        for (int i = 0; i < 5 && !endSum; i++)
        {
            for (int j = 0; j < 5 && !endSum; j++)
            {
                if ((i == minI && j == minJ) || (i == maxI && j == maxJ))
                {
                    if (!between)
                    {
                        between = true;
                        sum += array[i, j];
                    }
                    else
                    {
                        sum += array[i, j];
                        endSum = true;
                    }

                }
                else if (between)
                {
                    sum += array[i, j];
                }

            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j != 4)
                {
                    Console.Write($"{array[i, j]} ");
                }

                else
                {
                    Console.WriteLine($"{array[i, j]} ");
                }
            }
        }
        Console.WriteLine($"Сумма: {sum}");
    }
    static void Main()
    {
        //Program1();
        Program2();
    }
}