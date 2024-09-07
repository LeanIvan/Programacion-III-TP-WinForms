namespace Vista
{
    partial class NewArticleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonVerImagen = new System.Windows.Forms.Button();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(41, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(226, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(41, 115);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(145, 20);
            this.textBoxPrecio.TabIndex = 1;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(41, 71);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(226, 20);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(41, 161);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(145, 21);
            this.comboBoxMarca.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(41, 209);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCategoria.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(41, 303);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(226, 81);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(41, 393);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(101, 28);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(157, 393);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(110, 28);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonVerImagen
            // 
            this.buttonVerImagen.Location = new System.Drawing.Point(192, 255);
            this.buttonVerImagen.Name = "buttonVerImagen";
            this.buttonVerImagen.Size = new System.Drawing.Size(75, 23);
            this.buttonVerImagen.TabIndex = 8;
            this.buttonVerImagen.Text = "Ver Imagen";
            this.buttonVerImagen.UseVisualStyleBackColor = true;
            this.buttonVerImagen.Click += new System.EventHandler(this.buttonVerImagen_Click);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(41, 255);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(145, 20);
            this.textBoxImagen.TabIndex = 9;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(41, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(41, 55);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 11;
            this.labelCodigo.Text = "Código";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(41, 99);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 12;
            this.labelPrecio.Text = "Precio";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(41, 145);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 13;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(41, 193);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 14;
            this.labelCategoria.Text = "Categoría";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(41, 288);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 15;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(41, 239);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(83, 13);
            this.labelUrlImagen.TabIndex = 16;
            this.labelUrlImagen.Text = "Url de la imagen";
            // 
            // NewArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 429);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.buttonVerImagen);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewArticleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.NewArticleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonVerImagen;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelUrlImagen;
    }
}