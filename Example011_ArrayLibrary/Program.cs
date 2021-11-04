void FillArray(int[] collection)
{
    int lenght = collection.Lenght;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Lenght;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Lenght;
    int index = 0;
    int position = -1; // -1 ставим на тот случай, если искомого элемента не найдется то это будет видно.

    while (index < count)
    {
        if(collection[index] == find)
        { 
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);