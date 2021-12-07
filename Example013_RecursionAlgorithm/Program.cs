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
    Console.WriteLine(Fibonacci(i));
}



 // На семинаре


void Fill2DArray(int[,] a)
{
    for(int i = 0; i < GetLength(0); i++)       // 
    {                                           // создаются элементы массива
        for(int j = 0; j < GetLength(1); j++)   // 
        {                                       // 
            a[i, j] = i * 10 + j;               // элементы массива заполняются значениями
        }                                       //
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


// рекурсия

void Loop(int i)
{
    Console.Write($"{i} ");
    if(i < 10) Loop(i + 1);
}
Loop(1);



//Сщбрать сточку с числами от a до b, a<=b.

//Итеративный подход
string NumbersFor(int a, int b)
{
	string result = String.Empty;
	for (int i = a; i <= b; i++)
	{
		result += $"{i} ";
	}
	return result;
}

Console.WriteLine(NumbersFor(1, 10));

//Итеративный подход (собрать в обратную сторону)
string NumbersFor(int a, int b)
{
	string result = String.Empty;
	for (int i = b; i >= a; i--)
	{
		result += $"{i} ";
	}
	return result;
}

Console.WriteLine(NumbersFor(1, 10));


// Использование рекурсии
string NumberRec(int a, int b)
{
	if (a <= b) return $"{a} " + NumberRec(a + 1, b);
	else return String.Empty;
}

Console.WriteLine(NumberRec(1, 10));

// Использование рекурсии (собрать в обратную сторону)
string NumberRec(int a, int b)
{
	if (a <= b) return NumberRec(a + 1, b) + $"{a} ";
	else return String.Empty;
}

Console.WriteLine(NumberRec(1, 10));



//Сумма чисел от 1 до n

//Итеративный подход
int SumFor(int n)
{
    int result  = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine(SumFor(10));

// Использование рекурсии
int SumRec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else return n + SumRec(n + 1);
}

Console.WriteLine(SumRec(10));


//Вычислить a в степени n

//Итеративный подход
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine(PowerFor(2, 10));

// Использование рекурсии
int PowerRec(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else return PowerRec(a, n - 1) * a;
}   // вышенаписанное можно написать одной строкой: return n == 0 ? 1 : PowerRec(a, n - 1) * a;

Console.WriteLine(PowerRec(2, 10));

//или
int PowerRecMath(int a, int n)
{
    if (n == 0)
    {
        return 1;
    }
    else if (n % 2 == 0)
    {
        return PowerRecMath(a * a, n / 2);
    }
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10));


/* Перебор слов

В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в". Показпть
все слова, состоящие из T букв, которые можно построить из букв этого алфавита*/

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("асив", new char[2]);


//Как посмотреть содержимое папки

string path = @""; // В кавычках указывается путь к директории
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}

//Пример с рекурсией
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();

    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @""; // В кавычках указывается путь к директории
CatalogInfo(path);


//Игра "Пирамидки"

void Towers(string with = "1", string on = "3", string some = "2", int count = "3")
{
    if (count > 1)
    {
        Towers(with, some, on, count - 1);
    }
    Console.WriteLine($"{with} >> {on}");
    if (count > 1)
    {
        Towers(some, on, with, count - 1);
    }
}
Towers();


//Обход разных структур

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2     3    4    5    6    7    8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))
        {
            InOrderTraversal(left);
        }
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])
        {
            InOrderTraversal(right);
        }
    }
}
InOrderTraversal();