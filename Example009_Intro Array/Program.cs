int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1   2   3   4   5   6   7   8  - номера индексов элементов массива
int[] array = {11, 83, 22, 48, 39, 67, 78, 66, 65};

//array[0] = 12;                 элементу мвссива с индексом "0" присвоить значение "12" (вместо "11")
//Console.WriteLine(array[4]);   вывести на экран значение элемента с индексом "4" (39)

int max = Max (Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);