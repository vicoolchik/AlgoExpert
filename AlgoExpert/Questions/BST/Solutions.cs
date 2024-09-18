namespace AlgoExpert.BST;

public class Solutions
{
    public static void Run()
    {
        var bst = new BST(10);
        bst.Insert(5).Insert(15).Insert(2).Insert(5).Insert(13).Insert(22).Insert(1).Insert(14);
        Console.WriteLine("Inorder: " + bst.InOrder());
        Console.WriteLine("Preorder: " + bst.PreOrder());
        Console.WriteLine("Postorder: " + bst.PostOrder());
        Console.WriteLine("Contains 5: " + bst.Contains(5));
        Console.WriteLine("Contains 22: " + bst.Contains(22));
        Console.WriteLine("Contains 23: " + bst.Contains(23));
        Console.WriteLine("Min: " + bst.Min());
        Console.WriteLine("Max: " + bst.Max());
        Console.WriteLine("Remove 10: " + bst.Remove(10));
        Console.WriteLine("Inorder: " + bst.InOrder());
    }
    public class BST{
        public int value;
        public BST left;
        public BST right;
        public BST(int value){
            this.value = value;
        }
        public BST Insert(int value){
            if(value < this.value){
                if(left == null){
                    var newBST = new BST(value);
                    left = newBST;
                }else{
                    left.Insert(value);
                }
            }else{
                if(right == null){
                    var newBST = new BST(value);
                    right = newBST;
                }else{
                    right.Insert(value);
                }
            }
            return this;
        }
        public bool Contains(int value){
            if(value < this.value){
                if(left == null){
                    return false;
                }else{
                    return left.Contains(value);
                }
            }else if(value > this.value){
                if(right == null){
                    return false;
                }else{
                    return right.Contains(value);
                }
            }else{
                return true;
            }
        }
        public BST Remove(int value, BST parent = null){
            if(value < this.value){
                if(left != null){
                    left.Remove(value, this);
                }
            }else if(value > this.value){
                if(right != null){
                    right.Remove(value, this);
                }
            }else{
                if(left != null && right != null){
                    this.value = right.Min();
                    right.Remove(this.value, this);
                }else if(parent == null){
                    if(left != null){
                        this.value = left.value;
                        right = left.right;
                        left = left.left;
                    }else if(right != null){
                        this.value = right.value;
                        left = right.left;
                        right = right.right;
                    }else{
                        // Single node tree
                    }
                }else if(parent.left == this){
                    parent.left = left != null ? left : right;
                }else if(parent.right == this){
                    parent.right = left != null ? left : right;
                }
            }
            return this;
        }
        public int Min(){
            if(left == null){
                return value;
            }else{
                return left.Min();
            }
        }
        public int Max(){
            if(right == null){
                return value;
            }else{
                return right.Max();
            }
        }
        public List<int> InOrder(){
            var list = new List<int>();
            if(left != null){
                list.AddRange(left.InOrder());
            }
            list.Add(value);
            if(right != null){
                list.AddRange(right.InOrder());
            }
            return list;
        }
        public List<int> PreOrder(){
            var list = new List<int>();
            list.Add(value);
            if(left != null){
                list.AddRange(left.PreOrder());
            }
            if(right != null){
                list.AddRange(right.PreOrder());
            }
            return list;
        }
        public List<int> PostOrder(){
            var list = new List<int>();
            if(left != null){
                list.AddRange(left.PostOrder());
            }
            if(right != null){
                list.AddRange(right.PostOrder());
            }
            list.Add(value);
            return list;
        }
    }
}
