namespace Lab2;

public class LinkedList<T>
{
    private Node<T>? Head;
    private Node<T>? Tail;
    private int Count;

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        if (Head == null)
        {
            Head = node;
        }
        else
        {
            Tail.Next = node;
        }

        Tail = node;

        Count++;
    }
    
    
}

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}