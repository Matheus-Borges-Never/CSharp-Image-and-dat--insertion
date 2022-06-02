using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            inserirDado();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string m = "";
            if (cmbTexto.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma opção da lista!");
            }
            else
            {
                m = cmbTexto.Items[cmbTexto.SelectedIndex].ToString();
                MessageBox.Show("Selecionado: " + cmbTexto.Text);
            }
        }

        private void txtFrase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //MessageBox.Show("Você acaba de pressionar a tecla ENTER!");
                inserirDado();
            }
        }

        private void inserirDado()
        {
            if (txtFrase.Text == "")
            {
                MessageBox.Show("Informe um valor na caixa!!");
                txtFrase.Focus();
            }
            else
            {
                cmbTexto.Items.Add(txtFrase.Text);
                MessageBox.Show("Dado Inserido!");
                txtFrase.Text = ""; 
                txtFrase.Focus();
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            string arq = "C:/Users/matheus.bpaulino/Downloads/batman.jpg";
            ptbImagem.Image = Image.FromFile(arq);
        }
    }
}
