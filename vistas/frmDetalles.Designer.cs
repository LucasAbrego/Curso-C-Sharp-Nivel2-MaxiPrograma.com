namespace vistas
{
    partial class frmDetalles
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
            this.lbCategoriaDetalles = new System.Windows.Forms.Label();
            this.lbMarcaDetalles = new System.Windows.Forms.Label();
            this.lbDescripcionDetalles = new System.Windows.Forms.Label();
            this.lbNombreDetalles = new System.Windows.Forms.Label();
            this.lbCodigoDetalles = new System.Windows.Forms.Label();
            this.lbPrecioDetalles = new System.Windows.Forms.Label();
            this.pbxDetalles = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCerrarFrmDetalles = new System.Windows.Forms.Button();
            this.panelBordeInferior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCategoriaDetalles
            // 
            this.lbCategoriaDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaDetalles.Location = new System.Drawing.Point(12, 128);
            this.lbCategoriaDetalles.Name = "lbCategoriaDetalles";
            this.lbCategoriaDetalles.Size = new System.Drawing.Size(427, 40);
            this.lbCategoriaDetalles.TabIndex = 23;
            this.lbCategoriaDetalles.Text = "Categoría";
            // 
            // lbMarcaDetalles
            // 
            this.lbMarcaDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaDetalles.Location = new System.Drawing.Point(12, 88);
            this.lbMarcaDetalles.Name = "lbMarcaDetalles";
            this.lbMarcaDetalles.Size = new System.Drawing.Size(427, 40);
            this.lbMarcaDetalles.TabIndex = 22;
            this.lbMarcaDetalles.Text = "Marca";
            // 
            // lbDescripcionDetalles
            // 
            this.lbDescripcionDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionDetalles.Location = new System.Drawing.Point(12, 171);
            this.lbDescripcionDetalles.Name = "lbDescripcionDetalles";
            this.lbDescripcionDetalles.Size = new System.Drawing.Size(427, 336);
            this.lbDescripcionDetalles.TabIndex = 19;
            this.lbDescripcionDetalles.Text = "Descripción";
            // 
            // lbNombreDetalles
            // 
            this.lbNombreDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreDetalles.ForeColor = System.Drawing.Color.White;
            this.lbNombreDetalles.Location = new System.Drawing.Point(10, 7);
            this.lbNombreDetalles.Name = "lbNombreDetalles";
            this.lbNombreDetalles.Size = new System.Drawing.Size(815, 38);
            this.lbNombreDetalles.TabIndex = 18;
            this.lbNombreDetalles.Text = "Nombre";
            this.lbNombreDetalles.UseCompatibleTextRendering = true;
            // 
            // lbCodigoDetalles
            // 
            this.lbCodigoDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoDetalles.Location = new System.Drawing.Point(12, 48);
            this.lbCodigoDetalles.Name = "lbCodigoDetalles";
            this.lbCodigoDetalles.Size = new System.Drawing.Size(427, 40);
            this.lbCodigoDetalles.TabIndex = 17;
            this.lbCodigoDetalles.Text = "Código";
            // 
            // lbPrecioDetalles
            // 
            this.lbPrecioDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrecioDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioDetalles.Location = new System.Drawing.Point(445, 472);
            this.lbPrecioDetalles.Name = "lbPrecioDetalles";
            this.lbPrecioDetalles.Size = new System.Drawing.Size(428, 35);
            this.lbPrecioDetalles.TabIndex = 25;
            this.lbPrecioDetalles.Text = "Precio";
            this.lbPrecioDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxDetalles
            // 
            this.pbxDetalles.Location = new System.Drawing.Point(445, 50);
            this.pbxDetalles.Name = "pbxDetalles";
            this.pbxDetalles.Size = new System.Drawing.Size(428, 419);
            this.pbxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDetalles.TabIndex = 26;
            this.pbxDetalles.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.btnCerrarFrmDetalles);
            this.panelSuperior.Controls.Add(this.lbNombreDetalles);
            this.panelSuperior.Location = new System.Drawing.Point(0, -1);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(876, 47);
            this.panelSuperior.TabIndex = 27;
            // 
            // btnCerrarFrmDetalles
            // 
            this.btnCerrarFrmDetalles.FlatAppearance.BorderSize = 0;
            this.btnCerrarFrmDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFrmDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFrmDetalles.ForeColor = System.Drawing.Color.White;
            this.btnCerrarFrmDetalles.Location = new System.Drawing.Point(831, 3);
            this.btnCerrarFrmDetalles.Margin = new System.Windows.Forms.Padding(1);
            this.btnCerrarFrmDetalles.Name = "btnCerrarFrmDetalles";
            this.btnCerrarFrmDetalles.Size = new System.Drawing.Size(42, 41);
            this.btnCerrarFrmDetalles.TabIndex = 19;
            this.btnCerrarFrmDetalles.Text = "x";
            this.btnCerrarFrmDetalles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarFrmDetalles.UseVisualStyleBackColor = true;
            this.btnCerrarFrmDetalles.Click += new System.EventHandler(this.btnCerrarFrmDetalles_Click);
            // 
            // panelBordeInferior
            // 
            this.panelBordeInferior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBordeInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.panelBordeInferior.Location = new System.Drawing.Point(0, 514);
            this.panelBordeInferior.Name = "panelBordeInferior";
            this.panelBordeInferior.Size = new System.Drawing.Size(876, 1);
            this.panelBordeInferior.TabIndex = 28;
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 516);
            this.Controls.Add(this.panelBordeInferior);
            this.Controls.Add(this.pbxDetalles);
            this.Controls.Add(this.lbPrecioDetalles);
            this.Controls.Add(this.lbCategoriaDetalles);
            this.Controls.Add(this.lbMarcaDetalles);
            this.Controls.Add(this.lbDescripcionDetalles);
            this.Controls.Add(this.lbCodigoDetalles);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCategoriaDetalles;
        private System.Windows.Forms.Label lbMarcaDetalles;
        private System.Windows.Forms.Label lbDescripcionDetalles;
        private System.Windows.Forms.Label lbNombreDetalles;
        private System.Windows.Forms.Label lbCodigoDetalles;
        private System.Windows.Forms.Label lbPrecioDetalles;
        private System.Windows.Forms.PictureBox pbxDetalles;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnCerrarFrmDetalles;
        private System.Windows.Forms.Panel panelBordeInferior;
    }
}