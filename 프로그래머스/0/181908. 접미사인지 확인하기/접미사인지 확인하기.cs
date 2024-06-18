using System;

public class Solution {
    public int solution(string my_string, string is_suffix)
    {
        int len1 = my_string.Length;
        int len2 = is_suffix.Length;
        if (len2 > len1)
        {
            return 0;
        }
        for (int i = 0; i < len2; i++)
        {
            if (my_string[len1 - len2 + i] != is_suffix[i])
            {
                return 0;
            }
        }
        return 1;
    }
}