namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList<string>();
        list.Add("Ahoj");
        list.Add("Pepo");
        Console.WriteLine(list.Get(1));

        var list2 = new LinkedList<int>();
        list2.Add(12);
        Console.WriteLine(list2.Get(0));
    }
}

class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        this.Value = value;
    }
}

class LinkedList<T>
{
    private Node<T> first;
    private Node<T> last;

    public void Add(T value)
    {
        var node = new Node<T>(value);
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

    private Node<T> Search(int index)
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

    public T Get(int index)
    {
        return Search(index).Value;
    }

    public void Modify(int index, T value)
    {
        Search(index).Value = value;
    }
}