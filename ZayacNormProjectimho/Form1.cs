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

namespace ZayacNormProjectimho
{
    public partial class Form1 : Form
    {

        public double[,] dataBase = new double[7, 6];
        public string name; // имя используещегося файла
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                name = openFileDialog1.FileName;
            }
            label2.Text = name;
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.name = name;
            form2.ShowDialog();
        }
    }
}
