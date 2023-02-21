//Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
//using System.Linq;

void input_array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива № {i + 1}: ");
        array[i] = Console.ReadLine();
    }

}

int input_array2(string[] array)

{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            k++;
    return k;
}

void release(string[] array, string[] array2, int b)
{
    int j = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)

           {
            array2[j] = array[i];
        j++;
    }
}
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
input_array(array);
Console.WriteLine($"[{string.Join(" ,  ", array)}]");
int k = input_array2(array);
string[] array2 = new string[k];
release(array, array2, k);
Console.WriteLine($"[{string.Join(" ,  ", array2)}]");





