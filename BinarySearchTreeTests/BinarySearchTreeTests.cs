using Xunit;

public class BinarySearchTreeTests
{
    [Fact]
    public void Insert_SingleNode_ShouldInsertCorrectly()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);

        Assert.True(bst.Search(10));
    }

    [Fact]
    public void Insert_MultipleNodes_ShouldInsertCorrectly()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);

        Assert.True(bst.Search(10));
        Assert.True(bst.Search(5));
        Assert.True(bst.Search(15));
    }

    [Fact]
    public void Delete_LeafNode_ShouldDeleteCorrectly()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);

        bst.Delete(5);

        Assert.False(bst.Search(5));
    }

    [Fact]
    public void Delete_NodeWithOneChild_ShouldDeleteCorrectly()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(12);

        bst.Delete(15);

        Assert.False(bst.Search(15));
        Assert.True(bst.Search(12));
    }

    [Fact]
    public void Delete_NodeWithTwoChildren_ShouldDeleteCorrectly()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(12);
        bst.Insert(18);

        bst.Delete(15);

        Assert.False(bst.Search(15));
        Assert.True(bst.Search(12));
        Assert.True(bst.Search(18));
    }

    [Fact]
    public void InOrderTraversal_ShouldReturnSortedOrder()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(12);
        bst.Insert(18);

        using (var sw = new System.IO.StringWriter())
        {
            System.Console.SetOut(sw);
            bst.InOrder();
            var result = sw.ToString().Trim();
            Assert.Equal("5 10 12 15 18", result);
        }
    }

    [Fact]
    public void PreOrderTraversal_ShouldReturnPreOrder()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(12);
        bst.Insert(18);

        using (var sw = new System.IO.StringWriter())
        {
            System.Console.SetOut(sw);
            bst.PreOrder();
            var result = sw.ToString().Trim();
            Assert.Equal("10 5 15 12 18", result);
        }
    }

    [Fact]
    public void PostOrderTraversal_ShouldReturnPostOrder()
    {
        var bst = new BinarySearchTree();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(12);
        bst.Insert(18);

        using (var sw = new System.IO.StringWriter())
        {
            System.Console.SetOut(sw);
            bst.PostOrder();
            var result = sw.ToString().Trim();
            Assert.Equal("5 12 18 15 10", result);
        }
    }
}