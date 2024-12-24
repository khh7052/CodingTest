#include <string>
#include <vector>
#include <algorithm>

using namespace std;

struct Node{
    public:
    int idx, x, y;
    Node* left, *right;
    
    Node(int idx, int x, int y){
        this->idx = idx;
        this->x = x;
        this->y = y;
        left = nullptr;
        right = nullptr;
    }
    
    bool operator<(const Node& other){
        if(y == other.y) return x < other.x;
        return y > other.y;
    }
};

class Tree{
    public:
    Tree() {
        root = nullptr;
    }
    
    Node* root;
    
    void InsertNode(Node* parent, Node* node){
        if(!root){
            root = node;
            return;
        }
        
        // node x가 작을 때
        if(node->x < parent->x){
            // left의 노드와 비교
            if(!parent->left){
                parent->left = node;
                return;
            }
            
            InsertNode(parent->left, node);
        }
        // node x가 클 때
        else{
            if(!parent->right){
                parent->right = node;
                return;
            }
            
            // right의 노드와 비교
            InsertNode(parent->right, node);
        }
    }
    
    void Preorder(Node* node, vector<int>& ans){
        if(!node) return;
        ans.push_back(node->idx);
        Preorder(node->left, ans);
        Preorder(node->right, ans);
    }
    
    void Postorder(Node* node, vector<int>& ans){
        if(!node) return;
        Postorder(node->left, ans);
        Postorder(node->right, ans);
        ans.push_back(node->idx);
    }
};

vector<vector<int>> solution(vector<vector<int>> nodeinfo) {
    vector<vector<int>> answer;
    vector<Node> nodeList;
    Tree tree;
    
    for(int i = 0; i < nodeinfo.size(); i++){
        Node node(i + 1, nodeinfo[i][0], nodeinfo[i][1]);
        nodeList.emplace_back(node);
    }
    
    sort(nodeList.begin(), nodeList.end());
    
    for(auto& node : nodeList){
        tree.InsertNode(tree.root, &node);
    }
    
    vector<int> v1, v2;
    tree.Preorder(tree.root, v1);
    tree.Postorder(tree.root, v2);
    
    answer.push_back(v1);
    answer.push_back(v2);
    
    return answer;
}