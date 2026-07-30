public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0, result=0;
        HashSet<char> ch = new HashSet<char>();

        for(int r=0;r<s.Length;r++){
            while(ch.Contains(s[r])){
                ch.Remove(s[l]);
                l++;
            }
            ch.Add(s[r]);
            result = Math.Max(result, r-l+1);
        }
        return result;
    }
}
