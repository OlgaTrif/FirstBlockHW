/*Написать программу, которая из имеющегося массива строк формирует новый массив из 
строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.*/

// Инициализация двумерного массива символов
string[] firstArray = new string[] { { 'anh', 'bGRb68', 'NB', 'Hello', 'G', 'h'}};
// Вызов метода для создания нужного массива
string[] resultArray = FilterArray(firstArray);
// Вывод результата
WriteArray(resultArray);

// Метод для создания массива из элементов с <=3 символами
public string[] FilterArray(string[] array)
{
    string[] result = new string[];
    //цикл по result
    for (int j = 0; j < result.Length; j++) {
        //цикл по исходному массиву
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) {

            }
        

        }
    }
    return result;
}

//Вывод результата
public void WriteArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + ", ");
    }
}