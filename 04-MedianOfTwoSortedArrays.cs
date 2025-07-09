public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);
        
        int x = nums1.Length;
        int y = nums2.Length;
        int low = 0;
        int high = x;
        
        while(low <= high)
        {
            int partX = (low + high) / 2;
            int partY = (x + y + 1) / 2 - partX;

            int LX = (partX == 0) ? int.MinValue : nums1[partX - 1];
            int RX = (partX == x) ? int.MaxValue : nums1[partX];

            int LY = (partY == 0) ? int.MinValue : nums2[partY - 1];
            int RY = (partY == y) ? int.MaxValue : nums2[partY];

            if (LX <= RY && LY <= RX)
            {
                if ((x + y) % 2 == 0)
                    return (double)(Math.Max(LY, LX) + Math.Min(RY, RX)) / 2;
                else
                    return Math.Max(LX, LY);
            }
            else if (LX > RY)
                high = partX - 1;
            else
                low = partX + 1;
        }
        throw new ArgumentException();
    }
}