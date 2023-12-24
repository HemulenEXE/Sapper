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
    public partial class Game : Form
    { 
        public bool checkSettingSizeCalling = false;
        public Game()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Controls.Clear();
            Program.field.CallData = null;
            if (!checkSettingSizeCalling)
            {
                checkSettingSizeCalling = true;
                sizeRequest sizeRequest = new sizeRequest(this);
                sizeRequest.TopMost = true;
                sizeRequest.Show();
            }
            else
            {
                this.Text = Convert.ToString(0) + '/' + Convert.ToString(Program.field.countMin);
                int sizeByI = (this.Width - 20) / 20,
                    sizeByJ = (this.Height - 40) / 20;

                int buf = Program.field.countMin;
                Program.field = new CallField(sizeByI, sizeByJ);
                Program.field.countMin = buf;
                call._game = this;
                call._callField = Program.field;
                for (int i = 0; i < sizeByI; i++) //40
                {
                    for (int j = 0; j < sizeByJ; j++) //23
                    {
                        call newCall = new call(i, j);
                        this.Controls.Add(newCall);
                        Program.field[i, j] = newCall;
                    }
                }
                Program.field.ItFirstMove = true;
                this.Show();
            }
        }
    }

    
}
