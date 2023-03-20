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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCerrarBusquedaAv = new System.Windows.Forms.Button();
            this.btnLimpiarBusquedaAv = new System.Windows.Forms.Button();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.txtPrecioMaximo = new System.Windows.Forms.TextBox();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.cboMarcaCat = new System.Windows.Forms.ComboBox();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.btnTodoCat = new System.Windows.Forms.Button();
            this.btnLimpiarTxtBusqueda = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.gbxBusquedaAvanzada.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCatalogo
            // 
            this.pbxCatalogo.BackColor = System.Drawing.Color.White;
            this.pbxCatalogo.Location = new System.Drawing.Point(608, 0);
            this.pbxCatalogo.Name = "pbxCatalogo";
            this.pbxCatalogo.Size = new System.Drawing.Size(389, 403);
            this.pbxCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCatalogo.TabIndex = 0;
            this.pbxCatalogo.TabStop = false;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(120, 0);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowHeadersWidth = 62;
            this.dgvCatalogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatalogo.RowTemplate.Height = 28;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(485, 403);
            this.dgvCatalogo.TabIndex = 1;
            this.dgvCatalogo.SelectionChanged += new System.EventHandler(this.dgvCatalogo_SelectionChanged);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarCat.FlatAppearance.BorderSize = 0;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCat.Location = new System.Drawing.Point(0, 12);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(119, 40);
            this.btnAgregarCat.TabIndex = 2;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnCatAgregar_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificarCat.FlatAppearance.BorderSize = 0;
            this.btnModificarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCat.ForeColor = System.Drawing.Color.White;
            this.btnModificarCat.Location = new System.Drawing.Point(0, 58);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(119, 40);
            this.btnModificarCat.TabIndex = 3;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = false;
            this.btnModificarCat.Click += new System.EventHandler(this.btnCatModificar_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminarCat.FlatAppearance.BorderSize = 0;
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCat.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCat.Location = new System.Drawing.Point(0, 104);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(119, 40);
            this.btnEliminarCat.TabIndex = 4;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnCatEliminar_Click);
            // 
            // txtBuscarCat
            // 
            this.txtBuscarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCat.Location = new System.Drawing.Point(120, 408);
            this.txtBuscarCat.MaxLength = 50;
            this.txtBuscarCat.Name = "txtBuscarCat";
            this.txtBuscarCat.Size = new System.Drawing.Size(460, 32);
            this.txtBuscarCat.TabIndex = 5;
            this.txtBuscarCat.TextChanged += new System.EventHandler(this.txtBuscarCatalogo_TextChanged);
            // 
            // lbMarcaCat
            // 
            this.lbMarcaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaCat.ForeColor = System.Drawing.Color.White;
            this.lbMarcaCat.Location = new System.Drawing.Point(1, 25);
            this.lbMarcaCat.Name = "lbMarcaCat";
            this.lbMarcaCat.Size = new System.Drawing.Size(109, 40);
            this.lbMarcaCat.TabIndex = 6;
            this.lbMarcaCat.Text = "Marca";
            this.lbMarcaCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCategoríaCat
            // 
            this.lbCategoríaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoríaCat.ForeColor = System.Drawing.Color.White;
            this.lbCategoríaCat.Location = new System.Drawing.Point(1, 68);
            this.lbCategoríaCat.Name = "lbCategoríaCat";
            this.lbCategoríaCat.Size = new System.Drawing.Size(109, 40);
            this.lbCategoríaCat.TabIndex = 6;
            this.lbCategoríaCat.Text = "Categoría";
            this.lbCategoríaCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMinimo
            // 
            this.lbMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimo.ForeColor = System.Drawing.Color.White;
            this.lbMinimo.Location = new System.Drawing.Point(1, 111);
            this.lbMinimo.Name = "lbMinimo";
            this.lbMinimo.Size = new System.Drawing.Size(109, 40);
            this.lbMinimo.TabIndex = 6;
            this.lbMinimo.Text = "Mínimo";
            this.lbMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategoriaCat
            // 
            this.cboCategoriaCat.BackColor = System.Drawing.Color.White;
            this.cboCategoriaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaCat.FormattingEnabled = true;
            this.cboCategoriaCat.Location = new System.Drawing.Point(108, 72);
            this.cboCategoriaCat.Name = "cboCategoriaCat";
            this.cboCategoriaCat.Size = new System.Drawing.Size(141, 34);
            this.cboCategoriaCat.TabIndex = 8;
            // 
            // gbxBusquedaAvanzada
            // 
            this.gbxBusquedaAvanzada.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbxBusquedaAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbxBusquedaAvanzada.Controls.Add(this.btnCerrarBusquedaAv);
            this.gbxBusquedaAvanzada.Controls.Add(this.btnLimpiarBusquedaAv);
            this.gbxBusquedaAvanzada.Controls.Add(this.btnBuscarCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.txtPrecioMaximo);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbMinimo);
            this.gbxBusquedaAvanzada.Controls.Add(this.txtPrecioMinimo);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboMarcaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbCategoríaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.cboCategoriaCat);
            this.gbxBusquedaAvanzada.Controls.Add(this.lbMaximo);
            this.gbxBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBusquedaAvanzada.ForeColor = System.Drawing.Color.White;
            this.gbxBusquedaAvanzada.Location = new System.Drawing.Point(120, 204);
            this.gbxBusquedaAvanzada.Name = "gbxBusquedaAvanzada";
            this.gbxBusquedaAvanzada.Size = new System.Drawing.Size(256, 233);
            this.gbxBusquedaAvanzada.TabIndex = 9;
            this.gbxBusquedaAvanzada.TabStop = false;
            // 
            // btnCerrarBusquedaAv
            // 
            this.btnCerrarBusquedaAv.FlatAppearance.BorderSize = 0;
            this.btnCerrarBusquedaAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBusquedaAv.Location = new System.Drawing.Point(231, 0);
            this.btnCerrarBusquedaAv.Name = "btnCerrarBusquedaAv";
            this.btnCerrarBusquedaAv.Size = new System.Drawing.Size(25, 25);
            this.btnCerrarBusquedaAv.TabIndex = 12;
            this.btnCerrarBusquedaAv.Text = "X";
            this.btnCerrarBusquedaAv.UseVisualStyleBackColor = true;
            this.btnCerrarBusquedaAv.Click += new System.EventHandler(this.btnCerrarBusquedaAv_Click);
            // 
            // btnLimpiarBusquedaAv
            // 
            this.btnLimpiarBusquedaAv.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusquedaAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaAv.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusquedaAv.Location = new System.Drawing.Point(0, 0);
            this.btnLimpiarBusquedaAv.Name = "btnLimpiarBusquedaAv";
            this.btnLimpiarBusquedaAv.Size = new System.Drawing.Size(235, 25);
            this.btnLimpiarBusquedaAv.TabIndex = 14;
            this.btnLimpiarBusquedaAv.Text = "Limpiar";
            this.btnLimpiarBusquedaAv.UseVisualStyleBackColor = true;
            this.btnLimpiarBusquedaAv.Click += new System.EventHandler(this.btnLimpiarBusquedaAv_Click);
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.FlatAppearance.BorderSize = 0;
            this.btnBuscarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCat.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCat.Location = new System.Drawing.Point(6, 189);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(243, 40);
            this.btnBuscarCat.TabIndex = 13;
            this.btnBuscarCat.Text = "Buscar";
            this.btnBuscarCat.UseVisualStyleBackColor = true;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.Location = new System.Drawing.Point(108, 156);
            this.txtPrecioMaximo.MaxLength = 38;
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(141, 32);
            this.txtPrecioMaximo.TabIndex = 11;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Location = new System.Drawing.Point(108, 115);
            this.txtPrecioMinimo.MaxLength = 38;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(141, 32);
            this.txtPrecioMinimo.TabIndex = 10;
            // 
            // cboMarcaCat
            // 
            this.cboMarcaCat.BackColor = System.Drawing.Color.White;
            this.cboMarcaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaCat.FormattingEnabled = true;
            this.cboMarcaCat.Location = new System.Drawing.Point(108, 29);
            this.cboMarcaCat.Name = "cboMarcaCat";
            this.cboMarcaCat.Size = new System.Drawing.Size(141, 34);
            this.cboMarcaCat.TabIndex = 8;
            // 
            // lbMaximo
            // 
            this.lbMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaximo.ForeColor = System.Drawing.Color.White;
            this.lbMaximo.Location = new System.Drawing.Point(1, 152);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(109, 40);
            this.lbMaximo.TabIndex = 6;
            this.lbMaximo.Text = "Máximo";
            this.lbMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTodoCat
            // 
            this.btnTodoCat.FlatAppearance.BorderSize = 0;
            this.btnTodoCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoCat.ForeColor = System.Drawing.Color.White;
            this.btnTodoCat.Location = new System.Drawing.Point(1, 280);
            this.btnTodoCat.Name = "btnTodoCat";
            this.btnTodoCat.Size = new System.Drawing.Size(118, 37);
            this.btnTodoCat.TabIndex = 10;
            this.btnTodoCat.Text = "Traer Todo";
            this.btnTodoCat.UseVisualStyleBackColor = true;
            this.btnTodoCat.Click += new System.EventHandler(this.btnTodoCat_Click);
            // 
            // btnLimpiarTxtBusqueda
            // 
            this.btnLimpiarTxtBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarTxtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarTxtBusqueda.Location = new System.Drawing.Point(579, 407);
            this.btnLimpiarTxtBusqueda.Name = "btnLimpiarTxtBusqueda";
            this.btnLimpiarTxtBusqueda.Size = new System.Drawing.Size(26, 26);
            this.btnLimpiarTxtBusqueda.TabIndex = 10;
            this.btnLimpiarTxtBusqueda.Text = "X";
            this.btnLimpiarTxtBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarTxtBusqueda.Click += new System.EventHandler(this.btnLimpiarTxtBusqueda_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(0, 150);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(119, 40);
            this.btnDetalles.TabIndex = 4;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAgregarCat);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnTodoCat);
            this.panel1.Controls.Add(this.btnBusquedaAvanzada);
            this.panel1.Controls.Add(this.btnModificarCat);
            this.panel1.Controls.Add(this.btnEliminarCat);
            this.panel1.Controls.Add(this.btnDetalles);
            this.panel1.ForeColor = System.Drawing.Color.CadetBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 444);
            this.panel1.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.ForeColor = System.Drawing.Color.White;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(0, 217);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(119, 65);
            this.btnBusquedaAvanzada.TabIndex = 5;
            this.btnBusquedaAvanzada.Text = "Busqueda\r\nAvanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 440);
            this.Controls.Add(this.gbxBusquedaAvanzada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarTxtBusqueda);
            this.Controls.Add(this.txtBuscarCat);
            this.Controls.Add(this.pbxCatalogo);
            this.Controls.Add(this.dgvCatalogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCatalogo";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de productos";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.gbxBusquedaAvanzada.ResumeLayout(false);
            this.gbxBusquedaAvanzada.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtPrecioMaximo;
        private System.Windows.Forms.TextBox txtPrecioMinimo;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.Button btnTodoCat;
        private System.Windows.Forms.Button btnLimpiarTxtBusqueda;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarBusquedaAv;
        private System.Windows.Forms.Button btnLimpiarBusquedaAv;
        private System.Windows.Forms.Button btnBuscarCat;
    }
}

