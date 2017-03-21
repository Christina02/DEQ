using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DEQLibrary
{
    //Двойной узел
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        //данные
        public T Data { get; set; }
        //предыдущий
        public DoublyNode<T> Previous { get; set; }
        //следующий
        public DoublyNode<T> Next { get; set; }
    }

    public class Deque<T> : IEnumerable<T>  // двусвязный список
    {
        public static DoublyNode<T> head; // головной/первый элемент
        public static DoublyNode<T> tail; // последний/хвостовой элемент
        public static int count;  // количество элементов в списке

        //добавление в начало
        public static void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        //добавление в конец
        public static void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        //удаление первого
        public static int RemoveFirst()
        {
            
            return 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
