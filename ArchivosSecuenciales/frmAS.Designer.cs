
namespace ArchivosSecuenciales
{
    partial class frmAS
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
            this.lvProductos = new System.Windows.Forms.ListView();
            this.Clave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clave,
            this.Descripcion,
            this.Precio});
            this.lvProductos.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(65, 74);
            this.lvProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(528, 312);
            this.lvProductos.TabIndex = 2;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            // 
            // Clave
            // 
            this.Clave.Text = "Clave";
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 202;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 187;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasDeProductosToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.modificacionesDeProductosToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // altasDeProductosToolStripMenuItem
            // 
            this.altasDeProductosToolStripMenuItem.Name = "altasDeProductosToolStripMenuItem";
            this.altasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.altasDeProductosToolStripMenuItem.Text = "Altas de Productos";
            this.altasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.altasDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claveToolStripMenuItem,
            this.descripcionToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            // 
            // claveToolStripMenuItem
            // 
            this.claveToolStripMenuItem.Name = "claveToolStripMenuItem";
            this.claveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.claveToolStripMenuItem.Text = "Clave";
            this.claveToolStripMenuItem.Click += new System.EventHandler(this.claveToolStripMenuItem_Click);
            // 
            // descripcionToolStripMenuItem
            // 
            this.descripcionToolStripMenuItem.Name = "descripcionToolStripMenuItem";
            this.descripcionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.descripcionToolStripMenuItem.Text = "Descripcion";
            this.descripcionToolStripMenuItem.Click += new System.EventHandler(this.descripcionToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // modificacionesDeProductosToolStripMenuItem
            // 
            this.modificacionesDeProductosToolStripMenuItem.Name = "modificacionesDeProductosToolStripMenuItem";
            this.modificacionesDeProductosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.modificacionesDeProductosToolStripMenuItem.Text = "Modificaciones de Productos";
            this.modificacionesDeProductosToolStripMenuItem.Click += new System.EventHandler(this.modificacionesDeProductosToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos Secuenciales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader Clave;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

