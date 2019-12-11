using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        Thread t1, t2, t3, t4;
        Random r;
        public Form1()
        {
            r = new Random();

            InitializeComponent();
    
            t1 = new Thread(func1);
            t2 = new Thread(func2);
            t3 = new Thread(func3);
            t4 = new Thread(func4);
        }

        public void func1()
        {
            
            for (int i = 0; i < 100; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);

                this.CreateGraphics().DrawLine(new Pen(Color.Red, 3), x, y, x + 10, y);
                this.CreateGraphics().DrawLine(new Pen(Color.Red, 3), x + 10, y, x + 10, y + 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Red, 3), x + 10, y + 5, x, y + 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Red, 3), x, y + 5, x, y + 10);
                this.CreateGraphics().DrawLine(new Pen(Color.Red, 3), x, y + 10, x + 10, y + 10);
                Thread.Sleep(120);

            }
        }
        public void func2()
        {
            
            for (int i = 0; i < 100; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);

                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x, y, x + 10, y);
                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x + 10, y, x + 10, y + 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x + 10, y + 5, x, y + 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x, y + 5, x+10, y + 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x + 10, y + 5, x + 10, y + 10);
                this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x + 10, y + 10, x, y + 10);
                Thread.Sleep(120);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t4.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t3.Start();
        }

        public void func3()
        {
            
            for (int i = 0; i < 100; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawLine(new Pen(Color.Blue, 3), x, y, x, y +7.5f );
                this.CreateGraphics().DrawLine(new Pen(Color.Blue, 3), x, y + 7.5f, x + 7.5f, y + 7.5f);
                this.CreateGraphics().DrawLine(new Pen(Color.Blue, 3), x + 7.5f, y + 7.5f, x + 7.5f, y);
                this.CreateGraphics().DrawLine(new Pen(Color.Blue, 3), x + 7.5f, y, x + 7.5f, y + 15f);
                Thread.Sleep(120);
            }
        }
        public void func4()
        {
            
            for (int i = 0; i < 100; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawLine(new Pen(Color.Green, 3), x, y, x + 10, y);
                this.CreateGraphics().DrawLine(new Pen(Color.Green, 3), x + 10, y, x + 10, y - 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Green, 3), x + 10, y - 5, x, y - 5);
                this.CreateGraphics().DrawLine(new Pen(Color.Green, 3), x, y - 5, x, y - 10);
                this.CreateGraphics().DrawLine(new Pen(Color.Green, 3), x, y - 10, x + 10, y - 10);
                Thread.Sleep(120);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            t1.Start();

        }
    }
}
