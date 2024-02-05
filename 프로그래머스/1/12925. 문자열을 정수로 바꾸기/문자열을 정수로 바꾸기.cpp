#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(string s) {
    int answer = 0;
    int pow = 1;
    for(int i=s.length()-1; i>0; i--)
    {
        answer += (s[i] - '0') * pow;
        pow *= 10;
    }
    
    int isStartWithSign = (s[0] == '-') || (s[0] == '+');
    if(isStartWithSign)
        answer *= (s[0] == '-') ? -1 : 1;
    else
        answer += (s[0] - '0') * pow;
    cout << answer;
    return answer;
}