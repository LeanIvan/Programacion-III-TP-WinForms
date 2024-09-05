namespace Vista
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.Numeric_Max = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Min = new System.Windows.Forms.NumericUpDown();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.ListBox_Marcas = new System.Windows.Forms.ListBox();
            this.ListBox_Categorias = new System.Windows.Forms.ListBox();
            this.txtBox_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Marcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Min)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // GroupBox_Filtro
            // 
            this.GroupBox_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox_Filtro.Controls.Add(this.lbl_Marcas);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Categoria);
            this.GroupBox_Filtro.Controls.Add(this.Numeric_Max);
            this.GroupBox_Filtro.Controls.Add(this.Numeric_Min);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Max);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Min);
            this.GroupBox_Filtro.Controls.Add(this.ListBox_Marcas);
            this.GroupBox_Filtro.Controls.Add(this.ListBox_Categorias);
            this.GroupBox_Filtro.Location = new System.Drawing.Point(12, 39);
            this.GroupBox_Filtro.Name = "GroupBox_Filtro";
            this.GroupBox_Filtro.Size = new System.Drawing.Size(157, 399);
            this.GroupBox_Filtro.TabIndex = 1;
            this.GroupBox_Filtro.TabStop = false;
            this.GroupBox_Filtro.Text = "Filtros";
            // 
            // Numeric_Max
            // 
            this.Numeric_Max.Location = new System.Drawing.Point(11, 280);
            this.Numeric_Max.Name = "Numeric_Max";
            this.Numeric_Max.Size = new System.Drawing.Size(69, 20);
            this.Numeric_Max.TabIndex = 5;
            // 
            // Numeric_Min
            // 
            this.Numeric_Min.Location = new System.Drawing.Point(11, 209);
            this.Numeric_Min.Name = "Numeric_Min";
            this.Numeric_Min.Size = new System.Drawing.Size(69, 20);
            this.Numeric_Min.TabIndex = 4;
            // 
            // lbl_Max
            // 
            this.lbl_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(8, 250);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(33, 13);
            this.lbl_Max.TabIndex = 3;
            this.lbl_Max.Text = "MAX-";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(8, 184);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(30, 13);
            this.lbl_Min.TabIndex = 2;
            this.lbl_Min.Text = "MIN-";
            // 
            // ListBox_Marcas
            // 
            this.ListBox_Marcas.FormattingEnabled = true;
            this.ListBox_Marcas.Location = new System.Drawing.Point(7, 112);
            this.ListBox_Marcas.Name = "ListBox_Marcas";
            this.ListBox_Marcas.Size = new System.Drawing.Size(111, 17);
            this.ListBox_Marcas.TabIndex = 1;
            // 
            // ListBox_Categorias
            // 
            this.ListBox_Categorias.FormattingEnabled = true;
            this.ListBox_Categorias.Location = new System.Drawing.Point(6, 57);
            this.ListBox_Categorias.Name = "ListBox_Categorias";
            this.ListBox_Categorias.Size = new System.Drawing.Size(111, 17);
            this.ListBox_Categorias.TabIndex = 0;
            // 
            // txtBox_Buscar
            // 
            this.txtBox_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Buscar.Location = new System.Drawing.Point(244, 12);
            this.txtBox_Buscar.Name = "txtBox_Buscar";
            this.txtBox_Buscar.Size = new System.Drawing.Size(375, 20);
            this.txtBox_Buscar.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.Location = new System.Drawing.Point(625, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(163, 23);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoríaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.productoToolStripMenuItem.Text = "Articulo";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuToolStripMenuItem,
            this.marcaToolStripMenuItem1,
            this.categoriaToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar ";
            // 
            // articuToolStripMenuItem
            // 
            this.articuToolStripMenuItem.Name = "articuToolStripMenuItem";
            this.articuToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.articuToolStripMenuItem.Text = "Articulo";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(8, 41);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(76, 13);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "CATEGORIAS";
            // 
            // lbl_Marcas
            // 
            this.lbl_Marcas.AutoSize = true;
            this.lbl_Marcas.Location = new System.Drawing.Point(8, 96);
            this.lbl_Marcas.Name = "lbl_Marcas";
            this.lbl_Marcas.Size = new System.Drawing.Size(52, 13);
            this.lbl_Marcas.TabIndex = 8;
            this.lbl_Marcas.Text = "MARCAS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txtBox_Buscar);
            this.Controls.Add(this.GroupBox_Filtro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox_Filtro.ResumeLayout(false);
            this.GroupBox_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Min)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GroupBox_Filtro;
        private System.Windows.Forms.TextBox txtBox_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBox_Marcas;
        private System.Windows.Forms.ListBox ListBox_Categorias;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.NumericUpDown Numeric_Max;
        private System.Windows.Forms.NumericUpDown Numeric_Min;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Marcas;
        private System.Windows.Forms.Label lbl_Categoria;
    }
}

