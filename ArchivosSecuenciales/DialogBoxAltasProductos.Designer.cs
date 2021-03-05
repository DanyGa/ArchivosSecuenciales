
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
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.Snow;
            this.lblClave.Location = new System.Drawing.Point(36, 33);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(74, 23);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Snow;
            this.lblDesc.Location = new System.Drawing.Point(36, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(132, 23);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripcion:";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.ForeColor = System.Drawing.Color.Snow;
            this.lblPre.Location = new System.Drawing.Point(36, 139);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(77, 23);
            this.lblPre.TabIndex = 2;
            this.lblPre.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Snow;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(74, 205);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 50);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Snow;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(243, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtPrecioA
            // 
            this.txtPrecioA.BackColor = System.Drawing.Color.Snow;
            this.txtPrecioA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtPrecioA.Location = new System.Drawing.Point(204, 132);
            this.txtPrecioA.Name = "txtPrecioA";
            this.txtPrecioA.Size = new System.Drawing.Size(200, 30);
            this.txtPrecioA.TabIndex = 5;
            // 
            // txtDesA
            // 
            this.txtDesA.BackColor = System.Drawing.Color.Snow;
            this.txtDesA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDesA.Location = new System.Drawing.Point(204, 82);
            this.txtDesA.Name = "txtDesA";
            this.txtDesA.Size = new System.Drawing.Size(200, 30);
            this.txtDesA.TabIndex = 6;
            // 
            // txtClaveA
            // 
            this.txtClaveA.BackColor = System.Drawing.Color.Snow;
            this.txtClaveA.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtClaveA.Location = new System.Drawing.Point(204, 31);
            this.txtClaveA.Name = "txtClaveA";
            this.txtClaveA.Size = new System.Drawing.Size(200, 30);
            this.txtClaveA.TabIndex = 7;
            // 
            // DialogBoxAltasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
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