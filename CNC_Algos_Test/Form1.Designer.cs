﻿namespace CNC_Algos_Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.GroupBox();
            this.Dk_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Dir_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Q_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Y0textBox = new System.Windows.Forms.TextBox();
            this.X0textBox = new System.Windows.Forms.TextBox();
            this.N_textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Radius_textBox = new System.Windows.Forms.TextBox();
            this.J_textBox = new System.Windows.Forms.TextBox();
            this.I_textBox = new System.Windows.Forms.TextBox();
            this.Yfinnish_textBox = new System.Windows.Forms.TextBox();
            this.Xfinnish_textBox = new System.Windows.Forms.TextBox();
            this.Ystart_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.XStart_textBox = new System.Windows.Forms.TextBox();
            this.Result_richTextBox = new System.Windows.Forms.RichTextBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.PicBx = new System.Windows.Forms.PictureBox();
            this.QFtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Deg_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.C.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc Radius";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xstart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ystart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xfinnish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yfinnish";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "J";
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.C.Controls.Add(this.Deg_textBox);
            this.C.Controls.Add(this.label15);
            this.C.Controls.Add(this.QFtextBox);
            this.C.Controls.Add(this.label14);
            this.C.Controls.Add(this.Dk_textBox);
            this.C.Controls.Add(this.label13);
            this.C.Controls.Add(this.Dir_textBox);
            this.C.Controls.Add(this.label12);
            this.C.Controls.Add(this.Q_textBox);
            this.C.Controls.Add(this.label11);
            this.C.Controls.Add(this.label10);
            this.C.Controls.Add(this.label9);
            this.C.Controls.Add(this.Y0textBox);
            this.C.Controls.Add(this.X0textBox);
            this.C.Controls.Add(this.N_textBox1);
            this.C.Controls.Add(this.label8);
            this.C.Controls.Add(this.button2);
            this.C.Controls.Add(this.button1);
            this.C.Controls.Add(this.Radius_textBox);
            this.C.Controls.Add(this.J_textBox);
            this.C.Controls.Add(this.I_textBox);
            this.C.Controls.Add(this.Yfinnish_textBox);
            this.C.Controls.Add(this.Xfinnish_textBox);
            this.C.Controls.Add(this.Ystart_textBox);
            this.C.Controls.Add(this.label7);
            this.C.Controls.Add(this.XStart_textBox);
            this.C.Controls.Add(this.label6);
            this.C.Controls.Add(this.label1);
            this.C.Controls.Add(this.label5);
            this.C.Controls.Add(this.label2);
            this.C.Controls.Add(this.label4);
            this.C.Controls.Add(this.label3);
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(12, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(236, 503);
            this.C.TabIndex = 2;
            this.C.TabStop = false;
            this.C.Text = "Cordinates";
            // 
            // Dk_textBox
            // 
            this.Dk_textBox.Location = new System.Drawing.Point(100, 471);
            this.Dk_textBox.Name = "Dk_textBox";
            this.Dk_textBox.Size = new System.Drawing.Size(34, 26);
            this.Dk_textBox.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Dk";
            // 
            // Dir_textBox
            // 
            this.Dir_textBox.Location = new System.Drawing.Point(76, 303);
            this.Dir_textBox.Name = "Dir_textBox";
            this.Dir_textBox.Size = new System.Drawing.Size(143, 26);
            this.Dir_textBox.TabIndex = 13;
            this.Dir_textBox.Text = "G02";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "G02/03";
            // 
            // Q_textBox
            // 
            this.Q_textBox.Location = new System.Drawing.Point(100, 381);
            this.Q_textBox.Name = "Q_textBox";
            this.Q_textBox.Size = new System.Drawing.Size(34, 26);
            this.Q_textBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "QS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(171, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Y0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "X0";
            // 
            // Y0textBox
            // 
            this.Y0textBox.Location = new System.Drawing.Point(140, 381);
            this.Y0textBox.Name = "Y0textBox";
            this.Y0textBox.Size = new System.Drawing.Size(89, 26);
            this.Y0textBox.TabIndex = 8;
            // 
            // X0textBox
            // 
            this.X0textBox.Location = new System.Drawing.Point(5, 381);
            this.X0textBox.Name = "X0textBox";
            this.X0textBox.Size = new System.Drawing.Size(89, 26);
            this.X0textBox.TabIndex = 7;
            // 
            // N_textBox1
            // 
            this.N_textBox1.Location = new System.Drawing.Point(76, 272);
            this.N_textBox1.Name = "N_textBox1";
            this.N_textBox1.Size = new System.Drawing.Size(143, 26);
            this.N_textBox1.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "N";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(140, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "RUN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Radius_textBox
            // 
            this.Radius_textBox.Location = new System.Drawing.Point(76, 241);
            this.Radius_textBox.Name = "Radius_textBox";
            this.Radius_textBox.Size = new System.Drawing.Size(143, 26);
            this.Radius_textBox.TabIndex = 3;
            // 
            // J_textBox
            // 
            this.J_textBox.Location = new System.Drawing.Point(76, 177);
            this.J_textBox.Name = "J_textBox";
            this.J_textBox.Size = new System.Drawing.Size(143, 26);
            this.J_textBox.TabIndex = 3;
            this.J_textBox.Text = "100";
            // 
            // I_textBox
            // 
            this.I_textBox.Location = new System.Drawing.Point(76, 146);
            this.I_textBox.Name = "I_textBox";
            this.I_textBox.Size = new System.Drawing.Size(143, 26);
            this.I_textBox.TabIndex = 3;
            this.I_textBox.Text = "-100";
            // 
            // Yfinnish_textBox
            // 
            this.Yfinnish_textBox.Location = new System.Drawing.Point(76, 115);
            this.Yfinnish_textBox.Name = "Yfinnish_textBox";
            this.Yfinnish_textBox.Size = new System.Drawing.Size(143, 26);
            this.Yfinnish_textBox.TabIndex = 3;
            this.Yfinnish_textBox.Text = "0";
            // 
            // Xfinnish_textBox
            // 
            this.Xfinnish_textBox.Location = new System.Drawing.Point(76, 84);
            this.Xfinnish_textBox.Name = "Xfinnish_textBox";
            this.Xfinnish_textBox.Size = new System.Drawing.Size(143, 26);
            this.Xfinnish_textBox.TabIndex = 3;
            this.Xfinnish_textBox.Text = "0";
            // 
            // Ystart_textBox
            // 
            this.Ystart_textBox.Location = new System.Drawing.Point(76, 53);
            this.Ystart_textBox.Name = "Ystart_textBox";
            this.Ystart_textBox.Size = new System.Drawing.Size(143, 26);
            this.Ystart_textBox.TabIndex = 3;
            this.Ystart_textBox.Text = "250";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Radius";
            // 
            // XStart_textBox
            // 
            this.XStart_textBox.Location = new System.Drawing.Point(76, 22);
            this.XStart_textBox.Name = "XStart_textBox";
            this.XStart_textBox.Size = new System.Drawing.Size(143, 26);
            this.XStart_textBox.TabIndex = 3;
            this.XStart_textBox.Text = "450";
            // 
            // Result_richTextBox
            // 
            this.Result_richTextBox.Location = new System.Drawing.Point(12, 521);
            this.Result_richTextBox.Name = "Result_richTextBox";
            this.Result_richTextBox.Size = new System.Drawing.Size(236, 191);
            this.Result_richTextBox.TabIndex = 3;
            this.Result_richTextBox.Text = "";
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // PicBx
            // 
            this.PicBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBx.Location = new System.Drawing.Point(265, 12);
            this.PicBx.Name = "PicBx";
            this.PicBx.Size = new System.Drawing.Size(700, 700);
            this.PicBx.TabIndex = 4;
            this.PicBx.TabStop = false;
            // 
            // QFtextBox
            // 
            this.QFtextBox.Location = new System.Drawing.Point(100, 426);
            this.QFtextBox.Name = "QFtextBox";
            this.QFtextBox.Size = new System.Drawing.Size(34, 26);
            this.QFtextBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(105, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "QF";
            // 
            // Deg_textBox
            // 
            this.Deg_textBox.Location = new System.Drawing.Point(76, 209);
            this.Deg_textBox.Name = "Deg_textBox";
            this.Deg_textBox.Size = new System.Drawing.Size(143, 26);
            this.Deg_textBox.TabIndex = 19;
            this.Deg_textBox.Text = "60";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Deg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 721);
            this.Controls.Add(this.PicBx);
            this.Controls.Add(this.Result_richTextBox);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.C.ResumeLayout(false);
            this.C.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox C;
        private System.Windows.Forms.TextBox Radius_textBox;
        private System.Windows.Forms.TextBox J_textBox;
        private System.Windows.Forms.TextBox I_textBox;
        private System.Windows.Forms.TextBox Yfinnish_textBox;
        private System.Windows.Forms.TextBox Xfinnish_textBox;
        private System.Windows.Forms.TextBox Ystart_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox XStart_textBox;
        private System.Windows.Forms.RichTextBox Result_richTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox N_textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox PicBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Y0textBox;
        private System.Windows.Forms.TextBox X0textBox;
        private System.Windows.Forms.TextBox Q_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Dir_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Dk_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox QFtextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Deg_textBox;
        private System.Windows.Forms.Label label15;
    }
}

