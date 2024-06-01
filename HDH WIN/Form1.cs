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
        int speed = 2;
        int favor;
        bool[] flag=new bool[2];
        int ans=-1;
        public Form1()
        {
            
            InitializeComponent();
            tablepc0.Visible = false;
            tablepc1.Visible = false;
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
                while (flag[other] == true && favor == other) { flag[id] = false; flag[other] = false; ans=other; }
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
                if (carpink.Bounds.IntersectsWith(carblue.Bounds))
                {
                    GameOver();
                }
            }
            else if (cnt == 1  && ans==-1)
            {
                tablepc1.Visible = true;
                if (flag[0]==false) Do.Visible=true;
                Xanh1.Visible = true;
                if (carblue.Top <= 55) { tablepc1.Visible = false; tablepc0.Visible = true; Do1.Visible = true; Xanh1.Visible = false;}
                if (carblue.Top <= -100)
                {
                    Do.Visible = false; Xanh.Visible = true;
                }
                if (carpink.Left >= 320) { tablepc1.Visible = true; tablepc0.Visible = false; Do.Visible = true; Xanh.Visible = false; }
                if(carpink.Left<=140 || carblue.Top<=-150)
                carpink.Left += speed;
                carblue.Top -= speed;
                if (carpink.Left >= 650) GameOver1();
            }

            else if (cnt == 0  && ans == -1)
            {
                tablepc0.Visible = true;
                Xanh.Visible = true;
                Do1.Visible = true;
                if (carpink.Left >= 320) { Do.Visible = true; Xanh.Visible = false; tablepc0.Visible = false; tablepc1.Visible = true; }
                if (carpink.Left >= 600) { Xanh1.Visible = true; Do1.Visible = false;  }
                if (carblue.Top <= 55) { tablepc1.Visible = false; tablepc0.Visible = true; Do1.Visible = true; Xanh1.Visible=false;}
                if (carblue.Top <= -100)
                {
                     GameOver1();
                }
                
                carpink.Left += speed;
                if(carblue.Top >= 200 || carpink.Left >= 650 )
                carblue.Top -= speed;
            }

            else if (ans!=-1 && flag[0] == false && flag[1] == false)
            {

                Xanh.Visible = true;
                Xanh1.Visible = true;
                Do.Visible = false;
                Do1.Visible = false;
                if (ans == 1)
                {
                    tablepc1.Visible=true;
                    if (carblue.Top <= 55) { Do1.Visible = true; Xanh1.Visible = false; tablepc1.Visible = false; tablepc0.Visible = true; }
                    if (carblue.Top <= -100)
                    {
                        Do.Visible = false; Xanh.Visible = true;
                    }
                    if (carpink.Left >= 320) { Do.Visible = true; Xanh.Visible = false; }
                    if (carpink.Left >= 650)
                    {
                        Xanh.Visible = false;
                        Do.Visible = true;
                        GameOver1();
                    }
                    if (carpink.Left <= 140 || carblue.Top <= -150)
                    carpink.Left += speed;
                    carblue.Top -= speed;
                }

                else
                {
                    tablepc0.Visible = true;
                    if (carpink.Left >= 320) { Do.Visible = true; Xanh.Visible = false; tablepc0.Visible = false; tablepc1.Visible = true; }
                    if (carpink.Left >= 600) { Xanh1.Visible = true; Do1.Visible = false; }
                    if (carpink.Left >= 645) { Xanh1.Visible = true; Do1.Visible = false; }
                    if (carblue.Top <= 70)
                    {
                        Do1.Visible = true;
                        Xanh1.Visible = false;
                    }
                    if (carblue.Top <= -70)
                    {
                        GameOver1();
                    }
                    carpink.Left += speed;
                    if (carblue.Top >= 200 || carpink.Left >= 650)
                    carblue.Top -= speed;
                }

                

            }

        }
        private void GameOver()
        {
            GameTimer.Stop();
            carblue.Visible = false;
            carpink.Visible = false; 
            Bum.Visible = true;

            MessageBox.Show("HAI XE DA CHAM NHAU","THONG BAO",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Bum.Visible = false;
        }
        private void GameOver1()
        {

            GameTimer.Stop();
            MessageBox.Show("DA CHAY XONG", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void button2_Click(object sender, EventArgs e)
        {
            cnt = 1;

            process(cnt);
        }

        private void cahai_Click_1(object sender, EventArgs e)
        {

          //  DialogResult result = MessageBox.Show("Cả hai xe đều muốn vượt, bạn hãy ưu tiên chọn một xe!!!", "THONG BAO");
            cnt = 1;
             flag[0] = true;
             flag[1] = true;
             process(cnt);
        }
       
    }
}