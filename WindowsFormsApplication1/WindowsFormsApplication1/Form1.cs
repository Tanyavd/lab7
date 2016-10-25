using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int click = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonf_Click(object sender, EventArgs e)
        {
            label1f.Text = "Hellow";
        }
        void OvalForm(Button btn)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();

            //Создаем новый прямоуголник с размерами кнопки
            Rectangle rect = btn.ClientRectangle;

            //уменьшаем размеры прямоуголника
            rect.Inflate(-3, -3);

            //создаем эллипс
            gp.AddEllipse(rect);
            btn.Region = new Region(gp);

            //рисуем рамку для овальной кнопки
            g.DrawEllipse(new Pen(Color.Black, 2),
            btn.Left + 1, btn.Top + 1,
            btn.Width - 3, btn.Height - 3);

            //высвобождаем память
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OvalForm(button1);
        }

        private void button2ff_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            button1.Text = (++click).ToString();
            button1.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)); 
        }
    }
}
