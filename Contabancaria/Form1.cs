using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_creditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow l = dgv_contas.SelectedRows[0];
            string nome = l.Cells[0].Value.ToString();
            double saldo = Convert.ToDouble(l.Cells[1].Value);

            Conta cc = new Conta(nome, saldo);

            cc.Credito(Convert.ToDouble(nud_Valor.Value));

            l.Cells[1].Value = cc.getSaldo();
            
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            if (dgv_contas.Rows.Count == 0)
            {
                dgv_contas.ColumnCount = 2;
                dgv_contas.Columns[0].Name = "Nome";
                dgv_contas.Columns[0].Name = "Saldo (R$)";

            }
            string[] linha = new string[]
            {
                txtNome.Text,
                nud_Saldo.Value.ToString()

            };
            dgv_contas.Rows.Add(linha);
        }

        private void btn_debitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow l = dgv_contas.SelectedRows[0];
            string nome = l.Cells[0].Value.ToString();
            double saldo = Convert.ToDouble(l.Cells[1].Value);

            Conta cc = new Conta(nome, saldo);

            cc.Debito(Convert.ToDouble(nud_Valor.Value));

            l.Cells[1].Value = cc.getSaldo();
        }
    }
}
