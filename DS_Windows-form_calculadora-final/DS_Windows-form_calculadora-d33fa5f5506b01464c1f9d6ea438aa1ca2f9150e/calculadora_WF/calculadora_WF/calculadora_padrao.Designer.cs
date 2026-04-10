namespace calculadora_WF
{
    partial class calculadora_padrao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblvisor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.lblhist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 217);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(98, 7);
            this.btnback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 35);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "<=";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            this.btnback.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.btnback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.btnback.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(54, 7);
            this.button14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(41, 35);
            this.button14.TabIndex = 14;
            this.button14.Text = "CE";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(98, 54);
            this.button12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(41, 35);
            this.button12.TabIndex = 12;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.F_digitos);
            this.button12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(54, 54);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(41, 35);
            this.button11.TabIndex = 11;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.F_digitos);
            this.button11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(9, 7);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(41, 35);
            this.button13.TabIndex = 13;
            this.button13.Text = "C";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(9, 54);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(41, 35);
            this.button10.TabIndex = 10;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.F_digitos);
            this.button10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 93);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.F_digitos);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(54, 132);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 35);
            this.button9.TabIndex = 8;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.F_digitos);
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 131);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 35);
            this.button8.TabIndex = 7;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.F_digitos);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 93);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.F_digitos);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 93);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.F_digitos);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 170);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.F_digitos);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "+/-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.F_digitos);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // lblvisor
            // 
            this.lblvisor.BackColor = System.Drawing.Color.GhostWhite;
            this.lblvisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblvisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisor.Location = new System.Drawing.Point(21, 31);
            this.lblvisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvisor.Name = "lblvisor";
            this.lblvisor.Size = new System.Drawing.Size(259, 23);
            this.lblvisor.TabIndex = 1;
            this.lblvisor.Text = "0";
            this.lblvisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.button17);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(193, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 217);
            this.panel2.TabIndex = 1;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(11, 175);
            this.button21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(63, 27);
            this.button21.TabIndex = 20;
            this.button21.Text = "=";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            this.button21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(11, 132);
            this.button20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(63, 27);
            this.button20.TabIndex = 19;
            this.button20.Text = "^";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.F_operacoes);
            this.button20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(11, 39);
            this.button19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(63, 27);
            this.button19.TabIndex = 18;
            this.button19.Text = "-";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.F_operacoes);
            this.button19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(11, 70);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(63, 27);
            this.button18.TabIndex = 17;
            this.button18.Text = "*";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.F_operacoes);
            this.button18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(11, 101);
            this.button17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 27);
            this.button17.TabIndex = 16;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.F_operacoes);
            this.button17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(11, 8);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 27);
            this.button15.TabIndex = 15;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.F_operacoes);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_padrao_KeyDown_1);
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseDown);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Botao_MouseUp);
            // 
            // lblhist
            // 
            this.lblhist.AutoSize = true;
            this.lblhist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhist.Location = new System.Drawing.Point(190, 17);
            this.lblhist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhist.Name = "lblhist";
            this.lblhist.Size = new System.Drawing.Size(0, 15);
            this.lblhist.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // calculadora_padrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 307);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblvisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "calculadora_padrao";
            this.Text = "calculadora_padrao";
            this.Load += new System.EventHandler(this.calculadora_padrao_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvisor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lblhist;
        private System.Windows.Forms.Label label1;
    }
}