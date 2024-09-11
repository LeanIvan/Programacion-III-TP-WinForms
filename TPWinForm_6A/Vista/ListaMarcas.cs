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
    public partial class ListaMarcas : Form
    {
        public ListaMarcas()
        {
            InitializeComponent();


            ControladorMarca controladorMarca= new ControladorMarca();

            try
            {
                GridView_Marcas.DataSource = controladorMarca.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
