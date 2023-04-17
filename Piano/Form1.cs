using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Piano
{
    public partial class Form1 : Form
    {
        bool reButtonClicked = false;
        bool miButtonClicked = false;
        bool faButtonClicked = false;
        bool solButtonClicked = false;
        bool laButtonClicked  = false;
        bool siButtonClicked = false;
        bool doButtonClicked1 = false;
        bool reButtonClicked1 = false;
        bool miButtonClicked1 = false;
        bool faButtonClicked1 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources._do);
            Simple.Play();

            // = true;
            //DoSomethingIfBothClicked();
        }

        private void reButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.re);
            Simple.Play();

            // = true;
            //DoSomethingIfBothClicked();
        }

        private void miButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.mi);
            Simple.Play();
        }

        private void faButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.fa);
            Simple.Play();
        }

        private void solButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.sol);
            Simple.Play();
        }

        private void laButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.la);
            Simple.Play();
        }

        private void siButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.si);
            Simple.Play();
        }

        private void doButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.do1);
            Simple.Play();
        }

        private void reButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.re1);
            Simple.Play();
        }

        private void miButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.mi1);
            Simple.Play();
        }

        private void faButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(Properties.Resources.fa1);
            Simple.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) //если я нажимаю клавишу А на клавиатуре, то вызывается событие срабатывания этой кнопки. с остальными анологично.
            {
                doButton.PerformClick(); //вот как раз вызов события.
            }

            if (e.KeyCode == Keys.S)
            {
                reButton.PerformClick();
            }

            if (e.KeyCode == Keys.D)
            {
                miButton.PerformClick();
            }

            if (e.KeyCode == Keys.F)
            {
                faButton.PerformClick();
            }

            if (e.KeyCode == Keys.G)
            {
                solButton.PerformClick();
            }

            if (e.KeyCode == Keys.H)
            {
                laButton.PerformClick();
            }

            if (e.KeyCode == Keys.J)
            {
                siButton.PerformClick();
            }

            if (e.KeyCode == Keys.K)
            {
                doButton1.PerformClick();
            }

            if (e.KeyCode == Keys.L)
            {
                reButton1.PerformClick();
            }

            if (e.KeyCode == Keys.O)
            {
                miButton1.PerformClick();
            }

            if (e.KeyCode == Keys.P)
            {
                faButton1.PerformClick();
            }
        }
    }
}
