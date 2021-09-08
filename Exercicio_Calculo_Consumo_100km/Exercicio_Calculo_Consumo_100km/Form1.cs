using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Calculo_Consumo_100km
{
    public partial class Form1 : Form
    {
        string comp100 = "Lt"; // Tem de ser publica se não la na saida ele não concatena esta variável.
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ntf1.Visible = true;
            ntf1.BalloonTipText="Em Execução cara";
            ntf1.ShowBalloonTip(5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //txtKmPercorrido.Text = "0".ToString();
            //txtPrecoGasolina.Text = 0.ToString();
            //txtConsGasRegis.Text = "0".ToString(); //Temos de adicionar o cons. registado para saber quanto consumimos de gass. a cada 100km;
            //lbl100km.Text = "0".ToString() + comp100;
            //lblDespesa.Text = 0.ToString("C2");
        }
        private void encerrar()
        {
            this.Close();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtKmPercorrido.Text != "" && txtPrecoGasolina.Text != "" &&  txtConsGasRegis.Text != "")
            {
                float kmPercorr, precoGasolina, consRegistado;
                double consP100, despesaViagem;
                
                kmPercorr = float.Parse(txtKmPercorrido.Text);
                precoGasolina = float.Parse(txtPrecoGasolina.Text);
                consRegistado = float.Parse(txtConsGasRegis.Text);

                consP100 = consRegistado / kmPercorr * 100;
                despesaViagem = consRegistado * precoGasolina; //A despesa total é quanto tu consumiu de combustivel pelo valor do mesmo.

                lbl100km.Text = consP100.ToString() + comp100;
                lblDespesa.Text = despesaViagem.ToString("C2");
            }
            else
                MessageBox.Show("Preencha todos campos");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            encerrar();
        }
    }
}
