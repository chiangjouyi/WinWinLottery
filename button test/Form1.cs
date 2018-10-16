using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_test
{
    public partial class Form1 : Form
    {
        //類別變數
        List<Button> myButtons = new List<Button>();
        string 當期台彩號碼 = "   04   06   10   11   12   13   14   15   19   20   21   22      ";
        string[,] arrayNumber = new string[,] { { "01", "02", "03", "04", "05", "06" }, { "07", "08", "09", "10", "11", "12" }, { "13", "14", "15", "16", "17", "18" }, { "19", "20", "21", "22", "23", "24" } };
        int click = 0;
        string str自選號碼 = "";
        int[] selectnum = new int[] { };
        ToolTip tt1 = new ToolTip();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            產生按鈕(4, 6);
          
            label2.SendToBack();
            label1.BringToFront();
            label3.BringToFront();
            timer1.Enabled = true;
            timer1.Interval = 500;
            tt1.AutoPopDelay = 20000;
            tt1.ToolTipTitle = "*****基本玩法 & 獎金分配方式*****";
            tt1.SetToolTip(pictureBox1, "\n雙贏彩是一種樂透型遊戲，您必須從01~24的號碼中任選12個號碼進行投注。\n開獎時，開獎單位將隨機開出12個號碼，這一組號碼就是該期雙贏彩的中獎號碼，也稱為「獎號」。\n您的12個選號如果全部對中當期開出之12個號碼，或者全部未對中，均為中頭獎。\n\n\n各獎項的中獎方式如下表：\n\n     獎項                                  中獎方式\n\n     頭獎            對中當期12個獎號 或 對中當期0個獎號\n     貳獎            對中當期任11個獎號 或 對中任1個獎號\n     參獎            對中當期10個獎號 或 對中當期任2個獎號\n     肆獎            對中當期9個獎號 或 對中當期任3個獎號\n\n\n雙贏彩所有獎項皆為固定獎項，各獎項金額如下：\n\n       獎項                   頭獎                   貳獎            參獎        肆獎\n\n     單注獎金     $15,000,000       $100,000       $500       $100");   
        }

        void 產生按鈕(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Button EachButton = new Button();
                    System.Drawing.Drawing2D.GraphicsPath aCircle = new System.Drawing.Drawing2D.GraphicsPath();
                    EachButton.BringToFront();
                    EachButton.Size = new Size(80, 80);
                    aCircle.AddEllipse(new Rectangle(0, 0, 75, 75));
                    EachButton.Region = new Region(aCircle);
                    EachButton.Location = new Point(50 + 90 * j, 380 + 85 * i);
                    EachButton.Text = arrayNumber[i, j].ToString();
                    EachButton.Name = "btn" + arrayNumber[i, j].ToString();
                    EachButton.Font = new Font("微軟正黑體", 22, FontStyle.Bold);
                    EachButton.FlatStyle = FlatStyle.Standard;
                    EachButton.BackColor = Color.Gold;
                    EachButton.ForeColor = Color.MidnightBlue;
                    EachButton.Click += new EventHandler(EachButton_Click);

                    Controls.Add(EachButton);
                    myButtons.Add(EachButton);
                }
            }
        }

        void EachButton_Click(object sender, EventArgs e)
        {
            Button mybtn = (Button)sender;
            click++;
            if (click <= 12)
            {
                mybtn.ForeColor = Color.White;
                mybtn.BackColor = Color.Green;
                mybtn.Enabled = false;
                str自選號碼 += mybtn.Text.ToString() + ",";
                label.Text = str自選號碼.Substring(0, str自選號碼.Length - 1);  //label在UI中隱藏                    
            }
            else
            {
                DialogResult drResult; //MessageBox的回傳值
                drResult = MessageBox.Show("您選取的獎號為\n" + label.Text.ToString() + "\n\n是否保留選號?", "********您已選取12個號碼********", MessageBoxButtons.YesNo);
                if (drResult == DialogResult.No)
                {
                    mybtn.Enabled = true;
                    清除所有選號();
                }
            }
        }

        void 清除所有選號()
        {
            click = 0;
            str自選號碼 = "";
            label.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            int x = 0;
            Button allbtn = myButtons[x];
            for (x = 0; x < 24; x++)
            {
                myButtons[23].Enabled = true;
                allbtn.Enabled = true;
                allbtn = myButtons[x];
                allbtn.BackColor = Color.Gold;
                allbtn.ForeColor = Color.MidnightBlue;
            }
        }

        private void btn獎號自動生成_Click_1(object sender, EventArgs e)
        {
            清除所有選號();
            Random Rnd = new Random();
            Button[] RndBtn = new Button[24];
            string str單項 = "";
            string str總項 = "";
            for (int i = 0; i < 12; i++)
            {
                RndBtn[i] = myButtons[Rnd.Next(24)];

                for (int j = 0; j < i; j++)
                {
                    while (RndBtn[j] == RndBtn[i])
                    {
                        j = 0;
                        RndBtn[i] = myButtons[Rnd.Next(24)];
                    }
                }
                RndBtn[i].BackColor = Color.Navy;
                RndBtn[i].ForeColor = Color.Snow;
                str單項 += RndBtn[i].Text.ToString() + ",";
            }
            str總項 = str單項;
            label.Text = str總項.Substring(0, str總項.Length - 1);
            DialogResult drResult; //MessageBox的回傳值
            drResult = MessageBox.Show("電腦自動選號為\n" + label.Text.ToString() + "\n\n是否保留選號?", "********已隨機選取12個號碼********", MessageBoxButtons.YesNo);
            if (drResult == DialogResult.No)
            {
                清除所有選號();
            }
        }

        private void btn清除選號_Click_1(object sender, EventArgs e)
        {
            清除所有選號();
        }

        private void btn當期對獎_Click_1(object sender, EventArgs e)
        {
            string[] selectnum = label.Text.Split(',');
            string[] lotterynum = new string[] { "04", "06", "10", "11", "12", "13", "14", "15", "19", "20", "21", "22" };
            Array.Sort(selectnum);
            Array.Sort(lotterynum);
            string str相符獎號 = "";
            int bingo = 0;
            Button[] BingoBtn = new Button[24];
            int[] bingonum = new int[]{};

            if ((selectnum.Length == 12) && (lotterynum.Length == 12))
            {
                bool hasCommonElements = selectnum.Intersect(lotterynum).Count() > 0;
                string[] commonElements = selectnum.Intersect(lotterynum).ToArray();
                for (int i = 0; i < commonElements.Length; i++)
                {
                    str相符獎號 += commonElements[i]+"   ";
                    bingo = commonElements.Count();
                    //把commonElements[i]轉成數字陣列
                    bingonum = Array.ConvertAll(commonElements, int.Parse);
                    BingoBtn[i] = myButtons[bingonum[i]];
                    BingoBtn[i].BackColor = Color.DarkRed;
                    BingoBtn[i].ForeColor = Color.Snow;
                }
               
                if (bingo == 12 || bingo == 11 || bingo == 10 || bingo == 9 || bingo == 3 || bingo == 2 || bingo == 1 || bingo == 0)
                {
                    label4.Text = "恭喜您中了\n\n共有\n相符獎號為";
                    label6.Text = "\n個獎號相符";
                    if (bingo == 12 || bingo == 0)
                    { label5.Text = "頭獎!!!   單注獎金為$15,000,000 \n\n" + bingo + "\n" + str相符獎號; }
                    else if (bingo == 11 || bingo == 1)
                    { label5.Text = "貳獎!!    單注獎金為$100,000 \n\n" + bingo + "\n" + str相符獎號; }
                    else if (bingo == 10 || bingo == 2)
                    {label5.Text = "參獎!     單注獎金為$500\n\n" + bingo + "\n" + str相符獎號; }
                    else {label5.Text = "肆獎      單注獎金為$100\n\n" + bingo + "\n" + str相符獎號; }
                }
                else
                {
                    label4.Text = "很遺憾您\n\n共有\n相符獎號為";
                    label5.Text = "沒有中獎                      \n\n" + bingo + "\n" + str相符獎號;
                    label6.Text = "\n個獎號相符";
                }
            } else
            {
                MessageBox.Show("請點選12個號碼","",MessageBoxButtons.OK);
            }
      
        }






        private void label_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = 當期台彩號碼.Substring(0, 1);
            當期台彩號碼 = 當期台彩號碼.Substring(1, 當期台彩號碼.Length - 1) + temp;
            label3.Text = 當期台彩號碼;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

