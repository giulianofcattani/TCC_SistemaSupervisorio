using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Net.Http;
using System.Windows.Forms;

namespace TCCFinal
{
    public partial class Form1 : Form
    {
        private System.IO.Ports.SerialPort _serialArduino;
        public ConexaoModbus cModbus = new ConexaoModbus();
        public int contaRequisicoes = 0;

        delegate void SerialCallback(string dado);
        delegate void MostraMedidasModbusCallback(ushort[] medidas);
        delegate void ReceberMensagemCallback(string msg);
        delegate void EnviaRequisicaoCallback(ushort[] requisicao);

        public delegate void ConfiguraPortaSerial(string baudrate, string bitDados, string paridade, string bitsParada);

        public Form1()
        {
            InitializeComponent();
            ListaPortasArduino();
            gBoxFonte.Enabled = false;
        }

        /**
         * Ações Click - Ligar e desligar
         */

        // Início Arduino
        private void btnConectaArduino_Click(object sender, EventArgs e)
        {
            if (!_serialArduino.IsOpen)
            {
                try
                {
                    _serialArduino.PortName = cBoxPortas.Text;
                    _serialArduino.Open();
                    _serialArduino.DiscardInBuffer();
                    radioPlacaIntrumentacao.Checked = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            if (_serialArduino.IsOpen)
            {
                try
                {
                    _serialArduino.Close();
                    radioPlacaIntrumentacao.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAtualizaArduino_Click(object sender, EventArgs e)
        {
            ListaPortasArduino();
        }

        // Fim Arduino

        // Inicio Modbus
        private void btnModbusConectar_Click(object sender, EventArgs e)
        {
            string modbusIP = txtModbusIP.Text;
            int modbusPorta = int.Parse(txtModbusPorta.Text);
            cModbus.ConectaModbus(modbusIP, modbusPorta);
            if (cModbus.TestaConexaoModbus())
            {
                gBoxFonte.Enabled = true;
                radioFonteTensao.Checked = true;
            }
        }

        private void btnDesconectarModbus_Click_1(object sender, EventArgs e)
        {
            cModbus.DesconectaModbus();
            gBoxFonte.Enabled = false;
            radioFonteTensao.Checked = false;
        }

        // Fim Modbus

        /**
         * Operações para conexão Serial
         */
        private void AbrirConfigruacoesSerial(object sender, EventArgs e)
        {
            var abrirConfig = new ConfigSerial();
            if (abrirConfig == null) throw new ArgumentNullException(nameof(abrirConfig));
            abrirConfig.SerialBaudrate2 = _serialArduino.BaudRate.ToString();
            abrirConfig.SerialBitsDados2 = _serialArduino.DataBits.ToString();
            abrirConfig.SerialParidade2 = _serialArduino.Parity.ToString();
            abrirConfig.SerialBitsParada2 = _serialArduino.StopBits.ToString();
            abrirConfig.Show();
        }
        private void ListaPortasArduino()
        {
            cBoxPortas.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                cBoxPortas.Items.Add(s);
            }
        }

        private void serialArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dadoRecebido = _serialArduino.ReadLine();
            MostraDado(dadoRecebido);
        }

        private void MostraDado(string dadoRecebido)
        {
            if (txtBoxDados.InvokeRequired)
            {
                SerialCallback scb = new SerialCallback(MostraDado);
                Invoke(scb, dadoRecebido);
            }
            else
            {
                txtBoxDados.Text = dadoRecebido;
            }

            if (dadoRecebido.Length > 8)
            {
                var mudaRele = CorrigeLeituraSerial(dadoRecebido);
                MudaRadio(mudaRele[0]);
                txtTemperatura.Text = mudaRele[1];

                var msg = contaRequisicoes.ToString();
                ReceberMensagem(msg);
                if (cModbus.TestaConexaoModbus() && (contaRequisicoes >= 19))
                {
                    var medidas = cModbus.LeituraModbus();
                    MostraMedidasModbus(medidas);
                    contaRequisicoes = 0;
                    cModbus.EscritaModbus((ushort)0);

                }
                contaRequisicoes++;

            }
        }

        private void IncrementoModbus()
        {
            //var medidas = cModbus.LeituraModbus();
            //ushort leituraInicial = medidas[0];
            ushort leituraConstante = ushort.Parse(txtConstanteTensao.Text);
            //ushort resultadoLeitura = (ushort)(leituraInicial + leituraConstante);
            cModbus.EscritaModbus(leituraConstante);
        }
        private void DecrementoModbus()
        {
            //var medidas = cModbus.LeituraModbus();
            //ushort leituraInicial = medidas[0];
            ushort leituraConstante = (ushort)(ushort.Parse(txtConstanteTensao.Text) * -1);
            //ushort resultadoLeitura = (ushort)(leituraInicial - leituraConstante);
            cModbus.EscritaModbus(leituraConstante);
        }

        private string[] CorrigeLeituraSerial(string dadoSerial)
        {
            string result = "";
            string result2 = txtTemperatura.Text;
            string[] reslts = dadoSerial.Split(new string[] { "_/", "_" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var dad in reslts)
            {
                var comeco = dad.IndexOf(".", StringComparison.Ordinal);
                result = dad.Substring(0, comeco);
                string[] reslts3 = dad.Split(new string[] { ".", "/", "\n", "\r" },
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var res2 in reslts3)
                {
                    result2 = res2;
                }
            }
            return new[] { result, result2 };
        }

        /**
         * Sinalizações
         */

        void MostraMedidasModbus(ushort[] medidas)
        {

            if (InvokeRequired)
            {
                MostraMedidasModbusCallback callback = MostraMedidasModbus;
                Invoke(callback, medidas);
            }
            else
            {
                txtUV.Text = medidas[0].ToString();
                txtVV.Text = medidas[1].ToString();
                txtWV.Text = medidas[2].ToString();

                txtUA.Text = medidas[3].ToString();
                txtVA.Text = medidas[4].ToString();
                txtWA.Text = medidas[5].ToString();

                txtUW.Text = medidas[6].ToString();
                txtVW.Text = medidas[7].ToString();
                txtWW.Text = medidas[8].ToString();
            }
        }

        private void MudaRadio(string leitura)
        {
            if (leitura.Contains("10") == true)
            {
                rbElevar.Checked = true;
                rbRebaixar.Checked = false;
                if (cModbus.TestaConexaoModbus())
                {
                    IncrementoModbus();
                }
            }
            else if (leitura.Contains("01") == true)
            {
                rbElevar.Checked = false;
                rbRebaixar.Checked = true;
                if (cModbus.TestaConexaoModbus())
                {
                    DecrementoModbus();
                }
            }
            else if (leitura.Contains("00") == true)
            {
                rbElevar.Checked = false;
                rbRebaixar.Checked = false;
            }
        }
        

        void ReceberMensagem(string msg)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceberMensagem;
                Invoke(callback, msg);
            }
            else
            {
                txtBoxRequisicoes.Text = msg;
            }

        }


        void EnviaRequisicao(ushort[] requisicao)
        {
            if (InvokeRequired)
            {
                EnviaRequisicaoCallback callback = EnviaRequisicao;
                Invoke(callback, requisicao);
            }
            else
            {
                using (var cliente = new HttpClient())
                {
                    try
                    {
                        var dadosRequisicao = new Dictionary<string, string>
                        {
                            {"TensaoU", requisicao[0].ToString()},
                            {"TensaoV", requisicao[1].ToString()},
                            {"TensaoW", requisicao[2].ToString()},

                            {"CorrenteU", requisicao[3].ToString()},
                            {"CorrenteV", requisicao[4].ToString()},
                            {"CorrenteW", requisicao[5].ToString()},

                            {"PotU", requisicao[6].ToString()},
                            {"PotV", requisicao[7].ToString()},
                            {"PotW", requisicao[8].ToString()},

                            {"Temp", requisicao[9].ToString()}
                        };

                        var dadosRequisicaoHttp = new FormUrlEncodedContent(dadosRequisicao);

                        var resposta = cliente.PostAsync("http://localhost/tcc/", dadosRequisicaoHttp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void AbrirConfiguracoesFonte(object sender, EventArgs e)
        {
            var abrirConfigFonte = new ConfigFonte();
            if (abrirConfigFonte == null) throw new ArgumentNullException(nameof(abrirConfigFonte));
            abrirConfigFonte.Show();
        }
    }
}