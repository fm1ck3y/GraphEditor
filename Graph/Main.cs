using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Main : Form
    {
        Graph mainGraph = new Graph();
        Graphics g;
        int R = 50;
        bool _CreateEdge = false, _DeleteElement = false, _Cursor = true, _CreateVertex = false;
        Vertex CreateEdge_v = null, SelectVertex = null;
        Color _ColorVertex, _ColorEdge;
        private Bitmap bitmap;


        private void ChangeState(bool CreateVertex = false, bool Cursor = false, bool CreateEdge = false, bool DeleteElement = false)
        {
            if (Cursor) SidePanel.Location = new Point(0, 0);
            if (CreateVertex) SidePanel.Location = new Point(0, 40);
            if (CreateEdge) SidePanel.Location = new Point(0, 80);
            if (DeleteElement) SidePanel.Location = new Point(0, 120);
            this._CreateVertex = CreateVertex;
            this._Cursor = Cursor;
            this._CreateEdge = CreateEdge;
            this._DeleteElement = DeleteElement;
        }
        public Main()
        {
            InitializeComponent();
            dgvMatrix.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatrix.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DoubleBuffered = true;
            _ColorVertex = colorV.BackColor;
            _ColorEdge = colorEdge.BackColor;
            UpdateGrid();
            bitmap = new Bitmap(graphicsPanel.Width, graphicsPanel.Height);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeState(false, true, false, false);
        }

        private void btnCreateVert_Click(object sender, EventArgs e)
        {
            ChangeState(true, false, false, false);
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            ChangeState(false, false, false, true);
        }

        DataTable GetDataTable(int[,] array)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < array.GetLength(1); i++)
                table.Columns.Add(((char)(65 + i)).ToString());
            for (int i = 0; i < array.GetLength(0); i++)
            {
                table.Rows.Add(table.NewRow());
                for (int j = 0; j < array.GetLength(1); j++)
                    table.Rows[i][j] = array[i, j];
            }
            return table;
        }

        private void UpdateGrid()
        {
            dgvMatrix.DataSource = null;
            var table = GetDataTable(mainGraph.CreateAdjacencyMatrix());
            dgvMatrix.DataSource = table;
            for (int i = 0; i < dgvMatrix.Rows.Count; i++)
            {
                dgvMatrix.Rows[i].HeaderCell.Value = mainGraph.vertexs[i].name;
            }
            cbSelectStart.Items.Clear();
            cbEnd.Items.Clear();
            foreach (var v in mainGraph.vertexs)
            {
                cbSelectStart.Items.Add(v.name);
                cbEnd.Items.Add(v.name);
            }
        }

        private void DrawVertex(Vertex v, Color colorText, Color colorCircle, Color colorFill, int radius = -1)
        {
            if (radius == -1) radius = R;
            Font drawFont = new Font("Century Ghotic", 14);
            SolidBrush drawBrush = new SolidBrush(colorText);
            SolidBrush circleBrush = new SolidBrush(colorFill);
            Pen pen = new Pen(colorCircle, 3);
            Rectangle rec = new Rectangle(v.x, v.y, radius, radius);
            g.DrawEllipse(pen, rec);
            g.FillEllipse(circleBrush, rec);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(v.name.ToString(), drawFont, drawBrush, v.x + radius / 2, v.y + radius / 2, sf);
            // clear memory
            drawFont.Dispose();
            circleBrush.Dispose();
            drawBrush.Dispose();
            circleBrush.Dispose();
            pen.Dispose();
        }

        private void DrawEdge(Edge edge, Color color, string value = null, bool EndCap = false)
        {
            Pen pen = new Pen(color, 2);
            if(!EndCap)
                pen.CustomEndCap = new AdjustableArrowCap(5, 20);
            if (edge.v1 == edge.v2)
            {
                Rectangle rec = new Rectangle(edge.v1.x + R, edge.v1.y, R / 2, R / 2);
                pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                g.DrawArc(pen, rec, 0, 180);
                g.DrawArc(pen, rec, 180, 360);
            }
            else
            {
                g.DrawLine(pen, edge.v1.x + R / 2, edge.v1.y + R / 2, edge.v2.x + R / 2, edge.v2.y + R / 2);
            }
            if (value != null || edge.cost != 0)
            {
                Color colorCost = Color.Red;
                if (value != null) colorCost = Color.Blue;
                value = edge.cost.ToString();
                Font drawFont = new Font("Century Ghotic", 14);
                SolidBrush drawBrush = new SolidBrush(colorCost);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(value, drawFont, drawBrush, (edge.v1.x + edge.v2.x) / 2 + R / 2, (edge.v1.y + edge.v2.y) / 2 + R / 2, sf);
            }
        }

        private void DrawGraph(List<Vertex> way = null, Vertex selectVertex = null, Graph mainGraph = null,bool MST = false)
        {
            if (mainGraph == null) mainGraph = this.mainGraph;
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            List<Edge> edges_way = new List<Edge>();
            if (way != null)
                edges_way = GenerateEdges(way);
            else
                way = new List<Vertex>();
            foreach (var e in mainGraph.edges)
                if (edges_way.FirstOrDefault(t => t.v1 == e.v1 && t.v2 == e.v2 || t.v1 == e.v2 && t.v2 == e.v1) != null)
                {
                    if (edges_way.IndexOf(e) != -1)
                        DrawEdge(e, Color.Green,"",MST);
                }
                else
                    DrawEdge(e, _ColorEdge,null, MST);
            foreach (var v in mainGraph.vertexs)
                if (way.Contains(v))
                    DrawVertex(v, Color.Black, Color.Black, Color.Red);
                else
                {
                    if (selectVertex == v)
                        DrawVertex(v, Color.Black, Color.Black, Color.Red);
                    else
                        DrawVertex(v, Color.Black, Color.Black, _ColorVertex);
                }
            pBoxGraph.Image = bitmap;
            pBoxGraph.Invalidate();
            g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void graphicsPanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            pBoxGraph.Width = graphicsPanel.Width - rightPanel.Width;
            pBoxGraph.Height = graphicsPanel.Height;
            bitmap = new Bitmap(graphicsPanel.Width, graphicsPanel.Height);
            DrawGraph();
        }

        private List<Edge> GenerateEdges(List<Vertex> way)
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < way.Count - 1; i++)
                edges.Add(mainGraph.edges.FirstOrDefault(t => t.v1.name == way[i].name && t.v2.name == way[i + 1].name));
            return edges;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Vertex v1 = mainGraph.vertexs.FirstOrDefault(t => t.name.ToString() == cbSelectStart.Text), v2 = mainGraph.vertexs.FirstOrDefault(t => t.name.ToString() == cbEnd.Text);
                List<Vertex> way = mainGraph.Wave(v1, v2);
                DrawGraph(way);
                if (way == null)
                    lblWay.Text = "Данный путь не существует.";
                else
                    lblWay.Text = $"Кратчайший путь проходит через: {way.Count - 1} вершины";
            }
            catch (Exception)
            {
                lblWay.Text = "Данный путь не существует.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить графическое поле?", "Очистить рабочее поле?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mainGraph = new Graph();
                UpdateGrid();
                DrawGraph();
            }

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCreateEdge_Click(object sender, EventArgs e)
        {
            ChangeState(false, false, true, false);
            CreateEdge_v = null;
        }

        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnStrong_Click(object sender, EventArgs e)
        {
            int[,] S = mainGraph.StrongLinkedMatrix();
            Graph newGraph = new Graph();
            newGraph = newGraph.DownloadAdjacencyMatrix(S, null, mainGraph.vertexs);
            List<List<Vertex>> components = newGraph.StrongConnectivityComponents();
            newGraph.DownloadGraphConnectivity(components, mainGraph.vertexs);
            DrawGraph(null, null, newGraph);
        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void trackSizeVertex_Scroll(object sender, EventArgs e)
        {
            this.R = trackSizeVertex.Value;
            DrawGraph();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void pBoxGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if (_CreateVertex)
            {
                Vertex v = mainGraph.AddVertex(' ', e.X - R / 2, e.Y - R / 2);
                DrawGraph();
                UpdateGrid();
            }
            else if (_CreateEdge)
            {
                if (CreateEdge_v == null)
                {
                    for (int i = 0; i < mainGraph.vertexs.Count; i++)
                        if (Math.Pow((mainGraph.vertexs[i].x - e.X), 2) + Math.Pow((mainGraph.vertexs[i].y - e.Y), 2) <= R * R)
                        {
                            CreateEdge_v = mainGraph.vertexs[i];
                            DrawGraph(null, mainGraph.vertexs[i]);
                            return;
                        }
                }
                else
                    for (int i = 0; i < mainGraph.vertexs.Count; i++)
                        if (Math.Pow((mainGraph.vertexs[i].x - e.X), 2) + Math.Pow((mainGraph.vertexs[i].y - e.Y), 2) <= R * R)
                        {
                            int cost;
                            try
                            {
                                cost = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Введите цену ребра:"), System.Globalization.NumberStyles.Integer);
                            }
                            catch
                            {
                                cost = 0;
                            }
                            mainGraph.AddEdge(CreateEdge_v, mainGraph.vertexs[i], cost);
                            CreateEdge_v = null;
                            UpdateGrid();
                            DrawGraph();
                            return;
                        }
            }
            else if (_Cursor)
            {
                if (SelectVertex == null)
                {
                    for (int i = 0; i < mainGraph.vertexs.Count; i++)
                        if (Math.Pow((mainGraph.vertexs[i].x - e.X), 2) + Math.Pow((mainGraph.vertexs[i].y - e.Y), 2) <= R * R)
                        {
                            SelectVertex = mainGraph.vertexs[i];
                            return;
                        }
                }
                else
                    SelectVertex = null;
            }
            else if (_DeleteElement)
            {
                for (int i = 0; i < mainGraph.vertexs.Count; i++)
                    if (Math.Pow((mainGraph.vertexs[i].x - e.X), 2) + Math.Pow((mainGraph.vertexs[i].y - e.Y), 2) <= R * R)
                    {
                        mainGraph.RemoveVertex(mainGraph.vertexs[i]);
                        DrawGraph();
                        UpdateGrid();
                        return;
                    }
                foreach (var edge in mainGraph.edges)
                {
                    int[] vec = new int[2] { edge.v2.x - edge.v1.x, edge.v2.y - edge.v1.y };
                    if (vec[0] * (e.X - edge.v1.x) + vec[1] * (e.Y - edge.v1.y) == 0)
                    {
                        mainGraph.RemoveEdge(edge.v1, edge.v2);
                        DrawGraph();
                        UpdateGrid();
                        return;
                    }
                }

            }
        }

        private void pBoxGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectVertex != null)
            {
                SelectVertex.x = e.X;
                SelectVertex.y = e.Y;
                DrawGraph();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Vertex v1 = mainGraph.vertexs.FirstOrDefault(t => t.name.ToString() == cbSelectStart.Text), v2 = mainGraph.vertexs.FirstOrDefault(t => t.name.ToString() == cbEnd.Text);
                List<Vertex> path = mainGraph.DijkstraSearchPath(v1, v2);
                DrawGraph(path);
                if (mainGraph.distances[v2] == int.MaxValue || path == null)
                    lblWay.Text = "Данный путь не существует.";
                else
                    lblWay.Text = $"Цена кратчайшего пути = {mainGraph.distances[v2]}";
            }
            catch (Exception)
            {
                lblWay.Text = "Данный путь не существует.";
            }
        }

        private void btnMST_Click(object sender, EventArgs e)
        {
            Graph MST = mainGraph.FindMSTPrima();
            DrawGraph(null,null,MST,true);
            int cost = 0;
            foreach (var edge in MST.edges) cost += edge.cost;
            lblWay.Text = $"Вес минимального остовного дерева = {cost}";
        }

        private void btnEulerCycles_Click(object sender, EventArgs e)
        {
            var graphs = mainGraph.FindEulerCycles();
            if (graphs.Count == 0)
            {
                MessageBox.Show("Ошибка. В данном графе нет циклов Эйлера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ColorVertex = Color.Green;
            _ColorEdge = Color.Red;
            foreach (var g in graphs)
            {
                DrawGraph(null, null, g,true);
                Task.Delay(2000).GetAwaiter().GetResult();
            }
            _ColorVertex = colorV.BackColor;
            _ColorEdge = colorEdge.BackColor;
            DrawGraph();
        }

        private void btnChangeColorVertex_Click(object sender, EventArgs e)
        {
            if (colorVertex.ShowDialog() == DialogResult.OK)
                colorV.BackColor = colorVertex.Color;
            _ColorVertex = colorV.BackColor;
            DrawGraph();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorVertex.ShowDialog() == DialogResult.OK)
                colorEdge.BackColor = colorVertex.Color;
            _ColorEdge = colorEdge.BackColor;
            DrawGraph();
        }

        private void graphicsPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void graphicsPanel_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void graphicsPanel_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}