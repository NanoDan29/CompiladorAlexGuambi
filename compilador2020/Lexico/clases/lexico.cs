using compilador2020.Lexico.estructuraDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace compilador2020.Lexico.clases
{
    class lexico
    {
        cargarArchivos misArchivos = new cargarArchivos();

        cargarArchivos cargar = new cargarArchivos();


        public string[,] movimientos(string cadena)
        {
            Console.WriteLine(cadena);
            string[] simbolos = { "\"", "+", "-", "*", "/", "&", "|", "(", ")", ",", ";", ".", "[", "]", "!", "#", "$", "%", "<", ">", "_", "=", ":", "?", "\\" };
            string[] mayusculas = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] minusculas = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] digitos = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //Cortamos para ver de la cadena de uno en uno
            char[] cortar = cadena.ToCharArray();
            string[] cadenaCortar = new string[cortar.Length];

            for (int i = 0; i < cadenaCortar.Length; i++)
            {
                cadenaCortar[i] = Convert.ToString(cortar[i]);
            }

            //Cargamos el archivo para poder reconocer cada una de las letras ingresadas
            List<AFD> automata = cargar.automata();
            AFD mi = new AFD()
            {
                Estado = 2,
                Lee = "a",
                NEstado = 2
            };
            int inicio = 0;

            int indice;
                
          

            for (int i = 0; i < cadenaCortar.Length; i++)
            {


                foreach (var item in automata)
                {
                    if (item.Estado == inicio)
                    {
                        if (item.Lee.Equals(cadenaCortar[i]))
                        {
                            Console.WriteLine(i + " leyendo " + item.Lee + " va " + item.NEstado);
                            inicio = item.NEstado;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(inicio + " leyendo " + cadenaCortar[0] + " va " + 999);
                        inicio = 0;
                        break;
                    }


                }
            }  
            
            return null;

        }


        public string FormaterTexto(string cadena)
        {

            //Cortamos todas las tabulaciones 
            string cadenaTransformada = "";
            string[] vectorCadena = cadena.Split('\t');

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + " ";
                }
            }
            //Console.WriteLine("Cadena sin saltos tabulaciones : " + cadenaTransformada);

            //Cortamos todos los altos de linea
            vectorCadena = cadenaTransformada.Split('\n');
            cadenaTransformada = "";
            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + " ";
                }
            }
            //Console.WriteLine("Cadena sin saltos de linea: " + cadenaTransformada);

            //Cortamos los espacios y agregamos $
            vectorCadena = cadenaTransformada.Split(' ');
            cadenaTransformada = "";

            for (int i = 0; i < vectorCadena.Length; i++)
            {
                if (vectorCadena[i] != "")
                {
                    cadenaTransformada += vectorCadena[i] + "#";
                }

            }
            //Console.WriteLine("Cadena si: " + cadenaTransformada);

            return cadenaTransformada;
        }
    }

}
