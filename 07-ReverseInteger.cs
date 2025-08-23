public class Solution {
    public int Reverse(int x) {
        long reverse = 0;
        while(x != 0)
        {
            var r = x % 10;
            reverse = reverse * 10 + r;
            x /= 10;
        }

        return (Int32.MinValue < reverse && reverse < Int32.MaxValue) ? (int)reverse : 0;   
    }
}