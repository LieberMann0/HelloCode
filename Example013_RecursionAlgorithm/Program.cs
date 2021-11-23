// Двумерный массив (строки, столбцы)


string[,] table = new string[2, 5];

//String.Empty - инициализация для string
//table[0, 0]   table[0, 1]   table[0, 2]   table[0, 3]   table[0, 4]
//table[1, 0]   table[1, 1]   table[1, 2]   table[1, 3]   table[1, 4]

table[1, 2] = "слово";

// распечатать массив нужен цикл в цикле
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}- ");
    }
    Console.WriteLine();
}

//метод создающий массив и выводящий его на экран
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);

//метод заполняющий массив случайными значениями и выводящий их на экран
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);            
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);


//представление черно-белого изображения
//закрашивание внутренней области контура изображения
int[,] pic = new int[,] //не обязательно указывать количество строк и столбцов если есть фиксированные данные
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ..........} //итд строки массива из "0" с контуром ладони из "1"
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); // метод вызывает самого себя - рекурсия
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);


//вычисление факториала (пример рекурсии)
double Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1   0! = 1
    else return n * Factorial(n - 1);
}
for (int i; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


//числа Фибоначчи (пример рекурсии)

// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2)
}
 for (int i = 1; i < 10; i++)
{
    ;
}



 // На семинаре


void Fill2DArray(int[,] a)
{
    for(int i = 0; i < GetLength(0); i++)       // создаются элементы массива
    {
        for(int j = 0; j < GetLength(1); j++)   // 
        {                                       // элементы массива заполняются значениями
            a[i, j] = i * 10 + j;               //
        }
    }
}

void Print2DArray(int[,] a)
{
    for(int i = 0; i < GetLength(0); i++)       //
    {                                           //
        for(int j = 0; j < GetLength(1); j++)   // 
        {                                       // элементы массива выводятся на экран
            Console.Write($"{a[i, j], 4}");     //    - в интерполяционной строке ($) указывается что выводим 
        }                                       //      и сколько места отводим для каждого элемента (4)
        Console.WriteLine();                    //
    }  
}

int[,] a;
a = new int[10, 4];                               

Fill2DArray(a);
Print2DArray(a);


