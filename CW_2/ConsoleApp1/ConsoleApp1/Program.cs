﻿Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static int getAverage(int[] nums)
{
    var sum_konflikt_main = 0;
    foreach (var num in nums)
    {
        sum_konflikt_main += num;
    }

    return sum_konflikt_main / nums.Length;
}
int[] nums = {1,2,3,4,5};
var average = getAverage(nums);
Console.WriteLine(average);

static int getMaxValue(int[] nums)
{
    var max = int.MinValue;
    foreach (var num in nums)
    {
        if (num > max) max = num;
    }
    return max;
}