#include <string>
#include <vector>

using namespace std;

vector<vector<int>> solution(vector<vector<int>> arr1, vector<vector<int>> arr2) {
    vector<vector<int>> answer;
    
    for(int m = 0; m < arr1.size(); m++){
        vector<int> v;
        for(int n = 0; n < arr2[0].size(); n++){
            int sum = 0;
            for(int k = 0; k < arr1[0].size(); k++){
                sum += arr1[m][k] * arr2[k][n];
            }
            v.push_back(sum);
        }
        answer.push_back(v);
    }
    
    /*
    vector<vector<int>> answer;
    int m = arr1.size();
    int n = arr2[0].size();
    int k = arr2.size();
    
    for(int i = 0; i < m; i++){
        vector<int> v;
        
        for(int j = 0; j < n; j++){
            int sum = 0;
            vector<int> rowV = arr1[i];
            vector<int> columnV;
            
            for(int q = 0; q < k; q++)
                columnV.push_back(arr2[q][j]);
            
            for(int q = 0; q < k; q++)
                sum += rowV[q] * columnV[q];
            
            v.push_back(sum);
        }
        answer.push_back(v);
    }
    */
    return answer;
}