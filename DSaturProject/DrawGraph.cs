using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSaturProject
{
    public partial class DrawGraph : Form
    {
        #region PODACI

        public int numberVertices;
        public int chromaticNumber;
        public int[,] dataMatrix;
        public LinkedList<int>[] adjacentVertices;
        public Color[] palette;
        public Point[] vertexPoints;
        public int vertexDiag;
        public int vertexRad;

        #endregion

        public DrawGraph(int numberVertices, int chromaticNumber, int[,] dataMatrix, LinkedList<int>[] adjacentVertices)
        {
            InitializeComponent();

            this.numberVertices = numberVertices;
            this.chromaticNumber = chromaticNumber;
            this.dataMatrix = dataMatrix;
            this.adjacentVertices = adjacentVertices;

            vertexDiag = 50;
            vertexRad = 25;
            Random rand = new Random();
            palette = new Color[this.chromaticNumber];
            if (this.chromaticNumber <= 4)
            {
                switch (this.chromaticNumber)
                {
                    case 1:
                        palette[0] = Color.Red;
                        break;
                    case 2:
                        palette[0] = Color.Red;
                        palette[1] = Color.Green;
                        break;
                    case 3:
                        palette[0] = Color.Red;
                        palette[1] = Color.Green;
                        palette[2] = Color.Blue;
                        break;
                    case 4:
                        palette[0] = Color.Red;
                        palette[1] = Color.Green;
                        palette[2] = Color.Blue;
                        palette[3] = Color.Yellow;
                        break;
                }
            }
            else
            {

                int k = 0;
                while (k < this.chromaticNumber)
                {
                    Color color1 = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    palette[k] = color1;
                    int j = 0;
                    while (j < k)
                    {
                        if (palette[j].Equals(color1))
                        {
                            k--;
                            break;
                        }
                        j++;
                    }
                    k++;
                }
            }

            int w = SystemInformation.PrimaryMonitorSize.Width;
            int h = SystemInformation.PrimaryMonitorSize.Height;

            int margin = 50;
            int xm = w - margin * 2;
            int ym = h - 50 - margin * 2;

            vertexPoints = new Point[this.numberVertices];
            for (int i = 0; i < vertexPoints.Length; i++)
            {
                vertexPoints[i] = new Point(rand.Next(xm) + margin, rand.Next(ym) + margin);
                for (int j = 0; j < i; j++)
                {
                    double a = vertexPoints[i].X - vertexPoints[j].X;
                    double b = vertexPoints[i].Y - vertexPoints[j].Y;
                    if (Math.Sqrt(a * a + b * b) < vertexDiag)
                    {
                        i--;
                        break;
                    }
                }
            }
        }

        private void DrawGraph_Load(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 12.0f, FontStyle.Bold);
            this.Font = font;
            int w = SystemInformation.PrimaryMonitorSize.Width;
            int h = SystemInformation.PrimaryMonitorSize.Height;
            this.Width = w;
            this.Height = h;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.Clear(Color.Black);
                using (Pen p = new Pen(Color.White, 1))
                {
                    for (int v = 0; v < this.numberVertices; v++)
                    {
                        foreach (int w in this.adjacentVertices[v])
                        {
                            g.DrawLine(p, vertexPoints[v].X, vertexPoints[v].Y, vertexPoints[w].X, vertexPoints[w].Y);
                        }
                    }
                    for (int v = 0; v < this.numberVertices; v++)
                    {
                        SolidBrush myBrush = new SolidBrush(palette[this.dataMatrix[1, v] - 1]);
                        g.FillEllipse(myBrush, vertexPoints[v].X - vertexRad, vertexPoints[v].Y - vertexRad, vertexDiag, vertexDiag);
                        myBrush = new SolidBrush(Color.White);
                        String s = (v + 1).ToString();
                        g.DrawString(s, Font, myBrush, vertexPoints[v].X - 8, vertexPoints[v].Y - 10);
                    }
                }
            }

        }

    }
}
