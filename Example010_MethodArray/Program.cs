/*Имеется массив array из n элементов, требуется 
  найти элемент массива, равный произвольно заданному числу faind
 1.Установить счетчик index в позицию 0
 2.Если array[index] = find, алгоритм завершил работу успешно.
 3.Увеличить index на 1
 4.Если index < n, то перейти к шагу 2. В противном случае алглритм 
   завершил свою работу безуспешно.*/

int[] array = {15, 8, 17, 6, 32, 48, 43, 2, 32};
int n = array.Length;
int find = 32;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    ++index;
}