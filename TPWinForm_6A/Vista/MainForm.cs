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
using Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            inicializarControles();

          
        }

        public void inicializarControles()
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            

            /// subscripciones a eventos
            dgvList.SelectionChanged += dgvList_SelectionChanged;  
            dgvList.KeyDown += dgvList_KeyDown;
           
        


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void cargar()
        {
            ControladorArticulo controlador = new ControladorArticulo();
            dgvList.DataSource = controlador.Listar();
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            ControladorMarca ControladorMarca = new ControladorMarca();

            /// ocultamos los headers y sus columnas
            dgvList.Columns["IdMarca"].Visible = false;
            dgvList.Columns["IdCategoria"].Visible = false;


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

            dgvList.Rows[0].Selected = true;

        }


        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarFormularioDetalle();
        }


        private void MostrarFormularioDetalle()
        {
           
            if (dgvList.CurrentRow != null)
            {
              
                int IdCategoria = (int)dgvList.CurrentRow.Cells["IdCategoria"].Value;
                int IdMarca = (int)dgvList.CurrentRow.Cells["IdMarca"].Value;

                Articulo art = new Articulo
                {
                    Id = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value),
                    Codigo = dgvList.CurrentRow.Cells["Codigo"].Value.ToString(),
                    Nombre = dgvList.CurrentRow.Cells["Nombre"].Value.ToString(),
                    Precio = Convert.ToDecimal(dgvList.CurrentRow.Cells["Precio"].Value),
                    Descripcion = dgvList.CurrentRow.Cells["Descripcion"].Value.ToString(),
                    IdCategoria = IdCategoria,
                    IdMarca = IdMarca
                };

                using (FormDetalle frm = new FormDetalle(art))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                       
                    }
                }
            }
        }







        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
          
            
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            
        
            if (dgvList.SelectedCells.Count > 0)
            {
              
                int rowIndex = dgvList.SelectedCells[0].RowIndex;
    
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }


        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /// abrir ventana para agregar nuevo producto

            using (NewArticleForm frm = new NewArticleForm())
            {

                
                frm.ShowDialog();
                cargar();

            }



        }





        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {      
                e.Handled = true;

                MostrarFormularioDetalle();  
            }
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvList.CurrentRow == null)
                {
                    throw new Exception("Debe seleccionar algún articulo");

                }
                    

                // me quedo con el articulo seleccionado
                Articulo seleccionado;
                seleccionado = (Articulo)dgvList.CurrentRow.DataBoundItem;


                NewArticleForm modificar = new NewArticleForm(seleccionado);
                modificar.ShowDialog();
                cargar();

            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar algún articulo");
            }

  
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ControladorArticulo Controlador = new ControladorArticulo();


            try
            {
                DialogResult Respuesta = MessageBox.Show("¿Esta Seguro/a?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvList.CurrentRow.DataBoundItem;
                    Controlador.Eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ControladorArticulo Controlador = new ControladorArticulo();

            try
            {

                string busquedaNombre = txtBox_Buscar.Text;
                int SeleccionCategoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
                int SeleccionMarca = Convert.ToInt32(comboBoxMarcas.SelectedValue.ToString());
                decimal min = Numeric_Min.Value;
                decimal max = Numeric_Max.Value;
                bool filtros = false;

                if (min>max || max==0)
                {
                    MessageBox.Show("Si el precio mínimo es mayor al máximo o el precio máximo es igual a 0, no encontrará coincidencias.");
                
                }

                if (RB_ActivarFiltros.Checked == true)
                {   
                    filtros = true;                
                }

                dgvList.DataSource = Controlador.Filtrar(busquedaNombre, SeleccionCategoria, SeleccionMarca, min, max, filtros);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SeleccionCategoria = comboBoxCategorias.SelectedItem.ToString();
            

        }

        private void comboBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SeleccionMarca = comboBoxCategorias.SelectedItem.ToString();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListaCategorias = new ListaCategorias();
            ListaCategorias.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListaMarcas = new ListaMarcas();
            ListaMarcas.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AcercaDe = new AcercaDe();
            AcercaDe.ShowDialog();
        }

        private void btn_Instrucciones_Click(object sender, EventArgs e)
        {

            Form Instrucciones = new Instrucciones();
            Instrucciones.ShowDialog();
        }
    }
}
