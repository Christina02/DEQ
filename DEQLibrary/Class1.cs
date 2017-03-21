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
        DoublyNode<T> head; // головной/первый элемент
        DoublyNode<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке
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
