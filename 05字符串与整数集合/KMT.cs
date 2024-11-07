using System;
using System.Collections.Generic;

class KMPSearch
{
    public static List<int> KMPSearchPattern(string text, string pattern)
    {
        List<int> matches = new List<int>();
        int[] lps = ComputeLPSArray(pattern);

        int textIndex = 0;
        int patternIndex = 0;

        while(textIndex < text.Length)
        {
            if(pattern[patternIndex] == text[textIndex])
            {
                patternIndex++;
                textIndex++;
            }

            if(patternIndex == pattern.Length)
            {
                matches.Add(textIndex - patternIndex);
                patternIndex = lps[patternIndex - 1];
            }
            else if(textIndex < text.Length && pattern[patternIndex] != text[textIndex])
            {
                if(patternIndex != 0)
                {
                    patternIndex = lps[patternIndex - 1];
                }
                else
                {
                    textIndex++;
                }
            }
        }

        return matches;
    }

    private static int[] ComputeLPSArray(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int length = 0; // Length of the previous longest prefix suffix

        lps[0] = 0; // lps[0] is always 0
        int i = 1;

        while(i < pattern.Length)
        {
            if(pattern[i] == pattern[length])
            {
                length++;
                lps[i] = length;
                i++;
            }
            else
            {
                if(length != 0)
                {
                    length = lps[length - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }

        return lps;
    }
}
