using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asansör_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buton_aktif()
        {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }
        private void buton_pasif()
        {
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            label_süre.Text = "";
        }
        private void buton_renk()
        {
            button0.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button3.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
        }
        private void kat()
        {
            if (pictureBox0.Location.Y == 16)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 8";
            }
            else if (pictureBox0.Location.Y == 101)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 7";
            }
            else if (pictureBox0.Location.Y == 186)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 6";
            }
            else if (pictureBox0.Location.Y == 271)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 5";
            }
            else if (pictureBox0.Location.Y == 356)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 4";
            }
            else if (pictureBox0.Location.Y == 441)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 3";
            }
            else if (pictureBox0.Location.Y == 526)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 2";
            }
            else if (pictureBox0.Location.Y == 611)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 1";
            }
            else if (pictureBox0.Location.Y == 696)
            {
                label_asansör.Text = "Asansörün Bulunduğu Kat: 0";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Green;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label0.Location.Y.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label1.Location.Y.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label2.Location.Y.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label3.Location.Y.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label4.Location.Y.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label5.Location.Y.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label6.Location.Y.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Red;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label7.Location.Y.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.Red;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Green;
            buton_pasif();
            timer_asansör.Enabled = true;
            timer_süre.Enabled = true;
            label_seviye.Text = label8.Location.Y.ToString();
        }
        private void timer_asansör_Tick(object sender, EventArgs e)
        {
            if (timer_asansör.Interval != 1 && (pictureBox0.Location.Y - int.Parse(label_seviye.Text) <= -21 || pictureBox0.Location.Y - int.Parse(label_seviye.Text) >= 21))
            {
                timer_asansör.Interval -= 5;
            }
            int y = pictureBox0.Location.Y;
            if (pictureBox0.Location.Y - int.Parse(label_seviye.Text) < 0)
            {
                if (pictureBox0.Location.Y - int.Parse(label_seviye.Text) > -21)
                {
                    timer_asansör.Interval += 5;
                }
                y++;
                label_durum.Text = "Asansör ↓ yönde hareket halinde.";
            }
            else if (pictureBox0.Location.Y - int.Parse(label_seviye.Text) == 0)
            {
                timer_asansör.Enabled = false;
                timer_süre.Enabled = false;
                buton_aktif();
                buton_renk();
                label_durum.Text = "Asansör hazır.";
                label_süre.Text = süre.ToString()+" saniye seyehat edildi.";
                süre = 0;
            }
            else if (pictureBox0.Location.Y - int.Parse(label_seviye.Text) > 0)
            {
                if (pictureBox0.Location.Y - int.Parse(label_seviye.Text) < 21)
                {
                    timer_asansör.Interval += 5;
                }
                y--;
                label_durum.Text = "Asansör ↑ yönde hareket halinde.";
            }
            kat();
            pictureBox0.Location = new Point(pictureBox0.Location.X, y);
        }
        int süre = 0;
        private void timer_süre_Tick(object sender, EventArgs e)
        {
            süre++;
        }
    }
}