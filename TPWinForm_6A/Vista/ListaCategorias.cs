using Controlador;
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
    public partial class ListaCategorias : Form
    {
        public ListaCategorias()
        {
            InitializeComponent();

            ControladorCategoria controladorCategoria = new ControladorCategoria();

            try
            {
                GridView_Categorias.DataSource = controladorCategoria.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
