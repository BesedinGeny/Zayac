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
using System.Globalization;


namespace ZayacNormProjectimho
{
    public partial class Form2 : Form
    {
        public double[,] dataBase = new double[7, 6];
        public double[,] dataBase1 = new double[7, 6];
        public double Hy, Hx;
        public string name; // имя файла, открытого в главной форме

        private float[] X = new float[50];
        private int[] Y = new int[50];
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name != null)
            {
                label1.Text = name;
                string line;
                int i = 0, n = 50;
                float xMin = 1000, xMax = 0;
                int yMin = 1000, yMax = 0;
                System.IO.StreamReader file =
                    new System.IO.StreamReader(name);


                while ((line = file.ReadLine()) != null) {
                    //reading database
                    float[] numbers = line.Split(' ').Select(
                        snum => float.Parse(snum, new CultureInfo("en-us"))).ToArray();
                    X[i] = numbers[0];
                    Y[i] = (int)numbers[1];

                    //finding min and max els
                    if (xMin > X[i])
                        xMin = X[i];
                    if (xMax < X[i])
                        xMax = X[i];

                    if (yMin > Y[i])
                        yMin = Y[i];
                    if (yMax < Y[i])
                        yMax = Y[i];

                    //increase index
                    i++;
                    n = i;
                }

                //task:
                int r = 7;
                double Rx = (double)(xMax - xMin);
                double Ry = (double)(yMax - yMin);
                Hx = Rx / r;
                Hy = Ry / r;
                int ceilHx = (int) Math.Ceiling(Hx);
                int ceilHY = (int)Math.Ceiling(Hy);
                int xBorderLeft = (int)Math.Floor(xMin);
                int YBorderLeft = yMin;

                // data: n-row
                
                int[] data = new int[7];
                int[] dataY = new int[7];

                // null all els in data
                for ( i = 0; i < 7; i++)
                {
                    data[i] = 0;
                    dataY[i] = 0;
                }
                //getting n-row 
                for ( i = 0; i < n; i++)
                {
                    if (xBorderLeft <= X[i] && X[i] < xBorderLeft + ceilHx)
                        data[0]++;
                    else if (xBorderLeft + ceilHx <= X[i] && X[i] < xBorderLeft + ceilHx * 2)
                        data[1]++;
                    else if (xBorderLeft + ceilHx * 2 <= X[i] && X[i] < xBorderLeft + ceilHx * 3)
                        data[2]++;
                    else if (xBorderLeft + ceilHx * 3 <= X[i] && X[i] < xBorderLeft + ceilHx * 4)
                        data[3]++;
                    else if (xBorderLeft + ceilHx * 4 <= X[i] && X[i] < xBorderLeft + ceilHx * 5)
                        data[4]++;
                    else if (xBorderLeft + ceilHx * 5 <= X[i] && X[i] < xBorderLeft + ceilHx * 6)
                        data[5]++;
                    else if (xBorderLeft + ceilHx * 6 <= X[i] && X[i] < xBorderLeft + ceilHx * 7)
                        data[6]++;
                }
                for (i = 0; i < n; i++)
                {
                    if (YBorderLeft <= Y[i] && Y[i] < YBorderLeft + ceilHY)
                        dataY[0]++;
                    else if (YBorderLeft + ceilHY <= Y[i] && Y[i] < YBorderLeft + ceilHY * 2)
                        dataY[1]++;
                    else if (YBorderLeft + ceilHY * 2 <= Y[i] && Y[i] < YBorderLeft + ceilHY * 3)
                        dataY[2]++;
                    else if (YBorderLeft + ceilHY * 3 <= Y[i] && Y[i] < YBorderLeft + ceilHY * 4)
                        dataY[3]++;
                    else if (YBorderLeft + ceilHY * 4 <= Y[i] && Y[i] < YBorderLeft + ceilHY * 5)
                        dataY[4]++;
                    else if (YBorderLeft + ceilHY * 5 <= Y[i] && Y[i] < YBorderLeft + ceilHY * 6)
                        dataY[5]++;
                    else if (YBorderLeft + ceilHY * 6 <= Y[i] && Y[i] < YBorderLeft + ceilHY * 7)
                        dataY[6]++;
                }

                
                //getting average 
                for ( i = 0; i < r; i++)
                {
                    dataBase[i , 0] = i + 1;
                    dataBase[i , 3] = data[i];
                    //cout << i + 1 << "\t" << dataBase[i , 3] << endl;
                }

                //находим X(i)* = (X(i - 1) + X(i)) / 2;
                //cout << endl << "X(i)*: " << endl;
                for ( i = 0; i < r; i++)
                {
                    int average = (int)((xBorderLeft + ceilHx * i) / 2 + (xBorderLeft + ceilHx * (i + 1)) / 2);
                    dataBase[i , 2] = average;
                    //cout << i + 1 << "\t" << average << endl;
                }

                //находим dataBase[i , 4], dataBase[i , 5]
                //cout << endl << "N(i)/n: " << endl;
                for ( i = 0; i < r; i++)
                {
                    double _out = dataBase[i , 3] / n;
                    dataBase[i , 4] = _out;
                   // cout << i + 1 << "\t" << _out << endl;
                }

                //cout << endl << "N(i) / (n * H(x)): " << endl;
                for ( i = 0; i < r; i++)
                {
                    double _out = dataBase[i , 3] / (ceilHx * n);
                    dataBase[i , 5] = _out;
                    //cout << i + 1 << "\t" << _out << endl;
                }

                



                //YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
                //находим Y(i)* = (X(i - 1) + X(i)) / 2;
                //cout << endl << "X(i)*: " << endl;


                for (i = 0; i < r; i++)
                {
                    dataBase1[i, 0] = i + 1;
                    dataBase1[i, 3] = dataY[i];
                    //cout << i + 1 << "\t" << dataBase[i , 3] << endl;
                }

                for (i = 0; i < r; i++)
                {
                    int average = (int)((YBorderLeft + ceilHY * i) / 2 + (YBorderLeft + ceilHY * (i + 1)) / 2);
                    dataBase1[i, 2] = average;
                    //cout << i + 1 << "\t" << average << endl;
                }

                //находим dataBase1[i , 4], dataBase1[i , 5]
                //cout << endl << "N(i)/n: " << endl;
                for (i = 0; i < r; i++)
                {
                    double _out = dataBase1[i, 3] / n;
                    dataBase1[i, 4] = _out;
                    // cout << i + 1 << "\t" << _out << endl;
                }

                //cout << endl << "N(i) / (n * H(x)): " << endl;
                for (i = 0; i < r; i++)
                {
                    double _out = dataBase1[i, 3] / (ceilHY * n);
                    dataBase1[i, 5] = _out;
                    //cout << i + 1 << "\t" << _out << endl;
                }

                //graphic 
                //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                //chart1.Series[0]
                for ( i = 0; i < 7; i++)
                {
                    chart1.Series[0].Points.AddXY(dataBase[i, 2], (double)dataBase[i, 3] / 50);
                    chart2.Series[0].Points.AddXY(dataBase[i, 2] + 3, dataBase[i, 5]);
                    chart3.Series[0].Points.AddXY(dataBase1[i, 2], (double)dataBase1[i, 3] / 50);
                    chart4.Series[0].Points.AddXY(dataBase1[i, 2] + 3, dataBase1[i, 5]);
                }

                // height - 5 ,width -2
            }
            else
            {
                label1.Text = "Reopen file";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.dataBase = dataBase;
            form3.ShowDialog();
        }

        private void secondTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(dataBase, dataBase1, Hy, Hx);
            form4.ShowDialog();
        }
    }
}
