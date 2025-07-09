public class Solution {
    public string LongestPalindrome(string s)
    {

        int mid=0;
        int start = 0, end = 0;
        while (mid < s.Length)
        {

            int oddCase = ExpandfromMiddle(s, mid, mid + 1);
            int evenCase = ExpandfromMiddle(s, mid, mid);

            int longestCase = Math.Max(evenCase, oddCase);

            if(longestCase > end - start)
            {
                start = mid - (longestCase - 1) / 2;
                end = mid + longestCase / 2;
            }
            mid++;
        }
        return s.Substring(start, end - start + 1);
    }

    public int ExpandfromMiddle(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }
}