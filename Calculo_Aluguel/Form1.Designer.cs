namespace Calculo_Aluguel
{
    partial class calculoAluguel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datasAluguel = new System.Windows.Forms.ListBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckCartao = new System.Windows.Forms.CheckBox();
            this.lbl_nomeCliente = new System.Windows.Forms.Label();
            this.melhorCarro = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            this.lblDiasAluguel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local do Arquivo do Cliente:";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(148, 6);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(266, 20);
            this.txtDiretorio.TabIndex = 1;
            this.txtDiretorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDiretorio_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Qtd de Pessoas: ";
            // 
            // datasAluguel
            // 
            this.datasAluguel.FormattingEnabled = true;
            this.datasAluguel.Location = new System.Drawing.Point(100, 110);
            this.datasAluguel.Name = "datasAluguel";
            this.datasAluguel.Size = new System.Drawing.Size(215, 69);
            this.datasAluguel.TabIndex = 6;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(148, 261);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(123, 23);
            this.btnRelatorio.TabIndex = 8;
            this.btnRelatorio.Text = "Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Datas do Aluguel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dias do Aluguel:";
            // 
            // ckCartao
            // 
            this.ckCartao.AutoSize = true;
            this.ckCartao.Enabled = false;
            this.ckCartao.Location = new System.Drawing.Point(314, 34);
            this.ckCartao.Name = "ckCartao";
            this.ckCartao.Size = new System.Drawing.Size(108, 17);
            this.ckCartao.TabIndex = 5;
            this.ckCartao.Text = "Cartão Fidelidade";
            this.ckCartao.UseVisualStyleBackColor = true;
            // 
            // lbl_nomeCliente
            // 
            this.lbl_nomeCliente.AutoSize = true;
            this.lbl_nomeCliente.Location = new System.Drawing.Point(6, 35);
            this.lbl_nomeCliente.Name = "lbl_nomeCliente";
            this.lbl_nomeCliente.Size = new System.Drawing.Size(94, 13);
            this.lbl_nomeCliente.TabIndex = 89;
            this.lbl_nomeCliente.Text = "Nome do Cliente : ";
            // 
            // melhorCarro
            // 
            this.melhorCarro.FormattingEnabled = true;
            this.melhorCarro.Location = new System.Drawing.Point(152, 185);
            this.melhorCarro.Name = "melhorCarro";
            this.melhorCarro.Size = new System.Drawing.Size(215, 69);
            this.melhorCarro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Melhor Opção de Automóvel:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(97, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 2;
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.AutoSize = true;
            this.lblQtdPessoas.Location = new System.Drawing.Point(87, 62);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(0, 13);
            this.lblQtdPessoas.TabIndex = 3;
            // 
            // lblDiasAluguel
            // 
            this.lblDiasAluguel.AutoSize = true;
            this.lblDiasAluguel.Location = new System.Drawing.Point(87, 87);
            this.lblDiasAluguel.Name = "lblDiasAluguel";
            this.lblDiasAluguel.Size = new System.Drawing.Size(0, 13);
            this.lblDiasAluguel.TabIndex = 4;
            // 
            // calculoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 296);
            this.Controls.Add(this.lblDiasAluguel);
            this.Controls.Add(this.lblQtdPessoas);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.melhorCarro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datasAluguel);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckCartao);
            this.Controls.Add(this.lbl_nomeCliente);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.label1);
            this.Name = "calculoAluguel";
            this.Text = "Calcula o Aluguel do Melhor Automóvel para o Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox datasAluguel;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckCartao;
        private System.Windows.Forms.Label lbl_nomeCliente;
        private System.Windows.Forms.ListBox melhorCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQtdPessoas;
        private System.Windows.Forms.Label lblDiasAluguel;
    }
}

