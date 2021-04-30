namespace EscalonadorRoundRobin
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
            this.tblProcessos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcessoExecucao = new System.Windows.Forms.Label();
            this.txtQuantum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempoVidaProcesso = new System.Windows.Forms.TextBox();
            this.txtProcessosMinuto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btParar = new System.Windows.Forms.Button();
            this.txtPercentualIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblProcessosIO = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProcessos
            // 
            this.tblProcessos.FormattingEnabled = true;
            this.tblProcessos.Location = new System.Drawing.Point(6, 19);
            this.tblProcessos.Name = "tblProcessos";
            this.tblProcessos.Size = new System.Drawing.Size(244, 407);
            this.tblProcessos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processo em Execução:";
            // 
            // lblProcessoExecucao
            // 
            this.lblProcessoExecucao.AutoSize = true;
            this.lblProcessoExecucao.Location = new System.Drawing.Point(404, 15);
            this.lblProcessoExecucao.Name = "lblProcessoExecucao";
            this.lblProcessoExecucao.Size = new System.Drawing.Size(0, 13);
            this.lblProcessoExecucao.TabIndex = 3;
            // 
            // txtQuantum
            // 
            this.txtQuantum.Location = new System.Drawing.Point(289, 306);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.Size = new System.Drawing.Size(100, 20);
            this.txtQuantum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantum [clocks]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempo de vida do processo [ms]:";
            // 
            // txtTempoVidaProcesso
            // 
            this.txtTempoVidaProcesso.Location = new System.Drawing.Point(404, 306);
            this.txtTempoVidaProcesso.Name = "txtTempoVidaProcesso";
            this.txtTempoVidaProcesso.Size = new System.Drawing.Size(100, 20);
            this.txtTempoVidaProcesso.TabIndex = 7;
            // 
            // txtProcessosMinuto
            // 
            this.txtProcessosMinuto.Location = new System.Drawing.Point(571, 306);
            this.txtProcessosMinuto.Name = "txtProcessosMinuto";
            this.txtProcessosMinuto.Size = new System.Drawing.Size(100, 20);
            this.txtProcessosMinuto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Processos por Minuto:";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(289, 333);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 10;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btParar
            // 
            this.btParar.Location = new System.Drawing.Point(370, 332);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(75, 23);
            this.btParar.TabIndex = 11;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = true;
            this.btParar.Click += new System.EventHandler(this.btParar_Click);
            // 
            // txtPercentualIO
            // 
            this.txtPercentualIO.Location = new System.Drawing.Point(689, 306);
            this.txtPercentualIO.Name = "txtPercentualIO";
            this.txtPercentualIO.Size = new System.Drawing.Size(100, 20);
            this.txtPercentualIO.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Probabilidade OI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblProcessos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 431);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fila Processos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblProcessosIO);
            this.groupBox2.Location = new System.Drawing.Point(276, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 172);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aguardando IO";
            // 
            // tblProcessosIO
            // 
            this.tblProcessosIO.FormattingEnabled = true;
            this.tblProcessosIO.Location = new System.Drawing.Point(6, 19);
            this.tblProcessosIO.Name = "tblProcessosIO";
            this.tblProcessosIO.Size = new System.Drawing.Size(244, 147);
            this.tblProcessosIO.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPercentualIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.txtProcessosMinuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTempoVidaProcesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantum);
            this.Controls.Add(this.lblProcessoExecucao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcessoExecucao;
        private System.Windows.Forms.TextBox txtQuantum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempoVidaProcesso;
        private System.Windows.Forms.TextBox txtProcessosMinuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.ListBox tblProcessos;
        private System.Windows.Forms.TextBox txtPercentualIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox tblProcessosIO;
    }
}

