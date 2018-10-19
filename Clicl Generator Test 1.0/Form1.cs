using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicl_Generator_Test_1._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Class1 sınıf = new Class1();
        static void arttır(ref int s)
        {
            Class1 sınıf = new Class1();
           s= s + sınıf.artırma;

        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            arttır(ref sınıf.Puan);
            LabelPuan.Text = sınıf.Puan.ToString();
            label1.Text = sınıf.artırma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shop form = new shop();
            form.Show();
        }
    }
}
