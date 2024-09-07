namespace Vista
{
    partial class NewMarcaForm
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(95, 26);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 0;
            this.labelMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(12, 51);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(204, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(12, 104);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(95, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(121, 104);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(95, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // NewMarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 143);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMarcaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}