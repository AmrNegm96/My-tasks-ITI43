#include <iostream>

using namespace std;
///////////////////////////////////// TREE NODE /////////////////////////////////////////////////////
typedef struct treeNode
{
    int data;
    treeNode* leftPtr;
    treeNode* rightPtr;
} treeNode;

///////////////////////////////////// TREE HEAD /////////////////////////////////////////////////////

treeNode* Ptreenode;

///////////////////////////////////// CREATE NODE /////////////////////////////////////////////////////

treeNode* createNode(int x)
{
    treeNode* node = new treeNode();

    node->data=x;
    node->leftPtr = NULL;
    node->rightPtr = NULL;

    return node;
}

///////////////////////////////////// COUNT NODES /////////////////////////////////////////////////////
int countNodes(treeNode* node)
{
    if (node == NULL)
    {
        return 0;
    }
    else
    {
        return countNodes((node->leftPtr)) + 1 + (countNodes(node->rightPtr));
    }
}


///////////////////////////////////// TRAVERSE /////////////////////////////////////////////////////

void traverseInorder(treeNode* node)
{
    if (node == NULL )
    {
        return;
    }
    /// print left

    traverseInorder(node->leftPtr);

    ///print head node

    cout<< node->data << " , " ;

    ///print right

    traverseInorder(node->rightPtr);
}

///////////////////////////////////// SEARCH IN BINARY SEARCH TREE /////////////////////////////////////////////////////

treeNode* searchNodeBST (treeNode* node, int x)
{
    if (node == NULL )
    {
        return NULL;
        cout<< "Not found" <<endl;
    }
    else if ( x == node->data)
    {
        return node;
        cout<<"Found"<<endl;
    }
    else if ( x < node->data)
    {
        return searchNodeBST( (node->leftPtr), x );
    }
    else
    {
        return searchNodeBST( (node->rightPtr), x );
    }
    return node;
}

///////////////////////////////////// insertNodeBST IN BINARY SEARCH TREE /////////////////////////////////////////////////////

treeNode* insertNodeBST (treeNode* node, int x)
{
    if (node == NULL )
    {
        node = createNode(x);
        cout << "New Node With Value " << x << " Created!" << endl;
    }
    else if (node->data == x)
    {
        cout << "Value " << x << " Already Exists!" << endl;
    }
    else if ( x < node->data)
    {
        node->leftPtr = insertNodeBST( (node->leftPtr), x );
    }
    else
    {
        node->rightPtr = insertNodeBST( (node->rightPtr), x );
    }
    return node;

}
///////////////////////////////////// DELETION FROM BINARY SEARCH TREE /////////////////////////////////////////////////////

/// Find the in order successor ///

treeNode* minimumValueOn_Right_SubTree(treeNode* node)
{
    treeNode* current = node ;

    // Find the leftmost leaf

    while (current && current->leftPtr != NULL)
    {
        current = current->leftPtr;
    }

    return current;
}

treeNode* deleteNodeBST(treeNode* node, int x)
{
    treeNode* Pdelete = node ;
    ///if tree is empty
    if (node == NULL )
    {
        cout<< "The tree is empty" << endl;
    }
    /// Find the node to be deleted
    if(x < node->data)
    {
        node->leftPtr = deleteNodeBST(node->leftPtr, x);
    }
    else if (x > node->data)
    {
        node->rightPtr = deleteNodeBST(node->rightPtr, x);
    }
    /// delete operation ///
    else
    {
        /// case 1 : delete leaf node ///
        if(node->leftPtr == NULL && node->rightPtr == NULL)
        {
            delete Pdelete ;
        }
        /// case 2 : node that have only single child ///
        /// only right child
        else if (node->leftPtr == NULL)
        {
            node = node->rightPtr;
            delete Pdelete;
        }
        ///only left child
        else if (node->rightPtr == NULL)
        {
            node = node->leftPtr;
            delete Pdelete;
        }
        /// case 3 : node that have 2 childs ///
        else
        {
            /// go to the right (largest values) and get the smallest value from it
            treeNode* temp = minimumValueOn_Right_SubTree(node->rightPtr);

            /// Place the in order successor in position of the node to be deleted
            node->data = temp->data ;

            /// Delete the in order successor

            node->rightPtr = deleteNodeBST(node->rightPtr, temp->data);
        }

    }

    return node;
}

///////////////////////////////////// MAIN /////////////////////////////////////////////////////

int main()
{
    treeNode* node = NULL;
    node = insertNodeBST(node, 8);

    cout<< "The number of nodes now is: " << countNodes(node) <<endl;

    node = insertNodeBST(node, 3);
    node = insertNodeBST(node, 1);
    node = insertNodeBST(node, 6);
    node = insertNodeBST(node, 7);
    node = insertNodeBST(node, 10);
    node = insertNodeBST(node, 14);
    node = insertNodeBST(node, 4);
    node = insertNodeBST(node, 8);

    cout<< "The number of nodes now is: " << countNodes(node) <<endl;

    cout << "\n Traverse: \n";
    traverseInorder(node);
    cout << "\n \n";
    cout << "\n After deleting 10 \n";
    cout << "\n \n";
    node = deleteNodeBST(node, 10);
    cout << "\n Traverse: \n";
    traverseInorder(node);
    cout << "\n \n";
}
