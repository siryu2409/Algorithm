#include <string>
#include <vector>

using namespace std;

int solution(int num) {
    long long ln = num;
    int answer = 0;
    while(ln != 1)
    {
        if((ln % 2) == 0)
        {
            ln /= 2;
        }
        else 
        {
            ln = (ln * 3) + 1;
        }
        answer++;
        if(answer == 500)
            return -1;
    }
    return answer;
}