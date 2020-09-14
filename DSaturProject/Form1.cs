using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSaturProject
{
    public partial class Form1 : Form
    {
        #region PODACI
        RadSaFajlovima radSaFajlovima = new RadSaFajlovima();
        String fileName = "";
        KeyValuePair<int, KeyValuePair<int[,], LinkedList<int>[]>> data = new KeyValuePair<int, KeyValuePair<int[,], LinkedList<int>[]>>();
        LinkedList<int>[] adjacentVerticesArray;
        int[,] fullData;
        #endregion

        #region SUDOKU EXAMPLE
        int[,] sudoku1 = {
                {0, 0, 0, 0, 0, 0, 5, 0, 0 },
                {3, 0, 2, 0, 7, 0, 9, 1, 0 },
                {6, 0, 0, 9, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 2, 6 },
                {0, 2, 0, 3, 0, 0, 1, 5, 9 },
                {7, 9, 0, 6, 0, 5, 0, 8, 0 },
                {1, 0, 9, 7, 0, 0, 0, 0, 0 },
                {4, 5, 0, 0, 0, 0, 2, 3, 0 },
                {0, 3, 8, 4, 5, 0, 6, 0, 0 }
            };
        int[,] sudoku2 = {
                {0, 7, 0, 0, 0, 0, 0, 5, 0 },
                {0, 9, 3, 0, 0, 0, 1, 6, 0 },
                {1, 0, 5, 0, 7, 0, 4, 0, 3 },
                {9, 0, 0, 2, 1, 6, 0, 0, 4 },
                {4, 0, 0, 3, 0, 9, 0, 0, 1 },
                {0, 1, 0, 8, 0, 7, 0, 2, 0 },
                {0, 0, 8, 0, 0, 0, 5, 0, 0 },
                {0, 6, 1, 0, 9, 0, 7, 8, 0 },
                {0, 4, 0, 0, 8, 0, 0, 1, 0 }
            };
        int[,] sudoku3 = {
                {0, 0, 5, 0, 0, 0, 1, 0, 0 },
                {0, 1, 9, 0, 0, 5, 0, 4, 0 },
                {0, 0, 0, 8, 0, 2, 0, 9, 3 },
                {8, 0, 0, 1, 0, 0, 0, 0, 6 },
                {1, 3, 0, 2, 4, 8, 0, 5, 7 },
                {4, 0, 0, 0, 0, 6, 0, 0, 1 },
                {5, 7, 0, 3, 0, 9, 0, 0, 0 },
                {0, 2, 0, 4, 0, 0, 7, 6, 0 },
                {0, 0, 1, 0, 0, 0, 8, 0, 0 }
            };
        int[,] sudoku4 = {
                {0, 0, 0, 0, 8, 9, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0, 0, 6, 8 },
                {3, 0, 0, 5, 7, 0, 0, 0, 9 },
                {0, 5, 0, 4, 0, 0, 7, 0, 1 },
                {0, 0, 8, 0, 0, 0, 2, 0, 0 },
                {6, 0, 1, 0, 0, 8, 0, 4, 0 },
                {4, 0, 0, 0, 5, 3, 0, 0, 2 },
                {1, 7, 0, 0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 2, 6, 0, 0, 0, 0 }
            };
        int[,] sudoku5 = {
                {3, 0, 2, 1, 0, 0, 0, 0, 6 },
                {0, 0, 0, 6, 4, 5, 0, 0, 0 },
                {0, 7, 0, 0, 3, 0, 0, 0, 0 },
                {0, 0, 0, 0, 1, 0, 0, 4, 9 },
                {0, 0, 6, 0, 0, 0, 8, 0, 0 },
                {5, 1, 0, 0, 2, 0, 0, 0, 0 },
                {0, 0, 0, 0, 8, 0, 0, 5, 0 },
                {0, 0, 0, 7, 9, 4, 0, 0, 0 },
                {7, 0, 0, 0, 0, 1, 2, 0, 4 }
            };
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFiles();
            createData();
        }

        #region METODE

        public void loadFiles()
        {
            String[] fileNames = radSaFajlovima.fileNames();
            foreach (String file in fileNames)
            {
                comboBoxSelectGraph.Items.Add(file);
            }
        }

        public void fillInformationLabel(String fileName, int chromaticNum)
        {
            if (fileName == "")
            {
                return;
            }
            String numberNodes = "";
            String numberEdges = "";
            String chromaticNumber = "Trenutno nepoznat";
            if(chromaticNum != -1)
            {
                chromaticNumber = chromaticNum.ToString();
            }
            FileStream fs = new FileStream("../../graph/" + fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lineStrings = line.Split(' ');
                if (lineStrings[0] == "p")
                {
                    numberNodes = lineStrings[2];
                    numberEdges = lineStrings[3];
                }
                else
                {
                    if (lineStrings[0] == "e")
                    {
                        break;
                    }
                }
            }
            sr.Close();
            fs.Close();
            labelGraphInformation.Text = "";
            labelGraphInformation.Text = "Informacije o grafu:\n\nNaziv fajla: " + fileName +
                "\nBroj cvorova: " + numberNodes +
                "\nBroj grana: " + numberEdges +
                "\nHromatski broj: " + chromaticNumber;
        }

        public int[,] fillMatrix()
        {
            int[,] tempMatrix = new int[9, 9];
            int num = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tempMatrix[i, j] = num;
                    num++;
                }
            }
            return tempMatrix;
        }

        public LinkedList<int>[] createAdjacent(int[,] matrix, LinkedList<int>[] tempAdjacentList)
        {
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // dodavanje iz reda
                    for (int k = 0; k < 9; k++)
                    {
                        if (k != j)
                        {
                            tempAdjacentList[index].AddLast(matrix[i, k]);
                        }
                    }
                    // dodavanje iz kolone
                    for (int k = 0; k < 9; k++)
                    {
                        if (k != i)
                        {
                            tempAdjacentList[index].AddLast(matrix[k, j]);
                        }
                    }
                    // dodavanje 4 preostala polja iz 3x3
                    if (i % 3 == 0)
                    {
                        if (j % 3 == 0)
                        {
                            tempAdjacentList[index].AddLast(matrix[i + 1, j + 1]);
                            tempAdjacentList[index].AddLast(matrix[i + 1, j + 2]);
                            tempAdjacentList[index].AddLast(matrix[i + 2, j + 1]);
                            tempAdjacentList[index].AddLast(matrix[i + 2, j + 2]);
                        }
                        else
                        {
                            if (j % 3 == 1)
                            {
                                tempAdjacentList[index].AddLast(matrix[i + 1, j - 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 1, j + 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 2, j - 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 2, j + 1]);
                            }
                            else
                            {
                                tempAdjacentList[index].AddLast(matrix[i + 1, j - 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 1, j - 2]);
                                tempAdjacentList[index].AddLast(matrix[i + 2, j - 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 2, j - 2]);
                            }
                        }
                    }
                    else
                    {
                        if (i % 3 == 1)
                        {
                            if (j % 3 == 0)
                            {
                                tempAdjacentList[index].AddLast(matrix[i + 1, j + 1]);
                                tempAdjacentList[index].AddLast(matrix[i + 1, j + 2]);
                                tempAdjacentList[index].AddLast(matrix[i - 1, j + 1]);
                                tempAdjacentList[index].AddLast(matrix[i - 1, j + 2]);
                            }
                            else
                            {
                                if (j % 3 == 1)
                                {
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j + 1]);
                                    tempAdjacentList[index].AddLast(matrix[i + 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i + 1, j + 1]);
                                }
                                else
                                {
                                    tempAdjacentList[index].AddLast(matrix[i + 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i + 1, j - 2]);
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 2]);
                                }
                            }
                        }
                        else
                        {
                            if (j % 3 == 0)
                            {
                                tempAdjacentList[index].AddLast(matrix[i - 1, j + 1]);
                                tempAdjacentList[index].AddLast(matrix[i - 1, j + 2]);
                                tempAdjacentList[index].AddLast(matrix[i - 2, j + 1]);
                                tempAdjacentList[index].AddLast(matrix[i - 2, j + 2]);
                            }
                            else
                            {
                                if (j % 3 == 1)
                                {
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j + 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 2, j + 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 2, j - 1]);
                                }
                                else
                                {
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 1, j - 2]);
                                    tempAdjacentList[index].AddLast(matrix[i - 2, j - 1]);
                                    tempAdjacentList[index].AddLast(matrix[i - 2, j - 2]);
                                }
                            }
                        }
                    }

                    // prelazak na sledeci element
                    index++;
                }
            }


            return tempAdjacentList;
        }

        public void createData()
        {
            int[,] matrix = new int[9, 9]; //matrica na osnovu koje se kreiraju susjedi
            LinkedList<int>[] adjacentVertices = new LinkedList<int>[81]; //lista susjeda

            //kreiranje liste listi
            for (int i = 0; i < adjacentVertices.Length; i++)
            {
                adjacentVertices[i] = new LinkedList<int>();
            }

            //popunjavanje matrice
            matrix = fillMatrix();

            //popunjavanje liste listi..za susjede
            adjacentVertices = createAdjacent(matrix, adjacentVertices);

            this.adjacentVerticesArray = adjacentVertices;
        }

        public int[,] createSudoku(int[,] data)
        {
            int[,] tempData = new int[9, 9];
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tempData[i, j] = data[1, index];
                    index++;
                }
            }
            return tempData;
        }

        public void draw(int[,] fullData, int[,] emptyDate, bool control)
        {
            Graphics g = panelShowSudoku.CreateGraphics();
            g.Clear(panelShowSudoku.BackColor);
            Pen p;
            SolidBrush brush;
            int startPointX = 10;
            int startPointY = 10;
            Font font = new Font("Arial", 12);
            for(int i = 0; i <= 9; i++)
            {
                float x = i * 30 + 10;
                float y = i * 30 + 10;
                if ((x - startPointX) % 90 == 0)
                {
                    p = new Pen(Brushes.Black, 2);
                }
                else
                {
                    p = new Pen(Brushes.Black, 1);
                }
                g.DrawLine(p, x, startPointY, x, 280);
                g.DrawLine(p, startPointX, y, 280, y);
            }
            if (control)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (emptyDate[i ,j] == 0)
                        {
                            brush = new SolidBrush(Color.Black);
                        }
                        else
                        {
                            brush = new SolidBrush(Color.Red);
                        }
                        String text = fullData[i, j].ToString();
                        float x = (float)(startPointX + j * 30 + 7.5);
                        float y = (float)(startPointY + i * 30 + 7.5);
                        g.DrawString(text, font, brush, x, y);
                    }
                }
            }
            else
            {
                brush = new SolidBrush(Color.Red);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (emptyDate[i, j] != 0)
                        {
                            String text = emptyDate[i, j].ToString();
                            float x = (float)(startPointX + j * 30 + 7.5);
                            float y = (float)(startPointY + i * 30 + 7.5);
                            g.DrawString(text, font, brush, x, y);
                        }
                    }
                }
            }

        }

        #endregion

        #region POCETNA DUGMAD

        private void btnColorGraph_Click(object sender, EventArgs e)
        {
            labelGraphInformation.Text = "";
            comboBoxSelectGraph.SelectedIndex = -1;

            panelSudoku.Visible = false;
            panelColorGraph.Visible = true;
        }

        private void btnSudoku_Click(object sender, EventArgs e)
        {
            comboBoxSudokuExample.SelectedIndex = -1;

            panelColorGraph.Visible = false;
            panelSudoku.Visible = true;
        }

        #endregion

        #region PANEL GRAPH

        private void comboBoxSelectGraph_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSolution.Visible = false;
            fileName = ((ComboBox)sender).Text;
            fillInformationLabel(fileName, -1);
        }

        private void btnChromaticNumber_Click(object sender, EventArgs e)
        {
            DSatur dsatur = new DSatur(fileName);
            data = dsatur.main();
            fillInformationLabel(fileName, data.Key);
        }

        private void btnShowSolutionGraphColor_Click(object sender, EventArgs e)
        {
            labelSolution.Text = "";
            for (int i = 0; i < data.Value.Key.GetLength(1); i++)
            {
                String tempText = "Čvor " + (i + 1).ToString() + " ima boju " + data.Value.Key[1, i].ToString() + "\n";
                labelSolution.Text += tempText;
            }
            panelSolution.Visible = true;
        }

        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            LinkedList<int>[] adjacentVertices = data.Value.Value; //susjedni cvorovi
            int chromNum = data.Key; //hromatski broj
            int[,] matrix = data.Value.Key; //matrica sa podacima
            int v = matrix.GetLength(1); //broj cvorova

            DrawGraph forma = new DrawGraph(v, chromNum, matrix, adjacentVertices);
            forma.ShowDialog();
        }

        #endregion

        #region PANEL SUDOKU

        private void comboBoxSudokuExample_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            switch (index)
            {
                case 0:
                    draw(sudoku1, sudoku1, false);
                    break;
                case 1:
                    draw(sudoku2, sudoku2, false);
                    break;
                case 2:
                    draw(sudoku3, sudoku3, false);
                    break;
                case 3:
                    draw(sudoku4, sudoku4, false);
                    break;
                case 4:
                    draw(sudoku5, sudoku5, false);
                    break;
                default:
                    return;
            }
        }

        private void btnSolveSudoku_Click(object sender, EventArgs e)
        {
            int index = comboBoxSudokuExample.SelectedIndex;
            int[,] sudoku;
            switch (index)
            {
                case 0:
                    sudoku = sudoku1;
                    break;
                case 1:
                    sudoku = sudoku2;
                    break;
                case 2:
                    sudoku = sudoku3;
                    break;
                case 3:
                    sudoku = sudoku4;
                    break;
                case 4:
                    sudoku = sudoku5;
                    break;
                default:
                    return;
            }
            SudokuSolution sudokuSolution = new SudokuSolution(81, this.adjacentVerticesArray, 9, 20, sudoku);
            int[,] tempData = sudokuSolution.solution();
            fullData = createSudoku(tempData);
            draw(fullData, sudoku, true);
        }

        #endregion

    }
}
