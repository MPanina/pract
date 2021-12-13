using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string an1 = "материнская плата";
        string an2 = "чипсет";
        string an3 = "оперативная память";
        string an4 = "тактовая частота";
        string an5 = "кэш";
        string an6 = "процессор";
        string an7 = "матричный";
        string an8 = "графический адаптер";
        string an9 = "сокет";
        //string an10 = "разрядность";

        private void button1_Click(object sender, EventArgs e)
        {
            string An1 = textBox1.Text;
            string An2 = textBox2.Text;
            string An3 = textBox3.Text;
            string An4 = textBox4.Text;
            string An5 = textBox5.Text;
            string An6 = textBox6.Text;
            string An7 = textBox7.Text;
            string An8 = textBox8.Text;
            string An9 = textBox9.Text;
            //string An10 = textBox10.Text;
            if (An1 == an1 && An2 == an2 && An3 == an3 && An4 == an4 && An5 == an5 && An6 == an6 && An7 == an7
                && An8 == an8 && An9 == an9/* && An10 == an10*/)
            {
                MessageBox.Show("дима иванов легенда","проверка работы программы");
            }
            else
            {
                MessageBox.Show("долбоеб", "почему?");
            }
            label2.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.Show();
        }
    }
}
