namespace AlgoExpert.RemoveDuplicatesFromLinkedList;

public class Solutions
{
    public static void Run()
    {
        var linkedList = new LinkedList(0);
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(4);
        linkedList.Add(4);
        linkedList.Add(5);
        linkedList.Add(6);

        var result = RemoveDuplicatesFromLinkedList(linkedList);
        while (result != null)
        {
            Console.WriteLine("Result: " + result.value);
            result = result.next;
        }
    }

    public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
    {
        // O(n) time | O(1) space where n is the number of nodes in the linked list
        var currentNode = linkedList;
        while (currentNode != null)
        {
            var nextDistinctNode = currentNode.next;
            while (nextDistinctNode != null && nextDistinctNode.value == currentNode.value)
            {
                nextDistinctNode = nextDistinctNode.next;
            }
            currentNode.next = nextDistinctNode;
            currentNode = nextDistinctNode;
        }
        return linkedList;
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }

        public void Add(int value)
        {
            var currentNode = this;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = new LinkedList(value);
        }
    }

}
