﻿// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введи {i + 1}(ую) строку");
        Console.WriteLine();
        array[i] = Console.ReadLine()!;
        Console.WriteLine();
    }
    return array;
}

int countingnumbers(string[] array)
{
    int count = 0;
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        foreach (char e in array[i])
        {
            a++;
        }
        if (a <= 3)
        {
            count++;
        }
        a = 0;
    }
    return count;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] strarray = new string[size];
strarray = CreateStringArray(strarray);
string[] newarray = new string[countingnumbers(strarray)];

int index = 0;
for (int i = 0; i < strarray.Length; i++)
{
    if (strarray[i].Length <= 3)
    {
        newarray[index] = strarray[i];
        index++;
    }
}

PrintArray(newarray);