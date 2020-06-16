using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2
{
    class Point<T>
    {
        public T Data { get; set; }
        public Point<T> Next { get; set; }
        public Point(T data)
        {
            Data = data;
        }
        public override bool Equals(object obj)
        {
            Point<T> point = (Point<T>)obj;
            return Data.Equals(point.Data);
        }
        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}
