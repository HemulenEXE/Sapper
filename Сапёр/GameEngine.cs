using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sapper
{
    public class call : Button
    {
        public static Game _game;
        public static CallField _callField;
        public bool itsMina = false;
        public bool markToMina = false;
        public bool checkcall = false;

        public int countNeighbour = 0;

        public call(int i, int j)
        {
            this.MouseUp += TryCheckCall;
            this.Size = new Size(20, 20);
            this.Text = "?";
            this.ForeColor = Color.Gray;
            this.BackColor = Color.Green;
            this.Location = new Point(i * 20, j * 20);
        }


        public void TryCheckCall(object sender, MouseEventArgs e)
        {
            if(!checkcall)
            if (e.Button == MouseButtons.Left)
            {
                if (Program.field.ItFirstMove)
                {
                    Program.field.ItFirstMove = false;
                    Program.field.GenerationField(this);
                    TryCheckCall(sender, e);
                }
                else
                {
                        if (!this.markToMina)
                        {
                            this.checkcall = true;
                            if (this.itsMina == true)
                            {
                                this.Text = "М";
                                SetColorText(this.Text);
                                _callField.openingUp();
                                endGG endgg = new endGG(_game, false);
                                endgg.TopMost = true;
                                endgg.Show();
                            }
                            else if (!this.itsMina && this.countNeighbour > 0)
                            {
                                this.Text = Convert.ToString(this.countNeighbour);
                                SetColorText(this.Text);
                            }
                            else
                            {
                                this.Text = " ";
                                SetColorText(this.Text);
                                OpenSafeZone(this);
                            }
                        }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (!this.markToMina)
                {
                    
                    this.Text = "Ф";
                    this.markToMina = true;
                    if(this.itsMina)
                    {
                        _callField.countRealClearMin++;
                    }
                    _callField.countClearedMin++;
                    SetColorText(this.Text);
                    if(_callField.countRealClearMin == _callField.countMin)
                    {
                            endGG endgg = new endGG(_game, true);
                            endgg.TopMost = true;
                            for (int i = 0; i < _callField.CallData.GetLength(0); i++)
                            {
                                for (int j = 0; j < _callField.CallData.GetLength(1); j++)
                                {
                                    _callField.CallData[i, j].checkcall = true;
                                }
                            }
                            endgg.Show();
                    }
                }
                else
                {
                    this.markToMina = false;
                    this.Text = "?";
                    if (this.itsMina)
                    {
                        _callField.countRealClearMin--;
                    }
                    _callField.countClearedMin--;
                    SetColorText(this.Text);
                }

                _game.Text = Convert.ToString(_callField.countClearedMin) + '/' + Convert.ToString(_callField.countMin);
            }
        }
        public void CheckCall()
        {
            if (!checkcall)
            {
                this.checkcall = true;
                if (this.itsMina == true)
                {
                    this.Text = "М";
                }
                else if (!this.itsMina && this.countNeighbour > 0)
                {
                    this.Text = Convert.ToString(this.countNeighbour);
                    SetColorText(this.Text);
                }
                else
                {
                    this.Text = " ";
                    SetColorText(this.Text);
                    OpenSafeZone(this);
                }
            } 
        }


        public void SetColorText(string text)
        {
            switch (text)
            {
                case "1": this.ForeColor = Color.Blue;
                    this.BackColor = Color.White;
                    break;
                case "2": this.ForeColor = Color.Green;
                    this.BackColor = Color.White;
                    break;
                case "3": this.ForeColor = Color.Red;
                    this.BackColor = Color.White;
                    break;
                case "4": this.ForeColor = Color.DarkBlue;
                    this.BackColor = Color.White;
                    break;
                case "5": this.ForeColor = Color.OrangeRed;
                    this.BackColor = Color.White;
                    break;
                case "6": this.ForeColor = Color.Cyan;
                    this.BackColor = Color.White;
                    break;
                case "7": this.ForeColor = Color.DarkRed;
                    this.BackColor = Color.White;
                    break;
                case "8": this.ForeColor = Color.Orange;
                    this.BackColor = Color.White;
                    break;
                case "Ф": this.ForeColor = Color.White;
                    break;
                case "М": this.ForeColor = Color.Black;
                    this.BackColor = Color.Red;
                    break;
                case " ":
                    this.BackColor = Color.White;
                    break;
                case "?":
                    this.Text = "?";
                    this.ForeColor = Color.Gray;
                    this.BackColor = Color.Green;
                    break;

            }

        } 

        void OpenSafeZone(call startCall)
        {
            int thisI = startCall.Location.X / 20;
            int thisJ = startCall.Location.Y / 20;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i + thisI > -1 && i + thisI < call._callField.CallData.GetLength(0) && j + thisJ > -1 && j + thisJ < call._callField.CallData.GetLength(1))
                    {
                            call._callField.CallData[i + thisI, j + thisJ].CheckCall();  
                    }
                }
            }
        }
    }

    public class CallField
    {

        public int countMin;
        public int countClearedMin = 0;
        public int countRealClearMin = 0;
        public bool ItFirstMove = true;

        public call[,] CallData;

        public CallField(int sizeI, int sizeJ)
        {
            CallData = new call[sizeI, sizeJ];
        }
        public CallField() //Не удалять
        {
            
        }
        public call this [int i, int j]
        {
            get
            {
                return CallData[i, j];
            }
            set
            {
                CallData[i, j] = value;
            }
        }

        public void GenerationField(call itsNotMin)
        {
            Random rand = new Random();
            for(int i = 0; i < countMin; )
            {
                int width = rand.Next() % CallData.GetLength(0);
                int height = rand.Next() % CallData.GetLength(1);

                if(!CallData[width,height].itsMina && CallData[width, height].Location != itsNotMin.Location)
                {
                    CallData[width, height].itsMina = true;
                    i++;
                }
            }

            for(int i = 0; i < CallData.GetLength(0); i++)
            {
                for(int j = 0; j < CallData.GetLength(1); j++)
                {
                    if (CallData[i, j].itsMina)
                        continue;
                    for(int k = -1; k < 2; k++)
                    {
                        for(int l = -1; l < 2; l++)
                        {
                            if (k == 0 && l == 0)
                                continue;
                            if(i + k > -1 && i +k < CallData.GetLength(0) && j + l > -1 && j + l < CallData.GetLength(1))
                            {
                                if (CallData[i + k, j + l].itsMina)
                                    CallData[i, j].countNeighbour++;
                            }
                        }
                    }
                }
            }
        }

        public void openingUp()
        {
            for(int i = 0; i < CallData.GetLength(0); i++)
            {
                for(int j = 0; j < CallData.GetLength(1); j++)
                {
                    if(CallData[i,j].itsMina)
                    {
                            CallData[i, j].Text = "М";
                            CallData[i, j].SetColorText("М");
                    }
                    else if (CallData[i, j].markToMina && !CallData[i, j].itsMina)
                    {
                        CallData[i,j].ForeColor = Color.Black;
                        CallData[i,j].BackColor = Color.Red;
                    }
                    CallData[i, j].checkcall = true;
                }
            }
        }
    }
}
