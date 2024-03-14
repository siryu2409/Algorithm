#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<vector<int>> sizes) {
    int answer = 0;
    int biggest_w = 0;
    int biggest_h = 0;
    
    for(int i=0; i<sizes.size(); i++)
    {
        if (sizes[i][0] < sizes[i][1])
        {
            std::swap(sizes[i][0], sizes[i][1]);
        }
        if (sizes[i][0] > biggest_w)
        {
            biggest_w = sizes[i][0];
        }
        if (sizes[i][1] > biggest_h)
        {
            biggest_h = sizes[i][1];
        }
    }
    answer = biggest_w * biggest_h;
    return answer;
}