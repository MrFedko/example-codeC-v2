int[] array = { 21, 42, 74, 96, 201, 22, 42, 536, 22 };
int n = array.Length;
int find = 22;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
