using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador2020.Lexico.estructuraDatos
{
    class movimientos
    {
        private char leyendo;
        private int estadoInicial, estadoFinal;

        public int EstadoInicial { get => estadoInicial; set => estadoInicial = value; }
        public char Leyendo { get => leyendo; set => leyendo = value; }
        public int EstadoFinal { get => estadoFinal; set => estadoFinal = value; }
    }
}
