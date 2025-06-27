using System.Collections.Generic;

/// <Question>
/// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string. Return the merged string.
/// </Question>

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2) {
        var word11 = word1.Chunk(1);
        var word22 = word2.Chunk(1);     
    }
}