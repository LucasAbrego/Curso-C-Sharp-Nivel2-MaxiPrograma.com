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
            this.btnCatAgregar = new System.Windows.Forms.Button();
            this.btnCatModificar = new System.Windows.Forms.Button();
            this.btnCatEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCatalogo
            // 
            this.pbxCatalogo.Location = new System.Drawing.Point(693, 42);
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
            this.dgvCatalogo.Location = new System.Drawing.Point(13, 42);
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
            // btnCatAgregar
            // 
            this.btnCatAgregar.Location = new System.Drawing.Point(13, 398);
            this.btnCatAgregar.Name = "btnCatAgregar";
            this.btnCatAgregar.Size = new System.Drawing.Size(120, 40);
            this.btnCatAgregar.TabIndex = 2;
            this.btnCatAgregar.Text = "Agregar";
            this.btnCatAgregar.UseVisualStyleBackColor = true;
            this.btnCatAgregar.Click += new System.EventHandler(this.btnCatAgregar_Click);
            // 
            // btnCatModificar
            // 
            this.btnCatModificar.Location = new System.Drawing.Point(152, 398);
            this.btnCatModificar.Name = "btnCatModificar";
            this.btnCatModificar.Size = new System.Drawing.Size(120, 40);
            this.btnCatModificar.TabIndex = 3;
            this.btnCatModificar.Text = "Modificar";
            this.btnCatModificar.UseVisualStyleBackColor = true;
            this.btnCatModificar.Click += new System.EventHandler(this.btnCatModificar_Click);
            // 
            // btnCatEliminar
            // 
            this.btnCatEliminar.Location = new System.Drawing.Point(290, 398);
            this.btnCatEliminar.Name = "btnCatEliminar";
            this.btnCatEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnCatEliminar.TabIndex = 4;
            this.btnCatEliminar.Text = "Eliminar";
            this.btnCatEliminar.UseVisualStyleBackColor = true;
            // 
            // frmCatalogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1066, 552);
            this.Controls.Add(this.btnCatEliminar);
            this.Controls.Add(this.btnCatModificar);
            this.Controls.Add(this.btnCatAgregar);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.pbxCatalogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de productos";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCatalogo;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Button btnCatAgregar;
        private System.Windows.Forms.Button btnCatModificar;
        private System.Windows.Forms.Button btnCatEliminar;
    }
}

