using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


namespace Vista
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inicializar();
        }



        public void inicializar()
        {

          




        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClontroladorArticulo controlador = new ClontroladorArticulo();
            dgvList.DataSource = controlador.Listar();
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            ControladorMarca ControladorMarca = new ControladorMarca();
            try
            {

                //listo categorias
                comboBoxCategorias.DataSource = controladorCategoria.Listar();
                comboBoxCategorias.ValueMember = "Id";
                comboBoxCategorias.DisplayMember = "Descripcion";
                // listo marcas
                comboBoxMarcas.DataSource = ControladorMarca.Listar();
                comboBoxMarcas.ValueMember = "Id";
                comboBoxMarcas.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
