using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCFinal
{
    public partial class ConfigSerial : Form
    {
        public string SerialBaudrate2 { get; set; }
        public string SerialBitsDados2 { get; set; }
        public string SerialParidade2 { get; set; }
        public string SerialBitsParada2 { get; set; }
        public ConfigSerial()
        {
            InitializeComponent();
        }

        private void btnInfoSerial_Click(object sender, EventArgs e)
        {
            CarregaConfiguracaoSerial();
        }


        private void ConfigSerial_Load(object sender, EventArgs e)
        {
            CarregaConfiguracaoSerial();
        }

        private void CarregaConfiguracaoSerial()
        {
            configBaudRate.Text = SerialBaudrate2;
            configBitDados.Text = SerialBitsDados2;
            configParidade.Text = SerialParidade2;
            configBitsParada.Text = SerialBitsParada2;
        }
    }
}
