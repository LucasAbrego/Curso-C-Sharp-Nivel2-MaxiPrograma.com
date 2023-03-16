using dominio;
using negocio;
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
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
            cargarDesplegables();
            
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvCatalogo.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void cargarDesplegables()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca marcaTodos = new Marca(0, "Todos"); ;
            List<Marca> marcasCboLista = marcaNegocio.listar();
            marcasCboLista.Insert(0, marcaTodos);
            cboMarcaCat.DataSource = marcasCboLista;
            cboMarcaCat.ValueMember = "Id";
            cboMarcaCat.DisplayMember = "Descripcion";

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categoria categoriaTodos = new Categoria(0, "Todos");
            List<Categoria> categoriasCboLista = categoriaNegocio.listar();
            categoriasCboLista.Insert(0, categoriaTodos);
            cboCategoriaCat.DataSource = categoriasCboLista;
            cboCategoriaCat.ValueMember = "Id";
            cboCategoriaCat.DisplayMember = "Descripcion";
        }
        private void ocultarColumnas()
        {
            dgvCatalogo.Columns["ImagenUrl"].Visible = false;
            dgvCatalogo.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxCatalogo.Load(imagen);
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

        private void btnCatAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaAgregar = new frmAltaArticulo();
            altaAgregar.ShowDialog();
            cargar();
        }

        private void btnCatModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;
            artSeleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;

            frmAltaArticulo altaModificar = new frmAltaArticulo(artSeleccionado); ;
            altaModificar.ShowDialog();
            cargar();
        }

        private void btnCatEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Articulo artSeleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("El artículo se eliminará de forma PERMANENTE ¿Desea continuar?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (respuesta == DialogResult.Yes)
                {
                    artSeleccionado = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                    artNegocio.eliminar(artSeleccionado.Id);
                }
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscarCatalogo_TextChanged(object sender, EventArgs e)
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
            ocultarColumnas();
        }
    }
}
