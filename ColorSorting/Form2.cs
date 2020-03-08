using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            Random rand = new Random();
            List<Color> colorsR = new List<Color>();
            for (int i = 0; i < 100; i++)
            {
                //colors.Add(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                colorsR.Add(Color.FromArgb(rand.Next(0, 255), 0, 0));
            }
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel1.Controls.Add(new Panel() { BackColor = colorsR[count], Margin = new Padding(0, 0, 0, 0) }, i, 0);
                count++;
            }
            colorsR.Clear();
            //***************************
            List<Color> colorsG = new List<Color>();
            for (int i = 0; i < 100; i++)
            {
                //colors.Add(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                colorsG.Add(Color.FromArgb(0, rand.Next(0, 255), 0));
            }
            int countG = 0;

            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel2.Controls.Add(new Panel() { BackColor = colorsG[countG], Margin = new Padding(0, 0, 0, 0) }, i, 0);
                countG++;
            }
            colorsG.Clear();
            //***************************
            List<Color> colorsB = new List<Color>();
            for (int i = 0; i < 100; i++)
            {
                //colors.Add(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                colorsB.Add(Color.FromArgb(0, 0, rand.Next(0, 255)));
            }
            int countB = 0;

            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel3.Controls.Add(new Panel() { BackColor = colorsB[countB], Margin = new Padding(0, 0, 0, 0) }, i, 0);
                countB++;
            }
            colorsB.Clear();
        }

        private  void fooR()
        {
            byte first;
            byte second;

            for (int i = 0; i < 100; i++)
            {

                for (int j = 1 + i; j < 100; j++)
                {
                    Text = j.ToString();
                    first = tableLayoutPanel1.GetControlFromPosition(i, 0).BackColor.R;
                    second = tableLayoutPanel1.GetControlFromPosition(j, 0).BackColor.R;
                    if (first.CompareTo(second) < 0)
                    {
                        tableLayoutPanel1.GetControlFromPosition(i, 0).BackColor = Color.FromArgb(second, 0, 0);
                        tableLayoutPanel1.GetControlFromPosition(j, 0).BackColor = Color.FromArgb(first, 0, 0);
                        //await Task.Delay(1);
                    }
                }
            }
        }



        private  void fooG()
        {
            byte first;
            byte second;

            for (int i = 0; i < 100; i++)
            {

                for (int j = 1 + i; j < 100; j++)
                {
                    Text = j.ToString();
                    first = tableLayoutPanel2.GetControlFromPosition(i, 0).BackColor.G;
                    second = tableLayoutPanel2.GetControlFromPosition(j, 0).BackColor.G;
                    if (first.CompareTo(second) < 0)
                    {
                        tableLayoutPanel2.GetControlFromPosition(i, 0).BackColor = Color.FromArgb(0, second, 0);
                        tableLayoutPanel2.GetControlFromPosition(j, 0).BackColor = Color.FromArgb(0, first, 0);
                        //await Task.Delay(1);
                    }
                }
            }
        }

        private  void fooB()
        {
            byte first;
            byte second;

            for (int i = 0; i < 100; i++)
            {

                for (int j = 1 + i; j < 100; j++)
                {
                    Text = j.ToString();
                    first = tableLayoutPanel3.GetControlFromPosition(i, 0).BackColor.B;
                    second = tableLayoutPanel3.GetControlFromPosition(j, 0).BackColor.B;
                    if (first.CompareTo(second) < 0)
                    {
                        tableLayoutPanel3.GetControlFromPosition(i, 0).BackColor = Color.FromArgb(0, 0, second);
                        tableLayoutPanel3.GetControlFromPosition(j, 0).BackColor = Color.FromArgb(0, 0, first);
                        //await Task.Delay(1);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fooR();
            fooG();
            fooB();
        }
    }
}
