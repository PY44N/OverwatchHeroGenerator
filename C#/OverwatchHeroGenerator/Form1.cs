using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchHeroGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenAll_Click(object sender, EventArgs e)
        {
            HeroLabel.Text = Hero.Gen();
        }

        private void GenTank_Click(object sender, EventArgs e)
        {
            HeroLabel.Text = Hero.GenTank();
        }

        private void GenDamage_Click(object sender, EventArgs e)
        {
            HeroLabel.Text = Hero.GenDamage();
        }

        private void GenSupport_Click(object sender, EventArgs e)
        {
            HeroLabel.Text = Hero.GenSupport();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PY44N/OverwatchHeroGenerator");
        }
    }
}
