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
            this.pbxCat = new System.Windows.Forms.PictureBox();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnCatAgregar = new System.Windows.Forms.Button();
            this.btnCatModificar = new System.Windows.Forms.Button();
            this.btnCatEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCat
            // 
            this.pbxCat.Location = new System.Drawing.Point(529, 42);
            this.pbxCat.Name = "pbxCat";
            this.pbxCat.Size = new System.Drawing.Size(231, 227);
            this.pbxCat.TabIndex = 0;
            this.pbxCat.TabStop = false;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(13, 42);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.RowHeadersWidth = 62;
            this.dgvCatalogo.RowTemplate.Height = 28;
            this.dgvCatalogo.Size = new System.Drawing.Size(495, 338);
            this.dgvCatalogo.TabIndex = 1;
            // 
            // btnCatAgregar
            // 
            this.btnCatAgregar.Location = new System.Drawing.Point(13, 398);
            this.btnCatAgregar.Name = "btnCatAgregar";
            this.btnCatAgregar.Size = new System.Drawing.Size(120, 40);
            this.btnCatAgregar.TabIndex = 2;
            this.btnCatAgregar.Text = "Agregar";
            this.btnCatAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCatModificar
            // 
            this.btnCatModificar.Location = new System.Drawing.Point(152, 398);
            this.btnCatModificar.Name = "btnCatModificar";
            this.btnCatModificar.Size = new System.Drawing.Size(120, 40);
            this.btnCatModificar.TabIndex = 3;
            this.btnCatModificar.Text = "Modificar";
            this.btnCatModificar.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCatEliminar);
            this.Controls.Add(this.btnCatModificar);
            this.Controls.Add(this.btnCatAgregar);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.pbxCat);
            this.Name = "frmCatalogo";
            this.Text = "Catálogo de productos";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCat;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Button btnCatAgregar;
        private System.Windows.Forms.Button btnCatModificar;
        private System.Windows.Forms.Button btnCatEliminar;
    }
}

