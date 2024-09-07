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

            }



        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// abrir ventana para agregar nueva marca
            /// 

            using (NewMarcaForm frm = new NewMarcaForm() )
            {
              
              if( frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Marca Agregada con Exito");

                }

            }

        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// abrir ventana para agregar nueva categoría
            /// 

            using (NewCategoryForm frm = new NewCategoryForm())
            {

             if( frm.ShowDialog() == DialogResult.OK ) {

                    MessageBox.Show("Categoria agregada con exito");

                }

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




    }


}
