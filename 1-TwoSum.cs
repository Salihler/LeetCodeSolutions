using System.Collections.Generic;

public class TwoSumClass
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numsDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            numsDict.Add(i, nums[i]);
        }
        foreach (var item in numsDict)
        {
            foreach (var item2 in numsDict)
            {
                if (item.Key != item2.Key && item.Value + item2.Value == target)
                {
                    return new int[] { item.Key, item2.Key };
                }
            }
        }
        return nums;
    }
}