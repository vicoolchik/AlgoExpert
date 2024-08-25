namespace AlgoExpert;

public class Solutions
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
    }
    public static void Run()
    {
        var root = new BST(10);
        root.left = new BST(5);
        root.right = new BST(15);
        root.left.left = new BST(2);
        root.left.right = new BST(5);
        root.left.left.left = new BST(1);
        root.right.left = new BST(13);
        root.right.right = new BST(22);
        root.right.left.right = new BST(14);
        var result = FindClosestValueInBst(root, 12);
        Console.WriteLine("Result: " + result);
    }

    public static int FindClosestValueInBst(BST tree, int target)
    {
        //Average: O(log(n)) time | O(1) space
        //Worst: O(n) time | O(1) space
        var closestValue = tree.value;
        var currentNode = tree;
        while (currentNode != null)
        {
            if (Math.Abs(target - closestValue) > Math.Abs(target - currentNode.value))
            {
                closestValue = currentNode.value;
            }
            if (target < currentNode.value)
            {
                currentNode = currentNode.left;
            }
            else if (target > currentNode.value)
            {
                currentNode = currentNode.right;
            }
            else
            {
                break;
            }
        }
        return closestValue;
    }
    public static int FindClosestValueInBst1(BST tree, int target, int closest = Int32.MaxValue)
    {
        //Average: O(log(n)) time | O(log(n)) space
        //Worst: O(n) time | O(n) space
        if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
        {
            closest = tree.value;
        }
       if (target < tree.value && tree.left != null){
           return FindClosestValueInBst1(tree.left, target, closest);
       } else if (target > tree.value && tree.right != null){
           return FindClosestValueInBst1(tree.right, target, closest);
       } else {
           return closest;
       }
    }
}
