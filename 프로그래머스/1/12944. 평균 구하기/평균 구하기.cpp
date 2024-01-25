#include <string>
#include <vector>

using namespace std;

double solution(vector<int> arr) {
    int total = 0;
    for(auto i : arr)
    {
        total += i;
    }
    double answer = (double)total / arr.size();
    return answer;
}