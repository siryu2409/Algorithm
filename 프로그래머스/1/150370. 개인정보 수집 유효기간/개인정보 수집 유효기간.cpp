#include <string>
#include <vector>
#include <iostream>
#include <sstream>

using namespace std;

int stringToDate(string &today);

vector<int> solution(string today, vector<string> terms, vector<string> privacies) {
    vector<int> answer;
    vector<int> iterms('Z'-'A'+1);
    
    int dateToday = stringToDate(today);
    
    for(int i=0; i<terms.size(); i++)
    {   
        stringstream ss;
        stringstream ss2;
        string temp;
        char c;
        int date;
        ss.str(terms[i]);
        getline(ss, temp, ' ');
        ss2 << temp;
        ss2 >> c;
        getline(ss, temp, ' ');
        ss2 << temp;
        ss2 >> date;
        iterms[c-'A'] = date * 28; 
    }
    
    for(int i=0; i<privacies.size(); i++)
    {
        stringstream ss;
        string temp;
        char c;
        int date = 0;
        
        ss.str(privacies[i]);
        getline(ss, temp, ' ');
        date = stringToDate(temp);
        
        getline(ss, temp, ' ');
        c = temp[0];
        date += iterms[c-'A'];
        
        if(date <= dateToday)
        {
            answer.push_back(i+1);
        }
    }
    
    return answer;
}

int stringToDate(string &today)
{
    stringstream ss;
    string temp;
    int date = 0;
    
    ss.str(today);
    
    getline(ss, temp, '.');
    date += (stoi(temp)) * 336;
    
    getline(ss, temp, '.');
    date += (stoi(temp)) * 28;
    
    getline(ss, temp, '.');
    date += (stoi(temp));
    
    return date;
}
