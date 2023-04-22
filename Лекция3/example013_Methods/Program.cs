//Вид 1
void Method1()
{
    System.Console.WriteLine("Автор Алёна");
}

//Method1();

//Вид2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

// Method2("Текст сообщения");

void Method21(string msg, int count)
{
   int i = 0;
   while (i< count)
   {
    System.Console.WriteLine(msg);
    i++;
   }
}

// Method21("Текст", 4);
// Method21(count: 5, msg: "text");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// System.Console.WriteLine(year);

// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; /*string result = "";*/
//     while (i < count)
//     {
//       result = result +text;
//       i++;  
//     }
//     return result;
// }

// string res = Method4(10,"Aluo");
// System.Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
      result = result +text;
    }
    return result;
}

string res = Method4(10,"Aluo");
// System.Console.WriteLine(res);

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }


string text = "Расцветает дух, как роза мая,"
+"Как огонь, он разрывает тьму."
+"Тело, ничего не понимая,"
+"Слепо повинуется ему.";

string Replace(string text, char OldValue, char NewValue)
{
    string result;
    result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) 
        {result +=$"{NewValue}";}
        else {result += $"{text[i]}";}
       
    }

    return result;
}

// string NewText = Replace(text, 'к', 'К');
// System.Console.WriteLine(NewText);

int[] arr = {1,5,6,7,8,1,2,4,3};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
       int  minPosition = i;
        for (int j = i; j < array.Length; j++)
        {
            if(array[j]< array[minPosition]) minPosition = j;
        }

       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition]= temporary;
    }
}

PrintArray(arr);
//  
void SelectionSort1(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
       int  maxPosition = i;
        for (int j = i; j < array.Length; j++)
        {
            if(array[j]> array[maxPosition]) maxPosition = j;
        }

       int temporary = array[i];
       array[i] = array[maxPosition];
       array[maxPosition]= temporary;
    }
}

SelectionSort1(arr);
PrintArray(arr);