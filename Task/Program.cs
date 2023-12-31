﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Привет! Напиши что-нибудь, а я отсортирую!");

Console.Write("Итак, первая строка: ");
string? m1 = Console.ReadLine()!;
Console.Write("Вторая: ");
string? m2 = Console.ReadLine()!;
Console.Write("Третья: ");
string? m3 = Console.ReadLine()!;
Console.Write("Четвертая: ");
string? m4 = Console.ReadLine()!;
Console.Write("И пятая: ");
string? m5 = Console.ReadLine()!;

string[] arr1 = new string[5] {m1, m2, m3, m4, m5};

string[] arr2 = new string[arr1.Length];

void ArrayСounter(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }

}

ArrayСounter(arr1, arr2);
Console.WriteLine("Результат сортировки: ");
PrintArray(arr2);