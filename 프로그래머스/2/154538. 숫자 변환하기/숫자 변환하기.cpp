#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(int x, int y, int n)
{
    vector<int> dp(y + 1, 1000001); // 초기화
    dp[x] = 0; // 시작점 x의 연산 횟수는 0

    for (int i = x; i <= y; i++) {
        if (dp[i] == 1000001) continue; // 도달 불가능한 값은 건너뜀

        // i + n
        if (i + n <= y) dp[i + n] = min(dp[i + n], dp[i] + 1);

        // i * 2
        if (i * 2 <= y) dp[i * 2] = min(dp[i * 2], dp[i] + 1);

        // i * 3
        if (i * 3 <= y) dp[i * 3] = min(dp[i * 3], dp[i] + 1);
    }

    return (dp[y] == 1000001) ? -1 : dp[y];
}
