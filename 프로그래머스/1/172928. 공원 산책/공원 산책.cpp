#include <string>
#include <vector>
#include <iostream>
#include <sstream>

using namespace std;

void set_start();
char get_pos_char(int x, int y);
void move(char direction, int distance);
bool move_up();
bool move_down();
bool move_left();
bool move_right();

int robot_x = 0, robot_y = 0;
int width, height;

vector<string> map;

vector<int> solution(vector<string> park, vector<string> routes) {
    vector<int> answer;
    
    map = park;
    set_start();
    width = park[0].length();
    height = park.size();
    
    for(auto& route : routes){
        char direction;
        int distance;
        
        stringstream ss(route);
        string first, second;
        ss >> first >> second;
        
        direction = first[0];
        distance = stoi(second);
        
        move(direction, distance);
    }
    
    answer.push_back(robot_y);
    answer.push_back(robot_x);
    return answer;
}

void set_start(){
    int x = 0;
    int y = 0;
    for(const string& str : map){
        x = 0;
        for(const char& c : str){
            if(c == 'S'){
                robot_x = x;
                robot_y = y;
                printf("Set Start %i %i \n", x, y);
                return;
            }
            x++;
        }
        y++;
    }
    
}

char get_pos_char(int x, int y){
    printf("(%i, %i) -> (%i, %i) : %c\n", robot_x, robot_y, x, y, map[y][x]);
    return map[y][x];
}

void move(char direction, int distance){
    
    printf("Move %c %i \n", direction, distance);
    int previous_x = robot_x;
    int previous_y = robot_y;
    
    switch(direction){
        case 'N':
            for(int i = 0; i < distance; i++){
                if(move_down() == false){
                    robot_y = previous_y;
                    return;
                }
            }
            break;
        case 'S':
            for(int i = 0; i < distance; i++){
                if(move_up() == false){
                    robot_y = previous_y;
                    return;
                }
            }
            break;
        case 'E':
            for(int i = 0; i < distance; i++){
                if(move_right() == false){
                    robot_x = previous_x;
                    return;
                }
            }
            break;
        case 'W':
            for(int i = 0; i < distance; i++){
                if(move_left() == false){
                    robot_x = previous_x;
                    return;
                }
            }
            break;
    }
}

bool move_up(){
    printf("Move Up\n");
    if(robot_y + 1 < height){
        if(get_pos_char(robot_x, robot_y+1) != 'X'){
            robot_y++;
            return true;
        }
    }
    printf("Move Up false\n");
    return false;
}

bool move_down(){
    printf("Move Down\n");
    if(robot_y - 1 >= 0){
        if(get_pos_char(robot_x, robot_y-1) != 'X'){
            robot_y--;
            return true;
        }
    }
    printf("Move Down false\n");
    return false;
}


bool move_left(){
    printf("Move Left\n");
    if(robot_x - 1 >= 0){
        if(get_pos_char(robot_x-1, robot_y) != 'X'){
            robot_x--;
            return true;
        }
    }
    printf("Move Left false\n");
    return false;
}

bool move_right(){
    printf("Move Right\n");
    if(robot_x + 1 < width){
        if(get_pos_char(robot_x+1, robot_y) != 'X'){
            robot_x++;
            return true;
        }
    }
    printf("Move Right false\n");
    return false;
}
