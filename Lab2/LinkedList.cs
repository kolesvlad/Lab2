namespace Lab2;

public class LinkedList<T>
{
    private Node<T>? Head; // посилання на перший елемент
    private Node<T>? Tail; // посилання на останній елемент
    private int Count; // загальна кількість елементів

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
                // якщо вузол в середині або в кінці
                if (previous != null)
                {
                    // видаляємо вузол current, Tenep previous вказує не на current, а на current.Next
                    previous.Next = current.Next;
                    
                    // якщо current.Next не встановлений, значить вузол останній,
                    // змінюємо змінну tail
                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                }
                else
                {
                    // якщо видаляється перший елемент
                    // змінюємо значення head
                    Head = Head?.Next;
                    
                    // якщо після видалення список порожній то скидаємо tail
                    if (Head == null)
                    {
                        Tail = null;
                    }
                }

                Count--;

                return true;
            }

            previous = current; //продовжуємо просуватись по списку
            current = current.Next;
        }

        return false; // якщо елемента з вказаним значенням не знайшли
    }

    public bool RemoveAt(int position)
    {
        // якщо список пустий
        if (Head == null)
        {
            return false;
        }
        
        // збереження голови списку
        Node<T> current = Head;
        
        // якщо треба видалити голову
        if (position == 0) {
            
            // змінити голову
            Head = current.Next;
            return true;
        }

        // знаходимо попередній вузол вузла який треба видалити
        int i = 0;
        while (i < position - 1)
        {
            current = current.Next;
            i++;
        }
        
        // якщо позиція більша за кількість вузлів
        if (current == null || current.Next == null)
            return false;
        
        // зберігаємо посилання на вузол після вузла який потрібно видалити
        Node<T> next = current.Next.Next;
        
        // видаляємо вузол зі списку
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