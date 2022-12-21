/* int Max(int arg1, int arg2, int arg3)
{ 
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0  1  2  3  4  5  6  7  8
int [] array = {14,62,33,24,66,87,38,29,32};

int result = Max(
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8]));
Console.WriteLine(result); */

// int[] array = {1,12,4,46,15,16,4,96};
// int n = array.Length;
// int find = 4;

// int index = 0;
// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }

//     index++;
// }

void FillArray(int[] somearray)
{
    int lenght = somearray.Length;
    int index = 0;
    while (index < lenght)
    {
        somearray[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] arrray)
{
    int dlina = arrray.Length;
    int position = 0;
    while (position < dlina)
    {
        Console.WriteLine(arrray[position]);
        position++;
    }
}

int IndexOf(int[] somearray, int find)
{
    int count = somearray.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(somearray[index] == find)
        {
            position = index;
        }
    
    index++;
    }
    return position;
}
int[] somearray = new int[10];

FillArray(somearray);
PrintArray(somearray);
Console.WriteLine();

int pos = IndexOf(somearray, 4);
Console.WriteLine(pos);