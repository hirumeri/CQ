using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CQ
{
    public partial class Form1 : Form
    {
        Hero hero = new Hero();

        Enemy enemy = new Enemy();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
                label3.Text = "An enemy has appeared";
                label2.Text = hero.hp_he.ToString();
                label1.Text = enemy.hp_en.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enemy.hp_en = hero.Bite(enemy.hp_en);
            if (enemy.hp_en > 0)
            {
                label1.Text = enemy.hp_en.ToString();
            }
            else
            { 
                label1.Text = "0";
                // pictureBox1.Image = CQ.Properties.Resources.death;
                pictureBox1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                label3.Text = "You have won!";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (hero.hp_he > 13)
            {
                hero.hp_he -= 12;
                label2.Text = hero.hp_he.ToString();

                enemy.hp_en = hero.Magi(enemy.hp_en);

                if (enemy.hp_en > 0)
                {
                    label1.Text = enemy.hp_en.ToString();
                }
                else
                {
                    label1.Text = "0";
                    // pictureBox1.Image = CQ.Properties.Resources.death;
                    pictureBox1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    label3.Text = "You have won!";
                }
            }
            else
            {
                label3.Text = "price for Magi is not enough... ";
            }
        }
    }

    public class Hero
    {
        public int hp_he = 100;

        public int Bite(int x)
        {
            return x - 19;
        }
        public int Magi(int x)
        {
            return x - 30;

        }

    }

    public class Enemy
    {
        public int hp_en = 218;

        public int Kick(int y)
        {
            return y - 16;
        }
    }
}
