using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapper
{
    public partial class endGG : Form
    {
        Game _game;
        public endGG(Game game, bool win)
        {
            InitializeComponent();
            _game = game;
            if(win)
            {
                this.label1.Text = "Победа!";
            }
            else
            {
                this.label1.Text = "Вас разарвало на части.";
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            _game.checkSettingSizeCalling = false;
            _game.Form1_Load(sender, e);
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            _game.Close();
            this.Close();
        }
    }
}
