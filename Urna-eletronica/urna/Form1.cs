using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace urna
{
    public partial class Form1 : Form
    {

        string num; //armazena o número do candidato

        int candidato10, candidato20, candidato30, candidato40, branco, nulo;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnNumero(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDireita.Text = txtDireita.Text + bt.Text;

        }
        private void txtDireita_TextChanged(object sender, EventArgs e)
        {
            num = txtDireita.Text;

            if (num == "12")
            {
                pictureBox1.Image = Properties.Resources.cad_ciro;
                lblNomeCandidato.Text = "Ciro Gomes";

            }

            else if (num == "13")
            {
                pictureBox1.Image = Properties.Resources.cad_lula;
                lblNomeCandidato.Text = "Lula";
            }

            else if (num == "22")
            {
                pictureBox1.Image = Properties.Resources.cad_mito;
                lblNomeCandidato.Text = "Jair Bolsonaro";
            }

            else if (num == "15")
            {
                pictureBox1.Image = Properties.Resources.cad_simone;
                lblNomeCandidato.Text = "Simone Tebet";
            }

            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" & num != "--")
            {
                pictureBox1.Image = Properties.Resources.erro;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDireita.Text = "";
            lblNomeCandidato.Text = "";
            a = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fundobranco_urna;
            txtDireita.Text = "--";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var resultado = new Form2(candidato10, candidato20, candidato30, candidato40, branco, nulo);
            resultado.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (num == "12")
                {
                    candidato10 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_ciro;
                }
                else if (num == "13")
                {
                    candidato20 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_lula;
                }
                else if (num == "22")
                {
                    candidato30 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_mito;
                }
                else if (num == "15")
                {
                    candidato40 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.cad_simone;
                }

                else if (num == "--")
                {
                    branco += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundobranco_urna;
                }

                else
                {
                    nulo += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundobranco_urna;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      


    }
}






