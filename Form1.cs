using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStimulator
{
    public partial class Form1 : Form
    {

        int speed = 2;
        private int startingpointX=200;
        private int startingpointY= 200;
        

        public Form1()
        {
            InitializeComponent();
           
            startingpointX = car1.Left;
            startingpointY = car1.Top;
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


          car1.Location = new Point(car1.Location.X - speed , car1.Location.Y);

        }

        private void gear1_CheckedChanged(object sender, EventArgs e)
        {
            speed = 4;
        }

        private void gear2_CheckedChanged(object sender, EventArgs e)
        {
            speed = 7;
        }

        private void txtmove_Click(object sender, EventArgs e)
        {
            timer1.Start();

           
        }

        private void txtlaunch_Click(object sender, EventArgs e)
        {
           
           
            
            car1.Left = startingpointX;
            car1.Top = startingpointY;
            timer1.Stop();  
            
        }

        private void gear3_CheckedChanged(object sender, EventArgs e)
        {
            speed = 10;
        }

        private void gear4_CheckedChanged(object sender, EventArgs e)
        {
            speed = 40;
        }

       

        private void txtBrake_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
