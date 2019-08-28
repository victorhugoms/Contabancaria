namespace Contabancaria
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
            this.gpb_conta = new System.Windows.Forms.GroupBox();
            this.dgv_contas = new System.Windows.Forms.DataGridView();
            this.btn_Criar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Saldo = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_transacoes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_debitar = new System.Windows.Forms.Button();
            this.btn_creditar = new System.Windows.Forms.Button();
            this.nud_Valor = new System.Windows.Forms.NumericUpDown();
            this.gpb_conta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Saldo)).BeginInit();
            this.gpb_transacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Valor)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_conta
            // 
            this.gpb_conta.Controls.Add(this.dgv_contas);
            this.gpb_conta.Controls.Add(this.btn_Criar);
            this.gpb_conta.Controls.Add(this.label2);
            this.gpb_conta.Controls.Add(this.nud_Saldo);
            this.gpb_conta.Controls.Add(this.txtNome);
            this.gpb_conta.Controls.Add(this.label1);
            this.gpb_conta.Location = new System.Drawing.Point(41, 25);
            this.gpb_conta.Name = "gpb_conta";
            this.gpb_conta.Size = new System.Drawing.Size(310, 413);
            this.gpb_conta.TabIndex = 5;
            this.gpb_conta.TabStop = false;
            this.gpb_conta.Text = "Dados da Conta";
            // 
            // dgv_contas
            // 
            this.dgv_contas.AllowUserToAddRows = false;
            this.dgv_contas.AllowUserToDeleteRows = false;
            this.dgv_contas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_contas.Location = new System.Drawing.Point(23, 135);
            this.dgv_contas.Name = "dgv_contas";
            this.dgv_contas.ReadOnly = true;
            this.dgv_contas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_contas.Size = new System.Drawing.Size(240, 272);
            this.dgv_contas.TabIndex = 5;
            // 
            // btn_Criar
            // 
            this.btn_Criar.Location = new System.Drawing.Point(188, 27);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(75, 56);
            this.btn_Criar.TabIndex = 4;
            this.btn_Criar.Text = "Criar";
            this.btn_Criar.UseVisualStyleBackColor = true;
            this.btn_Criar.Click += new System.EventHandler(this.btn_Criar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo: ";
            // 
            // nud_Saldo
            // 
            this.nud_Saldo.DecimalPlaces = 2;
            this.nud_Saldo.Location = new System.Drawing.Point(66, 66);
            this.nud_Saldo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_Saldo.Name = "nud_Saldo";
            this.nud_Saldo.Size = new System.Drawing.Size(68, 20);
            this.nud_Saldo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // gpb_transacoes
            // 
            this.gpb_transacoes.Controls.Add(this.label3);
            this.gpb_transacoes.Controls.Add(this.btn_debitar);
            this.gpb_transacoes.Controls.Add(this.btn_creditar);
            this.gpb_transacoes.Controls.Add(this.nud_Valor);
            this.gpb_transacoes.Location = new System.Drawing.Point(377, 25);
            this.gpb_transacoes.Name = "gpb_transacoes";
            this.gpb_transacoes.Size = new System.Drawing.Size(225, 155);
            this.gpb_transacoes.TabIndex = 6;
            this.gpb_transacoes.TabStop = false;
            this.gpb_transacoes.Text = "Transações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor (R$): ";
            // 
            // btn_debitar
            // 
            this.btn_debitar.Location = new System.Drawing.Point(122, 75);
            this.btn_debitar.Name = "btn_debitar";
            this.btn_debitar.Size = new System.Drawing.Size(75, 23);
            this.btn_debitar.TabIndex = 5;
            this.btn_debitar.Text = "Debitar";
            this.btn_debitar.UseVisualStyleBackColor = true;
            this.btn_debitar.Click += new System.EventHandler(this.btn_debitar_Click);
            // 
            // btn_creditar
            // 
            this.btn_creditar.Location = new System.Drawing.Point(22, 75);
            this.btn_creditar.Name = "btn_creditar";
            this.btn_creditar.Size = new System.Drawing.Size(75, 23);
            this.btn_creditar.TabIndex = 4;
            this.btn_creditar.Text = "Crerditar";
            this.btn_creditar.UseVisualStyleBackColor = true;
            this.btn_creditar.Click += new System.EventHandler(this.btn_creditar_Click);
            // 
            // nud_Valor
            // 
            this.nud_Valor.DecimalPlaces = 2;
            this.nud_Valor.Location = new System.Drawing.Point(85, 27);
            this.nud_Valor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_Valor.Name = "nud_Valor";
            this.nud_Valor.Size = new System.Drawing.Size(68, 20);
            this.nud_Valor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.gpb_transacoes);
            this.Controls.Add(this.gpb_conta);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Contas Bancárias";
            this.gpb_conta.ResumeLayout(false);
            this.gpb_conta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_contas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Saldo)).EndInit();
            this.gpb_transacoes.ResumeLayout(false);
            this.gpb_transacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Valor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpb_conta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Saldo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_contas;
        private System.Windows.Forms.Button btn_Criar;
        private System.Windows.Forms.GroupBox gpb_transacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_debitar;
        private System.Windows.Forms.Button btn_creditar;
        private System.Windows.Forms.NumericUpDown nud_Valor;
    }
}

