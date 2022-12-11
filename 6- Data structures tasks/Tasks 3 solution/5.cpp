#include <iostream>
using namespace std;

class Node
{
public:
    int data;
    Node *left;
    Node *right;
    int h;
};

/// New node creation ////////////////////////////////////////////////////////////////////

Node* CreateNode(int x)
{
    Node *node = new Node();
    node->data = x;
    node->left = NULL;
    node->right = NULL;
    node->h = 1;
    return (node);
}

/// Get max //////////////////////////////////////////////////////////////////////////////

int max(int a, int b)
{
    return (a > b) ? a : b;
}

/// Calculate height /////////////////////////////////////////////////////////////////////

int CalculateHeight(Node *N)
{
    if (N == NULL)
    {
        return 0;
    }
    else
    {
        return N->h;
    }

}

/// Rotate right /////////////////////////////////////////////////////////////////////////

Node* rightRotate(Node* y)
{
    Node* x = y->left;
    Node* T2 = x->right;
    x->right = y;
    y->left = T2;
    y->h = max(CalculateHeight(y->left) , CalculateHeight(y->right)) +1 ;
    x->h = max(CalculateHeight(x->left) , CalculateHeight(x->right)) +1 ;
    return x;
}

/// Rotate left /////////////////////////////////////////////////////////////////////////

Node* leftRotate(Node* x)
{
    Node* y = x->right;
    Node* T2 = y->left;
    y->left = x;
    x->right = T2;
    x->h = max(CalculateHeight(x->left), CalculateHeight(x->right)) +1 ;
    y->h = max(CalculateHeight(y->left), CalculateHeight(y->right)) +1 ;
    return y;
}

/// Get the balance factor of each node //////////////////////////////////////////////////

int getBalanceFactor(Node *N)
{
    if (N == NULL)
    {
        return 0;
    }
    else
    {
        return CalculateHeight(N->left) - CalculateHeight(N->right);
    }
}

/// Insert a node /////////////////////////////////////////////////////////////////////////

Node* insertNode(Node* node, int x)
{
    /// Find the correct position and insert the node
    if (node == NULL)
    {
       return CreateNode(x);
    }

    if (x < node->data)
    {
        node->left = insertNode(node->left, x);
    }

    else if (x > node->data)
    {
        node->right = insertNode(node->right, x);
    }

    else
    {
       return node;
    }

/// Update the balance factor of each node and balance the tree

    node->h = 1 + max(CalculateHeight(node->left), CalculateHeight(node->right));

    int balanceFactor = getBalanceFactor(node);

    if (balanceFactor > 1)
    {
        if (x < node->left->data)
        {
            return rightRotate(node);
        }
        else if (x > node->left->data)
        {
            node->left = leftRotate(node->left);
            return rightRotate(node);
        }
    }
    if (balanceFactor < -1)
    {
        if (x > node->right->data)
        {
            return leftRotate(node);
        }
        else if (x < node->right->data)
        {
            node->right = rightRotate(node->right);
            return leftRotate(node);
        }
    }
    return node;
}

/// Node with minimum value ///////////////////////////////////////////////////////////////

Node* nodeWithMimumValue(Node* node)
{
    Node* current = node;

    while (current->left != NULL)
    {
       current = current->left;
    }

    return current;
}

/// Delete a node /////////////////////////////////////////////////////////////////////////

Node* deleteNode(Node* node, int x)
{
    /// Find the node and delete it
    if (node == NULL)
    {
        return node;
    }
    if (x < node->data)
        node->left = deleteNode(node->left, x);
    else if (x > node->data)
        node->right = deleteNode(node->right, x);
    else
    {
        if ((node->left == NULL) ||
                (node->right == NULL))
        {
            Node *temp = node->left ? node->left : node->right;
            if (temp == NULL)
            {
                temp = node;
                node = NULL;
            }
            else
                *node = *temp;
            free(temp);
        }
        else
        {
            Node *temp = nodeWithMimumValue(node->right);
            node->data = temp->data;
            node->right = deleteNode(node->right,temp->data);
        }
    }

    if (node == NULL)
        return node;

    /// Update the balance factor of each node and balance the tree

    node->h = 1 + max(CalculateHeight(node->left), CalculateHeight(node->right));

    int balanceFactor = getBalanceFactor(node);

    if (balanceFactor > 1)
    {
        if (getBalanceFactor(node->left) >= 0)
        {
            return rightRotate(node);
        }
        else
        {
            node->left = leftRotate(node->left);
            return rightRotate(node);
        }
    }
    if (balanceFactor < -1)
    {
        if (getBalanceFactor(node->right) <= 0)
        {
            return leftRotate(node);
        }
        else
        {
            node->right = rightRotate(node->right);
            return leftRotate(node);
        }
    }
    return node;
}

/// Print the tree //////////////////////////////////////////////////////////////////////////

void printTree(Node* node, string indent, bool last)
{
    if (node != NULL)
    {
        cout << indent;
        if (last)
        {
            cout << "R----";
            indent += "   ";
        }
        else
        {
            cout << "L----";
            indent += "|  ";
        }
        cout << node->data << endl;
        printTree(node->left, indent, false);
        printTree(node->right, indent, true);
    }
}

int main()
{
    Node *node = NULL;
    node = insertNode(node, 44);
    node = insertNode(node, 14);
    node = insertNode(node, 54);
    node = insertNode(node, 10);
    node = insertNode(node, 22);
    node = insertNode(node, 62);
    node = insertNode(node, 9);
    node = insertNode(node, 12);
    printTree(node, "", true);
    node = deleteNode(node, 14);
    cout << "After deleting 14" << endl;
    printTree(node, "", true);
}
