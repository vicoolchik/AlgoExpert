namespace AlgoExpert.DepthFirstSearch;

public class Solutions
{
    public static void Run()
    {
        var graph = new Node("A");
        graph.AddChild("B").AddChild("E").AddChild("F");
        graph.AddChild("C").AddChild("G");
        graph.AddChild("D").AddChild("H").AddChild("I").AddChild("J");
        var result = graph.DepthFirstSearch(new List<string>());
        Console.WriteLine("Result: " + string.Join(", ", result));
    }

    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }
        public List<string> DepthFirstSearch(List<string> array)
        {
            // O(v + e) time | O(v) space where v is the number of vertices and e is the number of edges
            array.Add(name);
            foreach (var child in children)
            {
                child.DepthFirstSearch(array);
            }
            return array;
        }
        public Node AddChild(string name)
        {
            var child = new Node(name);
            children.Add(child);
            return this;
        }
    }
}
