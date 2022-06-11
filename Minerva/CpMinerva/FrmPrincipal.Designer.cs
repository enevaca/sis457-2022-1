namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProveedores = new C1.Win.Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnOpRegistrarCompra = new C1.Win.Ribbon.RibbonButton();
            this.btnOpRegistrarVenta = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton2 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdmEmpleados = new C1.Win.Ribbon.RibbonButton();
            this.btnAdmUsuarios = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab4 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonButton8 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonButton9 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1200, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Items.Add(this.btnCaProveedores);
            this.ribbonGroup1.Items.Add(this.btnCaClientes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administración de Catálogos";
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("AcceptChanges", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 0));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.ToolTip = "Gestión de Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // btnCaProveedores
            // 
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("Users", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 332));
            this.btnCaProveedores.Name = "btnCaProveedores";
            this.btnCaProveedores.Text = "Proveedores";
            this.btnCaProveedores.ToolTip = "Gestión de Proveedores";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("AddressBook", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 3));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.Text = "Clientes";
            this.btnCaClientes.ToolTip = "Gestión de Clientes";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Groups.Add(this.ribbonGroup5);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Operaciones";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnOpRegistrarCompra);
            this.ribbonGroup2.Items.Add(this.btnOpRegistrarVenta);
            this.ribbonGroup2.Items.Add(this.ribbonButton2);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Caja";
            // 
            // btnOpRegistrarCompra
            // 
            this.btnOpRegistrarCompra.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnOpRegistrarCompra.IconSet.Add(new C1.Framework.C1BitmapIcon("QueryDesign", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 221));
            this.btnOpRegistrarCompra.Name = "btnOpRegistrarCompra";
            this.btnOpRegistrarCompra.Text = "Registrar Compras";
            this.btnOpRegistrarCompra.ToolTip = "Registrar Compras";
            // 
            // btnOpRegistrarVenta
            // 
            this.btnOpRegistrarVenta.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnOpRegistrarVenta.IconSet.Add(new C1.Framework.C1BitmapIcon("OutlineSubtotals", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 192));
            this.btnOpRegistrarVenta.Name = "btnOpRegistrarVenta";
            this.btnOpRegistrarVenta.Text = "Registrar Ventas";
            this.btnOpRegistrarVenta.ToolTip = "Registrar Ventas";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton2.IconSet.Add(new C1.Framework.C1BitmapIcon("MarkCitration", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 162));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.Text = "Arqueo Caja";
            this.ribbonButton2.ToolTip = "Arqueo Caja";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.ribbonButton1);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Reportes";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon("InternetFax", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 153));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.Text = "Ventas del Día";
            this.ribbonButton1.ToolTip = "Ventas del Día";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Administración";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnAdmEmpleados);
            this.ribbonGroup3.Items.Add(this.btnAdmUsuarios);
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Opciones de Administración";
            // 
            // btnAdmEmpleados
            // 
            this.btnAdmEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdmEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("User", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 331));
            this.btnAdmEmpleados.Name = "btnAdmEmpleados";
            this.btnAdmEmpleados.Text = "Empleados";
            this.btnAdmEmpleados.ToolTip = "Gestión de Empleados";
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdmUsuarios.IconSet.Add(new C1.Framework.C1BitmapIcon("Users", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 332));
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Text = "Usuarios";
            this.btnAdmUsuarios.ToolTip = "Gestión de Usuarios";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup4);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Ayuda";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonButton8);
            this.ribbonGroup4.Items.Add(this.ribbonButton9);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Ayuda";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton8.IconSet.Add(new C1.Framework.C1BitmapIcon("Help1", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 132));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.Text = "Manual de Usuario";
            this.ribbonButton8.ToolTip = "Manual de Usuario";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.ribbonButton9.IconSet.Add(new C1.Framework.C1BitmapIcon("Question", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 223));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.Text = "Acerca De";
            this.ribbonButton9.ToolTip = "Acerca De";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinerva.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Principal - Minerva :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonButton btnCaProveedores;
        private C1.Win.Ribbon.RibbonButton btnCaClientes;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnOpRegistrarCompra;
        private C1.Win.Ribbon.RibbonButton btnOpRegistrarVenta;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnAdmEmpleados;
        private C1.Win.Ribbon.RibbonButton btnAdmUsuarios;
        private C1.Win.Ribbon.RibbonTab ribbonTab4;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonButton ribbonButton8;
        private C1.Win.Ribbon.RibbonButton ribbonButton9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.Ribbon.RibbonButton ribbonButton2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton ribbonButton1;
    }
}