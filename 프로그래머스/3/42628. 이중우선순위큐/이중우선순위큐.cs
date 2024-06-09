using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations) {
        SortedDictionary<int, int> sortedList = new SortedDictionary<int, int>();
        
        int[] answer = new int[2] {0, 0};
        
        for(int i=0; i<operations.Length; i++)
        {
            if(operations[i][0] == 'I')
            {
                int key = int.Parse(operations[i].Substring(2));
                if(!sortedList.ContainsKey(key))
                    sortedList.Add(key, 0);
                sortedList[key]++;
            }
            else
            {
                if(operations[i][2] == '1')
                {
                    if(sortedList.Count != 0)
                    {
                        if(sortedList[sortedList.Keys.Last()] == 1)
                            sortedList.Remove(sortedList.Keys.Last());
                        else
                            sortedList[sortedList.Keys.Last()]--;
                    }
                }
                else
                {
                    if(sortedList.Count != 0)
                    {
                        if(sortedList[sortedList.Keys.First()] == 1)
                            sortedList.Remove(sortedList.Keys.First());
                        else
                            sortedList[sortedList.Keys.First()]--;
                    }
                }
            }
        }
        
        if(sortedList.Count != 0)
        {
            answer[0] = sortedList.Keys.Last();
            answer[1] = sortedList.Keys.First();
        }
        
        return answer;
    }
}