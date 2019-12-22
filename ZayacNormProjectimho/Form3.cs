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
    public partial class Form3 : Form
    {
        public double[,] dataBase = new double[7, 6];


        public Form3()
        {
            InitializeComponent();
        }

        public void On_load(object sender, EventArgs e) {
            dataGridView1.RowCount = 7;
            //dataGridView1.Rows[0].Cells[1].Value = dataBase[0, 1];
            for (int i = 0; i < 7; i++) {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 6; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = dataBase[i, j];
                }
            }
        }
    }
}
