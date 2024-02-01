#include <string>
#include <vector>

using namespace std;

vector<long long> solution(int x, int n) {
    vector<long long> answer;
    long long now = 0;
    while(n > 0)\
    {
        now += x;
        answer.push_back(now);
        n--;
    }
    return answer;
}