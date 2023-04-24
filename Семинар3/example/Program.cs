int[] GetArrayFromString(string arrayAsString)
{
string[] strings = arrayAsString.Split(", ");
int[] array = new int[strings.Length];

for (int i = 0; i < array.Length; i++)
{
array[i] = int.Parse(strings[i]);
}

return array;
}


void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " - ");
}
}

void UpdateArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] = arr[i] + 1;
}
}

int[] array = GetArrayFromString(Console.ReadLine());

PrintArray(array);
UpdateArray(array);
Console.WriteLine();
PrintArray(array);