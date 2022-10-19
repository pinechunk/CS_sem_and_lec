int[] array = { 91, 52, 13, 54, 95, 86, 77, 48, 69 };
int n = array.Length;
int find = 77;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index += 1;
}