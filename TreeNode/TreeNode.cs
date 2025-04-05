public class TreeNode
{
    public int Key { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int item)
    {
        Key = item;
        Left = Right = null;
    }
}
