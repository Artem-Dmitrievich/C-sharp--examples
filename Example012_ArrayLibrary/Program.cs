void FillArray(int[] collection)//collection- аргумент
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
//void - метод, который не возвращает никакие значения(при нем не используется return)
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;//по умолчанию в коде
    //int position = 0;//по умолчанию в коде
    int position = -1;//если элемента нет, то -1(элемент не найден)
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;//показывает только 1 первое число
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//дословно-создать новый массив с 10-ю элементами
//по умолчанию заполнен нулями

FillArray(array);//заполнил массив
PrintArray(array);//вывел массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);