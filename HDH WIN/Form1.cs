using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH_WIN
{
    public partial class Form1 : Form
    {
        static int cnt = 0;
        int speed = 3;
        int favor;
        bool[] flag=new bool[2];
       
        public Form1()
        {
            
            InitializeComponent();
            Bum.Visible = false;
            Do.Visible = false;
            Do1.Visible = false;
            Xanh.Visible = false;
            Xanh1.Visible = false;
            flag[0] = false;
            flag[1] = false;
            favor = 0;
        }
        private void process(int id)
        {
            do
            {
                int other = 1 - id;
                flag[id] = true;
                favor = other;
                while (flag[other] == true && favor == other) { flag[id] = false; flag[other] = false; process(other); }
                GameTimer.Tick += GameTimerEvent;
                flag[id] = false;
                break;

            } while (true);
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {

            if (cnt == -1)
            {
                carpink.Left += speed;
                carblue.Top -= speed;
                if (carpink.Left >= 695)
                {
                    carpink.Left = 32;
                }
                if (carblue.Top <= 3)
                {
                    carblue.Top = 526;
                }
                if (carpink.Bounds.IntersectsWith(carblue.Bounds))
                {
                    GameOver();
                }
            }
            else if (cnt == 1 && flag[0] == false)
            {
                if (flag[0]==false) Do.Visible=true;
                Xanh1.Visible = true;
                
                if(carpink.Left >= 140)
                {
                    if(carblue.Top >= -150)
                    {
                        carpink.Left = 140;
                    }
                }
                if (carblue.Top <= -100)
                {
                    Do1.Visible = true; Xanh1.Visible = false; Do.Visible = false; Xanh.Visible = true;
                }
                carpink.Left += speed;
                carblue.Top -= speed;
                if (carpink.Left >= 650) GameOver1();
            }
            else if (cnt == 0 && flag[1] == false)
            {
                Xanh.Visible = true;
                if (carblue.Top <= 250 && flag[1]==false)
                {
                    Do1.Visible = true;
                }

                if (carblue.Top <= 200)
                { 
                    if(carpink.Left <= 650)
                    carblue.Top = 200;
                }
                if (carpink.Left >= 645) { Xanh1.Visible = true; Do1.Visible = false; Xanh.Visible = false; Do.Visible = true; }
                if (carblue.Top <= -100)
                {
                     GameOver1();
                }
                
                carpink.Left += speed;
                carblue.Top -= speed;
            }
            
        }
        private void GameOver()
        {
            GameTimer.Stop();
            carblue.Visible = false;
            carpink.Visible = false; 
            Bum.Visible = true;

            MessageBox.Show("HAI XE DA CHAM NHAU","THONG BAO");

            Bum.Visible = false;
        }
        private void GameOver1()
        {

            GameTimer.Stop();
            MessageBox.Show("DA CHAY XONG", "THONG BAO");
            Do1.Visible=false;
            Xanh1.Visible=false;
            Do.Visible=false;
            Xanh.Visible=false;
         //   InitializeComponent();
        }
        private void nopeterson_Click(object sender, EventArgs e)
        {
            cnt = -1;
            GameTimer.Tick += GameTimerEvent;
        }

        private void PCPink_Click(object sender, EventArgs e)
        {
            cnt = 0;
            process(cnt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // cnt = 1;
         //   flag[0] = true;
            //flag[1] = true;
           // process(cnt);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cnt = 1;
            process(cnt);
        }

        private void carblue_Click(object sender, EventArgs e)
        {

        }

        

        private void Xanh1_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bum_Click(object sender, EventArgs e)
        {

        }
      
    }
}