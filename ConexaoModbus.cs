using System;
using System.Collections.Generic;
using System.Linq;
using NModbus;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCCFinal
{
    public class ConexaoModbus
    {
        public TcpClient _clienteModbus = new TcpClient();
        public ModbusFactory _factory = new ModbusFactory();

        public ConexaoModbus()
        {
            _clienteModbus = new TcpClient();
        }

        public void ConectaModbus(string _ip, int _port)
        {
            _clienteModbus = new TcpClient();
            _clienteModbus.Connect(_ip, _port);
        }

        public void DesconectaModbus()
        {
            _clienteModbus.GetStream().Close();
            _clienteModbus.Close();
        }
        public bool TestaConexaoModbus()
        {
            bool condicaoConexao;
            if (_clienteModbus.Connected)
            {
                condicaoConexao = true;
            }
            else
            {
                condicaoConexao = false;
            }
            return condicaoConexao;
        }

        public void EscritaModbus(ushort dado)
        {
            IModbusMaster mestre = _factory.CreateMaster(_clienteModbus);
            byte prim = 1;
            ushort sec = 0;
            ushort[] array_dado = { dado };
            mestre.WriteMultipleRegisters(prim, sec, array_dado);
        }

        public ushort[] LeituraModbus()
        {
            IModbusMaster mestre = _factory.CreateMaster(_clienteModbus);
            byte prim = 1;
            ushort sec = 1;
            ushort terc = 11;
            ushort[] medidas = mestre.ReadHoldingRegisters(prim, sec, terc);
            return medidas;
        }
    }
}
