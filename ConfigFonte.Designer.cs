namespace TCCFinal
{
    partial class ConfigFonte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDesconectarModbus = new System.Windows.Forms.Button();
            this.btnModbusConectar = new System.Windows.Forms.Button();
            this.lblModbusPorta = new System.Windows.Forms.Label();
            this.lblModbusIP = new System.Windows.Forms.Label();
            this.txtModbusPorta = new System.Windows.Forms.TextBox();
            this.txtModbusIP = new System.Windows.Forms.TextBox();
            this.radioConexao = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDesconectarModbus
            // 
            this.btnDesconectarModbus.Location = new System.Drawing.Point(113, 53);
            this.btnDesconectarModbus.Name = "btnDesconectarModbus";
            this.btnDesconectarModbus.Size = new System.Drawing.Size(83, 23);
            this.btnDesconectarModbus.TabIndex = 28;
            this.btnDesconectarModbus.Text = "Desconectar";
            this.btnDesconectarModbus.UseVisualStyleBackColor = true;
            this.btnDesconectarModbus.Click += new System.EventHandler(this.btnDesconectarModbus_Click);
            // 
            // btnModbusConectar
            // 
            this.btnModbusConectar.Location = new System.Drawing.Point(15, 53);
            this.btnModbusConectar.Name = "btnModbusConectar";
            this.btnModbusConectar.Size = new System.Drawing.Size(92, 23);
            this.btnModbusConectar.TabIndex = 27;
            this.btnModbusConectar.Text = "Testar Conexao";
            this.btnModbusConectar.UseVisualStyleBackColor = true;
            this.btnModbusConectar.Click += new System.EventHandler(this.btnModbusConectar_Click);
            // 
            // lblModbusPorta
            // 
            this.lblModbusPorta.Location = new System.Drawing.Point(58, 30);
            this.lblModbusPorta.Name = "lblModbusPorta";
            this.lblModbusPorta.Size = new System.Drawing.Size(32, 23);
            this.lblModbusPorta.TabIndex = 26;
            this.lblModbusPorta.Text = "Porta";
            // 
            // lblModbusIP
            // 
            this.lblModbusIP.Location = new System.Drawing.Point(9, 9);
            this.lblModbusIP.Name = "lblModbusIP";
            this.lblModbusIP.Size = new System.Drawing.Size(81, 21);
            this.lblModbusIP.TabIndex = 25;
            this.lblModbusIP.Text = "Endereço de IP";
            // 
            // txtModbusPorta
            // 
            this.txtModbusPorta.Location = new System.Drawing.Point(96, 27);
            this.txtModbusPorta.Name = "txtModbusPorta";
            this.txtModbusPorta.Size = new System.Drawing.Size(100, 20);
            this.txtModbusPorta.TabIndex = 24;
            this.txtModbusPorta.Text = "502";
            // 
            // txtModbusIP
            // 
            this.txtModbusIP.Location = new System.Drawing.Point(96, 6);
            this.txtModbusIP.Name = "txtModbusIP";
            this.txtModbusIP.Size = new System.Drawing.Size(100, 20);
            this.txtModbusIP.TabIndex = 23;
            this.txtModbusIP.Text = "192.168.1.12";
            // 
            // radioConexao
            // 
            this.radioConexao.AutoSize = true;
            this.radioConexao.Location = new System.Drawing.Point(15, 82);
            this.radioConexao.Name = "radioConexao";
            this.radioConexao.Size = new System.Drawing.Size(85, 17);
            this.radioConexao.TabIndex = 29;
            this.radioConexao.TabStop = true;
            this.radioConexao.Text = "Conexão OK";
            this.radioConexao.UseVisualStyleBackColor = true;
            // 
            // ConfigFonte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 197);
            this.Controls.Add(this.radioConexao);
            this.Controls.Add(this.btnDesconectarModbus);
            this.Controls.Add(this.btnModbusConectar);
            this.Controls.Add(this.lblModbusPorta);
            this.Controls.Add(this.lblModbusIP);
            this.Controls.Add(this.txtModbusPorta);
            this.Controls.Add(this.txtModbusIP);
            this.Name = "ConfigFonte";
            this.Text = "ConfigFonte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FechaFormulario);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesconectarModbus;
        private System.Windows.Forms.Button btnModbusConectar;
        private System.Windows.Forms.Label lblModbusPorta;
        private System.Windows.Forms.Label lblModbusIP;
        private System.Windows.Forms.TextBox txtModbusPorta;
        private System.Windows.Forms.TextBox txtModbusIP;
        private System.Windows.Forms.RadioButton radioConexao;
    }
}