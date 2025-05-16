public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var targets = new Dictionary<int,int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int index = 0;
        if (targets.TryGetValue(nums[i], out index))
        {
            return[index, i];
        }
        targets[target - nums[i]] = i;
    }
    return [];
    }
}
