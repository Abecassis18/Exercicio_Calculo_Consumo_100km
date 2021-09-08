
namespace Exercicio_Calculo_Consumo_100km
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtKmPercorrido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoGasolina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl100km = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.txtConsGasRegis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ntf1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 230);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtKmPercorrido
            // 
            this.txtKmPercorrido.Location = new System.Drawing.Point(177, 36);
            this.txtKmPercorrido.Name = "txtKmPercorrido";
            this.txtKmPercorrido.Size = new System.Drawing.Size(100, 20);
            this.txtKmPercorrido.TabIndex = 1;
            this.txtKmPercorrido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Km Percorrido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço da Gasolina";
            // 
            // txtPrecoGasolina
            // 
            this.txtPrecoGasolina.Location = new System.Drawing.Point(177, 80);
            this.txtPrecoGasolina.Name = "txtPrecoGasolina";
            this.txtPrecoGasolina.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoGasolina.TabIndex = 4;
            this.txtPrecoGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor gasto a cada  100km";
            // 
            // lbl100km
            // 
            this.lbl100km.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl100km.Location = new System.Drawing.Point(199, 153);
            this.lbl100km.Name = "lbl100km";
            this.lbl100km.Size = new System.Drawing.Size(61, 22);
            this.lbl100km.TabIndex = 6;
            this.lbl100km.Text = "label4";
            this.lbl100km.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Despesa da Viagem";
            // 
            // lblDespesa
            // 
            this.lblDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDespesa.Location = new System.Drawing.Point(199, 186);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(61, 22);
            this.lblDespesa.TabIndex = 8;
            this.lblDespesa.Text = "label6";
            this.lblDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConsGasRegis
            // 
            this.txtConsGasRegis.Location = new System.Drawing.Point(177, 119);
            this.txtConsGasRegis.Name = "txtConsGasRegis";
            this.txtConsGasRegis.Size = new System.Drawing.Size(100, 20);
            this.txtConsGasRegis.TabIndex = 10;
            this.txtConsGasRegis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Consumo de gasolina Registado";
            // 
            // ntf1
            // 
            this.ntf1.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf1.Icon")));
            this.ntf1.Text = "notifyIcon1";
            this.ntf1.Visible = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(193, 242);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(78, 28);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Encerrar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 282);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtConsGasRegis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl100km);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecoGasolina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKmPercorrido);
            this.Controls.Add(this.btnCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculo de Consumo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtKmPercorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoGasolina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl100km;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.TextBox txtConsGasRegis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon ntf1;
        private System.Windows.Forms.Button btnFechar;
    }
}

