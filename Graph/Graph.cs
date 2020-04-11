using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        private List<Vertex> _vertexs = new List<Vertex>();
        private List<Edge> _edges = new List<Edge>();
        private Dictionary<Vertex, bool> visited;
        private Dictionary<Vertex, bool> comps;
        public Dictionary<Vertex, int> distances = new Dictionary<Vertex, int>();
        public List<Vertex> vertexs
        {
            get
            {
                return _vertexs;
            }
            set
            {
                _vertexs = value;
            }
        }
        public List<Edge> edges
        {
            get
            {
                return _edges;
            }
            set
            {
                _edges = value;
            }
        }
        public Vertex AddVertex(char nameVert, int x = -1, int y = -1)
        {
            if (nameVert == ' ')
                nameVert = GetNameVertex();
            Vertex thisVert = _vertexs.FirstOrDefault(t => t.name == nameVert);
            if (thisVert == null)
                _vertexs.Add(new Vertex(nameVert, x, y));
            return _vertexs.FirstOrDefault(t => t.name == nameVert);
        }

        public Vertex AddVertex(Vertex v)
        {
            if (!_vertexs.Contains(v))
                _vertexs.Add(v);
            return v;
        }

        private char GetNameVertex()
        {
            for (int i = 65; i < 91; i++)
                if (_vertexs.FirstOrDefault(t => t.name == (char)(i)) == null) return (char)(i);
            for (int i = 97; i < 122; i++)
                if (_vertexs.FirstOrDefault(t => t.name == (char)(i)) == null) return (char)(i);
            return ' ';
        }
        public Edge AddEdge(Vertex v1, Vertex v2, int cost = 0)
        {
            Edge thisEdge = _edges.FirstOrDefault(t => t.v1 == v1 && t.v2 == v2);
            if (thisEdge == null)
                _edges.Add(new Edge(v1, v2, cost));
            else if (thisEdge.cost != cost)
                thisEdge.cost = cost;
            return _edges.FirstOrDefault(t => t.v1 == v1 && t.v2 == v2);
        }

        public Edge AddEdge(Edge edge)
        {
            if (!_edges.Contains(edge))
                _edges.Add(edge);
            return edge;
        }

        public void RemoveVertex(char nameVert)
        {
            Vertex thisVert = _vertexs.FirstOrDefault(t => t.name == nameVert);
            if (thisVert != null)
            {
                _vertexs.Remove(thisVert);
                foreach (var e in _edges.Where(t => t.v1 == thisVert || t.v2 == thisVert).ToList())
                    _edges.Remove(e);
            }
        }
        public void RemoveVertex(Vertex v)
        {
            Vertex thisVert = _vertexs.FirstOrDefault(t => t.name == v.name);
            if (thisVert != null)
            {
                _vertexs.Remove(thisVert);
                foreach (var e in _edges.Where(t => t.v1 == thisVert || t.v2 == thisVert).ToList())
                    _edges.Remove(e);
            }
        }
        public void RemoveEdge(Vertex v1, Vertex v2)
        {
            Edge thisEdge = _edges.FirstOrDefault(t => t.v1 == v1 && t.v2 == v2);
            if (thisEdge != null)
                _edges.Remove(thisEdge);
        }
        public void RemoveEdge(char v1, char v2)
        {
            Vertex Vert1 = _vertexs.FirstOrDefault(t => t.name == v1);
            Vertex Vert2 = _vertexs.FirstOrDefault(t => t.name == v2);
            if (Vert1 != null && Vert2 != null)
            {
                Edge thisEdge = _edges.FirstOrDefault(t => t.v1 == Vert1 && t.v2 == Vert2);
                if (thisEdge != null)
                    _edges.Remove(thisEdge);
            }

        }
        public int[,] CreateAdjacencyMatrix()
        {
            int[,] matrix = new int[_vertexs.Count, _vertexs.Count];
            for (int i = 0; i < _vertexs.Count; i++)
                for (int j = 0; j < _vertexs.Count; j++)
                {
                    var edge = _edges.FirstOrDefault(t => t.v1 == _vertexs[i] && t.v2 == _vertexs[j]);
                    if (edge != null)
                    {
                        if (edge.cost == 0)
                            matrix[i, j] = 1;
                        else matrix[i, j] = edge.cost;
                    }
                    else matrix[i, j] = 0;
                }
            return matrix;
        }
        public Graph DownloadAdjacencyMatrix(int[,] matrix, int[,] coords = null, List<Vertex> new_vertexs = null)
        {
            Graph g = new Graph();
            g.vertexs = new List<Vertex>();
            g.edges = new List<Edge>();
            if (new_vertexs == null)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                    if (coords != null)
                        g.AddVertex(g.GetNameVertex(), coords[i, 0], coords[i, 1]);
                    else
                        g.AddVertex(g.GetNameVertex(), -1, -1);
            }
            else
                foreach (var v in new_vertexs)
                    g._vertexs.Add(v);

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (matrix[i, j] != 0) g.AddEdge(g.vertexs[i], g.vertexs[j], matrix[i, j]);
            return g;
        }
        public int[,] MakeNonOriented()
        {
            int[,] matrix = CreateAdjacencyMatrix();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (matrix[i, j] != 0)
                        matrix[j, i] = matrix[i, j];
            return matrix;
        }
        public Dictionary<Vertex, int> MarkAllVertex(Vertex v_start, Vertex v_end, Dictionary<Vertex, int> visited_v, int d = 0)
        {
            d = 0;
            visited_v[v_start] = d;
            while (!visited_v.ContainsKey(v_end) && d < _vertexs.Count)
            {
                Dictionary<Vertex, int> _visited = new Dictionary<Vertex, int>();
                foreach (var h in visited_v.Keys)
                    if (visited_v[h] == d)
                        foreach (Edge edge in _edges)
                            if (edge.v1 == h && !visited_v.ContainsKey(edge.v2))
                                _visited.Add(edge.v2, d + 1);
                d++;
                foreach (var h in _visited.Keys)
                    visited_v.Add(h, _visited[h]);
            }
            return visited_v;
        }
        public List<Vertex> Wave(Vertex v_start, Vertex v_end)
        {
            List<Vertex> way = new List<Vertex>();
            Dictionary<Vertex, int> _visited = new Dictionary<Vertex, int>();
            _visited = MarkAllVertex(v_start, v_end, _visited);
            int[,] matrix = MakeNonOriented();
            Graph g = DownloadAdjacencyMatrix(matrix, null, _vertexs);
            Vertex last_vertex = v_end;
            if (_visited.ContainsKey(v_end))
            {
                while (last_vertex.name != v_start.name)
                    foreach (Edge edge in g.edges)
                        if (edge.v1.name == last_vertex.name && _visited.ContainsKey(edge.v2))
                            if (_visited[edge.v2] == _visited[last_vertex] - 1)
                            {
                                last_vertex = edge.v2;
                                if (edge.v2.name != v_start.name)
                                    way.Add(edge.v2);
                                break;
                            }
                way.Add(v_start);
                way.Reverse();
                way.Add(v_end);
                return way;
            }
            return null;
        }
        public int[,] ReachabilityMatrix()
        {
            List<int[,]> pows = new List<int[,]>();
            int[,] adj_matrix = CreateAdjacencyMatrix();
            for (int i = 2; i < adj_matrix.GetLength(0); i++)
                pows.Add(MatrixExt.BoolPowMatrix(adj_matrix, i + 1));
            foreach (var mat in pows)
                adj_matrix = MatrixExt.BoolPlusMatrix(adj_matrix, mat);
            adj_matrix = MatrixExt.BoolPlusMatrix(adj_matrix, MatrixExt.GenerateE(adj_matrix.GetLength(0)));
            return adj_matrix;
        }
        public int[,] StrongLinkedMatrix()
        {
            int[,] T = ReachabilityMatrix();
            int[,] transposed = MatrixExt.TransposedMatrix(T);
            return MatrixExt.ConjuctionMatrix(T, transposed);
        }
        public void DFS(Vertex v, Dictionary<Vertex, bool> visited, Dictionary<Vertex, bool> comps)
        {
            comps[v] = true;
            visited[v] = true;
            foreach (Edge e in _edges)
                if (e.v1 == v && !visited.ContainsKey(e.v2))
                    DFS(e.v2, visited, comps);
        }
        public List<List<Vertex>> StrongConnectivityComponents()
        {
            visited = new Dictionary<Vertex, bool>();
            comps = new Dictionary<Vertex, bool>();
            var _comp = new List<Vertex>();
            List<List<Vertex>> comp = new List<List<Vertex>>();
            foreach (Vertex v in _vertexs)
                if (!visited.ContainsKey(v))
                {
                    DFS(v, visited, comps);
                    foreach (Vertex vert in comps.Keys)
                        _comp.Add(vert);
                    comp.Add(_comp);
                    comps = new Dictionary<Vertex, bool>();
                    _comp = new List<Vertex>();
                }
            return comp;
        }
        public void DownloadGraphConnectivity(List<List<Vertex>> strong, List<Vertex> prev)
        {
            _vertexs = new List<Vertex>();
            _edges = new List<Edge>();
            foreach (List<Vertex> v in strong)
                foreach (Vertex h in v)
                {
                    Vertex oldV = prev.FirstOrDefault(t => t.name == h.name);
                    AddVertex(h.name, oldV.x, oldV.y);
                }
            foreach (List<Vertex> v in strong)
                foreach (Vertex h in v)
                    foreach (Vertex k in v)
                        if (h != k)
                        {
                            Vertex v1 = _vertexs.FirstOrDefault(t => t.name == h.name);
                            Vertex v2 = _vertexs.FirstOrDefault(t => t.name == k.name);
                            AddEdge(v1, v2);
                            AddEdge(v2, v1);
                        }
        }
        public List<Vertex> DijkstraSearchPath(Vertex start, Vertex end)
        {
            var previous = new Dictionary<Vertex, Vertex>();
            distances = new Dictionary<Vertex, int>();
            var visited = new Dictionary<Vertex, bool>();
            List<Vertex> path = null;
            Vertex smallVertex = start;
            foreach (var vertex in _vertexs)
            {
                if (vertex == start) distances[vertex] = 0;
                else distances[vertex] = int.MaxValue;
            }
            while (visited.Count != _vertexs.Count)
            {
                distances = distances.OrderBy(t => t.Value).ToDictionary(t => t.Key, t => t.Value);
                foreach (Vertex v in distances.Keys)
                    if (visited.ContainsKey(v) == false)
                    {
                        smallVertex = v;
                        visited.Add(v, true);
                        break;
                    }
                if (smallVertex == end)
                {
                    path = new List<Vertex>();
                    path.Add(smallVertex);
                    while (previous.ContainsKey(smallVertex))
                    {
                        path.Add(previous[smallVertex]);
                        smallVertex = previous[smallVertex];
                    }
                    path.Reverse();
                    break;
                }
                if (distances[smallVertex] == int.MaxValue) break;
                foreach (var edge in _edges.Where(t => t.v1 == smallVertex).ToList())
                {
                    int minCost = distances[smallVertex] + edge.cost;
                    if (distances[edge.v2] > minCost)
                    {
                        distances[edge.v2] = minCost;
                        previous[edge.v2] = smallVertex;
                    }
                }
            }
            return path;
        }

        public Graph FindMSTPrima() // rand - для проверки правильности работы алгоритма, потому-что случайные рёбра выбираем
        {
            List<Vertex> visitedV = new List<Vertex>(); // пройденные вершины
            List<Edge> notVisitedE = new List<Edge>(); // не пройденные рёбра
            foreach (var e in _edges) notVisitedE.Add(e); // добавляем туда все рёбка, которые есть в графе
            Graph MST = new Graph(); // создаём новый граф
            foreach (var v in _vertexs) MST.AddVertex(v);
            Random rand = new Random();
            visitedV.Add(_vertexs[rand.Next(0, _vertexs.Count)]); // случайным образом выбираем вершину
            while (visitedV.Count != _vertexs.Count) // пока все вершины не пройдены
            {
                Edge _e = null; // объявляем ребро
                int minCost = int.MaxValue; // устанавливаем цену (минимальная)
                foreach (var edge in notVisitedE) // пробегаемся рёбрам, которые еще не добавлялись 
                {
                    // если одна из вершин есть в пройденных, а другой нет, тогда
                    if (visitedV.Contains(edge.v1) && !visitedV.Contains(edge.v2) || visitedV.Contains(edge.v2) && !visitedV.Contains(edge.v1))
                        if (edge.cost < minCost) // если цена ребра меньше
                        {
                            _e = edge; // сохраняем это ребро
                            minCost = edge.cost; // сохраняем минимальную цену
                        }
                }
                if (visitedV.Contains(_e.v1)) // если v1 - вершина которая пройдена
                    visitedV.Add(_e.v2); // тогда добавляем вершину v2
                else
                    visitedV.Add(_e.v1); // иначе добавляем вершину v1, потому-что v2 пройдена
                notVisitedE.Remove(_e); // ну грубо говоря, добалвяем в пройденные рёбра ребро _e
                MST.AddEdge(_e); // добавляем это ребро в дерево
            }
            return MST; // возвращаем дерево
        }

        // ALGHORITM FIND CYCLES EULER
        private List<Edge> temp_edges = new List<Edge>(); // все вершины, которые потом удаляются
        private Dictionary<Edge, int> remove_edges = new Dictionary<Edge, int>();

        private void DFSEuler(Vertex v, int k)
        {
            if (visited.ContainsKey(v)) return;
            visited[v] = true; // добавляем в пройденные
            foreach (Edge e in temp_edges) // пробегаемся по смежным
                if (e.v1 == v) // если вершины соседней нет в пройденных, то
                {
                    remove_edges[e] = k; // добавляем в список ребёр ребро
                    DFSEuler(e.v2, k); // идём дальше в глубину
                }
        }

        public List<Graph> FindEulerCycles()
        {
            //foreach (var v in _vertexs)
            //if (_edges.Where(t => t.v1 == v).ToList().Count % 2 != 0) //проверяем степень на четность
            //        return null;
            temp_edges = new List<Edge>();
            List<Graph> graphs = new List<Graph>();
            remove_edges = new Dictionary<Edge, int>();
            foreach (var e in _edges)
                temp_edges.Add(e);

            int k = 0; // кол-во циклов
            while (temp_edges.Count != 0) // пока в графе остались рёбра
            {
                visited = new Dictionary<Vertex, bool>();
                graphs.Add(new Graph()); // создаём новый граф
                Vertex this_v = null;
                foreach (var v in _vertexs)
                    if (temp_edges.Where(t => t.v1 == v).ToList().Count >= 1) //проверяем степень на четность
                    {
                        this_v = v; // это вершина становится обрабатываемой
                        break;
                    }
                DFSEuler(this_v, k); // идём в глубину 
                foreach (var v in visited.Keys)
                    graphs[k].AddVertex(v); // добавляем вершины в эйлера граф

                foreach (var e in remove_edges.Keys)
                    if (remove_edges[e] == k)
                    {
                        
                        Edge _e = temp_edges.FirstOrDefault(t => t.v2 == e.v1 && t.v1 == e.v2);
                        if (_e != null) temp_edges.Remove(_e);
                        temp_edges.Remove(e); // удаляем из ребёр графа, чтобы больше их не проходить
                        graphs[k].AddEdge(e); // добавляем в эйлера граф
                    }
                foreach (var v in graphs[k].vertexs)
                {
                    if (_edges.Where(t => t.v1 == v || t.v2 == v).ToList().Count % 2 != 0)
                    {
                        graphs.RemoveAt(k);
                        k--;
                        break;
                    }
                }
                k++; // прибавляем кол-во графов
            }
            return graphs;
        }
    }
}
