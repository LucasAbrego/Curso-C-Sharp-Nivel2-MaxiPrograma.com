using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class frmDetalles : Form
    {
        private Articulo articulo = null;
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalles del artículo";
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            try
            {
                if (articulo.Codigo != null)
                    lbCodigoDetalles.Text = "Código artículo: "+ articulo.Codigo;
                if (articulo.Nombre != null)
                    lbNombreDetalles.Text = articulo.Nombre;
                if (articulo.Descripcion != null)
                    lbDescripcionDetalles.Text = "Descripcion \n" + articulo.Descripcion;
                if (articulo.Marca != null)
                    lbMarcaDetalles.Text = "Marca: " + articulo.Marca.Descripcion;
                if (articulo.Categoria != null)
                    lbCategoriaDetalles.Text = "Categoría: " + articulo.Categoria.Descripcion;
                if (articulo.ImagenUrl != null)
                    cargarImagen(articulo.ImagenUrl);
                lbPrecioDetalles.Text = articulo.Precio.ToString("0.00") + " ARS";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDetalles.Load(imagen);
            }
            catch (Exception)
            {
                pbxDetalles.Load("https://us.123rf.com/450wm/pe3check/pe3check1710/pe3check171000054/88673746-nenhuma-imagem-dispon%C3%ADvel-sinal-%C3%ADcone-da-web-da-internet-para-indicar-a-aus%C3%AAncia-de-imagem-at%C3%A9-que.jpg?ver=6");
            }
        }

        private void btnCerrarFrmDetalles_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
