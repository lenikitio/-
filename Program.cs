// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте заполнения алгоритма. При решении не рекомендуетс пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

string[] GetArray(int size)
{
    string[] result = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[" + array[i] + ", ");
        else if(i == array.Length - 1) Console.Write(array[i] + "]");
        else Console.Write(array[i] + ", ");
    }
}

string[] GetArrayThreeElem(string[] array)
{
    int count = 0;
    foreach(string elem in array)
        if(elem.Length <= 3) count++;
    string[] ThreeArray = new string[count];
    int i = 0;
    foreach(string elem in array)
    {
        if(elem.Length <= 3) 
        {
            ThreeArray[i] = elem;
            i++;
        }
        if(i == count) break;
    }
    return ThreeArray;
}

string[] OurArray = GetArray(4);
PrintArray(OurArray);
Console.Write(" -> ");
string[] ChangeArray = GetArrayThreeElem(OurArray);
PrintArray(ChangeArray);