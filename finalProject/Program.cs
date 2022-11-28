// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Clear();
string[] arr = { "hello", "2", "world", ":-)" };

string[] newArr = SelectArr(arr);
PrintResilt(arr, newArr);

string[] SelectArr(string[] array)
{
    int i = 0;
    string[] newArr = new string[array.Length];
    for (int current_index = 0; current_index < array.Length; current_index++)
    {
        if (array[current_index].Length <= 3)
        {
            newArr[i] = array[current_index];
        }
        else
        {
            newArr[i] = null;                                   //данный else нужен для возможности "красивого" вывода на экран массива
        }
        i++;
    }
    return newArr;
}

void PrintResilt(string[] arr, string[] newArr)
{

    PrintArray(arr);
    Console.Write(" -> ");
    PrintArray(newArr);

}

void PrintArray(string[] arr)
{
    bool firstElement = true;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null){
            if (firstElement == false)
            {
                Console.Write(", ");        
            }
            Console.Write($"{arr[i]}");
            firstElement = false;
        }
    }
    Console.Write("]");
}
