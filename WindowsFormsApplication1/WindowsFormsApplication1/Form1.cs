using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonff_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 5))
            {
                case 0: buttonff.BackColor = Color.Lavender; break;
                case 1: buttonff.BackColor = Color.Cyan; break;
                case 2: buttonff.BackColor = Color.Magenta; break;
                case 3: buttonff.BackColor = Color.Yellow; break;
                case 4: buttonff.BackColor = Color.Red; break;

            }
        }
    }
}
