using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2forms
{
    public partial class Form1 : Form
    {
        
        public Form1(string s1 = "hi")
        {
            InitializeComponent();
            textBox1.Text = s1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(textBox1.Text);
            f2.Show();
            this.Hide();
        }
    }
}
