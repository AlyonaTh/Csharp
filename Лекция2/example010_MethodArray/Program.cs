int[] array = {1, 12, 13, 4, 45, 46, 4, 46};

int n = array.Length;
int find = 4;

int index= 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}