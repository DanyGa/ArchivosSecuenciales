
namespace ArchivosSecuenciales
{
    partial class DialogBoxModificacionProductos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClaveM = new System.Windows.Forms.TextBox();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.txtDesM = new System.Windows.Forms.TextBox();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(127, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 50);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(29, 44);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(47, 17);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave:";
            // 
            // txtClaveM
            // 
            this.txtClaveM.Location = new System.Drawing.Point(226, 44);
            this.txtClaveM.Name = "txtClaveM";
            this.txtClaveM.Size = new System.Drawing.Size(200, 22);
            this.txtClaveM.TabIndex = 2;
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.txtDesM);
            this.gbModificar.Controls.Add(this.txtPrecioM);
            this.gbModificar.Controls.Add(this.lblPrecio);
            this.gbModificar.Controls.Add(this.lblDesc);
            this.gbModificar.Controls.Add(this.btnAceptar);
            this.gbModificar.Enabled = false;
            this.gbModificar.Location = new System.Drawing.Point(68, 267);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(331, 215);
            this.gbModificar.TabIndex = 3;
            this.gbModificar.TabStop = false;
            // 
            // txtDesM
            // 
            this.txtDesM.Location = new System.Drawing.Point(106, 34);
            this.txtDesM.Name = "txtDesM";
            this.txtDesM.Size = new System.Drawing.Size(200, 22);
            this.txtDesM.TabIndex = 4;
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.Location = new System.Drawing.Point(106, 87);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(200, 22);
            this.txtPrecioM.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(14, 90);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(14, 39);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripcion:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(115, 130);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 50);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // DialogBoxModificacionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 660);
            this.ControlBox = false;
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.txtClaveM);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxModificacionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de Productos";
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClaveM;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.TextBox txtDesM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAceptar;
    }
}