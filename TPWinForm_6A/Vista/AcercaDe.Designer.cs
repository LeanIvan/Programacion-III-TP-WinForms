namespace Vista
{
    partial class AcercaDe
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblGonza = new System.Windows.Forms.Label();
            this.lblAgustin = new System.Windows.Forms.Label();
            this.lblBraian = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(19, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(395, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proyecto Windows Form Programación III";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(19, 115);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(102, 20);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Integrantes";
            // 
            // lblGonza
            // 
            this.lblGonza.AutoSize = true;
            this.lblGonza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGonza.Location = new System.Drawing.Point(23, 167);
            this.lblGonza.Name = "lblGonza";
            this.lblGonza.Size = new System.Drawing.Size(184, 20);
            this.lblGonza.TabIndex = 2;
            this.lblGonza.Text = "Gonzalo Nicolás Garnica";
            // 
            // lblAgustin
            // 
            this.lblAgustin.AutoSize = true;
            this.lblAgustin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgustin.Location = new System.Drawing.Point(23, 205);
            this.lblAgustin.Name = "lblAgustin";
            this.lblAgustin.Size = new System.Drawing.Size(106, 20);
            this.lblAgustin.TabIndex = 3;
            this.lblAgustin.Text = "Agustin Leani";
            this.lblAgustin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBraian
            // 
            this.lblBraian.AutoSize = true;
            this.lblBraian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBraian.Location = new System.Drawing.Point(23, 244);
            this.lblBraian.Name = "lblBraian";
            this.lblBraian.Size = new System.Drawing.Size(173, 20);
            this.lblBraian.TabIndex = 4;
            this.lblBraian.Text = "Braian Exequiel Franco";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(20, 389);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(233, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "2024 Grupo 6A, Todos los derechos reservados";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblBraian);
            this.Controls.Add(this.lblAgustin);
            this.Controls.Add(this.lblGonza);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblGonza;
        private System.Windows.Forms.Label lblAgustin;
        private System.Windows.Forms.Label lblBraian;
        private System.Windows.Forms.Label lblCopyright;
    }
}