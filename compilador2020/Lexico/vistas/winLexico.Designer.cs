namespace compilador2020.Lexico.vistas
{
    partial class winLexico
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblAFD = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tblAlfabeto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tblMovimientos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtlexico = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dGTR = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAFD)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGTR)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 544);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblAFD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AFD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblAFD
            // 
            this.tblAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAFD.Location = new System.Drawing.Point(6, 6);
            this.tblAFD.Name = "tblAFD";
            this.tblAFD.Size = new System.Drawing.Size(766, 506);
            this.tblAFD.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tblAlfabeto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(778, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alfabeto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tblAlfabeto
            // 
            this.tblAlfabeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAlfabeto.Location = new System.Drawing.Point(3, 3);
            this.tblAlfabeto.Name = "tblAlfabeto";
            this.tblAlfabeto.Size = new System.Drawing.Size(772, 512);
            this.tblAlfabeto.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tblMovimientos);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.txtlexico);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(778, 518);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movimientos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tblMovimientos
            // 
            this.tblMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMovimientos.Location = new System.Drawing.Point(373, 3);
            this.tblMovimientos.Name = "tblMovimientos";
            this.tblMovimientos.Size = new System.Drawing.Size(402, 506);
            this.tblMovimientos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Leer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlexico
            // 
            this.txtlexico.Location = new System.Drawing.Point(3, 3);
            this.txtlexico.Name = "txtlexico";
            this.txtlexico.Size = new System.Drawing.Size(364, 444);
            this.txtlexico.TabIndex = 0;
            this.txtlexico.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dGTR);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(778, 518);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tokens Reconocidos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dGTR
            // 
            this.dGTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGTR.Location = new System.Drawing.Point(3, 3);
            this.dGTR.Name = "dGTR";
            this.dGTR.Size = new System.Drawing.Size(772, 512);
            this.dGTR.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // winLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "winLexico";
            this.Size = new System.Drawing.Size(792, 550);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAFD)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblAlfabeto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimientos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGTR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView tblAFD;
        private System.Windows.Forms.DataGridView tblAlfabeto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtlexico;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView tblMovimientos;
        private System.Windows.Forms.DataGridView dGTR;
    }
}
