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
       
        List<AFD> lista;

        lexico reconocerLexico = new lexico();

        public winLexico()
        {
            InitializeComponent();
          
            tblAutomata.DataSource = reconocerLexico.ListAFD;
            tblAlfabeto.DataSource = reconocerLexico.Alfabeto;
            reconocerLexico.Reconocedor_Lexico();
            tblMovimientos.DataSource = reconocerLexico.listaMovimientos;



        }

     

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
       
        }

        public void AgregarIndice() {
          
        }
    }
}
