string[] createArray(int size)
{
    string[] array=new string[size];

    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите {i+1} значение массива: ");
        array[i]=Convert.ToString(Console.ReadLine());
    }
    return array;
}

int elements(string[] array, int size)
{
    int k=0;
    for(int i=0; i<size; i++)
    {
        if(array[i].Length<4)
        {
            k++;
        }
    }
    return k;
}

string[] newArray(string[] array, int num)
{
    string[] mas=new string[num];
    int k=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            mas[k]=array[i];
            k++;
        }
    }
    return mas;
}

void printArray(string[] array)
{
    for(int i=0; i<array.Length; i++)   // последняя фигня это как раз размер массива
    Console.Write(array[i]+" ");

    Console.WriteLine();
}

Console.Write("Введите размерность массива: ");
int razmer=Convert.ToInt16(Console.ReadLine());
string[] masive=createArray(razmer);
int newRazmer=elements(masive, razmer);
string[] newMasive=newArray(masive, newRazmer);
Console.WriteLine("Новый массив, где размерность элементов меньше или равно 3");
printArray(newMasive);