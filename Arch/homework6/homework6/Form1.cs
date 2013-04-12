using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework6
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            s = new number();
            s.start();
        }
        public Form1 getForm() { return this; }

        state s;
        
        private void button10_Click(object sender, EventArgs e)
        {
            s=s.processEvent('0');
            textBox1.Text=s.setText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s=s.processEvent('1');
            textBox1.Text = s.setText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s=s.processEvent('2');
            textBox1.Text = s.setText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s=s.processEvent('3');
            textBox1.Text = s.setText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s=s.processEvent('4');
            textBox1.Text = s.setText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s=s.processEvent('5');
            textBox1.Text = s.setText();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s=s.processEvent('6');
            textBox1.Text = s.setText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s=s.processEvent('7');
            textBox1.Text = s.setText();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s=s.processEvent('8');
            textBox1.Text = s.setText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s=s.processEvent('9');
            textBox1.Text = s.setText();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            s=s.processEvent('b');
            textBox1.Text = s.setText();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            s=s.processEvent('c');
            textBox1.Text = s.setText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s=s.processEvent('+');
            textBox1.Text = s.setText();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            s=s.processEvent('-');
            textBox1.Text = s.setText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            s=s.processEvent('*');
            textBox1.Text = s.setText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            s=s.processEvent('/');
            textBox1.Text = s.setText();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            s=s.processEvent('s');
            textBox1.Text = s.setText();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            s=s.processEvent('%');
            textBox1.Text = s.setText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            s=s.processEvent('i');
            textBox1.Text = s.setText();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            s=s.processEvent('=');
            textBox1.Text = s.setText();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            s=s.processEvent('f');
            textBox1.Text = s.setText();
        }
    }
}
