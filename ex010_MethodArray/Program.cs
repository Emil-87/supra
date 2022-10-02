int [] array = {13,24,35,47,58,35,14,26,18,};

int n = array.Length;
int find = 35;

int index = 0;

while (index < n)
{

    if(array[index] == find) 
{
        Console.WriteLine(index);
        break;
}
    //index = index +1;
    index++;
}