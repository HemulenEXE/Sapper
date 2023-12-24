
namespace Sapper
{
    partial class sizeRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.X_Size = new System.Windows.Forms.TextBox();
            this.Y_Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CountMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(41, 212);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // X_Size
            // 
            this.X_Size.Location = new System.Drawing.Point(149, 60);
            this.X_Size.Name = "X_Size";
            this.X_Size.Size = new System.Drawing.Size(75, 23);
            this.X_Size.TabIndex = 1;
            this.X_Size.Text = "20";
            // 
            // Y_Size
            // 
            this.Y_Size.Location = new System.Drawing.Point(149, 116);
            this.Y_Size.Name = "Y_Size";
            this.Y_Size.Size = new System.Drawing.Size(75, 23);
            this.Y_Size.TabIndex = 2;
            this.Y_Size.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y_Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "X_Size";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поле делать не меньше чем 6 на 6";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(250, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "АвтоПодбор";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AutoSelection_Click);
            // 
            // CountMin
            // 
            this.CountMin.Location = new System.Drawing.Point(149, 162);
            this.CountMin.Name = "CountMin";
            this.CountMin.Size = new System.Drawing.Size(75, 23);
            this.CountMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество мин";
            // 
            // sizeRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountMin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_Size);
            this.Controls.Add(this.X_Size);
            this.Controls.Add(this.StartButton);
            this.MaximumSize = new System.Drawing.Size(390, 300);
            this.MinimumSize = new System.Drawing.Size(390, 300);
            this.Name = "sizeRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sizeRequest";
            this.Load += new System.EventHandler(this.sizeRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox X_Size;
        private System.Windows.Forms.TextBox Y_Size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CountMin;
        private System.Windows.Forms.Label label4;
    }
}