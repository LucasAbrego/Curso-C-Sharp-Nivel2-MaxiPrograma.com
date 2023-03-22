using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace vistas
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo= null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            lbAlta.Text = "Agregar Artículo";
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lbAlta.Text = "Modificiar Artículo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                ocultarAvisosDeRequeridos();
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    if (articulo.Marca != null)
                        cboMarca.SelectedValue = articulo.Marca.Id;
                    if (articulo.Categoria != null)
                        cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString().Replace(',','.');
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        private void btnAceptarAlta_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                bool validacion = true;
                if (articulo == null)
                    articulo = new Articulo();
                if (txtCodigo.Text.Length > 0) 
                { 
                    articulo.Codigo = txtCodigo.Text;
                    bordeRojo(txtCodigo, panelBordeCodigo, lbRequeridoCodigo, false);
                }
                else
                {
                    bordeRojo(txtCodigo, panelBordeCodigo, lbRequeridoCodigo, true);
                    validacion = false;
                }
                if (txtNombre.Text.Length > 0)
                {
                    articulo.Nombre = txtNombre.Text;
                    bordeRojo(txtNombre, panelBordeNombre, lbRequeridoNombre, false);
                }
                else
                {
                    bordeRojo(txtNombre, panelBordeNombre, lbRequeridoNombre, true);
                    validacion = false;
                }
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagenUrl.Text;
                if (txtPrecio.Text.Length > 0)
                {
                    if (validarPrecios(txtPrecio.Text))
                    {
                        CultureInfo cultura = new CultureInfo("en-US");
                        articulo.Precio = decimal.Parse(txtPrecio.Text, cultura);
                        bordeRojo(txtPrecio, panelBordePrecio, lbRequeridoPrecio, false);
                    }
                    else
                    {
                        lbRequeridoPrecio.Text = "Ingrese un número";
                        bordeRojo(txtPrecio, panelBordePrecio, lbRequeridoPrecio, true);
                        validacion = false;
                    }
                }
                else
                {
                    lbRequeridoPrecio.Text = "Campo requerido";
                    bordeRojo(txtPrecio, panelBordePrecio, lbRequeridoPrecio, true);
                    validacion = false;
                }

                if (validacion)
                {
                    if (articulo.Id != 0)
                    {
                        artNegocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        artNegocio.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    DialogResult = DialogResult.OK;
                    if (archivo != null && !(txtImagenUrl.Text.ToLower().Contains("http")))
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + articulo.Marca.Descripcion + articulo.Codigo + archivo.SafeFileName);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jgp|*.jpg;|png|*.png;";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAlta.Load(imagen);
            }
            catch (Exception)
            {
                pbxAlta.Load("https://us.123rf.com/450wm/pe3check/pe3check1710/pe3check171000054/88673746-nenhuma-imagem-dispon%C3%ADvel-sinal-%C3%ADcone-da-web-da-internet-para-indicar-a-aus%C3%AAncia-de-imagem-at%C3%A9-que.jpg?ver=6");
            }
        }
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        private void ocultarAvisosDeRequeridos()
        {
            lbRequeridoCodigo.Visible = false;
            lbRequeridoNombre.Visible = false;
            lbRequeridoPrecio.Visible = false;
            panelBordeCodigo.Visible = false;
            panelBordeNombre.Visible = false;
            panelBordePrecio.Visible = false;
        }
        private void bordeRojo(TextBox textBox, Panel panel, Label label, bool bordeRojo)
        {
            if (bordeRojo)
            {
                label.Visible = true;
                panel.Visible = true;
                textBox.BorderStyle = BorderStyle.None;
            }
            else
            {
                label.Visible = false;
                panel.Visible = false;
                textBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        private bool validarPrecios(string precio)
        {
            bool precioOk = true;
            foreach (char caracter in precio)
            {
                if (!(char.IsNumber(caracter) || caracter == '.'))
                    precioOk = false;
            }
            if (precioOk)
                return true;
            else
                return false;
        }
    }
}
