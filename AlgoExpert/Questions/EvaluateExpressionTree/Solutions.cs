namespace AlgoExpert.EvaluateExpressionTree;

public class Solutions
{
    public static void Run()
    {
        var root = new BinaryTree(-1);
        root.left = new BinaryTree(-2);
        root.right = new BinaryTree(-3);
        root.left.left = new BinaryTree(-4);
        root.left.right = new BinaryTree(2);
        root.right.left = new BinaryTree(8);
        root.right.right = new BinaryTree(3);
        root.left.left.left = new BinaryTree(2);
        root.left.left.right = new BinaryTree(3);
        var result = EvaluateExpressionTree(root);
        Console.WriteLine("Result: " + result);
    }
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public static int EvaluateExpressionTree(BinaryTree root)
    {
        //O(n) time | O(h) space where n is the number of nodes in the Binary Tree and h is the height of the Binary Tree
        return CalculateExpressionTree(root);
    }

    public static int CalculateExpressionTree(BinaryTree node)
    {
        if (node.value >= 0)
        {
            return node.value;
        }
        var leftValue = CalculateExpressionTree(node.left);
        var rightValue = CalculateExpressionTree(node.right);
        if (node.value == -1)
        {
            return leftValue + rightValue;
        }
        else if (node.value == -2)
        {
            return leftValue - rightValue;
        }
        else if (node.value == -3)
        {
            return leftValue * rightValue;
        }
        else
        {
            return leftValue / rightValue;
        }
    }
}
