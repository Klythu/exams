// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string InputString(string msg)
{
    Console.WriteLine(msg);
    string inp=Console.ReadLine();
    return inp;
}

int InputInt(string msg)
{
    Console.WriteLine(msg);
    int inp=int.Parse(Console.ReadLine());
    return inp;
}

string[] AddStringsToArray(int Long)
{
    string[] FullArrayOfStrings= new string[Long];
    for (int i = 0; i < FullArrayOfStrings.Length; i++)
    {
        FullArrayOfStrings[i]=InputString("введите строку");
    }
    return FullArrayOfStrings;
}

void ArrSee(string[] arr)
{
    Console.Write("[");
    int i=0;
    while (i<arr.Length-1)
    {
        Console.Write($"{arr[i]},");
        i++;
    }
    Console.Write(arr[i]);
    Console.Write("]");
}

string[] StringsLessThenFour(string[] ArrayWithStrings)
{
    
}

string[] StringsForProgramm= AddStringsToArray(InputInt("количество элементов масива"));
ArrSee(StringsForProgramm);
foreach (string word in StringsForProgramm)
{
    
}