namespace Vista
{
    partial class FormDetalle
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
            this.pictureBoxDetalle = new System.Windows.Forms.PictureBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDetalle
            // 
            this.pictureBoxDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDetalle.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxDetalle.Name = "pictureBoxDetalle";
            this.pictureBoxDetalle.Size = new System.Drawing.Size(424, 390);
            this.pictureBoxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetalle.TabIndex = 0;
            this.pictureBoxDetalle.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(443, 95);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(198, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(443, 146);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(129, 21);
            this.comboBoxMarca.TabIndex = 2;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(443, 199);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(129, 21);
            this.comboBoxCategoria.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(442, 79);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(42, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Articulo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(442, 130);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Marca";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(442, 183);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 6;
            this.labelCategoria.Text = "Categoría";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(442, 291);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(10, 13);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "-";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(456, 394);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(117, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(589, 394);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(442, 27);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(444, 43);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(198, 20);
            this.textBoxId.TabIndex = 11;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(445, 254);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(127, 20);
            this.textBoxPrecio.TabIndex = 12;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(442, 238);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Precio";
            // 
            // FormDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.pictureBoxDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDetalle;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
    }
}