public class BinarySearchTree
{
    private TreeNode root;

    public BinarySearchTree()
    {
        root = null;
    }

    public bool Search(int key)
    {
        return SearchRecursive(root, key);
    }

    private bool SearchRecursive(TreeNode root, int key)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Key == key)
        {
            return true;
        }
        else if (key > root.Key)
        {
            return SearchRecursive(root.Right, key);
        }
        else
        {
            return SearchRecursive(root.Left, key);
        }
    }

    public void Insert(int key)
    {
        root = InsertRecursive(root, key);
    }

    private TreeNode InsertRecursive(TreeNode root, int key)
    {
        if (root == null)
        {
            root = new TreeNode(key);
            return root;
        }

        if (key < root.Key)
        {
            root.Left = InsertRecursive(root.Left, key);
        }
        else if (key > root.Key)
        {
            root.Right = InsertRecursive(root.Right, key);
        }

        return root;
    }

    public void Delete(int key)
    {
        root = DeleteRecursive(root, key);
    }

    private TreeNode DeleteRecursive(TreeNode root, int key)
    {
        if (root == null)
        {
            return root;
        }

        if (key < root.Key)
        {
            root.Left = DeleteRecursive(root.Left, key);
        }
        else if (key > root.Key)
        {
            root.Right = DeleteRecursive(root.Right, key);
        }
        else
        {
            if (root.Left == null)
            {
                return root.Right;
            }
            else if (root.Right == null)
            {
                return root.Left;
            }

            root.Key = MinValue(root.Right);
            root.Right = DeleteRecursive(root.Right, root.Key);
        }

        return root;
    }

    private int MinValue(TreeNode root)
    {
        int minValue = root.Key;
        while (root.Left != null)
        {
            minValue = root.Left.Key;
            root = root.Left;
        }
        return minValue;
    }

    public void InOrder()
    {
        InOrderRecursive(root);
    }

    private void InOrderRecursive(TreeNode root)
    {
        if (root != null)
        {
            InOrderRecursive(root.Left);
            System.Console.Write(root.Key + " ");
            InOrderRecursive(root.Right);
        }
    }

    public void PreOrder()
    {
        PreOrderRecursive(root);
    }

    private void PreOrderRecursive(TreeNode root)
    {
        if (root != null)
        {
            System.Console.Write(root.Key + " ");
            PreOrderRecursive(root.Left);
            PreOrderRecursive(root.Right);
        }
    }

    public void PostOrder()
    {
        PostOrderRecursive(root);
    }

    private void PostOrderRecursive(TreeNode root)
    {
        if (root != null)
        {
            PostOrderRecursive(root.Left);
            PostOrderRecursive(root.Right);
            System.Console.Write(root.Key + " ");
        }
    }
}