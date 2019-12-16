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
                int i = 0;
                System.IO.StreamReader file =
                    new System.IO.StreamReader(name);
                while ((line = file.ReadLine()) != null) {
                    float[] numbers = line.Split(' ').Select(snum => float.Parse(snum, new CultureInfo("en-us"))).ToArray();
                    X[i] = numbers[0];
                    Y[i] = (int)numbers[1];
                    i++;

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
