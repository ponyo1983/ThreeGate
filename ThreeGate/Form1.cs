using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThreeGate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sample = int.Parse(textBox1.Text);


            int winNum = 0;

            for (int i = 0; i < sample; i++)
            {

                Random r = new Random();

              int giftGate=  r.Next(0, 3); //随机生成奖品所在的门


              int selGate = r.Next(0, 3);//随机选择奖品所在的门


              //加入主持人知道奖品所在门

              int openGate = -1;
              for (int j = 0; j < 3; j++)
              {
                  if ((j != giftGate) && (j != selGate))
                  {
                      openGate = j;
                      break;
                  }
              }

              int switchGate = 3 - selGate - openGate; //换门


              if (switchGate == giftGate)
              {
                  winNum++;
              }


            }
            MessageBox.Show(string.Format("赢的概率:{0}%", (winNum * 100d) / sample));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sample = int.Parse(textBox1.Text);


            int winNum = 0;

            for (int i = 0; i < sample; i++)
            {

                Random r = new Random();

                int giftGate = r.Next(0, 3); //随机生成奖品所在的门


                int selGate = r.Next(0, 3);//随机选择奖品所在的门


                //加入主持人知道奖品所在门

                int openGate = -1;
                for (int j = 0; j < 3; j++)
                {
                    if ((j != giftGate) && (j != selGate))
                    {
                        openGate = j;
                        break;
                    }
                }

                int switchGate = selGate; //不换门


                if (switchGate == giftGate)
                {
                    winNum++;
                }


            }
            MessageBox.Show(string.Format("赢的概率:{0}%", (winNum * 100d) / sample));
        }
    }
}
