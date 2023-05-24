namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.renda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.energiaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aguaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aliTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outrosTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.gastostotal = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.saldoss = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // renda
            // 
            this.renda.Location = new System.Drawing.Point(221, 67);
            this.renda.Name = "renda";
            this.renda.Size = new System.Drawing.Size(290, 20);
            this.renda.TabIndex = 1;
            this.renda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outrosTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.aliTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tvTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.aguaTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.energiaTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(138, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energia Elétrica :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // energiaTxt
            // 
            this.energiaTxt.Location = new System.Drawing.Point(149, 65);
            this.energiaTxt.Name = "energiaTxt";
            this.energiaTxt.Size = new System.Drawing.Size(166, 20);
            this.energiaTxt.TabIndex = 1;
            this.energiaTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Àgua :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // aguaTxt
            // 
            this.aguaTxt.Location = new System.Drawing.Point(149, 103);
            this.aguaTxt.Name = "aguaTxt";
            this.aguaTxt.Size = new System.Drawing.Size(166, 20);
            this.aguaTxt.TabIndex = 3;
            this.aguaTxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tv/Fone/Internet :";
            // 
            // tvTxt
            // 
            this.tvTxt.Location = new System.Drawing.Point(149, 140);
            this.tvTxt.Name = "tvTxt";
            this.tvTxt.Size = new System.Drawing.Size(166, 20);
            this.tvTxt.TabIndex = 5;
            this.tvTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alimentação :";
            // 
            // aliTxt
            // 
            this.aliTxt.Location = new System.Drawing.Point(149, 174);
            this.aliTxt.Name = "aliTxt";
            this.aliTxt.Size = new System.Drawing.Size(166, 20);
            this.aliTxt.TabIndex = 7;
            this.aliTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Outros Gastos :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // outrosTxt
            // 
            this.outrosTxt.Location = new System.Drawing.Point(148, 219);
            this.outrosTxt.Name = "outrosTxt";
            this.outrosTxt.Size = new System.Drawing.Size(166, 20);
            this.outrosTxt.TabIndex = 9;
            this.outrosTxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Novo Calculo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tolat de gastos :";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(143, 559);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(40, 13);
            this.lblsaldo.TabIndex = 7;
            this.lblsaldo.Text = "Saldo :";
            // 
            // gastostotal
            // 
            this.gastostotal.AutoSize = true;
            this.gastostotal.Location = new System.Drawing.Point(243, 518);
            this.gastostotal.Name = "gastostotal";
            this.gastostotal.Size = new System.Drawing.Size(0, 13);
            this.gastostotal.TabIndex = 8;
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Location = new System.Drawing.Point(190, 559);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(0, 13);
            this.saldo.TabIndex = 9;
            // 
            // saldoss
            // 
            this.saldoss.AutoSize = true;
            this.saldoss.Location = new System.Drawing.Point(190, 559);
            this.saldoss.Name = "saldoss";
            this.saldoss.Size = new System.Drawing.Size(0, 13);
            this.saldoss.TabIndex = 10;
            this.saldoss.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.saldoss);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.gastostotal);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.renda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox renda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox energiaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aliTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tvTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aguaTxt;
        private System.Windows.Forms.TextBox outrosTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label gastostotal;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label saldoss;
    }
}

