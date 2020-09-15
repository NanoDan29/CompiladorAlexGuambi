using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador2020.Lexico.estructuraDatos
{
    class AFD
    {
        private int fila;
        private int estado, nEstado;
        private String lee;

        public int Fila { get => fila; set => fila = value; }
        public int Estado { get => estado; set => estado = value; }
        public int NEstado { get => nEstado; set => nEstado = value; }
        public string Lee { get => lee; set => lee = value; }
    }
}