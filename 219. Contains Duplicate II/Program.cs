/*
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

 

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
0 <= k <= 105
*/

using System.Text.Json.Serialization;

Console.WriteLine(ContainsNearbyDuplicate([1,0,1,1], 3));


//better sol
bool ContainsNearbyDuplicate(int[] nums, int k)
{
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        // Check if the difference in indices is less than or equal to k
        if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
            return true;
        // Update the index of the current number
        map[nums[i]] = i;
    }

    return false;
}


// bool ContainsNearbyDuplicate(int[] nums, int k)
// {
//     for (int i = 0; i < nums.Length; i++)
//     {
//         for (int j = 0; j < nums.Length; j++)
//         {
//             if (i != j && nums[i] == nums[j] && Math.Abs(i - j) <= k)
//                 return true;
//         }
//     }
//     return false;
// }