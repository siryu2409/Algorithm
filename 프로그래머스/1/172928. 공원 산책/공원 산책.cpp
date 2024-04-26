#include <string>
#include <vector>

using namespace std;

void tryMove(vector<string>& park, pair<int, int>& start, char direction, int length);

vector<int> solution(vector<string> park, vector<string> routes) {
    int width = park[0].size();
    int height = park.size();
    
    pair<int, int> pos;
    
    for(int i=0; i<height; i++)
    {
        for(int j=0; j<width; j++)
        {
            if(park[i][j] == 'S')
            {
                pos = make_pair(i, j);
            }
        }
    }
    
    for(int i=0; i<routes.size(); i++)
    {
        char direction = routes[i][0];
        int length = stoi(routes[i].substr(2,routes.size()));
        
        tryMove(park, pos, direction, length);
    }
    
    vector<int> answer;
    answer.push_back(pos.first);
    answer.push_back(pos.second);
    return answer;
}

void tryMove(vector<string>& park, pair<int, int>& start, char direction, int length)
{
    int width = park[0].size();
    int height = park.size();
    
    switch(direction)
    {
        case 'N':
            if(start.first - length < 0)
                return;
            else
            {
                for(int i=start.first-1; i>(start.first - length)-1; i--)
                {
                    if(park[i][start.second] == 'X')
                        return;
                }
                start.first -= length;
            }
        break;
        
        case 'S':
            if(start.first + length > (height-1))
                return;
            else
            {
                for(int i=start.first+1; i<(start.first + length)+1; i++)
                {
                    if(park[i][start.second] == 'X')
                        return;
                }    
                start.first += length;
            }  
        break;
        
        case 'E':
            if(start.second + length > (width-1))
                return;
            else
            {
                for(int i=start.second+1; i<(start.second + length)+1; i++)
                {
                    if(park[start.first][i] == 'X')
                        return;
                }    
                start.second += length;
            }
        break;
            
        case 'W':
            if(start.second - length < 0)
                return;
            else
            {
                for(int i=start.second-1; i>(start.second - length)-1; i--)
                {
                    if(park[start.first][i] == 'X')
                        return;
                }    
                start.second -= length;
            }    
        break;
    }
}