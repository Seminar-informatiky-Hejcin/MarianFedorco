namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList();
        list.Add("Ahoj");
        list.Add("Pepo");
        Console.WriteLine(list.Get(1));
    }
}

class Node
{
    public string Value { get; set; }
    public Node Next { get; set; }

    public Node(string value)
    {
        this.Value = value;
    }
}

class LinkedList
{
    private Node first;
    private Node last;

    public void Add(string value)
    {
        var node = new Node(value);
        if (this.first == null)
        {
            this.first = node;
        }
        else
        {
            last.Next = node;
        }

        this.last = node;
    }

    public void Remove(int index)
    {
        var node = Search(index);
        if (node == this.first)
        {
            this.first = node.Next;
        }
        else
        {
            var previousNode = Search(index - 1);
            previousNode.Next = node.Next;

            if (node == this.last)
            {
                this.last = previousNode;
            }
        }
    }

    private Node Search(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Index is less than zero!!!");
        }

        var currentNode = this.first;
        for (int i = 0; i < index; i++)
        {
            if (currentNode == null)
            {
                throw new IndexOutOfRangeException("Index is bigger than range!!!");
            }
            currentNode = currentNode.Next;
        }

        return currentNode;
    }

    public string Get(int index)
    {
        return Search(index).Value;
    }

    public void Modify(int index, string value)
    {
        Search(index).Value = value;
    }
}