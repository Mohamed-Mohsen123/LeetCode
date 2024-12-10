

Console.WriteLine(string.Join(" , ", TwoSum([-3, 4, 3, 90], 0)));


int[] TwoSum(int[] nums, int target)
{
    int[] reslut = new int[2];

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (i == j)
                continue;
            if ((nums[i] + nums[j]) == target)
            {
                reslut[0] = i;
                reslut[1] = j;
                return reslut;
            }
        }
    }
    return reslut;
}
