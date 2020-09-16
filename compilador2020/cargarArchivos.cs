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
    public class cargarArchivos
    {
       

        public static List<tokens> cargarTokens()
        {
            string lexico = Path.GetFullPath("../../Archivos/Lexico");
            string path = lexico + "\\Alfabeto.json";
            List<tokens> listaTokens = new List<tokens>();
            string archivo = File.ReadAllText(path);
            listaTokens = JsonConvert.DeserializeObject<List<tokens>>(archivo);
            return listaTokens;
        }

        public static List<AFD> automata()
        {
            string lexico = Path.GetFullPath("../../Archivos/Lexico");
            string path = lexico + "\\AFD.json";
            List<AFD> listaTokens = new List<AFD>();
            string archivo = File.ReadAllText(path);
            listaTokens = JsonConvert.DeserializeObject<List<AFD>>(archivo);
            return listaTokens;
        }

     
    }
}
