namespace TCCFinal
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBoxPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.btnAtualizaArduino = new System.Windows.Forms.Button();
            this.btnConectaArduino = new System.Windows.Forms.Button();
            this._serialArduino = new System.IO.Ports.SerialPort(this.components);
            this.txtBoxDados = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbElevar = new System.Windows.Forms.RadioButton();
            this.rbRebaixar = new System.Windows.Forms.RadioButton();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.radioPlacaIntrumentacao = new System.Windows.Forms.RadioButton();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtModbusIP = new System.Windows.Forms.TextBox();
            this.txtModbusPorta = new System.Windows.Forms.TextBox();
            this.lblModbusIP = new System.Windows.Forms.Label();
            this.lblModbusPorta = new System.Windows.Forms.Label();
            this.btnModbusConectar = new System.Windows.Forms.Button();
            this.gBoxFonte = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWW = new System.Windows.Forms.TextBox();
            this.txtUW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVW = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVV = new System.Windows.Forms.TextBox();
            this.txtUV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDesconectarModbus = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRequisicoes = new System.Windows.Forms.TextBox();
            this.txtConstanteTensao = new System.Windows.Forms.TextBox();
            this.lblConstanteTensao = new System.Windows.Forms.Label();
            this.btnConfigurarFonte = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBoxStatusConexao = new System.Windows.Forms.GroupBox();
            this.radioFonteTensao = new System.Windows.Forms.RadioButton();
            this.lblFonte = new System.Windows.Forms.Label();
            this.lblPlacaInstrumentacao = new System.Windows.Forms.Label();
            this.gBoxFonte.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxStatusConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxPortas
            // 
            this.cBoxPortas.FormattingEnabled = true;
            this.cBoxPortas.Location = new System.Drawing.Point(403, 30);
            this.cBoxPortas.Name = "cBoxPortas";
            this.cBoxPortas.Size = new System.Drawing.Size(67, 21);
            this.cBoxPortas.TabIndex = 0;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(333, 33);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(64, 13);
            this.lblPortas.TabIndex = 1;
            this.lblPortas.Text = "Portas COM";
            // 
            // btnAtualizaArduino
            // 
            this.btnAtualizaArduino.Location = new System.Drawing.Point(529, 30);
            this.btnAtualizaArduino.Name = "btnAtualizaArduino";
            this.btnAtualizaArduino.Size = new System.Drawing.Size(61, 23);
            this.btnAtualizaArduino.TabIndex = 2;
            this.btnAtualizaArduino.Text = "Atualizar";
            this.btnAtualizaArduino.UseVisualStyleBackColor = true;
            this.btnAtualizaArduino.Click += new System.EventHandler(this.btnAtualizaArduino_Click);
            // 
            // btnConectaArduino
            // 
            this.btnConectaArduino.Location = new System.Drawing.Point(336, 57);
            this.btnConectaArduino.Name = "btnConectaArduino";
            this.btnConectaArduino.Size = new System.Drawing.Size(81, 23);
            this.btnConectaArduino.TabIndex = 3;
            this.btnConectaArduino.Text = "Conectar";
            this.btnConectaArduino.UseVisualStyleBackColor = true;
            this.btnConectaArduino.Click += new System.EventHandler(this.btnConectaArduino_Click);
            // 
            // _serialArduino
            // 
            this._serialArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialArduino_DataReceived);
            // 
            // txtBoxDados
            // 
            this.txtBoxDados.Location = new System.Drawing.Point(72, 18);
            this.txtBoxDados.Multiline = true;
            this.txtBoxDados.Name = "txtBoxDados";
            this.txtBoxDados.Size = new System.Drawing.Size(65, 31);
            this.txtBoxDados.TabIndex = 4;
            // 
            // rbElevar
            // 
            this.rbElevar.AutoSize = true;
            this.rbElevar.Location = new System.Drawing.Point(9, 19);
            this.rbElevar.Name = "rbElevar";
            this.rbElevar.Size = new System.Drawing.Size(55, 17);
            this.rbElevar.TabIndex = 5;
            this.rbElevar.TabStop = true;
            this.rbElevar.Text = "Elevar";
            this.rbElevar.UseVisualStyleBackColor = true;
            // 
            // rbRebaixar
            // 
            this.rbRebaixar.AutoSize = true;
            this.rbRebaixar.Location = new System.Drawing.Point(10, 42);
            this.rbRebaixar.Name = "rbRebaixar";
            this.rbRebaixar.Size = new System.Drawing.Size(67, 17);
            this.rbRebaixar.TabIndex = 6;
            this.rbRebaixar.TabStop = true;
            this.rbRebaixar.Text = "Rebaixar";
            this.rbRebaixar.UseVisualStyleBackColor = true;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(529, 55);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(136, 25);
            this.btnConfigurar.TabIndex = 7;
            this.btnConfigurar.Text = "Verificar Configurações";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.AbrirConfigruacoesSerial);
            // 
            // radioPlacaIntrumentacao
            // 
            this.radioPlacaIntrumentacao.AutoSize = true;
            this.radioPlacaIntrumentacao.Location = new System.Drawing.Point(117, 16);
            this.radioPlacaIntrumentacao.Name = "radioPlacaIntrumentacao";
            this.radioPlacaIntrumentacao.Size = new System.Drawing.Size(77, 17);
            this.radioPlacaIntrumentacao.TabIndex = 12;
            this.radioPlacaIntrumentacao.TabStop = true;
            this.radioPlacaIntrumentacao.Text = "Conectado";
            this.radioPlacaIntrumentacao.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(423, 57);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(81, 23);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click_1);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Location = new System.Drawing.Point(6, 74);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(71, 23);
            this.lblTemperatura.TabIndex = 14;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // txtModbusIP
            // 
            this.txtModbusIP.Location = new System.Drawing.Point(94, 26);
            this.txtModbusIP.Name = "txtModbusIP";
            this.txtModbusIP.Size = new System.Drawing.Size(100, 20);
            this.txtModbusIP.TabIndex = 16;
            this.txtModbusIP.Text = "192.168.1.12";
            // 
            // txtModbusPorta
            // 
            this.txtModbusPorta.Location = new System.Drawing.Point(94, 48);
            this.txtModbusPorta.Name = "txtModbusPorta";
            this.txtModbusPorta.Size = new System.Drawing.Size(100, 20);
            this.txtModbusPorta.TabIndex = 17;
            this.txtModbusPorta.Text = "502";
            // 
            // lblModbusIP
            // 
            this.lblModbusIP.Location = new System.Drawing.Point(7, 30);
            this.lblModbusIP.Name = "lblModbusIP";
            this.lblModbusIP.Size = new System.Drawing.Size(81, 21);
            this.lblModbusIP.TabIndex = 18;
            this.lblModbusIP.Text = "Endereço de IP";
            // 
            // lblModbusPorta
            // 
            this.lblModbusPorta.Location = new System.Drawing.Point(56, 51);
            this.lblModbusPorta.Name = "lblModbusPorta";
            this.lblModbusPorta.Size = new System.Drawing.Size(32, 23);
            this.lblModbusPorta.TabIndex = 19;
            this.lblModbusPorta.Text = "Porta";
            // 
            // btnModbusConectar
            // 
            this.btnModbusConectar.Location = new System.Drawing.Point(30, 74);
            this.btnModbusConectar.Name = "btnModbusConectar";
            this.btnModbusConectar.Size = new System.Drawing.Size(75, 23);
            this.btnModbusConectar.TabIndex = 20;
            this.btnModbusConectar.Text = "Conectar";
            this.btnModbusConectar.UseVisualStyleBackColor = true;
            this.btnModbusConectar.Click += new System.EventHandler(this.btnModbusConectar_Click);
            // 
            // gBoxFonte
            // 
            this.gBoxFonte.Controls.Add(this.groupBox4);
            this.gBoxFonte.Controls.Add(this.groupBox3);
            this.gBoxFonte.Controls.Add(this.groupBox2);
            this.gBoxFonte.Location = new System.Drawing.Point(7, 103);
            this.gBoxFonte.Name = "gBoxFonte";
            this.gBoxFonte.Size = new System.Drawing.Size(253, 181);
            this.gBoxFonte.TabIndex = 21;
            this.gBoxFonte.TabStop = false;
            this.gBoxFonte.Text = "FCAT 10000-60-25";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtWW);
            this.groupBox4.Controls.Add(this.txtUW);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtVW);
            this.groupBox4.Location = new System.Drawing.Point(6, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 46);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Potência Ativa (W)";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(157, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "W";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "U";
            // 
            // txtWW
            // 
            this.txtWW.Location = new System.Drawing.Point(180, 13);
            this.txtWW.Name = "txtWW";
            this.txtWW.Size = new System.Drawing.Size(41, 20);
            this.txtWW.TabIndex = 38;
            // 
            // txtUW
            // 
            this.txtUW.Location = new System.Drawing.Point(40, 13);
            this.txtUW.Name = "txtUW";
            this.txtUW.Size = new System.Drawing.Size(41, 20);
            this.txtUW.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(87, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 19);
            this.label10.TabIndex = 37;
            this.label10.Text = "V";
            // 
            // txtVW
            // 
            this.txtVW.Location = new System.Drawing.Point(110, 13);
            this.txtVW.Name = "txtVW";
            this.txtVW.Size = new System.Drawing.Size(41, 20);
            this.txtVW.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUA);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtVA);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtWA);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 46);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corrente Atual (A)";
            // 
            // txtUA
            // 
            this.txtUA.Location = new System.Drawing.Point(40, 13);
            this.txtUA.Name = "txtUA";
            this.txtUA.Size = new System.Drawing.Size(41, 20);
            this.txtUA.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "U";
            // 
            // txtVA
            // 
            this.txtVA.Location = new System.Drawing.Point(110, 13);
            this.txtVA.Name = "txtVA";
            this.txtVA.Size = new System.Drawing.Size(41, 20);
            this.txtVA.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(87, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "V";
            // 
            // txtWA
            // 
            this.txtWA.Location = new System.Drawing.Point(180, 13);
            this.txtWA.Name = "txtWA";
            this.txtWA.Size = new System.Drawing.Size(41, 20);
            this.txtWA.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(157, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "W";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVV);
            this.groupBox2.Controls.Add(this.txtUV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtWV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 46);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tensão Eficaz (V)";
            // 
            // txtVV
            // 
            this.txtVV.Location = new System.Drawing.Point(110, 19);
            this.txtVV.Name = "txtVV";
            this.txtVV.Size = new System.Drawing.Size(41, 20);
            this.txtVV.TabIndex = 24;
            // 
            // txtUV
            // 
            this.txtUV.Location = new System.Drawing.Point(40, 19);
            this.txtUV.Name = "txtUV";
            this.txtUV.Size = new System.Drawing.Size(41, 20);
            this.txtUV.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "U";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(87, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "V";
            // 
            // txtWV
            // 
            this.txtWV.Location = new System.Drawing.Point(180, 19);
            this.txtWV.Name = "txtWV";
            this.txtWV.Size = new System.Drawing.Size(41, 20);
            this.txtWV.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(157, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "W";
            // 
            // btnDesconectarModbus
            // 
            this.btnDesconectarModbus.Location = new System.Drawing.Point(111, 74);
            this.btnDesconectarModbus.Name = "btnDesconectarModbus";
            this.btnDesconectarModbus.Size = new System.Drawing.Size(83, 23);
            this.btnDesconectarModbus.TabIndex = 22;
            this.btnDesconectarModbus.Text = "Desconectar";
            this.btnDesconectarModbus.UseVisualStyleBackColor = true;
            this.btnDesconectarModbus.Click += new System.EventHandler(this.btnDesconectarModbus_Click_1);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(76, 71);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(64, 20);
            this.txtTemperatura.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Requisições:";
            // 
            // txtBoxRequisicoes
            // 
            this.txtBoxRequisicoes.Location = new System.Drawing.Point(72, 52);
            this.txtBoxRequisicoes.Name = "txtBoxRequisicoes";
            this.txtBoxRequisicoes.Size = new System.Drawing.Size(64, 20);
            this.txtBoxRequisicoes.TabIndex = 25;
            // 
            // txtConstanteTensao
            // 
            this.txtConstanteTensao.Location = new System.Drawing.Point(146, 19);
            this.txtConstanteTensao.Name = "txtConstanteTensao";
            this.txtConstanteTensao.Size = new System.Drawing.Size(18, 20);
            this.txtConstanteTensao.TabIndex = 26;
            this.txtConstanteTensao.Text = "0";
            // 
            // lblConstanteTensao
            // 
            this.lblConstanteTensao.AutoSize = true;
            this.lblConstanteTensao.Location = new System.Drawing.Point(82, 22);
            this.lblConstanteTensao.Name = "lblConstanteTensao";
            this.lblConstanteTensao.Size = new System.Drawing.Size(58, 13);
            this.lblConstanteTensao.TabIndex = 27;
            this.lblConstanteTensao.Text = "Constante:";
            // 
            // btnConfigurarFonte
            // 
            this.btnConfigurarFonte.Location = new System.Drawing.Point(10, 290);
            this.btnConfigurarFonte.Name = "btnConfigurarFonte";
            this.btnConfigurarFonte.Size = new System.Drawing.Size(118, 35);
            this.btnConfigurarFonte.TabIndex = 29;
            this.btnConfigurarFonte.Text = "Configurações\r\nFCAT 100000-60-25";
            this.btnConfigurarFonte.UseVisualStyleBackColor = true;
            this.btnConfigurarFonte.Click += new System.EventHandler(this.AbrirConfiguracoesFonte);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 26);
            this.label12.TabIndex = 31;
            this.label12.Text = "Leitura da \r\nporta serial:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtBoxRequisicoes);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtBoxDados);
            this.groupBox5.Location = new System.Drawing.Point(336, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(194, 80);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Apenas para fins demonstrativos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTemperatura);
            this.groupBox1.Controls.Add(this.rbElevar);
            this.groupBox1.Controls.Add(this.rbRebaixar);
            this.groupBox1.Controls.Add(this.txtTemperatura);
            this.groupBox1.Controls.Add(this.txtConstanteTensao);
            this.groupBox1.Controls.Add(this.lblConstanteTensao);
            this.groupBox1.Location = new System.Drawing.Point(336, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Placa de Instrumentação";
            // 
            // gBoxStatusConexao
            // 
            this.gBoxStatusConexao.Controls.Add(this.radioFonteTensao);
            this.gBoxStatusConexao.Controls.Add(this.lblFonte);
            this.gBoxStatusConexao.Controls.Add(this.lblPlacaInstrumentacao);
            this.gBoxStatusConexao.Controls.Add(this.radioPlacaIntrumentacao);
            this.gBoxStatusConexao.Location = new System.Drawing.Point(7, 360);
            this.gBoxStatusConexao.Name = "gBoxStatusConexao";
            this.gBoxStatusConexao.Size = new System.Drawing.Size(200, 56);
            this.gBoxStatusConexao.TabIndex = 34;
            this.gBoxStatusConexao.TabStop = false;
            this.gBoxStatusConexao.Text = "Status das conexões";
            // 
            // radioFonteTensao
            // 
            this.radioFonteTensao.AutoSize = true;
            this.radioFonteTensao.Location = new System.Drawing.Point(117, 33);
            this.radioFonteTensao.Name = "radioFonteTensao";
            this.radioFonteTensao.Size = new System.Drawing.Size(77, 17);
            this.radioFonteTensao.TabIndex = 35;
            this.radioFonteTensao.TabStop = true;
            this.radioFonteTensao.Text = "Conectado";
            this.radioFonteTensao.UseVisualStyleBackColor = true;
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Location = new System.Drawing.Point(7, 33);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(113, 13);
            this.lblFonte.TabIndex = 1;
            this.lblFonte.Text = "Comunicação Modbus";
            // 
            // lblPlacaInstrumentacao
            // 
            this.lblPlacaInstrumentacao.AutoSize = true;
            this.lblPlacaInstrumentacao.Location = new System.Drawing.Point(7, 16);
            this.lblPlacaInstrumentacao.Name = "lblPlacaInstrumentacao";
            this.lblPlacaInstrumentacao.Size = new System.Drawing.Size(101, 13);
            this.lblPlacaInstrumentacao.TabIndex = 0;
            this.lblPlacaInstrumentacao.Text = "Comunicação Serial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 444);
            this.Controls.Add(this.gBoxStatusConexao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnConfigurarFonte);
            this.Controls.Add(this.btnDesconectarModbus);
            this.Controls.Add(this.gBoxFonte);
            this.Controls.Add(this.btnModbusConectar);
            this.Controls.Add(this.lblModbusPorta);
            this.Controls.Add(this.lblModbusIP);
            this.Controls.Add(this.txtModbusPorta);
            this.Controls.Add(this.txtModbusIP);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.btnConectaArduino);
            this.Controls.Add(this.btnAtualizaArduino);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cBoxPortas);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.gBoxFonte.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxStatusConexao.ResumeLayout(false);
            this.gBoxStatusConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtConstanteTensao;
        private System.Windows.Forms.Label lblConstanteTensao;

        private System.Windows.Forms.TextBox txtTemperatura;

        private System.Windows.Forms.Button btnDesconectarModbus;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtUV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUW;

        private System.Windows.Forms.GroupBox gBoxFonte;

        private System.Windows.Forms.Button btnModbusConectar;

        private System.Windows.Forms.TextBox txtModbusIP;
        private System.Windows.Forms.TextBox txtModbusPorta;
        private System.Windows.Forms.Label lblModbusIP;
        private System.Windows.Forms.Label lblModbusPorta;

        private System.Windows.Forms.Button btnDesconectar;

        private System.Windows.Forms.RadioButton radioPlacaIntrumentacao;

        private System.Windows.Forms.Label lblTemperatura;

        private System.Windows.Forms.Button btnConfigurar;

        #endregion

        private System.Windows.Forms.ComboBox cBoxPortas;
        private System.Windows.Forms.Label lblPortas;
        private System.Windows.Forms.Button btnAtualizaArduino;
        private System.Windows.Forms.Button btnConectaArduino;
        private System.Windows.Forms.TextBox txtBoxDados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbElevar;
        private System.Windows.Forms.RadioButton rbRebaixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRequisicoes;
        private System.Windows.Forms.Button btnConfigurarFonte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBoxStatusConexao;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblPlacaInstrumentacao;
        private System.Windows.Forms.RadioButton radioFonteTensao;
    }
}

