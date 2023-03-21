namespace vistas
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbImagenUrl = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.pbxAlta = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lbAlta = new System.Windows.Forms.Label();
            this.panelBordeInferior = new System.Windows.Forms.Panel();
            this.lbRequeridoCodigo = new System.Windows.Forms.Label();
            this.lbRequeridoNombre = new System.Windows.Forms.Label();
            this.lbRequeridoPrecio = new System.Windows.Forms.Label();
            this.panelBordeCodigo = new System.Windows.Forms.Panel();
            this.panelBordeNombre = new System.Windows.Forms.Panel();
            this.panelBordePrecio = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCodigo.Location = new System.Drawing.Point(9, 89);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(102, 29);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código*";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNombre.Location = new System.Drawing.Point(9, 158);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(111, 29);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre*";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDescripcion.Location = new System.Drawing.Point(9, 503);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(141, 29);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbImagenUrl
            // 
            this.lbImagenUrl.AutoSize = true;
            this.lbImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbImagenUrl.Location = new System.Drawing.Point(9, 434);
            this.lbImagenUrl.Name = "lbImagenUrl";
            this.lbImagenUrl.Size = new System.Drawing.Size(146, 29);
            this.lbImagenUrl.TabIndex = 3;
            this.lbImagenUrl.Text = "URL Imagen";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPrecio.Location = new System.Drawing.Point(9, 227);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(93, 29);
            this.lbPrecio.TabIndex = 4;
            this.lbPrecio.Text = "Precio*";
            // 
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarAlta.FlatAppearance.BorderSize = 0;
            this.btnAceptarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptarAlta.ForeColor = System.Drawing.Color.White;
            this.btnAceptarAlta.Location = new System.Drawing.Point(436, 0);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(150, 55);
            this.btnAceptarAlta.TabIndex = 7;
            this.btnAceptarAlta.Text = "Aceptar";
            this.btnAceptarAlta.UseVisualStyleBackColor = true;
            this.btnAceptarAlta.Click += new System.EventHandler(this.btnAceptarAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.FlatAppearance.BorderSize = 0;
            this.btnCancelarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelarAlta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAlta.Location = new System.Drawing.Point(599, 0);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(150, 55);
            this.btnCancelarAlta.TabIndex = 8;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // pbxAlta
            // 
            this.pbxAlta.Location = new System.Drawing.Point(436, 86);
            this.pbxAlta.Name = "pbxAlta";
            this.pbxAlta.Size = new System.Drawing.Size(313, 313);
            this.pbxAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAlta.TabIndex = 7;
            this.pbxAlta.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(159, 155);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(159, 86);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(259, 35);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(159, 500);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(590, 131);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtImagenUrl.Location = new System.Drawing.Point(159, 431);
            this.txtImagenUrl.MaxLength = 1000;
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(469, 35);
            this.txtImagenUrl.TabIndex = 5;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecio.Location = new System.Drawing.Point(159, 224);
            this.txtPrecio.MaxLength = 38;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(259, 35);
            this.txtPrecio.TabIndex = 6;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(159, 293);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(259, 37);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(159, 362);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(259, 37);
            this.cboCategoria.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCategoria.Location = new System.Drawing.Point(9, 365);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(118, 29);
            this.lbCategoria.TabIndex = 16;
            this.lbCategoria.Text = "Categoría";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMarca.Location = new System.Drawing.Point(9, 296);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(79, 29);
            this.lbMarca.TabIndex = 15;
            this.lbMarca.Text = "Marca";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.lbAlta);
            this.panelSuperior.Controls.Add(this.btnCancelarAlta);
            this.panelSuperior.Controls.Add(this.btnAceptarAlta);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(764, 55);
            this.panelSuperior.TabIndex = 17;
            // 
            // lbAlta
            // 
            this.lbAlta.AutoSize = true;
            this.lbAlta.CausesValidation = false;
            this.lbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlta.ForeColor = System.Drawing.Color.White;
            this.lbAlta.Location = new System.Drawing.Point(10, 9);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(203, 37);
            this.lbAlta.TabIndex = 9;
            this.lbAlta.Text = "Alta Artículo";
            // 
            // panelBordeInferior
            // 
            this.panelBordeInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panelBordeInferior.Location = new System.Drawing.Point(0, 642);
            this.panelBordeInferior.Name = "panelBordeInferior";
            this.panelBordeInferior.Size = new System.Drawing.Size(764, 1);
            this.panelBordeInferior.TabIndex = 18;
            // 
            // lbRequeridoCodigo
            // 
            this.lbRequeridoCodigo.AutoSize = true;
            this.lbRequeridoCodigo.BackColor = System.Drawing.Color.White;
            this.lbRequeridoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbRequeridoCodigo.ForeColor = System.Drawing.Color.Red;
            this.lbRequeridoCodigo.Location = new System.Drawing.Point(256, 58);
            this.lbRequeridoCodigo.Name = "lbRequeridoCodigo";
            this.lbRequeridoCodigo.Size = new System.Drawing.Size(162, 22);
            this.lbRequeridoCodigo.TabIndex = 19;
            this.lbRequeridoCodigo.Text = "Campo Requerido*";
            // 
            // lbRequeridoNombre
            // 
            this.lbRequeridoNombre.AutoSize = true;
            this.lbRequeridoNombre.BackColor = System.Drawing.Color.White;
            this.lbRequeridoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequeridoNombre.ForeColor = System.Drawing.Color.Red;
            this.lbRequeridoNombre.Location = new System.Drawing.Point(256, 130);
            this.lbRequeridoNombre.Name = "lbRequeridoNombre";
            this.lbRequeridoNombre.Size = new System.Drawing.Size(162, 22);
            this.lbRequeridoNombre.TabIndex = 20;
            this.lbRequeridoNombre.Text = "Campo Requerido*";
            // 
            // lbRequeridoPrecio
            // 
            this.lbRequeridoPrecio.AutoSize = true;
            this.lbRequeridoPrecio.BackColor = System.Drawing.Color.White;
            this.lbRequeridoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbRequeridoPrecio.ForeColor = System.Drawing.Color.Red;
            this.lbRequeridoPrecio.Location = new System.Drawing.Point(256, 199);
            this.lbRequeridoPrecio.Name = "lbRequeridoPrecio";
            this.lbRequeridoPrecio.Size = new System.Drawing.Size(162, 22);
            this.lbRequeridoPrecio.TabIndex = 21;
            this.lbRequeridoPrecio.Text = "Campo Requerido*";
            // 
            // panelBordeCodigo
            // 
            this.panelBordeCodigo.BackColor = System.Drawing.Color.Red;
            this.panelBordeCodigo.Location = new System.Drawing.Point(158, 84);
            this.panelBordeCodigo.Name = "panelBordeCodigo";
            this.panelBordeCodigo.Size = new System.Drawing.Size(264, 33);
            this.panelBordeCodigo.TabIndex = 22;
            // 
            // panelBordeNombre
            // 
            this.panelBordeNombre.BackColor = System.Drawing.Color.Red;
            this.panelBordeNombre.Location = new System.Drawing.Point(158, 154);
            this.panelBordeNombre.Name = "panelBordeNombre";
            this.panelBordeNombre.Size = new System.Drawing.Size(264, 33);
            this.panelBordeNombre.TabIndex = 23;
            // 
            // panelBordePrecio
            // 
            this.panelBordePrecio.BackColor = System.Drawing.Color.Red;
            this.panelBordePrecio.Location = new System.Drawing.Point(158, 223);
            this.panelBordePrecio.Name = "panelBordePrecio";
            this.panelBordePrecio.Size = new System.Drawing.Size(264, 33);
            this.panelBordePrecio.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(634, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelarAlta;
            this.ClientSize = new System.Drawing.Size(763, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRequeridoPrecio);
            this.Controls.Add(this.lbRequeridoNombre);
            this.Controls.Add(this.panelBordeInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbxAlta);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagenUrl);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbRequeridoCodigo);
            this.Controls.Add(this.panelBordeCodigo);
            this.Controls.Add(this.panelBordePrecio);
            this.Controls.Add(this.panelBordeNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbImagenUrl;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.PictureBox pbxAlta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lbAlta;
        private System.Windows.Forms.Panel panelBordeInferior;
        private System.Windows.Forms.Label lbRequeridoCodigo;
        private System.Windows.Forms.Label lbRequeridoNombre;
        private System.Windows.Forms.Label lbRequeridoPrecio;
        private System.Windows.Forms.Panel panelBordeCodigo;
        private System.Windows.Forms.Panel panelBordeNombre;
        private System.Windows.Forms.Panel panelBordePrecio;
        private System.Windows.Forms.Button button1;
    }
}