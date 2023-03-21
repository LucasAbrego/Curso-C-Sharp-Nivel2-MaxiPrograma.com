using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        private Categoria categoriaSeleccionada;
        private Marca marcaSeleccionada;
        Articulo artSeleccionado;
        private string precioMinimo = "", precioMaximo="";
        
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                cargarDesplegables();
                listaArticulos = negocio.listar();
                dgvCatalogo.DataSource = listaArticulos;
                formatoDGV();
                gbxBusquedaAvanzada.Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarDesplegables()
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cboMarcaCat.DataSource = marcaNegocio.listarMarcasCbo();
                cboMarcaCat.ValueMember = "Id";
                cboMarcaCat.DisplayMember = "Descripcion";

                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                cboCategoriaCat.DataSource = categoriaNegocio.listarCategoriasCbo(); ;
                cboCategoriaCat.ValueMember = "Id";
                cboCategoriaCat.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void formatoDGV()
        {
            dgvCatalogo.Columns["ImagenUrl"].Visible = false;
            dgvCatalogo.Columns["Descripcion"].Visible = false;
            dgvCatalogo.Columns["Id"].Visible = false;
            dgvCatalogo.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvCatalogo.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                if (imagen != "sinElementos")
                    pbxCatalogo.Load(imagen);
                else
                {
                    pbxCatalogo.Image = null;
                    pbxCatalogo.Update();
                }
            }
            catch (Exception)
            {
                pbxCatalogo.Load("https://us.123rf.com/450wm/pe3check/pe3check1710/pe3check171000054/88673746-nenhuma-imagem-dispon%C3%ADvel-sinal-%C3%ADcone-da-web-da-internet-para-indicar-a-aus%C3%AAncia-de-imagem-at%C3%A9-que.jpg?ver=6");
            }
        }

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCatalogo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private string validarPrecios(string minimo, string maximo)
        {
            bool minOk = true, maxOk = true;

            foreach (char caracter in minimo)
            {
                if (!(char.IsNumber(caracter) || caracter == '.'))
                    minOk = false;
            }

            foreach (char caracter in maximo)
            {
                if (!(char.IsNumber(caracter) || caracter == '.'))
                    maxOk = false;
            }

            if (minOk == true && maxOk == true)
                return "TodoOk";
            else
                return "Ingrese un precio válido";
        }
        private void btnCatAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaAgregar = new frmAltaArticulo();
            DialogResult altaRespuesta= altaAgregar.ShowDialog();
            if (altaRespuesta == DialogResult.OK)
                cargar();             
        }

        private void btnCatModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;
            if (dgvCatalogo.CurrentRow != null)
            {   
                artSeleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                frmAltaArticulo altaModificar = new frmAltaArticulo(artSeleccionado) ;
                DialogResult altaRespuesta = altaModificar.ShowDialog();
                if (altaRespuesta == DialogResult.OK)
                    busquedaAvanzada();
            }
            else
                MessageBox.Show("Seleccione el artículo que desea modificar.");
        }

        private void btnCatEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Articulo artSeleccionado;
            
            try
            {
                if (dgvCatalogo.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("El artículo se eliminará de forma PERMANENTE ¿Desea continuar?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        artSeleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                        artNegocio.eliminar(artSeleccionado.Id);
                    }
                    cargar();
                }
                else
                    MessageBox.Show("Seleccione el artículo que desea elminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

            if (dgvCatalogo.CurrentRow != null)
            {
                artSeleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                frmDetalles detalles = new frmDetalles(artSeleccionado);
                detalles.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione un artículo para ver sus detalles.");
        }

        private void txtBuscarCatalogo_TextChanged(object sender, EventArgs e)
        {
            busquedaRapida();
        }
        private void busquedaRapida()
        {
            List<Articulo> listaArtBusqueda;
            string busqueda = txtBuscarCat.Text;

            if (busqueda.Length >= 2)
            {
                listaArtBusqueda = listaArticulos.FindAll(x => (x.Nombre == null ? false : x.Nombre.ToUpper().Contains(busqueda.ToUpper())) || (x.Codigo == null ? false : x.Codigo.ToUpper().Contains(busqueda.ToUpper())));
            }
            else
            {
                listaArtBusqueda = listaArticulos;
            }

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listaArtBusqueda;
            formatoDGV();
            if (listaArtBusqueda.Count == 0)
                cargarImagen("sinElementos");
            else
                dgvCatalogo.CurrentCell = dgvCatalogo.Rows[0].Cells[1];
        }
        private void busquedaAvanzada()
        {
            ArticuloNegocio negocioBusquedaAv = new ArticuloNegocio();
            try
            {
                categoriaSeleccionada = (Categoria)cboCategoriaCat.SelectedItem;
                marcaSeleccionada = (Marca)cboMarcaCat.SelectedItem;
                if (txtPrecioMinimo.Text.Length > 0)
                    precioMinimo = txtPrecioMinimo.Text;
                else
                    precioMinimo = "";
                if (txtPrecioMaximo.Text.Length > 0)
                    precioMaximo = txtPrecioMaximo.Text;
                else
                    precioMaximo = "";
                string estadoPrecio = validarPrecios(precioMinimo, precioMaximo);

                if (categoriaSeleccionada != null && marcaSeleccionada != null)
                {
                    if (estadoPrecio == "TodoOk")
                    {
                        listaArticulos = negocioBusquedaAv.filtrar(marcaSeleccionada, categoriaSeleccionada, precioMinimo, precioMaximo);
                        dgvCatalogo.DataSource = listaArticulos;
                        if (listaArticulos.Count == 0)
                            cargarImagen("sinElementos");
                        busquedaRapida();
                    }
                    else
                        MessageBox.Show(estadoPrecio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnFiltrarCat_Click(object sender, EventArgs e)
        {
            busquedaAvanzada();
            gbxBusquedaAvanzada.Visible = false;
        }

        private void btnLimpiarTxtBusqueda_Click(object sender, EventArgs e)
        {
            resetearFormulario("rapida");
        }

        private void btnCerrarBusquedaAv_Click(object sender, EventArgs e)
        {
            gbxBusquedaAvanzada.Visible = false;
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (gbxBusquedaAvanzada.Visible)
                gbxBusquedaAvanzada.Visible = false;
            else
                gbxBusquedaAvanzada.Visible = true;
        }

        private void btnLimpiarBusquedaAv_Click(object sender, EventArgs e)
        {
            resetearFormulario("avanzada");
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            busquedaAvanzada();
            gbxBusquedaAvanzada.Visible =false;
        }
        private void btnTodoCat_Click(object sender, EventArgs e)
        {
            cargar();
            resetearFormulario("ambas");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void resetearFormulario(string bAvanzadaRapidaAmbas)
        {
            if (bAvanzadaRapidaAmbas == "rapida")
                txtBuscarCat.Text = "";
            else if (bAvanzadaRapidaAmbas == "avanzada")
            {
                cboCategoriaCat.SelectedIndex = 0;
                cboMarcaCat.SelectedIndex = 0;
                txtPrecioMaximo.Text = "";
                txtPrecioMinimo.Text = "";
            }
            else if (bAvanzadaRapidaAmbas == "ambas")
            {
                txtBuscarCat.Text = "";
                cboCategoriaCat.SelectedIndex = 0;
                cboMarcaCat.SelectedIndex = 0;
                txtPrecioMaximo.Text = "";
                txtPrecioMinimo.Text = "";
            }
        }
    }
}

