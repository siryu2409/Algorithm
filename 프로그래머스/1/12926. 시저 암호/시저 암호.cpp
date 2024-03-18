#include <string>
#include <vector>

using namespace std;

char PushChar(char c, int n);

string solution(string s, int n) {
    string answer = "";
    answer.reserve(s.length());
    
    for(int i=0; i<s.length(); i++)
    {
        answer.push_back(PushChar(s[i], n));
    }
    
    return answer;
}

char PushChar(char c, int n)
{
    if(c >= 'a' && c <= 'z')
    {
        c = 'a' + ((c - 'a' + n) % ('z'-'a' + 1));
    }
    else if(c >= 'A' && c <= 'Z')
    {
        c = 'A' + ((c - 'A' + n) % ('Z'-'A' + 1));
    }
    return c;
}