using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nameText.Text = GameUtils.UserName;
            scoreText.Text = GameUtils.Score.ToString();
        }


        private void newplayerButton_Click(object sender, EventArgs e)
        {
            GameUtils.UserName = "";
            GameUtils.Score = 0;
            this.Hide();
            var form2 = new Form2();
            form2.Show();
        }

        private void playagainButton_Click(object sender, EventArgs e)
        {
            GameUtils.Score = 0;
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }
    }
}
