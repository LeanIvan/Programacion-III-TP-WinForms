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

        private Articulo articulo = null;

        public NewArticleForm()
        {
            controladorMarca = new ControladorMarca();
            controladorCategoria = new ControladorCategoria();

            InitializeComponent();      

            


        }

        public NewArticleForm(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
            Text = "Modificar Articulo";
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

            //Articulo art = new Articulo();
            ControladorArticulo controladorArticulo = new ControladorArticulo();

            try
            {
                //Si llegaste hasta aca con el articulo en null, es porque es un articulo nuevo
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Nombre = textBoxNombre.Text;
                articulo.Codigo = textBoxCodigo.Text;
                articulo.Precio = decimal.Parse(textBoxPrecio.Text);
                articulo.Descripcion = textBoxDescripcion.Text;
                articulo.IdMarca = (int)comboBoxMarca.SelectedValue;
                articulo.IdCategoria = (int)comboBoxCategoria.SelectedValue;
                // Agregar Marca y Categoria


                if (articulo.Id != 0)
                {
                    controladorArticulo.Modificar(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    controladorArticulo.Insertar(articulo);
                    MessageBox.Show("Articulo agregado correctamente");

                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
            
           

            ///

            this.DialogResult = DialogResult.OK;

        }

        private void NewArticleForm_Load(object sender, EventArgs e)
        {

            ControladorCategoria controladorCategoria = new ControladorCategoria();
            ControladorMarca controladorMarca = new ControladorMarca();

            try
            {
                comboBoxMarca.DataSource = controladorMarca.Listar();
                comboBoxCategoria.DisplayMember = "Descripcion";
                comboBoxCategoria.ValueMember = "Id";

                comboBoxCategoria.DataSource = controladorCategoria.Listar();
                comboBoxMarca.DisplayMember = "Descripcion";
                comboBoxMarca.ValueMember = "Id";

                if (articulo != null)
                {
                    textBoxNombre.Text = articulo.Nombre;
                    textBoxCodigo.Text = articulo.Codigo;
                    textBoxPrecio.Text = articulo.Precio.ToString();
                    textBoxDescripcion.Text = articulo.Descripcion;
                    comboBoxMarca.SelectedValue = articulo.IdMarca;
                    comboBoxCategoria.SelectedValue = articulo.IdCategoria;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




           



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
