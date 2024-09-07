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
    public partial class NewMarcaForm : Form
    {
        public NewMarcaForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ///  verificar e insertar marca en la db



            ///
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
