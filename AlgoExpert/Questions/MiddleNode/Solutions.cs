namespace AlgoExpert.MiddleNode;

public class Solutions
{
    public static void Run()
    {
        var linkedList = new LinkedList(0);
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(4);
        linkedList.Add(5);
        linkedList.Add(6);

        var result = MiddleNode(linkedList);
        Console.WriteLine("Result: " + result.value);
    }
     public class LinkedList{
        public int value;
        public LinkedList next;

        public LinkedList(int value){
            this.value = value;
            this.next = null;
        }

        public void Add(int value){
            var currentNode = this;
            while(currentNode.next != null){
                currentNode = currentNode.next;
            }
            currentNode.next = new LinkedList(value);
        }
     }
     public static LinkedList MiddleNode(LinkedList head){
        var currentNode = head;
        var length = 0;
        while(currentNode != null){
            length++;
            currentNode = currentNode.next;
        }
        var middle = length / 2;
        var middleNode = head;
        for(int i = 0; i < middle; i++){
            middleNode = middleNode.next;
        }
        return middleNode;
     }
}
