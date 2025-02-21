using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAJONCHOSSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        double costmajonchos;
        int CantidadMajonchos;
        double totalmajonchocost;

        private void CAntidadMAjonchos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            costmajonchos = Convert.ToDouble(textBox2.Text);
            CantidadMajonchos = Convert.ToInt32(textBox1. Text);
            totalmajonchocost = costmajonchos * CantidadMajonchos;
            textBox3.Text = "$" + Convert.ToInt32(totalmajonchocost);
        }
    }


}
