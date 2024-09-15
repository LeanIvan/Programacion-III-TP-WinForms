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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.GroupBox_Filtro = new System.Windows.Forms.GroupBox();
            this.RB_Desactivarfiltros = new System.Windows.Forms.RadioButton();
            this.RB_ActivarFiltros = new System.Windows.Forms.RadioButton();
            this.comboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.lbl_Marcas = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.Numeric_Max = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Min = new System.Windows.Forms.NumericUpDown();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.txtBox_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.GroupBox_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Min)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.ColumnHeadersHeight = 27;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvList.Location = new System.Drawing.Point(244, 39);
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.Size = new System.Drawing.Size(677, 473);
            this.dgvList.TabIndex = 3;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // GroupBox_Filtro
            // 
            this.GroupBox_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox_Filtro.Controls.Add(this.RB_Desactivarfiltros);
            this.GroupBox_Filtro.Controls.Add(this.RB_ActivarFiltros);
            this.GroupBox_Filtro.Controls.Add(this.comboBoxMarcas);
            this.GroupBox_Filtro.Controls.Add(this.comboBoxCategorias);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Marcas);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Categoria);
            this.GroupBox_Filtro.Controls.Add(this.Numeric_Max);
            this.GroupBox_Filtro.Controls.Add(this.Numeric_Min);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Max);
            this.GroupBox_Filtro.Controls.Add(this.lbl_Min);
            this.GroupBox_Filtro.Location = new System.Drawing.Point(12, 39);
            this.GroupBox_Filtro.Name = "GroupBox_Filtro";
            this.GroupBox_Filtro.Size = new System.Drawing.Size(137, 438);
            this.GroupBox_Filtro.TabIndex = 1;
            this.GroupBox_Filtro.TabStop = false;
            this.GroupBox_Filtro.Text = "Filtros";
            // 
            // RB_Desactivarfiltros
            // 
            this.RB_Desactivarfiltros.AutoSize = true;
            this.RB_Desactivarfiltros.Checked = true;
            this.RB_Desactivarfiltros.Location = new System.Drawing.Point(55, 33);
            this.RB_Desactivarfiltros.Name = "RB_Desactivarfiltros";
            this.RB_Desactivarfiltros.Size = new System.Drawing.Size(76, 17);
            this.RB_Desactivarfiltros.TabIndex = 1;
            this.RB_Desactivarfiltros.TabStop = true;
            this.RB_Desactivarfiltros.Text = "Desactivar";
            this.RB_Desactivarfiltros.UseVisualStyleBackColor = true;
            // 
            // RB_ActivarFiltros
            // 
            this.RB_ActivarFiltros.AutoSize = true;
            this.RB_ActivarFiltros.Location = new System.Drawing.Point(55, 10);
            this.RB_ActivarFiltros.Name = "RB_ActivarFiltros";
            this.RB_ActivarFiltros.Size = new System.Drawing.Size(61, 17);
            this.RB_ActivarFiltros.TabIndex = 0;
            this.RB_ActivarFiltros.Text = "Activar ";
            this.RB_ActivarFiltros.UseVisualStyleBackColor = true;
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Location = new System.Drawing.Point(6, 178);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarcas.TabIndex = 3;
            this.comboBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarcas_SelectedIndexChanged);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(6, 114);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorias.TabIndex = 2;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorias_SelectedIndexChanged);
            // 
            // lbl_Marcas
            // 
            this.lbl_Marcas.AutoSize = true;
            this.lbl_Marcas.Location = new System.Drawing.Point(6, 152);
            this.lbl_Marcas.Name = "lbl_Marcas";
            this.lbl_Marcas.Size = new System.Drawing.Size(52, 13);
            this.lbl_Marcas.TabIndex = 8;
            this.lbl_Marcas.Text = "MARCAS";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(6, 89);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(76, 13);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "CATEGORIAS";
            // 
            // Numeric_Max
            // 
            this.Numeric_Max.Location = new System.Drawing.Point(6, 396);
            this.Numeric_Max.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Numeric_Max.Name = "Numeric_Max";
            this.Numeric_Max.Size = new System.Drawing.Size(69, 20);
            this.Numeric_Max.TabIndex = 5;
            this.Numeric_Max.ThousandsSeparator = true;
            // 
            // Numeric_Min
            // 
            this.Numeric_Min.Location = new System.Drawing.Point(9, 299);
            this.Numeric_Min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Numeric_Min.Name = "Numeric_Min";
            this.Numeric_Min.Size = new System.Drawing.Size(69, 20);
            this.Numeric_Min.TabIndex = 4;
            this.Numeric_Min.ThousandsSeparator = true;
            // 
            // lbl_Max
            // 
            this.lbl_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(6, 369);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(33, 13);
            this.lbl_Max.TabIndex = 3;
            this.lbl_Max.Text = "MAX-";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(9, 269);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(30, 13);
            this.lbl_Min.TabIndex = 2;
            this.lbl_Min.Text = "MIN-";
            // 
            // txtBox_Buscar
            // 
            this.txtBox_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Buscar.Location = new System.Drawing.Point(244, 12);
            this.txtBox_Buscar.Name = "txtBox_Buscar";
            this.txtBox_Buscar.Size = new System.Drawing.Size(508, 20);
            this.txtBox_Buscar.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.Location = new System.Drawing.Point(758, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(163, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.toolStripMenuModificar,
            this.modificarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Articulo";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // toolStripMenuModificar
            // 
            this.toolStripMenuModificar.Name = "toolStripMenuModificar";
            this.toolStripMenuModificar.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuModificar.Text = "Modificar";
            this.toolStripMenuModificar.Click += new System.EventHandler(this.artículoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.modificarToolStripMenuItem.Text = "Ver";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(12, 519);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(157, 30);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 561);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txtBox_Buscar);
            this.Controls.Add(this.GroupBox_Filtro);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox GroupBox_Filtro;
        private System.Windows.Forms.TextBox txtBox_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.NumericUpDown Numeric_Max;
        private System.Windows.Forms.NumericUpDown Numeric_Min;
        private System.Windows.Forms.Label lbl_Marcas;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox comboBoxMarcas;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.RadioButton RB_ActivarFiltros;
        private System.Windows.Forms.RadioButton RB_Desactivarfiltros;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuModificar;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

