int[] array = { 12, 2, 23, 42, 5, 62, 23, 28 };

int n = array.Length;

int find = 23;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

