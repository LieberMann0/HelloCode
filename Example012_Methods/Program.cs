// Метод. Вид 1. (ни чего не принимает на входе, ни чего не выводит)

void Method1()
{
    Console.WriteLine("Аффтар Пупкин");    //Вывод имени автора.
}
Method1();          // Вызов этого метода.




// Метод. Вид 2. (принимает аргументы, но ни чего не выводит)

void Method2(string msg)
{
    Console.WriteLine(msg);  // Будет выводить сообщение, какое укажут.
}
Method2("Указать текст сообщения, которое нужно вывести");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Указать текст сообщения, которое нужно вывести", 4);  // Вывести текст 4 раза.




// Метод. Вид 3. (не принимает аргументы, только выводит данные)

int Method3();
{
    return DateTime.Now.Year;  //Будет выводить текущий год.
}

int year = Method3();  //Чтобы вызвать метод, нужно создать переменную.
Console.WriteLine(year);




//Метод. Вид 4. (получает аргументы, обрабатывает их и выводит данные)

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  //Пустая строка
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "Текст, который нужно вывести");   //Чтобы вызвать метод, нужно создать переменную. (5 раз вывести текст)
Console.Write(res);




// Цикл for

string Method4(int count, string text)
{
    string result = String.Empty;  //Пустая строка
    
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(5, "z");    //Чтобы вызвать метод, нужно создать переменную. (5 раз вывести z)
Console.WriteLine(res);




// Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}




/*======== Работа с текстом ==========
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".

   Ясна ли задача? */

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "abcdef"
//             012345
// s[3]  d

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();



//  Упорядочивание данных внутри массива

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)  // Метод выводящий массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)  // Метод упорядывающий массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i +1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }    

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray[arr];

SelectionSort[arr];
PrintArray[arr];