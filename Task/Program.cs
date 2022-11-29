/*
Итоговая проверочная работа:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.
Примеры:
Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []
*/


int n = 3;
int size = 4;
string[] firstArr = FillArray(); 
PrintArray(firstArr);
Console.Write(" -> ");

if (GetSizeSecondArray(firstArr) == 0){
    Console.WriteLine ("нет символов для переноса в новый строковый массив");
}
else{
    string[] newArr = ElementsTransfer(firstArr);
    PrintArray(newArr);
}

//Заполнение массива
string[] FillArray()
{
    Console.WriteLine($"Введите любые {size} значений (набор символов), формирующих строковый массив, через пробел: ");
    return Console.ReadLine().Split(" ");

}

//вывод массива на экран
void PrintArray (string[] array){
    int arrayLength = array.Length;
    Console.Write("[ ");
    for(int i = 0; i < arrayLength; i++){
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
}

//Создание нового массива длиной по условию
int GetSizeSecondArray (string[] array){
    int secondSize = 0;
    for(int i = 0; i < size; i++){
        if( array[i].Length <= n){
            secondSize++;
        }
    }
    return secondSize;
}

//перенесение элементов в новый массив
string[] ElementsTransfer (string[] array){
    string[] newArr = new string [GetSizeSecondArray(firstArr)];
    for(int i = 0, j = 0; i < size; i++){
        if(array[i].Length <= n){
            newArr[j] = array[i];
            j++;
        }
    }
    return newArr;
}


