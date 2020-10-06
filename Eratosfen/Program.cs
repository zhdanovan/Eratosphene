using System;
using System.Collections.Generic;

class Program
{
    static List<uint> Eratosphen(uint n)
    {
        var numbers = new List<uint>();  

        for (var i = 2u; i < n; i++) // Заполнение списка начиная с первого простого числа 
        {
            numbers.Add(i);
        }

        for (var i = 0; i < numbers.Count; i++)  // считаем количество элементов чтобы не выйти за пределы
        {
            for (var j = 2u; j < n; j++)  // вычисление простых чисел
            {
                
                numbers.Remove(numbers[i] * j); // удаляем кратные
            }
        }

        return numbers;
    }


    static void Main(string[] args)
    {
        Console.Write("N = ");
        var n = Convert.ToUInt32(Console.ReadLine());
        var primeNumbers = Eratosphen(n);
        Console.WriteLine("Простые числа до заданного {0}:", n);
        Console.WriteLine(string.Join(", ", primeNumbers));
        Console.ReadLine();
    }
}