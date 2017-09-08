using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Form2 form2 = new Form2())
            {
                DialogResult result = form2.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Console.WriteLine("OKがクリックされました");
                }
                else if (result == DialogResult.Cancel)
                {
                    Console.WriteLine("Cancelがクリックされました");
                }

            }
        }
    }
}
