﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}//              0  1  2  3  4  5  6  7  8
int [] array = {13,24,35,47,58,65,14,26,18,};
array[0] = 12;
Console.WriteLine(array[0]);
