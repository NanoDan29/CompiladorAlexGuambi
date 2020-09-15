using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using compilador2020.Lexico.estructuraDatos;
using compilador2020.Lexico.clases;
using System.IO;

namespace compilador2020.Lexico.vistas
{
    public partial class winLexico : UserControl
    {
        cargarArchivos misArchivos = new cargarArchivos();
        lexico milexico = new lexico();
        List<AFD> lista;
        public winLexico()
        {
            InitializeComponent();
            AgregarIndice();
            tblAFD.DataSource = lista;
            tblAlfabeto.DataSource = misArchivos.cargarTokens();
            
        }

      

        private void cargarMatriz_Click(object sender, EventArgs e)
        {

          

        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar en un txt pasar a una funcion¡¡¡¡¡
            String lexico = Path.GetFullPath("../../Archivos/Lexico");
            string cadenaTxt = txtlexico.Text;
            string path = lexico + "\\archivo.txt";

            //Si el archivo existe entonces solo guardamos la cadena
            if (File.Exists(path))
            {
                using (StreamWriter guardarArchivo = File.CreateText(path))
                { guardarArchivo.Write(cadenaTxt); };

            }

            //Si el archivo no existe entonces creamos el archivo
            else
            {
                //Creamos el archivo
                StreamWriter crearArchvio = new StreamWriter(path);

                //Guardar archivo
                using (StreamWriter guardarArchivo = File.CreateText(path))
                { guardarArchivo.Write(cadenaTxt); };
            }
            //

            //Formateamos la entrada de texto para poder 
            //traducir a una cadena que entienda nuestro texto
            string cadenaTransformada = milexico.FormaterTexto(cadenaTxt);
            
            milexico.movimientos(cadenaTransformada);

           
       
        }

        public void AgregarIndice() {
            lista=  misArchivos.automata();
            for (int i=0; i < lista.Count; i++)
            {
                lista[i].Fila=i;
            }
        }
    }
}
