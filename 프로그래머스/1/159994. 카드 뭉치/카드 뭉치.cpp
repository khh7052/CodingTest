#include <string>
#include <vector>
#include <queue>

using namespace std;

string solution(vector<string> cards1, vector<string> cards2, vector<string> goal) {
    queue<string> cardQ1, cardQ2, goalQ;
    
    for(auto& card : cards1){
        cardQ1.push(card);
    }
    
    for(auto& card : cards2){
        cardQ2.push(card);
    }
    
    for(auto& card : goal){
        goalQ.push(card);
    }
    
    while(!goalQ.empty()){
        string currentCard = goalQ.front();
        goalQ.pop();
        
        bool findCard = false;
        string card1 = "", card2 = "";
        
        if(!cardQ1.empty()){
            if(cardQ1.front() == currentCard){
                cardQ1.pop();
                findCard = true;
            }
        }
        
        if(!cardQ2.empty()){
            if(cardQ2.front() == currentCard){
                cardQ2.pop();
                findCard = true;
            }
        }
        
        if(!findCard) return "No";
    }
    
    return "Yes";
}