using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new EndPoint(this);
            new Player("Pepa z Depa", this);
            Enemy.VygenerujEnemy(30, this);
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_UP_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += " UP ";
        }

        private void button_DOWN_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += " DOWN ";
        }

        private void button_LEFT_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += " LEFT ";
        }

        private void button_RIGHT_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText += " RIGHT ";
        }

        private void button_play_Click(object sender, EventArgs e)
        {
         
        }
    }
}