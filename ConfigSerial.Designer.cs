using System.ComponentModel;

namespace TCCFinal
{
    partial class ConfigSerial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.configBaudRate = new System.Windows.Forms.TextBox();
            this.configBitDados = new System.Windows.Forms.TextBox();
            this.configParidade = new System.Windows.Forms.TextBox();
            this.configBitsParada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfoSerial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configBaudRate
            // 
            this.configBaudRate.Location = new System.Drawing.Point(92, 19);
            this.configBaudRate.Name = "configBaudRate";
            this.configBaudRate.Size = new System.Drawing.Size(46, 20);
            this.configBaudRate.TabIndex = 0;
            // 
            // configBitDados
            // 
            this.configBitDados.Location = new System.Drawing.Point(92, 45);
            this.configBitDados.Name = "configBitDados";
            this.configBitDados.Size = new System.Drawing.Size(46, 20);
            this.configBitDados.TabIndex = 1;
            // 
            // configParidade
            // 
            this.configParidade.Location = new System.Drawing.Point(92, 71);
            this.configParidade.Name = "configParidade";
            this.configParidade.Size = new System.Drawing.Size(46, 20);
            this.configParidade.TabIndex = 2;
            // 
            // configBitsParada
            // 
            this.configBitsParada.Location = new System.Drawing.Point(92, 97);
            this.configBitsParada.Name = "configBitsParada";
            this.configBitsParada.Size = new System.Drawing.Size(46, 20);
            this.configBitsParada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bits de dados";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bits de parada";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paridade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInfoSerial);
            this.groupBox1.Controls.Add(this.configBitsParada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.configBaudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.configBitDados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.configParidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gBoxSerial";
            // 
            // btnInfoSerial
            // 
            this.btnInfoSerial.Location = new System.Drawing.Point(58, 120);
            this.btnInfoSerial.Name = "btnInfoSerial";
            this.btnInfoSerial.Size = new System.Drawing.Size(80, 36);
            this.btnInfoSerial.TabIndex = 9;
            this.btnInfoSerial.Text = "Carregar informações";
            this.btnInfoSerial.UseVisualStyleBackColor = true;
            this.btnInfoSerial.Click += new System.EventHandler(this.btnInfoSerial_Click);
            // 
            // ConfigSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(170, 197);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigSerial";
            this.Text = "Configuração da porta serial";
            this.Load += new System.EventHandler(this.ConfigSerial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInfoSerial;

        private System.Windows.Forms.TextBox configBaudRate;
        private System.Windows.Forms.TextBox configBitDados;
        private System.Windows.Forms.TextBox configParidade;
        private System.Windows.Forms.TextBox configBitsParada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}