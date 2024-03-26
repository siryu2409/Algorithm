#include <string>
#include <vector>

using namespace std;

int returnBottle(int a, int b, int n);

int solution(int a, int b, int n) {
    int answer = returnBottle(a, b, n);
    return answer;
}

int returnBottle(int a, int b, int n)
{
    if(n < a) return 0;
    return ((n/a)*b) + returnBottle(a, b, ((n/a)*b) + (n%a));
}