using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculoNota
{
    public partial class Form1 : Form
    {
        bool alunoAprovado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            alunoAprovado = false;

            double nota01 = double.Parse(txtNota01.Text);
            double nota02 = double.Parse(txtNota02.Text);
            double nota03 = double.Parse(txtNota03.Text);

            double media = (nota01 + nota02 + nota03) / 3;

            if (media >= 5) alunoAprovado = true;

            lblMedia.Text = media.ToString();
        }

        private void btnVerificarSituacao_Click(object sender, EventArgs e)
        {
            if (alunoAprovado)
            {
                lblSituacao.Text = "Aprovado";
            } else
            {
                lblSituacao.Text = "Reprovado";
            }
        }

        private void btnNovoCalculo_Click(object sender, EventArgs e)
        {
            txtNota01.Text = string.Empty;
            txtNota02.Text = string.Empty;
            txtNota03.Text = string.Empty;

            lblMedia.Text = "";
            lblSituacao.Text = "";


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
