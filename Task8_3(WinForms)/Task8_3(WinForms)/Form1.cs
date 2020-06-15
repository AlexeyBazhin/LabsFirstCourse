using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8_3_WinForms_
{
    public partial class Form1 : Form
    {
        List<string> vertexList = new List<string>();
        List<Rib> ribList = new List<Rib>();
        int currentTest = 1;

        public Form1()
        {            
            InitializeComponent();
            DefaultItems();
        }

        //очистить все данные
        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            DefaultItems();
        }

        //установка начальных позиций у всех элементов управления
        private void DefaultItems()
        {
            addRibButton.Enabled = false;
            countButton.Enabled = false;
            deleteRibMenuItem.Enabled = false;
            deleteVertexMenuItem.Enabled = false;
            vertexList.Clear();
            ribList.Clear();
            graphTextBox.Text = "";
            vertexDataGridView.Rows.Clear();
            ribDataGridView.Rows.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }
        //
        //Обновление таблиц данных
        //
        private void UpdateVertexTable()
        {
            vertexDataGridView.Rows.Clear();
            int index = 1;
            foreach (var item in vertexList)
            {
                vertexDataGridView.Rows.Add(index++, item);
            }
        }

        private void UpdateRibTable()
        {
            ribDataGridView.Rows.Clear();
            int index = 1;
            foreach (var item in ribList)
            {
                ribDataGridView.Rows.Add(index++, $"({item.beg};{item.end})");
            }
        }

        //
        //Добавление вершины
        //
        private void addVertexButton_Click(object sender, EventArgs e)
        {            
            string vertex = vertexTextBox.Text.Trim();
            if (!vertexList.Contains(vertex))
            {
                vertexList.Add(vertex);
                UpdateVertexTable();
            }
            else
            {
                MessageBox.Show("Ошибка! Данная вершина уже была добавлена.", "Добавление вершины");
            }

            comboBox1.Items.Add(vertex);
            comboBox2.Items.Add(vertex);

            vertexTextBox.Text = "";

            deleteVertexMenuItem.Enabled = true;
            addRibButton.Enabled = true;
            countButton.Enabled = true;
            deleteVertexMenuItem.Enabled = true;
        }


        //
        //Добавление ребра
        //
        private void addRibButton_Click(object sender, EventArgs e)
        {
            deleteRibMenuItem.Enabled = true;

            string ribBeg = comboBox1.Text;
            string ribEnd = comboBox2.Text;

            if (ribBeg != ribEnd)
            {
                if (!ribList.Contains(new Rib(ribBeg, ribEnd)))
                {
                    ribList.Add(new Rib(ribBeg, ribEnd));
                    UpdateRibTable();
                }
                else
                {
                    MessageBox.Show("Ошибка! Данное ребро уже было добавлено.", "Добавление ребра");
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Вы не можете добавить ребро с одинаковыми концами.", "Добавление ребра");
            }
        }

        //
        //Создать матрицу смежности и посчитать кол-во компонент связности
        //
        private void countButton_Click(object sender, EventArgs e)
        {
            CreateGraph();
        }

        private void CreateGraph()
        {
            graphTextBox.Text = "";
            bool[,] graph = new bool[vertexList.Count, vertexList.Count];
            int singleVertex = 0;
            MakeMatrix(ref graph, ref singleVertex);
            graphTextBox.Text += $"Кол-во компонент \r\nсвязности: {CountComponents(graph) + singleVertex} \r\n\r\n";
            PrintGraph(graph);
        }
        //
        //Заполнить матрицу смежности
        //
        private void MakeMatrix(ref bool[,] graph, ref int singleVertex)
        {
            bool isSingleVertex = true;
            singleVertex = 0;
            for (int i = 0; i < vertexList.Count; i++)
            {
                isSingleVertex = true;
                for (int j = 0; j < ribList.Count; j++)
                {
                    if (ribList[j].beg == vertexList[i])
                    {
                        isSingleVertex = false;
                        int index = vertexList.IndexOf(ribList[j].end);
                        graph[i, index] = true;
                        graph[index, i] = true;
                        continue;
                    }

                    if (ribList[j].end == vertexList[i])
                    {
                        isSingleVertex = false;
                        int index = vertexList.IndexOf(ribList[j].beg);
                        graph[i, index] = true;
                        graph[index, i] = true;
                        continue;
                    }
                }

                if (isSingleVertex)
                {
                    singleVertex++;
                }
            }
        }

        //
        //Посчитать кол-во компонент связности
        //
        private int CountComponents(bool[,] graph)
        {
            bool[,] isPassed = new bool[graph.GetLength(0), graph.GetLength(0)];
            int count = 0;
            bool isCompanent = false;

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                isCompanent = false;
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] == true && isPassed[i, j] == false)
                    {
                        FillCompanents(graph, ref isPassed, i, j);
                        isCompanent = true;
                    }
                }

                if (isCompanent)
                {
                    count++;
                }
            }
            return count;
        }

        //
        //Отметить все вершины текущей компаненты связности
        //
        private void FillCompanents(bool[,] graph, ref bool[,] isPassed, int i, int j)
        {
            isPassed[i, j] = true;
            isPassed[j, i] = true;

            for (int j1 = 0; j1 < graph.GetLength(0); j1++)
            {
                if (graph[j, j1] == true && isPassed[j, j1] == false)
                {
                    FillCompanents(graph, ref isPassed, j, j1);
                }
            }
        }

        //
        //Печать матрицы смежности
        //
        private void PrintGraph(bool[,] graph)
        {
            graphTextBox.Text += "  ";
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                graphTextBox.Text += vertexList[i] + " ";
            }

            graphTextBox.Text += "\r\n";

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                graphTextBox.Text += vertexList[i] + " ";
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] == false)
                    {
                        graphTextBox.Text += 0 + " ";
                    }
                    else
                    {
                        graphTextBox.Text += 1 + " ";
                    }
                }
                graphTextBox.Text += "\r\n";
            }
        }

        #region Delete
        //
        //Удаление вершины
        //
        private void deleteVertexMenuItem_Click(object sender, EventArgs e)
        {
            int indexOfDeletedRow = vertexDataGridView.SelectedCells[0].RowIndex;

            if (indexOfDeletedRow >= vertexList.Count)
            {
                return;
            }

            if (ribList.Count != 0)
            {
                ribList.RemoveAll(x => x.beg == vertexList[indexOfDeletedRow] || x.end == vertexList[indexOfDeletedRow]);
                if (ribList.Count == 0)
                {
                    MessageBox.Show("Все ребра удалены!", "Удаление");
                    deleteRibMenuItem.Enabled = false; ;
                }
            }              
            
            vertexList.RemoveAt(indexOfDeletedRow);

            UpdateRibTable();
            UpdateVertexTable();
            vertexTextBox.Text = "";

            if (vertexList.Count == 0)
            {
                MessageBox.Show("Все вершины удалены!", "Удаление");
                DefaultItems();
            }
        }
        //
        //Удаление ребра
        //
        private void deleteRibMenuItem_Click(object sender, EventArgs e)
        {
            int indexOfDeletedRow = ribDataGridView.SelectedCells[0].RowIndex;

            if (indexOfDeletedRow >= ribList.Count)
            {
                return;
            }

            ribList.RemoveAt(indexOfDeletedRow);
            UpdateRibTable();

            if (ribList.Count == 0)
            {
                MessageBox.Show("Все ребра удалены!", "Удаление");
                deleteRibMenuItem.Enabled = false; ;
            }
        }
        #endregion
        //
        //Генератор тестов
        //
        private void запуститьГенераторТестовToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Генератор тестов был составлен по критериям ЧЯ:\n" +
                            "Классы входных данных:\n" +
                            "   1.1) Кол-во вершин: 1; 2; много...\n" +
                            "   1.2) Кол-во ребер: 0; 1; много...\n" +
                            "Классы выходных данных:\n" +
                            "   2.1) Кол-во компанент связности: 1; 2; много...",
                "Генератор тестов");
            DefaultItems();
            currentTest = 1;
            addVertexButton.Enabled = false;
            testStopButton.Visible = true;
            testNextButton.Visible = true;

            TestGenerator();
        }

        private void TestGenerator()
        {
            Random rnd = new Random();
            int vertexCount = 0;
            int firstVertex = 0;
            int secondVertex = 0;
            switch (currentTest)
            {
                case 0:
                    testStopButton.Visible = false;
                    testNextButton.Visible = false;
                    addVertexButton.Enabled = true;
                    DefaultItems();
                    currentTest = 1;
                    MessageBox.Show("Тестирование прекращено.", "Генератор тестов");
                    break;

                case 1://1 вершина, 0 ребер, 1 компонента
                    MessageBox.Show("1 вершина, 0 ребер, 1 компонента", $"Генератор тестов. Тест №{currentTest}");
                    vertexList.Add("1");
                    CreateGraph();
                    currentTest++;
                    break;

                case 2://2 вершины, 1 ребро, 1 компонента
                    MessageBox.Show("2 вершины, 1 ребро, 1 компонента", $"Генератор тестов. Тест №{currentTest}");
                    for (int i = 0; i < 2; i++)
                        vertexList.Add((i+1).ToString());
                    ribList.Add(new Rib(vertexList[0], vertexList[1]));
                    CreateGraph();
                    currentTest++;
                    break;

                case 3://2 вершины, 0 ребер, 2 компоненты
                    MessageBox.Show("2 вершины, 0 ребер, 2 компоненты", $"Генератор тестов. Тест №{currentTest}");
                    for (int i = 0; i < 2; i++)
                        vertexList.Add((i + 1).ToString());                    
                    CreateGraph();
                    currentTest++;
                    break;

                case 4://много вершин, 0 ребер, много компонент
                    MessageBox.Show("много вершин, 0 ребер, много компонент", $"Генератор тестов. Тест №{currentTest}");
                    vertexCount = rnd.Next(3, 15);
                    for (int i = 0; i < vertexCount; i++)
                        vertexList.Add((i + 1).ToString());
                    CreateGraph();
                    currentTest++;
                    break;

                case 5://много вершин, 1 ребро, много компонент (вершина - 1)
                    MessageBox.Show("много вершин, 1 ребро, много компонент (вершина - 1)", $"Генератор тестов. Тест №{currentTest}");
                    vertexCount = rnd.Next(3, 15);

                    for (int i = 0; i < vertexCount; i++)
                        vertexList.Add((i + 1).ToString());

                    firstVertex = rnd.Next(vertexCount);
                    secondVertex = 0;
                    do
                    {
                        secondVertex = rnd.Next(vertexCount);
                    } while (secondVertex == firstVertex);

                    ribList.Add(new Rib(vertexList[firstVertex], vertexList[secondVertex]));
                    CreateGraph();
                    currentTest++;
                    break;

                case 6://много вершин, много ребер, 1 компанента
                    MessageBox.Show("много вершин, много ребер, 1 компанента", $"Генератор тестов. Тест №{currentTest}");
                    GenerateVertexNRibs(5, 10, 0);
                    CreateGraph();
                    currentTest++;
                    break;

                case 7://много вершин, много ребер, 2 компаненты
                    MessageBox.Show("много вершин, много ребер, 2 компаненты", $"Генератор тестов. Тест №{currentTest}");
                    GenerateVertexNRibs(5, 10, 1);
                    CreateGraph();
                    currentTest++;
                    break;

                case 8://много вершин, много ребер, много компанент
                    {
                        //всего n вершин, из половины мы делаем одну компаненту, из n-2 и n-1 вершин тоже делаем компаненту (n-ая вершина остается одиночной)
                        MessageBox.Show("много вершин, много ребер, много компанент", $"Генератор тестов. Тест №{currentTest}");
                        GenerateVertexNRibs(5, 10, -1);
                        ribList.Add(new Rib(vertexList[vertexList.Count - 2], vertexList[vertexList.Count - 3]));
                        CreateGraph();
                        currentTest++;
                    }
                    break;
            }
        }
        //псевдослучайная генерация ребер и вершин
        private void GenerateVertexNRibs(int min, int max, int removedVertexCount)//removedVertexCount - сколько вершин мы отбрасываем, оставляем одиночными
        {
            Random rnd = new Random();
            int vertexCount = rnd.Next(min, max);

            if (removedVertexCount == -1)//небольшой костыль для 8 теста
            {
                removedVertexCount = (int)Math.Ceiling((Double)vertexCount / 2.0);//Отделяем половину вершин графа
            }

            for (int i = 0; i < vertexCount; i++)
            {
                vertexList.Add((i + 1).ToString());
            }

            int ribCount = rnd.Next(vertexCount - removedVertexCount - 1, 
                                   ((vertexCount - removedVertexCount) * (vertexCount - removedVertexCount - 1)) / 2);

            for (int i = 0; i < vertexCount - removedVertexCount - 1; i++)
            {
                ribList.Add(new Rib(vertexList[i], vertexList[i + 1]));
            }

            for (int i = 0; i < vertexCount - removedVertexCount; i++)
            {
                for (int j = 0; j < vertexCount - removedVertexCount; j++)
                {
                    if (i != j && !ribList.Contains(new Rib(vertexList[i], vertexList[j])))
                    {
                        ribList.Add(new Rib(vertexList[i], vertexList[j]));
                    }

                    if (ribList.Count == ribCount)
                    {
                        break;
                    }
                }

                if (ribList.Count == ribCount)
                {
                    break;
                }
            }

        }

        private void testNextButton_Click(object sender, EventArgs e)
        {
            if (currentTest == 9)
            {
                currentTest = 0;
            }
            DefaultItems();
            TestGenerator();
        }

        private void testStopButton_Click(object sender, EventArgs e)
        {
            currentTest = 0;
            TestGenerator();
        }
    }
}
