using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] sayılar = {5,8,12,45,15,68,23,54};
            listBox1.Items.Clear();
            for (int i = 0; i < sayılar.Length; i++)
			{
			 if(sayılar[i]%Convert.ToInt32(textBox1.Text)==0)
            {
              listBox1.Items.Add(sayılar[i]);
            }
			}

        }
    }
}
