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
    public partial class shop : Form
    {
        public shop()
        {
            InitializeComponent();
        }
        Class1 sınıf = new Class1();

        private static void arttır(ref int a)
        {
            Class1 sınıf = new Class1();
             a = sınıf.artırma;
        }
        int b;
        private void btn2X_Click(object sender, EventArgs e)
        {
            b = 2;
            arttır(ref b);
        }

        private void btn3X_Click(object sender, EventArgs e)
        {
            sınıf.artırma = 3;
        }

        private void btn4X_Click(object sender, EventArgs e)
        {
            sınıf.artırma = 4;
        }
    }
}
