public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        Dictionary<char, char> dt = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        foreach(char ch in s){
            if(dt.ContainsKey(ch)){
                if(st.Count>0 && st.Peek()==dt[ch]){
                    st.Pop();
                }
                else return false;
            }
            else st.Push(ch);
        }
        return st.Count ==0;
    }
}
