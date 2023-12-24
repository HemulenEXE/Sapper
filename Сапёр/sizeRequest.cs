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
    public partial class sizeRequest : Form
    {
        private Game _form1;
        public sizeRequest(Game f)
        {
            InitializeComponent();
            _form1 = f;
        }

        private void AutoSelection_Click(object sender, EventArgs e)
        {
            double ChanseOfMine = 0.15;
            int countByY,
                countByX;


            try
            {
                countByY = Convert.ToInt32(Y_Size.Text);
                countByX = Convert.ToInt32(X_Size.Text);
                int countMin = (int)(countByX * countByY * ChanseOfMine);
                CountMin.Text = Convert.ToString(countMin);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные, попробуйте еще раз.");
            }
            
        }

        private void sizeRequest_Load(object sender, EventArgs e)
        {
            ToolTip hint = new ToolTip();
            hint.SetToolTip(button2, "Автоматически подбирает количество мин в 15% от размера самого поля");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int sizeForm1Wid;
            int sizeForm1Heig;
            try
            {
                sizeForm1Wid = Convert.ToInt32(X_Size.Text);
                sizeForm1Heig = Convert.ToInt32(Y_Size.Text);
                if (sizeForm1Heig < 6 || sizeForm1Wid < 6)
                {
                    MessageBox.Show("Неверные данные, попробуйте еще раз.");
                    return;

                }
                Program.field.countMin = Convert.ToInt32(CountMin.Text);
                Size newS = new Size(sizeForm1Heig * 20 + 20, sizeForm1Wid * 20 + 40);
                _form1.MaximumSize = newS;
                _form1.MinimumSize = newS;
                _form1.Size = newS;
                _form1.Form1_Load(sender,e);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные, попробуйте еще раз.");
            }
        }
    }
}
