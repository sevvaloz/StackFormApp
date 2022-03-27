using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack stack = new Stack();

        private void btn_push_Click(object sender, EventArgs e)
        {
            stack.Push(Convert.ToInt32(sayi.Text));
            listView.Items.Add(stack.elemanlariYazdir());
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            stack.Pop();
            listView.Items.Add(stack.elemanlariYazdir());
        }
    }
}
