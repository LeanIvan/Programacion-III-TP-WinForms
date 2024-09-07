using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class NewArticleForm : Form
    {

       private ControladorMarca controladorMarca;
        private ControladorCategoria controladorCategoria;

        public NewArticleForm()
        {
            controladorMarca = new ControladorMarca();
            controladorCategoria = new ControladorCategoria();

            InitializeComponent();

            


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            /// insercion en base de datos
            /// 

         
            
           

            ///

            this.DialogResult = DialogResult.OK;

        }

        private void NewArticleForm_Load(object sender, EventArgs e)
        {

            comboBoxMarca.DataSource = controladorMarca.Listar();
            comboBoxCategoria.DataSource = controladorCategoria.Listar();


            comboBoxCategoria.DisplayMember = "Descripcion";
            comboBoxCategoria.ValueMember = "Id";

            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.ValueMember = "Id";


        }

        private void buttonVerImagen_Click(object sender, EventArgs e)
        {
            /// verificar que haya algio en la url

            /// mostrar la img de la url
            
            string url = textBoxImagen.Text;
             
            using (CheckImageForm frm = new CheckImageForm(url))
            {
                frm.ShowDialog();
            }


        }
    }
}
