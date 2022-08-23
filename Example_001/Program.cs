int Max(int argl, int arg2, int arg3)
{
    int result = argl;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a = 5;
int b = 4;
int c = 18;
int d = 89;
int e = 45;
int f = 187;
int g = 57;
int k = 49;
int l = 1800;

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, k, l);

int max = Max(max1, max2, max3);

Console.WriteLine(max);