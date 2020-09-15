using compilador2020.Lexico.estructuraDatos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador2020
{
    class cargarArchivos
    {
        string lexico = Path.GetFullPath("../../Archivos/Lexico");

        public List<AFD> automata()
        {
            string path = lexico + "\\AFD.json";
            List<AFD> listaTokens = new List<AFD>();
            string archivo = File.ReadAllText(path);
            listaTokens = JsonConvert.DeserializeObject<List<AFD>>(archivo);
            return listaTokens;
        }

        public List<tokens> cargarTokens()
        {
            string path = lexico + "\\Alfabeto.json";
            List<tokens> listaTokens = new List<tokens>();
            string archivo = File.ReadAllText(path);
            listaTokens = JsonConvert.DeserializeObject<List<tokens>>(archivo);
            return listaTokens;
        }
    }
}
