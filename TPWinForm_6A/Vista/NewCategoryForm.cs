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
    public partial class NewCategoryForm : Form
    {
        public NewCategoryForm()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            /// verificar e insertar nueva categoria


            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
