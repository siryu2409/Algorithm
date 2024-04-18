#include <string>
#include <vector>
#include <iostream>

using namespace std;

int canMakeBurger(vector<int>& arr);

int solution(vector<int> ingredient) {
    int answer = 0;
    vector<int> arr;
    for(int i=0; i<ingredient.size(); i++)
    {
        if(ingredient[i] == 1)
        {
            if(arr.size() > 2)
            {
                if(canMakeBurger(arr))
                {
                    arr.pop_back();
                    arr.pop_back();
                    arr.pop_back();
                    answer++;
                    continue;
                }
            }   
        }
        arr.push_back(ingredient[i]);
    }
    return answer;
}

int canMakeBurger(vector<int>& arr)
{
    int i = arr.size()-1;
    if((arr[i] == 3) && (arr[i-1] == 2) && (arr[i-2] == 1))
    {
        return true;
    }
    return false;
}