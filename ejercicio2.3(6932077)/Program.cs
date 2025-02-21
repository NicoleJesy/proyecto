using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._3_6932077_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal MajonchoCost;
        int CantidadadMajonchos;
        decimal TotalMajonchocost;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MajonchoCost = Convert.ToDecimal(costo.Text);
            CantidadadMajonchos = Convert.ToInt32(cantidad.Text);
            TotalMajonchocost = MajonchoCost * CantidadadMajonchos;
            total.Text = "Pagar: " + Convert.ToString(TotalMajonchocost);
        }

    }
}


