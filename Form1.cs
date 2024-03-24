using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        maaslar maas = new maaslar();

        private void button1_Click(object sender, EventArgs e)
        {
            maas.gun = Convert.ToInt16(textBox1.Text);
            label3.Text = (maas.hesapla()).ToString();
        
            

        }
    }
}
