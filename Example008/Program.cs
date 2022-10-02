int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 2;
int b1 = 3;
int c1 = 6;
int a2 = 7;
int b2 = 4567;
int c2 = 5;
int a3 = 1;
int b3 = 9;
int c3 = 8;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));


Console.WriteLine(max);