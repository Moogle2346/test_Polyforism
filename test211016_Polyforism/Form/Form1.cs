using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test211016_Polyforism.Class;
using test211016_Polyforism.Class.Print;

namespace test211016_Polyforism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Print_A_Click(object sender, EventArgs e)
        {
            Print_TypeA print = new Print_TypeA();
            TextControl textControl = new TextControl(print);

            txt_Notice.Text = textControl.GetText();
        }
        private void btn_Print_B_Click(object sender, EventArgs e)
        {
            Print_TypeB print = new Print_TypeB();
            TextControl textControl = new TextControl(print);

            txt_Notice.Text = textControl.GetText();
        }
    }
}
