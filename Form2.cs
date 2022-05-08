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

namespace Пара_ОП_06._04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Первое задание. Текст менял цвет, становился прозрачным. Нужен Label1

        private void redIfChekedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redIfChekedToolStripMenuItem.Checked)
            {
                redIfChekedToolStripMenuItem.Checked = false;
                //label1.ForeColor = Color.Black;
            }
            else
            {
                redIfChekedToolStripMenuItem.Checked=true;
                //label1.ForeColor = Color.Red;
            }
        }

        private void apossityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(apossityToolStripMenuItem.Checked)
            {
                apossityToolStripMenuItem.Checked = false;
                //label1.Visible = false;
            }
            else
            {
                apossityToolStripMenuItem.Checked=true; 
                //label1.Visible = true;
            }
        }

        StreamReader sr;

        private void button1_Click(object sender, EventArgs e)
        {
            sr = new StreamReader(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(sr.ReadLine());
        }
    }
}
