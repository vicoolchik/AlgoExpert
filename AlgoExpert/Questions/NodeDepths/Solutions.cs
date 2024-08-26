namespace AlgoExpert.NodeDepths;

public class Solutions
{
    public static void Run()
    {
        var root = new BinaryTree(1);
        root.left = new BinaryTree(2);
        root.left.left = new BinaryTree(4);
        root.left.left.left = new BinaryTree(8);
        root.left.left.right = new BinaryTree(9);
        root.left.right = new BinaryTree(5);
        root.right = new BinaryTree(3);
        root.right.left = new BinaryTree(6);
        root.right.right = new BinaryTree(7);
        int result = NodeDepths(root);
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

    public static int NodeDepths(BinaryTree root)
    {
        //O(n) time | O(h) space where n is the number of nodes in the Binary Tree and h is the height of the Binary Tree
        return CalculateNodeDepths(root, 0);
    }

    private static int CalculateNodeDepths(BinaryTree node, int depth)
    {
        if (node == null) return 0;
        return depth + CalculateNodeDepths(node.left, depth + 1) + CalculateNodeDepths(node.right, depth + 1);
    }

    public static int NodeDepthsIterative(BinaryTree root)
    {
        //O(n) time | O(h) space where n is the number of nodes in the Binary Tree and h is the height of the Binary Tree
        int sumOfDepths = 0;
        Stack<(BinaryTree node, int depth)> stack = new Stack<(BinaryTree, int)>();
        stack.Push((root, 0));

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();
            if (node == null) continue;
            sumOfDepths += depth;
            stack.Push((node.left, depth + 1));
            stack.Push((node.right, depth + 1));
        }

        return sumOfDepths;
    }
}
