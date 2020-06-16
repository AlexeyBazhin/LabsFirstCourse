using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    class MyList<T> : IEnumerable<T>
    {
        private Point<T> head;
        private Point<T> tail;
        private int count = 0;
        public int Count { get => count; }
        public MyList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //добавление в коллекцию
        public void Add(T data)
        {
            Point<T> point = new Point<T>(data);

            if (head == null)
            {
                head = point;
            }
            else
            {
                tail.Next = point;
            }
            tail = point;
            count++;
        }

        //удаление из коллекции
        public void Remove(T data)
        {
            Point<T> point = new Point<T>(data);
            Point<T> current = head;
            Point<T> previous = null;
            while (current != null && !current.Equals(point))
            {
                previous = current;
                current = current.Next;
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
            count--;
        }

        //Содержит ли коллекция
        public bool Contains(T data, out int index)
        {
            Point<T> current = head;
            Point<T> point = new Point<T>(data);
            index = 0;
            while (current != null)
            {
                if (current.Equals(point))
                {
                    return true;
                }
                current = current.Next;
                index++;
            }
            return false;
        }

        //индексатор
        public Point<T> this[int index]
        {
            get
            {
                Point<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current;
            }
        }

        //очистить коллекцию
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
            GC.Collect();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Point<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
