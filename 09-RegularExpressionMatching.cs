public class Solution {
    public bool IsMatch(string s, string p) {
        int m = s.Length + 1, n = p.Length + 1;
        bool[,] r = new bool[m, n];
        r[0, 0] = true;

        for(int j = 1; j < n; j++)
        {
            if(p[j - 1] == '*')
                r[0,j] = r[0,j-2];
        }
        for(int i = 1; i < m; i++)
        {
            for (int j = 1; j <n; j++)
            {
                if(p[j - 1] == '*')
                {
                    r[i, j] = (p[j - 2] == '.' || p[j - 2] == s[i - 1]) && (r[i - 1, j] || r[i,j]) || r[i, j-2];
                }
                else
                {
                    r[i,j] = r[i - 1, j - 1] && (s[i - 1] == p[j - 1] || p[j - 1] == '.');
                }
            }
        }

        return r[m -1 , n - 1];
    }
}