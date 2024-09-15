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
    public partial class Instrucciones : Form
    {
        public Instrucciones()
        {
            InitializeComponent();
            lbl_division1.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

            lbl_Instrucciones.Text = "1) SI SE BUSCA CON LOS FILTROS DESACTIVADOS : SOLAMENTE BUSCA POR EL NOMBRE.";
            lbl_2.Text = "2) SI SE BUSCA CON LOS FILTROS ACTIVADOS Y POR UN NOMBRE: UTILIZA LAS DOS COSAS PARA FILTRAR.";
            lbl_3.Text = "3) SI SE BUSCA CON LOS FILTROS ACTIVADOS Y SIN NOMBRE : FILTRA SOLAMENTE CON LOS PARÁMETROS DE LA IZQUIERDA.";
            lbl_4.Text = "4) SI SE BUSCA CON LOS FILTROS DESACTIVDADOS Y SIN NOMBRE : LISTA NUEVAMENTE LA GRILLA SIN FILTRO ALGUNO.";

            lbl_division2.Text = "--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

            lbl_nota.Text = " NOTA: AL ACTIVAR LOS FILTROS EN LA PARTE IZQUIERDA , SE FILTRARÁ POR TODO , EJ : NO SE PUEDE BUSCAR SOLAMENTE POR CATEGORÍA";

        }
    }
}
