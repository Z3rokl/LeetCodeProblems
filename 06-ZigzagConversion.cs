public class Solution
{
    public string Convert(string s, int numRows)
    {
        if(numRows < 2) return s;

        string[] rows = new string[numRows];

        int dir = -1;
        int rowIndex = 0;

        for(int i = 0; i<s.Length; i++)
        {
            if (rowIndex == 0 || rowIndex == numRows - 1 )
            {
                dir = dir * -1;
            }
            rows[rowIndex] += s[i];
            rowIndex += dir;
        }

        string result = string.Empty;
        
        foreach (string row in rows)
        {
            result += row;
        }
        return result;
    }
}




