public class Solution {
    public int MyAtoi(string s) {
        if (s.Length < 1) return 0;

        string number = string.Empty;
        int sign = 1;
        // step 1 Ignore leading whitespace characters
        s = s.Trim();
        if(s.Length < 1)
            return 0;

        // step 2 Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
        if (s[0].Equals('-'))
        {
            sign = -1;
            s = s.Remove(0, 1); // Remove the sign character for further processing
        }
        else if (s[0].Equals('+'))
        {
            sign = 1;
            s = s.Remove(0, 1); // Remove the sign character for further processing
        }

        //step 3 Read the characters until a non-digit character is encountered
        foreach (char c in s)
        {
            if (!char.IsNumber(c))
                break;
            number += c;

            // step 4 Convert the string to an integer 
            // if the integer is larger or smaller than the range of a 32-bit signed integer we round it down to the nearest 32-bit signed integer
            var stringNumber = long.Parse(number) * sign;

            if (stringNumber <= Int32.MinValue) return Int32.MinValue;
            else if (stringNumber >= Int32.MaxValue) return Int32.MaxValue;
        }
        return number.Length < 1 ? 0 : int.Parse(number) * sign;
    }
}