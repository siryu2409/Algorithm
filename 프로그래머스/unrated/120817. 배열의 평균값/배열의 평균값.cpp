#include <string>
#include <vector>

using namespace std;

double solution(vector<int> numbers) {
    int total = 0;
    for(int i=0; i<numbers.size(); i++)
    {
        total += numbers[i];
    }
    double answer = (double)total / numbers.size();
    return answer;
}