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
                double Rx = xMax - xMin;
                double Hx = Rx / r;
                int ceilHx = (int) Math.Ceiling(Hx);

                // data: n-row
                int[,] dataBase = new int[6,7];
                int[] data = new int[7];
                // null all els in data
                for ( i = 0; i < 7; i++)
                {
                    data[i] = 0;
                }
                //getting n-row
                for ( i = 0; i < n; i++)
                {
                    if (56 <= X[i] && X[i] < 62)
                        data[0]++;
                    else if (62 <= X[i] && X[i] < 68)
                        data[1]++;
                    else if (68 <= X[i] && X[i] < 74)
                        data[2]++;
                    else if (74 <= X[i] && X[i] < 80)
                        data[3]++;
                    else if (80 <= X[i] && X[i] < 86)
                        data[4]++;
                    else if (86 <= X[i] && X[i] < 92)
                        data[5]++;
                    else if (92 <= X[i] && X[i] < 98)
                        data[6]++;
                }

            }
            else
            {
                label1.Text = "Reopen file";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
