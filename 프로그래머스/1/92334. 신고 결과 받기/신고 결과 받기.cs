using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        int[] banned = new int[id_list.Length];
        int[,] reportedBoard = new int[id_list.Length,id_list.Length];
        int[,] reportBoard = new int[id_list.Length,id_list.Length];
        
        Dictionary<string, int> nameToIdxDic = new Dictionary<string, int>();
        for(int i=0; i<id_list.Length; i++)
        {
            nameToIdxDic.Add(id_list[i], i);
        }
        
        for(int i=0; i<report.Length; i++)
        {
            string[] strs = report[i].Split(" ");
            reportBoard[nameToIdxDic[strs[0]] , nameToIdxDic[strs[1]]] = 1;
            reportedBoard[nameToIdxDic[strs[1]] , nameToIdxDic[strs[0]]] = 1;
        }
        
        for(int i=0; i<reportedBoard.GetLength(1); i++)
        {
            int total = 0;
            for(int j=0; j<reportedBoard.GetLength(0); j++)
            {
                total += reportedBoard[i,j];
            }
            banned[i] = total >= k ? total - k + 1 : 0;
        }
        
        for(int i=0; i<reportBoard.GetLength(1); i++)
        {
            for(int j=0; j<reportBoard.GetLength(0); j++)
            {
                if(banned[j] != 0 && reportBoard[i,j] != 0) answer[i]++;
            }
        }
        
        return answer;
    }
}