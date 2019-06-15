using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var q = new Queue<char>();

        for (var i = 0; i < s.Length; i++)
        {            
            if (q.Contains(s[i]))
            {
                result = Math.Max(q.Count, result);

                while (q.Dequeue() != s[i]) ;

                if (q.Count + 1 + s.Length - i <= result)
                    return result;
            }

            q.Enqueue(s[i]);
        }

        result = Math.Max(q.Count, result);

        return result;
    }
}