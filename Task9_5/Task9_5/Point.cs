using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_5
{
    class Point
    {
        public int Node { get; set; }
        public Point Next { get; set; }
        public Point(int n)
        {
            Node = n;
        }

        public override string ToString()
        {
            return Node.ToString();
        }

        public override bool Equals(object obj)
        {
            Point point = (Point)obj;
            return Node.Equals(point.Node);
        }
        public override int GetHashCode()
        {
            return Node.GetHashCode();
        }
    }
}
