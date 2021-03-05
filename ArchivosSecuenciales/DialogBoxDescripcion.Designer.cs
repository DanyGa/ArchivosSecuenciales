
namespace ArchivosSecuenciales
{
    partial class DialogBoxDescripcion
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
            this.txtDesD = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDesD
            // 
            this.txtDesD.Location = new System.Drawing.Point(120, 62);
            this.txtDesD.Name = "txtDesD";
            this.txtDesD.Size = new System.Drawing.Size(200, 22);
            this.txtDesD.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 62);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(86, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripcion:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscar.Location = new System.Drawing.Point(105, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // DialogBoxDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesD);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxDescripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta por Descripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesD;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnBuscar;
    }
}