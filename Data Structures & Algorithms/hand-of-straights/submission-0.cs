public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if(hand.Length % groupSize != 0){
            return false;
        }

        SortedDictionary<int, int> handCount = new SortedDictionary<int, int>();

        foreach(int card in hand){
            handCount[card] = handCount.TryGetValue(card, out int count)?count+1: 1;
        }

        while(handCount.Count != 0){
            int first = handCount.First().Key;
            for(int i=0; i<groupSize; i++){
                int current = first+i;
                if (!handCount.ContainsKey(current)){
                    return false;
                }
                int count = handCount[current];
                if(count ==1){
                    handCount.Remove(current);
                }
                else{
                    handCount[current] -= 1;
                }
            }
        }
        return true;

    }
}
