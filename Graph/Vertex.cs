using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Vertex
    {
        public int x, y;
        public char name;
        public Vertex(char name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
