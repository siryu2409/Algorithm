#include <string>
#include <vector>
#include <algorithm>

using namespace std;

long long solution(long long n) {
    vector<int> vec;
    long long answer = 0;
    while(n > 0)
    {
        vec.push_back(n % 10);
        n /= 10;
    }
    sort(vec.rbegin(), vec.rend());
    for(int i=0; i<vec.size(); i++)
    {
        answer *= 10;
        answer += vec[i];
    }
    return answer;
}