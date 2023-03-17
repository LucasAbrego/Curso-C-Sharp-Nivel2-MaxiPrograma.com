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
            this.lbPrecioCat = new System.Windows.Forms.Label();
            this.cboCategoriaCat = new System.Windows.Forms.ComboBox();
            this.gbxBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.cboMarcaCat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.gbxBusquedaAvanzada.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCatalogo
            // 
            this.pbxCatalogo.Location = new System.Drawing.Point(681, 200);
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
            this.dgvCatalogo.Location = new System.Drawing.Point(12, 93);
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
            this.btnAgregarCat.Location = new System.Drawing.Point(12, 449);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(120, 40);
            this.btnAgregarCat.TabIndex = 2;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnCatAgregar_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(151, 449);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(120, 40);
            this.btnModificarCat.TabIndex = 3;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnCatModificar_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(289, 449);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(120, 40);
            this.btnEliminarCat.TabIndex = 4;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnCatEliminar_Click);
            // 
            // txtBuscarCat
            // 
            this.txtBuscarCat.Location = new System.Drawing.Point(12, 39);
            this.txtBuscarCat.Name = "txtBuscarCat";
            this.txtBuscarCat.Size = new System.Drawing.Size(185, 26);
            this.txtBuscarCat.TabIndex = 5;
            this.txtBuscarCat.TextChanged += new System.EventHandler(this.txtBuscarCatalogo_TextChanged);
            // 
            // lbMarcaCat
            // 
            this.lbMarcaCat.AutoSize = true;
            this.lbMarcaCat.Location = new System.Drawing.Point(34, 56);
            this.lbMarcaCat.Name = "lbMarcaCat";
            this.lbMarcaCat.Size = new System.Drawing.Size(56, 20);
            this.lbMarcaCat.TabIndex = 6;
            this.lbMarcaCat.Text = "Marca";
            // 
            // lbCategoríaCat
            // 
            this.lbCategoríaCat.AutoSize = true;
            this.lbCategoríaCat.Location = new System.Drawing.Point(34, 109);
            this.lbCategoríaCat.Name = "lbCategoríaCat";
            this.lbCategoríaCat.Size = new System.Drawing.Size(81, 20);
            this.lbCategoríaCat.TabIndex = 6;
            this.lbCategoríaCat.Text = "Categoría";
            // 
            // lbPrecioCat
            // 
            this.lbPrecioCat.AutoSize = true;
            this.lbPrecioCat.Location = new System.Drawing.Point(606, 70);
            this.lbPrecioCat.Name = "lbPrecioCat";
            this.lbPrecioCat.Size = new System.Drawing.Size(57, 20);
            this.lbPrecioCat.TabIndex = 6;
            this.lbPrecioCat.Text = "Precio";
            // 
            // cboCategoriaCat
            // 
            this.cboCategoriaCat.FormattingEnabled = true;
            this.cboCategoriaCat.Location = new System.Drawing.Point(140, 106);
            this.cboCategoriaCat.Name = "cboCategoriaCat";
            this.cboCategoriaCat.Size = new System.Drawing.Size(121, 28);
            this.cboCategoriaCat.TabIndex = 8;
            this.cboCategoriaCat.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaCat_SelectedIndexChanged);
            // 
            // gbxBusquedaAvanzada
            // 
            this.gbxBusquedaAvanzada.Controls.Add(this.cboMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCategoriaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbCategoríaCat);
            this.gbxBusquedaAvanzada.Location = new System.Drawing.Point(681, 25);
            this.gbxBusquedaAvanzada.Name = "gbxBusquedaAvanzada";
            this.gbxBusquedaAvanzada.Size = new System.Drawing.Size(340, 155);
            this.gbxBusquedaAvanzada.TabIndex = 9;
            this.gbxBusquedaAvanzada.TabStop = false;
            this.gbxBusquedaAvanzada.Text = "Busqueda Avanzada";
            // 
            // cboMarcaCat
            // 
            this.cboMarcaCat.FormattingEnabled = true;
            this.cboMarcaCat.Location = new System.Drawing.Point(140, 54);
            this.cboMarcaCat.Name = "cboMarcaCat";
            this.cboMarcaCat.Size = new System.Drawing.Size(121, 28);
            this.cboMarcaCat.TabIndex = 8;
            this.cboMarcaCat.SelectedIndexChanged += new System.EventHandler(this.cboMarcaCat_SelectedIndexChanged);
            // 
            // frmCatalogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1066, 552);
            this.Controls.Add(this.gbxBusquedaAvanzada);
            this.Controls.Add(this.lbPrecioCat);
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
        private System.Windows.Forms.Label lbPrecioCat;
        private System.Windows.Forms.ComboBox cboCategoriaCat;
        private System.Windows.Forms.GroupBox gbxBusquedaAvanzada;
        private System.Windows.Forms.ComboBox cboMarcaCat;
    }
}

