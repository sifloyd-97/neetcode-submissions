public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] hashS = new int[26];
        int[] hashW = new int[26];
        int windowLength = s1.Length;

        // Build initial frequency counts
        for (int i = 0; i < windowLength; i++) {
            hashS[s1[i] - 'a']++;
            hashW[s2[i] - 'a']++;
        }

        // Slide the window across s2
        for (int i = 0; i <= s2.Length - windowLength; i++) {
            if (IsHashSame(hashS, hashW)) return true;

            // Slide: remove left char, add right char
            if (i + windowLength < s2.Length) {
                hashW[s2[i] - 'a']--;
                hashW[s2[i + windowLength] - 'a']++;
            }
        }

        return false;
    }

    private bool IsHashSame(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
