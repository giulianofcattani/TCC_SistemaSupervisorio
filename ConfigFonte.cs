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
    public partial class ConfigFonte : Form
    {
        public string modbusIP { get; set; }
        public string modbusPorta { get; set; }

        public ConexaoModbus cModbus = new ConexaoModbus();
        public ConfigFonte()
        {
            InitializeComponent();
        }

        private void btnModbusConectar_Click(object sender, EventArgs e)
        {
            string modbusIP = txtModbusIP.Text;
            int modbusPorta = int.Parse(txtModbusPorta.Text);
            cModbus.ConectaModbus(modbusIP, modbusPorta);
            if (cModbus.TestaConexaoModbus())
            {
                radioConexao.Checked = true;
            }
            else
            {
                radioConexao.Checked = false;
            }
        }

        private void FechaFormulario(object sender, FormClosedEventArgs e)
        {
            cModbus.DesconectaModbus();
            radioConexao.Checked = false;
        }

        private void btnDesconectarModbus_Click(object sender, EventArgs e)
        {
            cModbus.DesconectaModbus();
            radioConexao.Checked = false;
        }
    }
}
