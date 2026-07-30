public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] freq = new int[26];

        foreach(char ch in s){
            freq[ch-'a'] +=1;
        }
        foreach(char ch in t){
            freq[ch-'a']-=1;
        }

        foreach(int count in freq){
            if(count!=0) return false;
        }
        return true;
    }
}
