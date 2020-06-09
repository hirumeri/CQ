using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }

    public class Hero
    {
        public int hp_he = 100;

        public void Attack()
        {
            var x =- 24;
        }
    }

    public class Enemy
    {
        public int hp_en = 60;

        public void Kick()
        {
            var y = -16;
        }
    }
}
