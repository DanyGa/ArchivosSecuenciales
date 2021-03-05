
namespace ArchivosSecuenciales
{
    partial class DialogBoxAltasProductos
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
            this.lblClave = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPrecioA = new System.Windows.Forms.TextBox();
            this.txtDesA = new System.Windows.Forms.TextBox();
            this.txtClaveA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(48, 53);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(47, 17);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(48, 87);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripcion:";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(59, 144);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(52, 17);
            this.lblPre.TabIndex = 2;
            this.lblPre.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(83, 219);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 50);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(233, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.Location = new System.Drawing.Point(204, 139);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(200, 22);
            this.txtPrecioA.TabIndex = 5;
            // 
            // txtDesA
            // 
            this.txtDesA.Location = new System.Drawing.Point(204, 82);
            this.txtDesA.Name = "txtDesA";
            this.txtDesA.Size = new System.Drawing.Size(200, 22);
            this.txtDesA.TabIndex = 6;
            // 
            // txtClaveA
            // 
            this.txtClaveA.Location = new System.Drawing.Point(204, 33);
            this.txtClaveA.Name = "txtClaveA";
            this.txtClaveA.Size = new System.Drawing.Size(200, 22);
            this.txtClaveA.TabIndex = 7;
            // 
            // DialogBoxAltasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.ControlBox = false;
            this.Controls.Add(this.txtClaveA);
            this.Controls.Add(this.txtDesA);
            this.Controls.Add(this.txtPrecioA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblClave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxAltasProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPrecioA;
        private System.Windows.Forms.TextBox txtDesA;
        private System.Windows.Forms.TextBox txtClaveA;
    }
}