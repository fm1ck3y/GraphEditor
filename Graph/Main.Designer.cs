using System.Windows.Forms;

namespace Graph
{
    

    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnCreateEdge = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCursor = new System.Windows.Forms.Button();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.btnCreateVert = new System.Windows.Forms.Button();
            this.vertexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightPanel = new System.Windows.Forms.Panel();
            this.btnMainCentre = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCyclomatic = new System.Windows.Forms.Button();
            this.btnEulerCycles = new System.Windows.Forms.Button();
            this.btnMST = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackSizeVertex = new System.Windows.Forms.TrackBar();
            this.colorEdge = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorV = new System.Windows.Forms.PictureBox();
            this.btnChangeColorVertex = new System.Windows.Forms.Button();
            this.btnStandart = new System.Windows.Forms.Button();
            this.btnStrong = new System.Windows.Forms.Button();
            this.lblWay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.cbSelectStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.btnWave = new System.Windows.Forms.Button();
            this.graphicsPanel = new System.Windows.Forms.Panel();
            this.pBoxGraph = new System.Windows.Forms.PictureBox();
            this.colorVertex = new System.Windows.Forms.ColorDialog();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.SVDialog = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCentre = new System.Windows.Forms.Button();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertexBindingSource)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.graphicsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlTools.Controls.Add(this.btnCreateEdge);
            this.pnlTools.Controls.Add(this.SidePanel);
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Controls.Add(this.btnCursor);
            this.pnlTools.Controls.Add(this.btnDeleteElement);
            this.pnlTools.Controls.Add(this.btnCreateVert);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(51, 579);
            this.pnlTools.TabIndex = 1;
            // 
            // btnCreateEdge
            // 
            this.btnCreateEdge.FlatAppearance.BorderSize = 0;
            this.btnCreateEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateEdge.ForeColor = System.Drawing.Color.White;
            this.btnCreateEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateEdge.Image")));
            this.btnCreateEdge.Location = new System.Drawing.Point(10, 80);
            this.btnCreateEdge.Name = "btnCreateEdge";
            this.btnCreateEdge.Size = new System.Drawing.Size(38, 40);
            this.btnCreateEdge.TabIndex = 15;
            this.btnCreateEdge.UseVisualStyleBackColor = true;
            this.btnCreateEdge.Click += new System.EventHandler(this.btnCreateEdge_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(216)))), ((int)(((byte)(113)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 40);
            this.SidePanel.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(10, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(38, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCursor
            // 
            this.btnCursor.FlatAppearance.BorderSize = 0;
            this.btnCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCursor.ForeColor = System.Drawing.Color.White;
            this.btnCursor.Image = ((System.Drawing.Image)(resources.GetObject("btnCursor.Image")));
            this.btnCursor.Location = new System.Drawing.Point(10, 0);
            this.btnCursor.Name = "btnCursor";
            this.btnCursor.Size = new System.Drawing.Size(38, 40);
            this.btnCursor.TabIndex = 12;
            this.btnCursor.UseVisualStyleBackColor = true;
            this.btnCursor.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.FlatAppearance.BorderSize = 0;
            this.btnDeleteElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteElement.ForeColor = System.Drawing.Color.White;
            this.btnDeleteElement.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteElement.Image")));
            this.btnDeleteElement.Location = new System.Drawing.Point(10, 120);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(38, 40);
            this.btnDeleteElement.TabIndex = 11;
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // btnCreateVert
            // 
            this.btnCreateVert.FlatAppearance.BorderSize = 0;
            this.btnCreateVert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateVert.ForeColor = System.Drawing.Color.White;
            this.btnCreateVert.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateVert.Image")));
            this.btnCreateVert.Location = new System.Drawing.Point(10, 40);
            this.btnCreateVert.Name = "btnCreateVert";
            this.btnCreateVert.Size = new System.Drawing.Size(38, 40);
            this.btnCreateVert.TabIndex = 10;
            this.btnCreateVert.UseVisualStyleBackColor = true;
            this.btnCreateVert.Click += new System.EventHandler(this.btnCreateVert_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.btnCentre);
            this.rightPanel.Controls.Add(this.button5);
            this.rightPanel.Controls.Add(this.btnMainCentre);
            this.rightPanel.Controls.Add(this.button4);
            this.rightPanel.Controls.Add(this.button3);
            this.rightPanel.Controls.Add(this.btnDownload);
            this.rightPanel.Controls.Add(this.btnSave);
            this.rightPanel.Controls.Add(this.btnCyclomatic);
            this.rightPanel.Controls.Add(this.btnEulerCycles);
            this.rightPanel.Controls.Add(this.btnMST);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.trackSizeVertex);
            this.rightPanel.Controls.Add(this.colorEdge);
            this.rightPanel.Controls.Add(this.button1);
            this.rightPanel.Controls.Add(this.colorV);
            this.rightPanel.Controls.Add(this.btnChangeColorVertex);
            this.rightPanel.Controls.Add(this.btnStandart);
            this.rightPanel.Controls.Add(this.btnStrong);
            this.rightPanel.Controls.Add(this.lblWay);
            this.rightPanel.Controls.Add(this.button2);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.cbEnd);
            this.rightPanel.Controls.Add(this.cbSelectStart);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Controls.Add(this.dgvMatrix);
            this.rightPanel.Controls.Add(this.btnWave);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(620, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(315, 579);
            this.rightPanel.TabIndex = 0;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // btnMainCentre
            // 
            this.btnMainCentre.Location = new System.Drawing.Point(158, 347);
            this.btnMainCentre.Name = "btnMainCentre";
            this.btnMainCentre.Size = new System.Drawing.Size(147, 23);
            this.btnMainCentre.TabIndex = 25;
            this.btnMainCentre.Text = "Центр графа";
            this.btnMainCentre.UseVisualStyleBackColor = true;
            this.btnMainCentre.Click += new System.EventHandler(this.btnCentre_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Кратчайшие пути";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Гамильтоновы циклы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(158, 439);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(147, 23);
            this.btnDownload.TabIndex = 22;
            this.btnDownload.Text = "Загрузить граф";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Сохранить граф";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCyclomatic
            // 
            this.btnCyclomatic.Location = new System.Drawing.Point(9, 376);
            this.btnCyclomatic.Name = "btnCyclomatic";
            this.btnCyclomatic.Size = new System.Drawing.Size(296, 23);
            this.btnCyclomatic.TabIndex = 20;
            this.btnCyclomatic.Text = "Цикломатическая матрица";
            this.btnCyclomatic.UseVisualStyleBackColor = true;
            this.btnCyclomatic.Visible = false;
            this.btnCyclomatic.Click += new System.EventHandler(this.btnCyclomatic_Click);
            // 
            // btnEulerCycles
            // 
            this.btnEulerCycles.Location = new System.Drawing.Point(7, 347);
            this.btnEulerCycles.Name = "btnEulerCycles";
            this.btnEulerCycles.Size = new System.Drawing.Size(149, 23);
            this.btnEulerCycles.TabIndex = 19;
            this.btnEulerCycles.Text = "Найти циклы эйлера";
            this.btnEulerCycles.UseVisualStyleBackColor = true;
            this.btnEulerCycles.Click += new System.EventHandler(this.btnEulerCycles_Click);
            // 
            // btnMST
            // 
            this.btnMST.Location = new System.Drawing.Point(7, 318);
            this.btnMST.Name = "btnMST";
            this.btnMST.Size = new System.Drawing.Size(298, 23);
            this.btnMST.TabIndex = 18;
            this.btnMST.Text = "Найти кратчайшее остовное дерево";
            this.btnMST.UseVisualStyleBackColor = true;
            this.btnMST.Click += new System.EventHandler(this.btnMST_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Размер вершин:";
            // 
            // trackSizeVertex
            // 
            this.trackSizeVertex.Location = new System.Drawing.Point(124, 468);
            this.trackSizeVertex.Maximum = 100;
            this.trackSizeVertex.Minimum = 10;
            this.trackSizeVertex.Name = "trackSizeVertex";
            this.trackSizeVertex.Size = new System.Drawing.Size(181, 45);
            this.trackSizeVertex.TabIndex = 15;
            this.trackSizeVertex.Value = 50;
            this.trackSizeVertex.Scroll += new System.EventHandler(this.trackSizeVertex_Scroll);
            // 
            // colorEdge
            // 
            this.colorEdge.BackColor = System.Drawing.Color.Gray;
            this.colorEdge.Location = new System.Drawing.Point(263, 516);
            this.colorEdge.Name = "colorEdge";
            this.colorEdge.Size = new System.Drawing.Size(38, 23);
            this.colorEdge.TabIndex = 14;
            this.colorEdge.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Цвет ребра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // colorV
            // 
            this.colorV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorV.Location = new System.Drawing.Point(108, 515);
            this.colorV.Name = "colorV";
            this.colorV.Size = new System.Drawing.Size(38, 23);
            this.colorV.TabIndex = 12;
            this.colorV.TabStop = false;
            // 
            // btnChangeColorVertex
            // 
            this.btnChangeColorVertex.Location = new System.Drawing.Point(4, 515);
            this.btnChangeColorVertex.Name = "btnChangeColorVertex";
            this.btnChangeColorVertex.Size = new System.Drawing.Size(98, 23);
            this.btnChangeColorVertex.TabIndex = 11;
            this.btnChangeColorVertex.Text = "Цвет вершины";
            this.btnChangeColorVertex.UseVisualStyleBackColor = true;
            this.btnChangeColorVertex.Click += new System.EventHandler(this.btnChangeColorVertex_Click);
            // 
            // btnStandart
            // 
            this.btnStandart.Location = new System.Drawing.Point(3, 544);
            this.btnStandart.Name = "btnStandart";
            this.btnStandart.Size = new System.Drawing.Size(299, 23);
            this.btnStandart.TabIndex = 10;
            this.btnStandart.Text = "Нарисовать стандартный вид графа";
            this.btnStandart.UseVisualStyleBackColor = true;
            this.btnStandart.Click += new System.EventHandler(this.btnStandart_Click);
            // 
            // btnStrong
            // 
            this.btnStrong.Location = new System.Drawing.Point(6, 289);
            this.btnStrong.Name = "btnStrong";
            this.btnStrong.Size = new System.Drawing.Size(299, 23);
            this.btnStrong.TabIndex = 9;
            this.btnStrong.Text = "Нарисовать компоненты сильной связности.";
            this.btnStrong.UseVisualStyleBackColor = true;
            this.btnStrong.Click += new System.EventHandler(this.btnStrong_Click);
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Location = new System.Drawing.Point(6, 265);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(96, 13);
            this.lblWay.TabIndex = 8;
            this.lblWay.Text = "Кратчайший путь:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Алгоритм Дейкстры";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "=>";
            // 
            // cbEnd
            // 
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(181, 208);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(56, 21);
            this.cbEnd.TabIndex = 5;
            // 
            // cbSelectStart
            // 
            this.cbSelectStart.FormattingEnabled = true;
            this.cbSelectStart.Location = new System.Drawing.Point(94, 208);
            this.cbSelectStart.Name = "cbSelectStart";
            this.cbSelectStart.Size = new System.Drawing.Size(56, 21);
            this.cbSelectStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите путь:";
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.AllowUserToAddRows = false;
            this.dgvMatrix.AllowUserToDeleteRows = false;
            this.dgvMatrix.AllowUserToResizeColumns = false;
            this.dgvMatrix.AllowUserToResizeRows = false;
            this.dgvMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatrix.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMatrix.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMatrix.Location = new System.Drawing.Point(3, 3);
            this.dgvMatrix.MultiSelect = false;
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMatrix.ShowCellErrors = false;
            this.dgvMatrix.ShowCellToolTips = false;
            this.dgvMatrix.ShowEditingIcon = false;
            this.dgvMatrix.ShowRowErrors = false;
            this.dgvMatrix.Size = new System.Drawing.Size(308, 170);
            this.dgvMatrix.TabIndex = 1;
            this.dgvMatrix.TabStop = false;
            // 
            // btnWave
            // 
            this.btnWave.Location = new System.Drawing.Point(3, 235);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(143, 23);
            this.btnWave.TabIndex = 0;
            this.btnWave.Text = "Волновой алгоритм";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.AutoSize = true;
            this.graphicsPanel.BackColor = System.Drawing.Color.White;
            this.graphicsPanel.Controls.Add(this.pBoxGraph);
            this.graphicsPanel.Controls.Add(this.rightPanel);
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(51, 0);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(935, 579);
            this.graphicsPanel.TabIndex = 2;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseClick);
            this.graphicsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseDown);
            this.graphicsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseMove);
            this.graphicsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseUp);
            // 
            // pBoxGraph
            // 
            this.pBoxGraph.Location = new System.Drawing.Point(3, 0);
            this.pBoxGraph.Name = "pBoxGraph";
            this.pBoxGraph.Size = new System.Drawing.Size(612, 544);
            this.pBoxGraph.TabIndex = 1;
            this.pBoxGraph.TabStop = false;
            this.pBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBoxGraph_MouseClick);
            this.pBoxGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxGraph_MouseMove);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "OFDialog";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Выгрузить матрицу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCentre
            // 
            this.btnCentre.Location = new System.Drawing.Point(153, 176);
            this.btnCentre.Name = "btnCentre";
            this.btnCentre.Size = new System.Drawing.Size(149, 23);
            this.btnCentre.TabIndex = 27;
            this.btnCentre.Text = "Главный центр графа";
            this.btnCentre.UseVisualStyleBackColor = true;
            this.btnCentre.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 579);
            this.Controls.Add(this.graphicsPanel);
            this.Controls.Add(this.pnlTools);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.pnlTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vertexBindingSource)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSizeVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.graphicsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCursor;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Button btnCreateVert;
        private System.Windows.Forms.BindingSource vertexBindingSource;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnCreateEdge;
        private Panel rightPanel;
        private Button button2;
        private Label label2;
        private ComboBox cbEnd;
        private ComboBox cbSelectStart;
        private Label label1;
        private DataGridView dgvMatrix;
        private Button btnWave;
        private Panel graphicsPanel;
        private Label lblWay;
        private Button btnStrong;
        private Button btnStandart;
        private PictureBox colorEdge;
        private Button button1;
        private PictureBox colorV;
        private Button btnChangeColorVertex;
        private ColorDialog colorVertex;
        private Label label4;
        private TrackBar trackSizeVertex;
        private PictureBox pBoxGraph;
        private Button btnMST;
        private Button btnEulerCycles;
        private Button btnCyclomatic;
        private Button btnDownload;
        private Button btnSave;
        private OpenFileDialog OFDialog;
        private SaveFileDialog SVDialog;
        private Button button3;
        private Button button4;
        private Button btnMainCentre;
        private Button button5;
        private Button btnCentre;
    }
}

