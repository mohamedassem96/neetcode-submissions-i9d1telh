public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var listOfLists = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();
        for(var i=0; i<strs.Length; i++)
        {
            var str = strs[i];
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var sorted = new string(charArr);
            if(!dict.ContainsKey(sorted))
                dict.Add(sorted, new List<string> { str });
            else
                dict[sorted].Add(str);
        }

        foreach(var item in dict)
        {
            listOfLists.Add(item.Value);
        }

        return listOfLists;
    }
}
