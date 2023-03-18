namespace vistas
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxCatalogo = new System.Windows.Forms.PictureBox();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.txtBuscarCat = new System.Windows.Forms.TextBox();
            this.lbMarcaCat = new System.Windows.Forms.Label();
            this.lbCategoríaCat = new System.Windows.Forms.Label();
            this.lbMinimo = new System.Windows.Forms.Label();
            this.cboCategoriaCat = new System.Windows.Forms.ComboBox();
            this.gbxBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.btnTodoCat = new System.Windows.Forms.Button();
            this.btnFiltrarCat = new System.Windows.Forms.Button();
            this.gbxPrecio = new System.Windows.Forms.GroupBox();
            this.txtPrecioMaximo = new System.Windows.Forms.TextBox();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.cboMarcaCat = new System.Windows.Forms.ComboBox();
            this.btnLimpiarTxtBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.gbxBusquedaAvanzada.SuspendLayout();
            this.gbxPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCatalogo
            // 
            this.pbxCatalogo.Location = new System.Drawing.Point(670, 200);
            this.pbxCatalogo.Name = "pbxCatalogo";
            this.pbxCatalogo.Size = new System.Drawing.Size(340, 340);
            this.pbxCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCatalogo.TabIndex = 0;
            this.pbxCatalogo.TabStop = false;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(12, 200);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersWidth = 62;
            this.dgvCatalogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatalogo.RowTemplate.Height = 28;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(632, 340);
            this.dgvCatalogo.TabIndex = 1;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(120, 40);
            this.btnAgregarCat.TabIndex = 2;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnCatAgregar_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(12, 58);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(120, 40);
            this.btnModificarCat.TabIndex = 3;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnCatModificar_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(12, 104);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarCat.TabIndex = 4;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnCatEliminar_Click);
            // 
            // txtBuscarCat
            // 
            this.txtBuscarCat.Location = new System.Drawing.Point(49, 165);
            this.txtBuscarCat.Name = "txtBuscarCat";
            this.txtBuscarCat.Size = new System.Drawing.Size(961, 26);
            this.txtBuscarCat.TabIndex = 5;
            this.txtBuscarCat.TextChanged += new System.EventHandler(this.txtBuscarCatalogo_TextChanged);
            // 
            // lbMarcaCat
            // 
            this.lbMarcaCat.AutoSize = true;
            this.lbMarcaCat.Location = new System.Drawing.Point(16, 43);
            this.lbMarcaCat.Name = "lbMarcaCat";
            this.lbMarcaCat.Size = new System.Drawing.Size(56, 20);
            this.lbMarcaCat.TabIndex = 6;
            this.lbMarcaCat.Text = "Marca";
            // 
            // lbCategoríaCat
            // 
            this.lbCategoríaCat.AutoSize = true;
            this.lbCategoríaCat.Location = new System.Drawing.Point(6, 86);
            this.lbCategoríaCat.Name = "lbCategoríaCat";
            this.lbCategoríaCat.Size = new System.Drawing.Size(81, 20);
            this.lbCategoríaCat.TabIndex = 6;
            this.lbCategoríaCat.Text = "Categoría";
            // 
            // lbMinimo
            // 
            this.lbMinimo.AutoSize = true;
            this.lbMinimo.Location = new System.Drawing.Point(17, 28);
            this.lbMinimo.Name = "lbMinimo";
            this.lbMinimo.Size = new System.Drawing.Size(63, 20);
            this.lbMinimo.TabIndex = 6;
            this.lbMinimo.Text = "Mínimo";
            // 
            // cboCategoriaCat
            // 
            this.cboCategoriaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaCat.FormattingEnabled = true;
            this.cboCategoriaCat.Location = new System.Drawing.Point(93, 83);
            this.cboCategoriaCat.Name = "cboCategoriaCat";
            this.cboCategoriaCat.Size = new System.Drawing.Size(170, 28);
            this.cboCategoriaCat.TabIndex = 8;
            // 
            // gbxBusquedaAvanzada
            // 
            this.gbxBusquedaAvanzada.Controls.Add(this.btnTodoCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.btnFiltrarCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.gbxPrecio);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCategoriaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbCategoríaCat);
            this.gbxBusquedaAvanzada.Location = new System.Drawing.Point(220, 12);
            this.gbxBusquedaAvanzada.Name = "gbxBusquedaAvanzada";
            this.gbxBusquedaAvanzada.Size = new System.Drawing.Size(790, 135);
            this.gbxBusquedaAvanzada.TabIndex = 9;
            this.gbxBusquedaAvanzada.TabStop = false;
            this.gbxBusquedaAvanzada.Text = "Busqueda Avanzada";
            // 
            // btnTodoCat
            // 
            this.btnTodoCat.Location = new System.Drawing.Point(616, 25);
            this.btnTodoCat.Name = "btnTodoCat";
            this.btnTodoCat.Size = new System.Drawing.Size(149, 43);
            this.btnTodoCat.TabIndex = 10;
            this.btnTodoCat.Text = "Traer Todo";
            this.btnTodoCat.UseVisualStyleBackColor = true;
            this.btnTodoCat.Click += new System.EventHandler(this.btnTodoCat_Click);
            // 
            // btnFiltrarCat
            // 
            this.btnFiltrarCat.Location = new System.Drawing.Point(616, 76);
            this.btnFiltrarCat.Name = "btnFiltrarCat";
            this.btnFiltrarCat.Size = new System.Drawing.Size(149, 40);
            this.btnFiltrarCat.TabIndex = 11;
            this.btnFiltrarCat.Text = "Filtrar";
            this.btnFiltrarCat.UseVisualStyleBackColor = true;
            this.btnFiltrarCat.Click += new System.EventHandler(this.btnFiltrarCat_Click);
            // 
            // gbxPrecio
            // 
            this.gbxPrecio.Controls.Add(this.txtPrecioMaximo);
            this.gbxPrecio.Controls.Add(this.txtPrecioMinimo);
            this.gbxPrecio.Controls.Add(this.lbMaximo);
            this.gbxPrecio.Controls.Add(this.lbMinimo);
            this.gbxPrecio.Location = new System.Drawing.Point(298, 15);
            this.gbxPrecio.Name = "gbxPrecio";
            this.gbxPrecio.Size = new System.Drawing.Size(283, 108);
            this.gbxPrecio.TabIndex = 9;
            this.gbxPrecio.TabStop = false;
            this.gbxPrecio.Text = "Precio";
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.Location = new System.Drawing.Point(97, 68);
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(152, 26);
            this.txtPrecioMaximo.TabIndex = 11;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Location = new System.Drawing.Point(97, 25);
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(152, 26);
            this.txtPrecioMinimo.TabIndex = 10;
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(17, 71);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(67, 20);
            this.lbMaximo.TabIndex = 6;
            this.lbMaximo.Text = "Máximo";
            // 
            // cboMarcaCat
            // 
            this.cboMarcaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaCat.FormattingEnabled = true;
            this.cboMarcaCat.Location = new System.Drawing.Point(94, 40);
            this.cboMarcaCat.Name = "cboMarcaCat";
            this.cboMarcaCat.Size = new System.Drawing.Size(169, 28);
            this.cboMarcaCat.TabIndex = 8;
            // 
            // btnLimpiarTxtBusqueda
            // 
            this.btnLimpiarTxtBusqueda.Location = new System.Drawing.Point(12, 165);
            this.btnLimpiarTxtBusqueda.Name = "btnLimpiarTxtBusqueda";
            this.btnLimpiarTxtBusqueda.Size = new System.Drawing.Size(31, 26);
            this.btnLimpiarTxtBusqueda.TabIndex = 10;
            this.btnLimpiarTxtBusqueda.Text = "X";
            this.btnLimpiarTxtBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarTxtBusqueda.Click += new System.EventHandler(this.btnLimpiarTxtBusqueda_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1035, 552);
            this.Controls.Add(this.btnLimpiarTxtBusqueda);
            this.Controls.Add(this.gbxBusquedaAvanzada);
            this.Controls.Add(this.txtBuscarCat);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnModificarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.pbxCatalogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de productos";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.gbxBusquedaAvanzada.ResumeLayout(false);
            this.gbxBusquedaAvanzada.PerformLayout();
            this.gbxPrecio.ResumeLayout(false);
            this.gbxPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCatalogo;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.TextBox txtBuscarCat;
        private System.Windows.Forms.Label lbMarcaCat;
        private System.Windows.Forms.Label lbCategoríaCat;
        private System.Windows.Forms.Label lbMinimo;
        private System.Windows.Forms.ComboBox cboCategoriaCat;
        private System.Windows.Forms.GroupBox gbxBusquedaAvanzada;
        private System.Windows.Forms.ComboBox cboMarcaCat;
        private System.Windows.Forms.GroupBox gbxPrecio;
        private System.Windows.Forms.TextBox txtPrecioMaximo;
        private System.Windows.Forms.TextBox txtPrecioMinimo;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.Button btnTodoCat;
        private System.Windows.Forms.Button btnFiltrarCat;
        private System.Windows.Forms.Button btnLimpiarTxtBusqueda;
    }
}

