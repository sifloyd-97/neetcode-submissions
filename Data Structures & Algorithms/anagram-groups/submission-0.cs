public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            int[] count = new int[26];
            foreach(char ch in s){
                count[ch-'a']++;
            }
            string key = string.Join(",",count);
            if(!result.ContainsKey(key)){
                result[key] = new List<string>();
            }
            result[key].Add(s);
        }
        return result.Values.ToList<List<string>>();
    }
}
