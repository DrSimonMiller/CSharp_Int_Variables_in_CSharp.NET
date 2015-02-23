using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Int_Variables_in_CSharp.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntegers_Click(object sender, EventArgs e)
        {
            const int myNumber = 25;
            MessageBox.Show(myNumber.ToString());
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            const float myFloat = 0.42F;
            MessageBox.Show(myFloat.ToString());

        }

        private void myDouble_Click(object sender, EventArgs e)
        {
            const double myDouble = 0.007;
            MessageBox.Show(myDouble.ToString());
        }
    }
}
