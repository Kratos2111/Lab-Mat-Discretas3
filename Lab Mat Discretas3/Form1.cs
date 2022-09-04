using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Mat_Discretas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Focus();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            DATOS.num1 = int.Parse(txtNum1.Text);
            DATOS.num2 = int.Parse(txtNum2.Text);
            if (DATOS.testNums())
            {
                MessageBox.Show(DATOS.suma());
            }
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DATOS.numeroPrimo());
        }
    }
}
