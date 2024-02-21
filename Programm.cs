/*Написать программу, которая из имеющегося массива строк формирует новый массив из 
строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

// Инициализация массива символов
string[] firstArray = new string[6] {"anh", "bGRb68", "NB", "Hello", "G", "h"};
Console.WriteLine("Исходный массив: ");
WriteArray(firstArray);
// Вызов метода для создания нужного массива
// Вывод результата
Console.WriteLine("Результирующий массив: ");
WriteArray(FilterArray(firstArray));

// Метод для создания массива из элементов с <=3 символами
string[] FilterArray(string[] array)
{
    string[] result = new string[4];
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            result.SetValue(array[i], counter);
            counter++;
        }
    }
    return result;
}

//Вывод результата
void WriteArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine(array[i] + ", ");
    }
}