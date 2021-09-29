using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace SimpleTCP
{
    public partial class TCPClient : Form
    {
        SimpleTcpClient _Client;


        public TCPClient()
        {
            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _Client = new SimpleTcpClient(txtBoxIPServidor.Text, 80);
            _Client.Events.Connected += Connected;
            _Client.Events.Disconnected += Disconnected;
            _Client.Events.DataReceived += DataReceived;

            try
            {
                _Client.Connect();
                btnComecar.Enabled = true;
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TCPClient_Load(object sender, EventArgs e)
        {
            btnComecar.Enabled = false;
            btnDesconectar.Enabled = false;

            chtTempUmid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //seta o tipo de gráfico como linha
            chtTempUmid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void Connected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                txtBoxMensagem.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void Disconnected(object sender, EventArgs e)
        {
                this.Invoke((MethodInvoker)delegate {
                    txtBoxMensagem.Text += $"Server disconnected.{Environment.NewLine}";
                });
            }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                const char delimitador = '|';
                string mensagem = Encoding.UTF8.GetString(e.Data);

                txtBoxMensagem.Text += $"Server: {mensagem}{Environment.NewLine}";

                string[] dados = mensagem.Split(delimitador);
                chtTempUmid.Series[0].Points.AddY(dados[0]);
                chtTempUmid.Series[1].Points.AddY(dados[1]);

                txtBoxMensagem.Text += $"Temp: {dados[0]}{Environment.NewLine}";
                txtBoxMensagem.Text += $"Umid: {dados[1]}{Environment.NewLine}";
            });
                }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (_Client.IsConnected)
            {
                //  txtMessage.Text = string.Empty;

                if (!String.IsNullOrEmpty(txtBoxPeriodo.Text) && Convert.ToInt16(txtBoxPeriodo.Text) >=2)
                {
                    periodo.Interval = Convert.ToInt16(txtBoxPeriodo.Text);
                    periodo.Interval *= 1000; //passa de segundos para milissegundos
                    periodo.Enabled = true; //dispara timer
                    txtBoxPeriodo.Enabled = false;
                    txtBoxMensagem.Text += $"Iniciado {Environment.NewLine}";

                    _Client.Send("X"); //primeira amostra
                }
                else
                {
                    MessageBox.Show("O período deve ser igual ou maior que 2!");
                }
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            periodo.Enabled = false;
            _Client.Disconnect();
            btnComecar.Enabled = false;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            txtBoxPeriodo.Enabled = true;
        }

        private void periodo_Tick(object sender, EventArgs e)
        {
            _Client.Send("X");
            // txtBoxMensagem.Text += $"Me: {txtBoxMensagem.Text}{Environment.NewLine}";
           //_Client.Send("U");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chtTempUmid.Series[0].Points.Clear();
            chtTempUmid.Series[1].Points.Clear();
            txtBoxMensagem.Clear();
        }
        // periodo.Interval = Int16.Parse(txtBoxPeriodo.Text);

    }
}
