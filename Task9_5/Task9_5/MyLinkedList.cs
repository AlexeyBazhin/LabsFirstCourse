using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_5
{
    class MyLinkedList : IEnumerable
    {

        public Point head;

        public Point tail;

        public int Count { get; private set; } = 0;

        public MyLinkedList(int n)
        {
            if (n != 1)
            {
                MyLinkedList prevList = new MyLinkedList(n - 1);
                prevList.Add(n);
                head = prevList.head;
                tail = prevList.tail;
                Count = prevList.Count;
            }
            else
                this.Add(n);
        }

        public void Add(int n)
        {
            Point point = new Point(n);

            if (head == null)
            {
                head = point;
            }
            else
                tail.Next = point;
            tail = point;
            Count++;
        }

        public void Remove(int n, Point current, Point previous)
        {
            if (current != null && !current.Equals(new Point(n)))
            {
                Remove(n, current.Next, current);
                return;
            }

            if (current == null)
            {
                Console.WriteLine("Объект не найден");
                return;
            }

            if (previous == null)
            {
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                    Console.WriteLine("\nКоллекция стала пустой!\n");
                }
            }
            else
            {
                previous.Next = current.Next;
                if (current.Next == null)
                    tail = previous;
            }
            Count--;
        }

        public bool Contains(int n, Point current)
        {
            if (current == null)
                return false;

            if (current.Equals(new Point(n)))
                return true;

            return Contains(n, current.Next);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            Point current = head;
            while (current != null)
            {
                yield return current.Node;
                current = current.Next;
            }
        }
    }
}
