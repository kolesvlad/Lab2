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

    public void AddAt(T data, int position)
    {
        if (position > Count)
        {
            throw new IndexOutOfRangeException();
        }
        
        Node<T> newNode = new Node<T>(data);
        Node<T> currentNode = Head;
        
        if (position == 0)
        {
            newNode.Next = currentNode;
            Head = newNode;
            currentNode = currentNode.Next;
        }
        
        int i = 0;
        while(i < position - 1)
        {
            currentNode = currentNode.Next;
            i++;
        }
        
        newNode.Next = currentNode.Next;
        currentNode.Next = newNode;
    }

    public bool Remove(T data)
    {
        Node<T>? current = Head;
        Node<T>? previous = null;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                }
                else
                {
                    Head = Head?.Next;
                    if (Head == null)
                    {
                        Tail = null;
                    }
                }

                Count--;

                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public bool RemoveAt(int position)
    {
        if (Head == null)
        {
            return false;
        }
        
        Node<T> current = Head;
        
        if (position == 0) {
            
            Head = current.Next;
            return true;
        }

        int i = 0;
        while (i < position - 1)
        {
            current = current.Next;
            i++;
        }
        
        Node<T> next = current.Next.Next;
        
        current.Next = next;

        return true;
    }

    public List<T> ConvertToList()
    {
        Node<T> current = Head;
        List<T> result = new List<T>();

        while (current != null)
        {
            result.Add(current.Data);
            current = current.Next;
        }

        return result;
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