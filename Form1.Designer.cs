
namespace SimpleTCP
{
    partial class TCPClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.txtBoxIPServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMensagem = new System.Windows.Forms.TextBox();
            this.periodo = new System.Windows.Forms.Timer(this.components);
            this.chtTempUmid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtTempUmid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(610, 385);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(178, 53);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(426, 385);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(178, 53);
            this.btnComecar.TabIndex = 0;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(12, 385);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(178, 53);
            this.btnDesconectar.TabIndex = 0;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // txtBoxIPServidor
            // 
            this.txtBoxIPServidor.Location = new System.Drawing.Point(87, 12);
            this.txtBoxIPServidor.Name = "txtBoxIPServidor";
            this.txtBoxIPServidor.Size = new System.Drawing.Size(215, 22);
            this.txtBoxIPServidor.TabIndex = 1;
            this.txtBoxIPServidor.Text = "192.168.100.29";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Servidor";
            // 
            // txtBoxPeriodo
            // 
            this.txtBoxPeriodo.Location = new System.Drawing.Point(768, 12);
            this.txtBoxPeriodo.Name = "txtBoxPeriodo";
            this.txtBoxPeriodo.Size = new System.Drawing.Size(30, 22);
            this.txtBoxPeriodo.TabIndex = 1;
            this.txtBoxPeriodo.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Período (segundos)";
            // 
            // txtBoxMensagem
            // 
            this.txtBoxMensagem.Location = new System.Drawing.Point(12, 56);
            this.txtBoxMensagem.Multiline = true;
            this.txtBoxMensagem.Name = "txtBoxMensagem";
            this.txtBoxMensagem.ReadOnly = true;
            this.txtBoxMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMensagem.Size = new System.Drawing.Size(290, 323);
            this.txtBoxMensagem.TabIndex = 1;
            // 
            // periodo
            // 
            this.periodo.Tick += new System.EventHandler(this.periodo_Tick);
            // 
            // chtTempUmid
            // 
            chartArea1.Name = "ChartArea1";
            this.chtTempUmid.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTempUmid.Legends.Add(legend1);
            this.chtTempUmid.Location = new System.Drawing.Point(308, 47);
            this.chtTempUmid.Name = "chtTempUmid";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperatura (ºC)";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Umidade (%)";
            this.chtTempUmid.Series.Add(series1);
            this.chtTempUmid.Series.Add(series2);
            this.chtTempUmid.Size = new System.Drawing.Size(732, 332);
            this.chtTempUmid.TabIndex = 3;
            this.chtTempUmid.Text = "chart1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(242, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(178, 53);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.chtTempUmid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMensagem);
            this.Controls.Add(this.txtBoxPeriodo);
            this.Controls.Add(this.txtBoxIPServidor);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.btnConectar);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.TCPClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTempUmid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TextBox txtBoxIPServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMensagem;
        private System.Windows.Forms.Timer periodo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTempUmid;
        private System.Windows.Forms.Button btnLimpar;
    }
}

