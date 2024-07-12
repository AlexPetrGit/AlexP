// Задача 1: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// void F(int m, int n)
// {
//     if (m != n)
//     {
//         if (m > n)
//         {
//             F(m - 1, n);
//             System.Console.Write(m + " ");
//         }
//         else
//         {

//             F(m, n - 1);
//             System.Console.Write(m + " ");

//         }

//     }
//     else
//     {
//         System.Console.Write(m);
//     }
// }

// F(1, 9);


// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// псевдокод
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

// int Promt(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine());
// }

// int AckermanFunction(int M, int N)
// {
//     if (M == 0) return N + 1;
//     else if (M > 0 && N == 0) return AckermanFunction(M - 1, 1);
//     else if (M > 0 && N > 0) return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
//     return 0;
// }

// int M = Promt("Введите неотрицательное число M: ");
// int N = Promt("Введите неотрицательное число N: ");

// if (M < 0 || N < 0)
// {
//     Console.WriteLine("Введите неотрицательные числа!!!");
// }
// else
// {
//     Console.WriteLine($"Значение функции Аккермана - А({M}, {N}) равно: {AckermanFunction(M, N)}");
// }


// Задача 3: Задайте произвольный массив. Выведете его элементы,
// начиная с конца. Использовать рекурсию, не использовать циклы.

// void ShowArray(int[] array, int i)
// {
//     if (i == 0)
//     {
//         System.Console.Write(array[i]);
//         return;
//     }
//     System.Console.Write(array[i] + " ");
//     ShowArray(array, i - 1);
//     return;
// }

// int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, };
// ShowArray(arr1, arr1.Length - 1);