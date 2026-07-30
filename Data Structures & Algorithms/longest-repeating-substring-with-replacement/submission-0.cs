public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dt =  new Dictionary<char, int>();
        int res=0, l=0, maxcount=0;
        for(int r=0;r<s.Length;r++){
            if(dt.ContainsKey(s[r])) dt[s[r]]++;
            else dt[s[r]] = 1;
            maxcount = Math.Max(maxcount, dt[s[r]]);
            if((r-l+1)-maxcount>k){
                dt[s[l]]--;
                l++;
            }
            res=Math.Max(res, r-l+1);          
        }
        return res;
    }
}
