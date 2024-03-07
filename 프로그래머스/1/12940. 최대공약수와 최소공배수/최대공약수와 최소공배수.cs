public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = n < m ? n : m;
        int mg = 1;
        for(int i=2; i<min+1; i++)
        {
            if((n % i == 0) && (m % i == 0))
                mg = i;
        }
        answer[0] = mg;
        answer[1] = n * m / mg;
        
        return answer;
    }
}