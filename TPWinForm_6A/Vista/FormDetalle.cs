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
    public partial class FormDetalle : Form
    {

        private ControladorImagen imgController;
        private ControladorMarca marcaController;
        private ControladorCategoria catController;



        public FormDetalle(Articulo art)
        {
            imgController = new ControladorImagen();
           marcaController = new ControladorMarca();
            catController = new ControladorCategoria();



            InitializeComponent();
            InicializarControles(art);
        }


        private void InicializarControles(Articulo art)
        {


            textBoxId.Text = art.Id.ToString();
            textBoxNombre.Text = art.Nombre;
            textBoxPrecio.Text = art.Precio.ToString();
            labelDescripcion.Text = art.Descripcion;

            var categorias = catController.Listar();
            var marcas = marcaController.Listar();

            comboBoxCategoria.DataSource = categorias;
            comboBoxMarca.DataSource = marcas;


            comboBoxCategoria.DisplayMember = "Descripcion";
            comboBoxCategoria.ValueMember = "Id";
            //comboBoxCategoria.Enabled = false;

            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.ValueMember = "Id";
            //comboBoxCategoria.Enabled = false;

       
            comboBoxCategoria.SelectedValue = art.IdCategoria; 
            comboBoxMarca.SelectedValue = art.IdMarca;


            try
            {
                pictureBoxDetalle.LoadAsync(imgController.getImagenByArticuloId(art.Id).Url);
            }
            catch
            {
                pictureBoxDetalle.Image = pictureBoxDetalle.ErrorImage;
            }

        }



        private void buttonAceptar_Click(object sender, EventArgs e)
        {

           /// verificamos si hubo algún cambio y lo guardamos , sinó cerramos



            this.DialogResult = DialogResult.OK;    
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
