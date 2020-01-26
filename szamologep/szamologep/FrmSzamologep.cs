using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            CbMuvelet.SelectedIndex = 0;
        }

        private void lblEq_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            if (int.TryParse(TbX.Text, out x) & int.TryParse(TbY.Text, out y))
            {
                if(CbMuvelet.SelectedItem.ToString() =="*")
                {
                    LblEredmeny.Text = x * y + "";
                }
                if (CbMuvelet.SelectedItem.ToString() == "+")
                {
                    LblEredmeny.Text = x + y + "";
                }
                if (CbMuvelet.SelectedItem.ToString() == "-")
                {
                    LblEredmeny.Text = x - y + "";
                }
                if (CbMuvelet.SelectedItem.ToString() == "/")
                {
                    LblEredmeny.Text = x / (float)y + "";
                }
                if (CbMuvelet.SelectedItem.ToString() == "^")
                {
                    LblEredmeny.Text = Math.Pow(x, y) + "";
                }
                if (CbMuvelet.SelectedItem.ToString() == "%")
                {
                    LblEredmeny.Text = x % y + "";
                }
               


            }
            else
            {
                MessageBox.Show("Fullba nyomod a kretént!\n Sose nyomd fullba a kretént!");
            }

        }
    }
}
