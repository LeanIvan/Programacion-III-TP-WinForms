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
        }
    }
}
