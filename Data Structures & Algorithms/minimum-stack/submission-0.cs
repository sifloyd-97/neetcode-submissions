public class MinStack {
    private Stack<int> st;
    private Stack<int> minst;

    public MinStack() {
        st = new Stack<int>();
        minst = new Stack<int>();   
    }
    
    public void Push(int val) {
        st.Push(val);
        int min = Math.Min(val, minst.Count == 0?val : minst.Peek());
        minst.Push(min);
    }
    
    public void Pop() {
        st.Pop();
        minst.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minst.Peek();
    }
}
