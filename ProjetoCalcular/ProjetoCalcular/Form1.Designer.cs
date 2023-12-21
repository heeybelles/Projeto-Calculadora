namespace ProjetoCalcular
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.adicaoNumber = new System.Windows.Forms.Button();
            this.multNumber = new System.Windows.Forms.Button();
            this.dividirNumber = new System.Windows.Forms.Button();
            this.numberDec = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.subnumber = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 23);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(163, 20);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 68);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(37, 23);
            this.number1.TabIndex = 2;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(55, 68);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(35, 23);
            this.number2.TabIndex = 3;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(96, 68);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(36, 23);
            this.number3.TabIndex = 4;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(12, 97);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(37, 23);
            this.number4.TabIndex = 5;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(55, 97);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(37, 23);
            this.number5.TabIndex = 6;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(95, 97);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(37, 23);
            this.number6.TabIndex = 7;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(12, 126);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(37, 23);
            this.number7.TabIndex = 8;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(53, 126);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(37, 23);
            this.number8.TabIndex = 9;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(96, 126);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(37, 23);
            this.number9.TabIndex = 10;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // adicaoNumber
            // 
            this.adicaoNumber.Location = new System.Drawing.Point(138, 68);
            this.adicaoNumber.Name = "adicaoNumber";
            this.adicaoNumber.Size = new System.Drawing.Size(36, 23);
            this.adicaoNumber.TabIndex = 11;
            this.adicaoNumber.Text = "+";
            this.adicaoNumber.UseVisualStyleBackColor = true;
            this.adicaoNumber.Click += new System.EventHandler(this.adicaoNumber_Click);
            // 
            // multNumber
            // 
            this.multNumber.Location = new System.Drawing.Point(139, 97);
            this.multNumber.Name = "multNumber";
            this.multNumber.Size = new System.Drawing.Size(36, 23);
            this.multNumber.TabIndex = 12;
            this.multNumber.Text = "*";
            this.multNumber.UseVisualStyleBackColor = true;
            this.multNumber.Click += new System.EventHandler(this.multNumber_Click);
            // 
            // dividirNumber
            // 
            this.dividirNumber.Location = new System.Drawing.Point(139, 126);
            this.dividirNumber.Name = "dividirNumber";
            this.dividirNumber.Size = new System.Drawing.Size(36, 23);
            this.dividirNumber.TabIndex = 13;
            this.dividirNumber.Text = "/";
            this.dividirNumber.UseVisualStyleBackColor = true;
            this.dividirNumber.Click += new System.EventHandler(this.dividirNumber_Click);
            // 
            // numberDec
            // 
            this.numberDec.Location = new System.Drawing.Point(13, 155);
            this.numberDec.Name = "numberDec";
            this.numberDec.Size = new System.Drawing.Size(36, 23);
            this.numberDec.TabIndex = 14;
            this.numberDec.Text = ",";
            this.numberDec.UseVisualStyleBackColor = true;
            this.numberDec.Click += new System.EventHandler(this.numberDec_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(54, 155);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(36, 23);
            this.number0.TabIndex = 15;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // subnumber
            // 
            this.subnumber.Location = new System.Drawing.Point(95, 155);
            this.subnumber.Name = "subnumber";
            this.subnumber.Size = new System.Drawing.Size(36, 23);
            this.subnumber.TabIndex = 16;
            this.subnumber.Text = "-";
            this.subnumber.UseVisualStyleBackColor = true;
            this.subnumber.Click += new System.EventHandler(this.subnumber_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(137, 151);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(36, 56);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 184);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(11, 213);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(164, 23);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 256);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.subnumber);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.numberDec);
            this.Controls.Add(this.dividirNumber);
            this.Controls.Add(this.multNumber);
            this.Controls.Add(this.adicaoNumber);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button adicaoNumber;
        private System.Windows.Forms.Button multNumber;
        private System.Windows.Forms.Button dividirNumber;
        private System.Windows.Forms.Button numberDec;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button subnumber;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

