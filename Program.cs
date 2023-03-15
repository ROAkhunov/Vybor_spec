void ChooseString(string[] array)
{
    int length = array.Length;
    Console.Write("Элементы с тремя и менее символами: "+"[");
    for (int i = 0; i < length; i++)
    { 
        string str=array[i];
        if (str.Length<=3)
        {
          Console.Write(array[i]+", ") ; 
        }
    }
   Console.Write("]");
}

string[] GetArray()
{
    Console.WriteLine("Введите число элементов массива");
    int size=Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент массива", i, ":");
        array[i] = Console.ReadLine();
    }
    return array;
}

ChooseString(GetArray()); 
   
   
   