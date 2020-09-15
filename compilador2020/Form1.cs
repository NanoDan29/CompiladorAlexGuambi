using compilador2020.Lexico.clases;
using compilador2020.Lexico.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador2020
{
    public partial class Form1 : Form
    {
        winLexico winlexico;
       
        public Form1()
        {
            InitializeComponent();
            winlexico = new winLexico();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            principal.Controls.Clear();
            principal.Controls.Add(winlexico);
            winlexico.BringToFront();

        }
    }
}
