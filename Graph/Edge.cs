using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
class Edge
    {
        public Vertex v1, v2;
        public int cost;

        public Edge(Vertex v1, Vertex v2, int cost)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.cost = cost;
        }
    }
}
