using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        int minx = wallpaper[0].Length;
        int maxx = 0;
        int miny = wallpaper.Length;
        int maxy = 0;
        
        for(int i=0; i<wallpaper.Length; i++)
        {
            for(int j=0; j<wallpaper[0].Length; j++)
            {
                if(wallpaper[i][j] == '#')
                {
                    if(j < minx)
                        minx = j;
                    if(j > maxx)
                        maxx = j;
                    if(i < miny)
                        miny = i;
                    if(i > maxy)
                        maxy = i;
                }
            }   
        }
        
        answer[0] = miny;
        answer[1] = minx;
        answer[2] = maxy + 1;
        answer[3] = maxx + 1;
        
        return answer;
    }
}