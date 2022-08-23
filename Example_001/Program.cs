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


int max = Max(
    Max(a, b, c), 
    Max(d, e, f), 
    Max(g, k, l));

Console.WriteLine(max);