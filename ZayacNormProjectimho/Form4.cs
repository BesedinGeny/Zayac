using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZayacNormProjectimho
{
    public partial class Form4 : Form
    {

        public double[,] dataBase = new double[7, 6];
        public double[,] dataBase1 = new double[7, 6];

        public double Hy, Hx;
        public Form4( double[,] db, double[,] db1,  double y, double x)
        {
            dataBase = db;
            dataBase1 = db1;
            Hy = y;
            Hx = x;
            InitializeComponent();
        }


        public void On_load(object sender, EventArgs e)
        {

            double[,] utable = new double[7, 6];
            double[,] vtable = new double[7, 6];

            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Rows.Add();
                utable[i, 0] = i + 1;
                utable[i, 1] = (dataBase[i, 2] - dataBase[3, 2]) / Hx;
                utable[i, 2] = dataBase[i, 3];
                utable[i, 3] = utable[i, 1] * utable[i, 2];
                utable[i, 4] = utable[i, 3] * utable[i, 1];

                dataGridView2.Rows.Add();
                vtable[i, 0] = i + 1;
                vtable[i, 1] = (dataBase1[i, 2] - dataBase1[3, 2]) / Hx;
                vtable[i, 2] = dataBase1[i, 3];
                vtable[i, 3] = vtable[i, 1] * vtable[i, 2];
                vtable[i, 4] = vtable[i, 3] * vtable[i, 1];
            }


            double u1 = 0, u2 = 0, s1, v1 = 0, v2 = 0, s2;
            for (int i = 0; i < 7; i++)
            {
                u1 += utable[i, 3];
                u2 += utable[i, 4];
                v1 += vtable[i, 3];
                v2 += vtable[i, 4];
            }
            u1 /= 50; u2 /= 50; v1 /= 50; v2 /= 50;
            s1 = 50.0 / 49 * (u2 - u1 * u1);
            s2 = 50.0 / 49 * (v2 - v1 * v1);
            label12.Text = u1.ToString();
            label11.Text = u2.ToString();
            label10.Text = s1.ToString();
            label9.Text = v1.ToString();
            label8.Text = v2.ToString();
            label7.Text = s2.ToString();
        }
    }




}
