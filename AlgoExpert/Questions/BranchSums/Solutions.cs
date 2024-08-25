namespace AlgoExpert.BranchSums;

public class Solutions
{
    public class BinaryTree {
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value) {
      this.value = value;
      this.left = null;
      this.right = null;
    }
  }
  public static void Run()
  {
    var root = new BinaryTree(1);
    root.left = new BinaryTree(2);
    root.right = new BinaryTree(3);
    root.left.left = new BinaryTree(4);
    root.left.right = new BinaryTree(5);
    root.right.left = new BinaryTree(6);
    root.right.right = new BinaryTree(7);
    root.left.left.left = new BinaryTree(8);
    root.left.left.right = new BinaryTree(9);
    root.left.right.left = new BinaryTree(10);
    var result = BranchSums(root);
    Console.WriteLine("Result: " + string.Join(", ", result));
  }

  public static List<int> BranchSums(BinaryTree root) {
    var sums = new List<int>();
    CalculateBranchSumsWithStack(root,  sums);
    return sums;
  }

    private static void CalculateBranchSums(BinaryTree node, int runningSum, List<int> sums)
    {
        //O(n) time | O(n) space where n is the number of nodes in the Binary Tree
        if (node == null) return;
        var newRunningSum = runningSum + node.value;
        if (node.left == null && node.right == null)
        {
        sums.Add(newRunningSum);
        return;
        }
        CalculateBranchSums(node.left, newRunningSum, sums);
        CalculateBranchSums(node.right, newRunningSum, sums);
    }

    private static void CalculateBranchSumsWithStack(BinaryTree node, List<int> sums)
{
    // O(n) time | O(n) space where n is the number of nodes in the Binary Tree
    if (node == null) return;

    Stack<(BinaryTree node, int runningSum)> stack = new Stack<(BinaryTree, int)>();
    stack.Push((node, 0));

    while (stack.Count > 0)
    {
        var (currentNode, runningSum) = stack.Pop();
        var newRunningSum = runningSum + currentNode.value;

        if (currentNode.left == null && currentNode.right == null)
        {
            sums.Add(newRunningSum);
            continue;
        }

        if (currentNode.right != null)
        {
            stack.Push((currentNode.right, newRunningSum));
        }

        if (currentNode.left != null)
        {
            stack.Push((currentNode.left, newRunningSum));
        }
    }
}

}
