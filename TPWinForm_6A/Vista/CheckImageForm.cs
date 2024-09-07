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
    public partial class CheckImageForm : Form
    {

        string UrlImagen;

        public CheckImageForm(string url)
        {
            UrlImagen = url;
            InitializeComponent();
           
        }

        private void CheckImageForm_Load(object sender, EventArgs e)
        {



            try
            {
                pictureBoxImage.LoadAsync(UrlImagen);
            }catch (Exception ex)
            {
                pictureBoxImage.Image = pictureBoxImage.ErrorImage;

            }
           

        }
    }
}
