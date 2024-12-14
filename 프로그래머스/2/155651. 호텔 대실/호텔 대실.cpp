#include <string>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

struct Room {
    int startTime;
    int endTime;

    bool operator>(const Room& other) const {
        return startTime > other.startTime;
    }

    Room(int start, int end) : startTime(start), endTime(end) {}
};

int TimeToInt(string time){
    return stoi(time.substr(0, 2)) * 60 + stoi(time.substr(3, 2));
}

int solution(vector<vector<string>> book_time) {
    int answer = 0;
    int usingRoom = 0;
    priority_queue<Room, vector<Room>, greater<Room>> readyRooms;
    priority_queue<int, vector<int>, greater<int>> usingRooms;
    
    for(auto& book : book_time){
        int startTime = TimeToInt(book[0]);
        int endTime = TimeToInt(book[1]) + 10;
        
        Room room(startTime, endTime);
        readyRooms.push(room);
    }
    
    while(!readyRooms.empty()){
        Room room = readyRooms.top();
        
        // 시간확인해서 퇴실처리
        while(!usingRooms.empty()){
            int endTime = usingRooms.top();
            if(room.startTime >= endTime){
                usingRooms.pop();
                usingRoom--;
            }
            else break;
        }
        
        // 사용중인 방 추가
        usingRooms.push(room.endTime);
        answer = max(answer, ++usingRoom);
        readyRooms.pop();
    }
    
    return answer;
}