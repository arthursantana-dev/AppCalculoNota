namespace AppCalculoNota
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnVerificarSituacao = new System.Windows.Forms.Button();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovoCalculo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalcularMedia);
            this.groupBox1.Controls.Add(this.txtNota03);
            this.groupBox1.Controls.Add(this.txtNota02);
            this.groupBox1.Controls.Add(this.txtNota01);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculo de Média";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 02";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 03";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNota01
            // 
            this.txtNota01.Location = new System.Drawing.Point(57, 23);
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(100, 20);
            this.txtNota01.TabIndex = 3;
            // 
            // txtNota02
            // 
            this.txtNota02.Location = new System.Drawing.Point(57, 53);
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(100, 20);
            this.txtNota02.TabIndex = 4;
            // 
            // txtNota03
            // 
            this.txtNota03.Location = new System.Drawing.Point(57, 83);
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(100, 20);
            this.txtNota03.TabIndex = 5;
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(9, 116);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(148, 23);
            this.btnCalcularMedia.TabIndex = 6;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Média";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblMedia.Location = new System.Drawing.Point(104, 158);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 22);
            this.lblMedia.TabIndex = 8;
            // 
            // btnVerificarSituacao
            // 
            this.btnVerificarSituacao.Location = new System.Drawing.Point(12, 214);
            this.btnVerificarSituacao.Name = "btnVerificarSituacao";
            this.btnVerificarSituacao.Size = new System.Drawing.Size(171, 23);
            this.btnVerificarSituacao.TabIndex = 1;
            this.btnVerificarSituacao.Text = "Verificar Situação";
            this.btnVerificarSituacao.UseVisualStyleBackColor = true;
            this.btnVerificarSituacao.Click += new System.EventHandler(this.btnVerificarSituacao_Click);
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSituacao.Location = new System.Drawing.Point(87, 252);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSituacao.Size = new System.Drawing.Size(0, 22);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Situação";
            // 
            // btnNovoCalculo
            // 
            this.btnNovoCalculo.Location = new System.Drawing.Point(12, 294);
            this.btnNovoCalculo.Name = "btnNovoCalculo";
            this.btnNovoCalculo.Size = new System.Drawing.Size(171, 23);
            this.btnNovoCalculo.TabIndex = 11;
            this.btnNovoCalculo.Text = "Novo Cálculo";
            this.btnNovoCalculo.UseVisualStyleBackColor = true;
            this.btnNovoCalculo.Click += new System.EventHandler(this.btnNovoCalculo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(12, 323);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(171, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 359);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovoCalculo);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVerificarSituacao);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Média - Aluno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.TextBox txtNota03;
        private System.Windows.Forms.TextBox txtNota02;
        private System.Windows.Forms.TextBox txtNota01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificarSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovoCalculo;
        private System.Windows.Forms.Button btnFechar;
    }
}

