namespace Vista
{
    partial class NewCategoryForm
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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(88, 37);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 0;
            this.labelCategoria.Text = "Categoría";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(15, 123);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(84, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(132, 124);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(15, 69);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(199, 20);
            this.textBoxCategoria.TabIndex = 3;
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 159);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelCategoria);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxCategoria;
    }
}