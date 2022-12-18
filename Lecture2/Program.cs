// See https://aka.ms/new-console-template for more information
//Example 1 
/*
Console.Write("Input X  "); double numberX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a  "); double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("result F "+f(numberX,numberA));
double f(double x, double a)
{
    double result = x * x + x + a;
    return result;
}
*/


/*

int a1 = 4543;
int a2 = 3234;
int a3 = 101;
int a4 = 1;
int a5 = 45;
int a6 = 34;
int a7 = 105;
int a8 = -1;
int a9 = 100;
int result = a1;
result = Max(Max(result, a2);
result = Max(result, a3);
result = Max(result, a4);
result = Max(result, a5);
result = Max(result, a6);
result = Max(result, a7);
result = Max(result, a8);
result = Max(result, a9);
Console.WriteLine("max is " + result);
*/

//Function Max
/*
int Max(int a, int b)
{
    int result = a;
    if (b > result) result = b;
    return result;
}
/*
//Array
int[] array = { 12, 34, 284, 85, 399, 13 };

int count = 1;
int result = array[0];
while (count < array.lenght)
{
    result = Max(result, array[count]);
    count++;
}
Console.WriteLine("max is " + result);
*/
/*
int[] array = { 12, 34, 284, 85, 399, 13 };
int index = 0; int result = -1;
int size = array.Length;
int target = 1;
while (index < size)
{
    if (array[index] == target)
    {
        result = index;
        break;
    }
    index++;
}
Console.WriteLine("index is " + result);

*/

void FillArray(int[] collection)
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1, size);
        index++;
    }
}

void PrintArray(int[] col)
{
    int size = col.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(col[index] + ", ");
        index++;
    }
}
int IndexOf(int[] collection, int find)
{
    int index = 0; int size = collection.Length;
    int result = -1;
    while (index < size)
    {
        if (collection[index] == find)
        {
            result = index;
            break;
        }
        index++;
    }
    return result;

}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int findnum = new Random().Next(1, 10);
int index = IndexOf(array, findnum);
Console.WriteLine();
if (index == -1)
{
    Console.Write("looking for  " + findnum+ " not found");
}
else
{
    Console.Write("looking for  " + findnum + " index is " + index);
}


