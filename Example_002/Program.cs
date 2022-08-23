int Max(int argl, int arg2, int arg3)
{
    int result = argl;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 21, 56, 76, 89, 65, 80, 45, 67 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);