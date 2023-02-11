int[] array = {10, 21, 23, 44, 15, 46, 87, 87};

int n = array.Length;
int find = 87;

int index = 0;

while(index < n) 
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
