using compilador2020.Lexico.estructuraDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace compilador2020.Lexico.clases
{
    class lexico
    {

        public List<AFD> ListAFD;
        public List<tokens> Alfabeto;
        public List<TablaSimbolos> listTDS;
        public List<tokens> lista_tks_reconocidos;
        public List<movimientos> listaMovimientos;
        string texto_file_name;

        public lexico()
        {
            // Cargar los archivos AFD.xml
            ListAFD = cargarArchivos.automata();
            // cargar el archivo Alfabeto.xml
            Alfabeto = cargarArchivos.cargarTokens();
            // Declarar los tipos de tabla de simbolos
            listTDS = new List<TablaSimbolos>();
            // Declara la lista de tokens reconocidos

            // Aperturar el archivo fuente de entrada
            Cargar_Archivo_Fuente();

            // Proceso de Ir reconociendo los tokens

        }

        // Función que carga el archivo fuente a compilar
        public void Cargar_Archivo_Fuente()
        {
            string ruta_file = Path.GetFullPath("../../Archivos/Lexico");
            // pedir el nombre de archivo a compilar
            string texto_archivo_fuente = codigoFuente(ruta_file);

            // subir a una estructura para ir leyendo caracter x caracter
            texto_file_name = texto_archivo_fuente;

        }
        static string codigoFuente(string ruta)

        {
            string path = ruta + "\\ejemplo.cs";
            string texto_archivo = File.ReadAllText(path);

            return texto_archivo;
        }



        public void Reconocedor_Lexico()
        {
            listaMovimientos = new List<movimientos>();
            lista_tks_reconocidos = new List<tokens>();

            int estado = 0, newestado = 0, nidentificador = 0;
            char simbolo;
            string lexema = null;

            char[] palabras = DarFormatoTextoLexico(texto_file_name).Replace(' ', '#').ToCharArray();

            int cuenta_simbolos = texto_file_name.Length;
            tokens tk = new tokens();
            int j = 0;

            movimientos move;

            while (j < palabras.Length)
            {
                simbolo = Convert.ToChar(palabras[j]);

                newestado = movimiento_AFD(estado, simbolo);

                move = new movimientos()
                {
                    EstadoInicial = estado,
                    Leyendo = simbolo,
                    EstadoFinal = newestado
                };

                listaMovimientos.Add(move);

                if (newestado == 999)
                {
                    move = new movimientos()
                    {
                        EstadoInicial = estado,
                        Leyendo = simbolo,
                        EstadoFinal = newestado
                    };

                    listaMovimientos.Add(move);


                    estado = 0;
                    j++;

                }
                else if (newestado < 0)
                {
                    newestado = -newestado;
                    tk.NumToken = newestado;
                    tk = BuscarToken(newestado);
                    tk.Lexema = lexema;



                    lista_tks_reconocidos.Add(tk);

                    if (tk.NumToken == 1)
                    {
                        TablaSimbolos identificador = new TablaSimbolos();
                        identificador.Nombre = lexema;
                        identificador.Numero = nidentificador++;
                        listTDS.Add(identificador);
                    }
                    estado = 0;
                    lexema = "";
                }
                else
                {
                    lexema += simbolo;
                    estado = newestado;

                }

                j++;

            }

        }

        public int movimiento_AFD(int estado, char simbolo)
        {
            int caso = 0;
            if (char.IsLetter(simbolo))
            {
                //es una letra
                caso = 2;
                if (char.IsUpper(simbolo))
                {
                    //es una mayuscula
                    caso = 1;
                }
            }
            else if (char.IsDigit(simbolo))
            {
                //es un digitp 
                caso = 3;
            }
            else
            {
                //validar que el simbolo exista en nuestro alfabeto
                //es otro caracter
                caso = 4;
            }

            foreach (AFD transicion in ListAFD)
            {
                if (transicion.Estado == estado)
                {
                    if ((transicion.Lee.Equals("letra") && caso == 2) ||
                       (transicion.Lee.Equals("mayuscula") && caso == 1) ||
                       (transicion.Lee.Equals("digito") && caso == 3) ||
                       (transicion.Lee.Equals("simbolo") && caso == 4))
                    {

                        return transicion.NEstado;
                    }
                    String letra = simbolo.ToString();
                    if (transicion.Lee.Equals(letra))
                    {
                        return transicion.NEstado;
                    }
                }
            }
            return 999;
        }

        public tokens BuscarToken(int nrtk)
        {
            tokens tk1 = new tokens();
            foreach (tokens item in Alfabeto)
            {
                if (item.NumToken == nrtk)
                {
                    tk1 = item;
                }
            }
            return tk1;
        }

        public string DarFormatoTextoLexico(string cadena)
        {

           
            string[] vectorCadena = cadena.Split('\t');
            string cadenaTransformada = "";
          

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + " ";
                }
            }
          

            vectorCadena = cadenaTransformada.Split('\n');
            cadenaTransformada = "";
            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + " ";
                }
            }
        
            vectorCadena = cadenaTransformada.Split(' ');
            cadenaTransformada = "";

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + "#";
                }

            }

            return cadenaTransformada;
        }

    }

}
