public class Solution {
    public bool IsAnagram(string s, string t) {
        var dictS = new Dictionary<char, int>();
        for(int i=0; i<s.Length;i++) {
            if(!dictS.ContainsKey(s[i]))
                dictS.Add(s[i], 1);
            else
               dictS[s[i]]++;
        }

        var dictT = new Dictionary<char, int>();
        for(int i=0; i<t.Length;i++) {
            if(!dictT.ContainsKey(t[i]))
                dictT.Add(t[i], 1);
            else
               dictT[t[i]]++;
        }

        if (dictT.Count != dictS.Count)
            return false;

        foreach (var item in dictT)
        {
            if (!dictS.ContainsKey(item.Key))
                return false;
                
            if (dictS[item.Key] != item.Value)
                return false;
        }

        return true;
    }
}
