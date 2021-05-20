
namespace appVentas.Vista
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.panelSuperior1 = new System.Windows.Forms.Panel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDocumentos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelPrincipal.SuspendLayout();
            this.panelSuperior1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelContenedor);
            this.panelPrincipal.Controls.Add(this.panelInferior);
            this.panelPrincipal.Controls.Add(this.panelSuperior1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.MinimumSize = new System.Drawing.Size(960, 480);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1200, 700);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Location = new System.Drawing.Point(237, 87);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(951, 527);
            this.panelContenedor.TabIndex = 2;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.SteelBlue;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 620);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1200, 80);
            this.panelInferior.TabIndex = 1;
            // 
            // panelSuperior1
            // 
            this.panelSuperior1.AllowDrop = true;
            this.panelSuperior1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuperior1.Controls.Add(this.btnDefault);
            this.panelSuperior1.Controls.Add(this.btnRestaurar);
            this.panelSuperior1.Controls.Add(this.btnAmpliar);
            this.panelSuperior1.Controls.Add(this.btnMinimizar);
            this.panelSuperior1.Controls.Add(this.btnCerrar);
            this.panelSuperior1.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior1.Name = "panelSuperior1";
            this.panelSuperior1.Size = new System.Drawing.Size(1200, 85);
            this.panelSuperior1.TabIndex = 1;
            this.panelSuperior1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior1_MouseDown);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnDefault.Image")));
            this.btnDefault.ImageActive = null;
            this.btnDefault.Location = new System.Drawing.Point(237, 12);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(50, 50);
            this.btnDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDefault.TabIndex = 1;
            this.btnDefault.TabStop = false;
            this.btnDefault.Zoom = 10;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestaurar.Image = global::appVentas.Properties.Resources.dentro;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestaurar.Location = new System.Drawing.Point(1122, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 41);
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAmpliar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAmpliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmpliar.FlatAppearance.BorderSize = 0;
            this.btnAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmpliar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpliar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmpliar.Image = global::appVentas.Properties.Resources.fuera;
            this.btnAmpliar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAmpliar.Location = new System.Drawing.Point(1122, 3);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(36, 41);
            this.btnAmpliar.TabIndex = 10;
            this.btnAmpliar.UseVisualStyleBackColor = false;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = global::appVentas.Properties.Resources.menos;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1080, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 33);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::appVentas.Properties.Resources.cerrar__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1164, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSideBar.Controls.Add(this.bunifuSeparator2);
            this.panelSideBar.Controls.Add(this.btnUsuarios);
            this.panelSideBar.Controls.Add(this.btnDocumentos);
            this.panelSideBar.Controls.Add(this.btnClientes);
            this.panelSideBar.Controls.Add(this.btnProductos);
            this.panelSideBar.Controls.Add(this.bunifuSeparator1);
            this.panelSideBar.Controls.Add(this.lblCorreo);
            this.panelSideBar.Controls.Add(this.btnPerfil);
            this.panelSideBar.Controls.Add(this.label2);
            this.panelSideBar.Controls.Add(this.label1);
            this.panelSideBar.Controls.Add(this.bunifuImageButton1);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 700);
            this.panelSideBar.TabIndex = 1;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 532);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(224, 35);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 7;
            this.btnUsuarios.ButtonText = "Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = global::appVentas.Properties.Resources.video_chat;
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 90D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(22, 469);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.White;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = false;
            this.btnUsuarios.Size = new System.Drawing.Size(192, 48);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuarios.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnDocumentos.BackColor = System.Drawing.Color.White;
            this.btnDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDocumentos.BorderRadius = 7;
            this.btnDocumentos.ButtonText = "Documentos";
            this.btnDocumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocumentos.DisabledColor = System.Drawing.Color.Gray;
            this.btnDocumentos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDocumentos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDocumentos.Iconimage = global::appVentas.Properties.Resources.article;
            this.btnDocumentos.Iconimage_right = null;
            this.btnDocumentos.Iconimage_right_Selected = null;
            this.btnDocumentos.Iconimage_Selected = null;
            this.btnDocumentos.IconMarginLeft = 0;
            this.btnDocumentos.IconMarginRight = 0;
            this.btnDocumentos.IconRightVisible = true;
            this.btnDocumentos.IconRightZoom = 0D;
            this.btnDocumentos.IconVisible = true;
            this.btnDocumentos.IconZoom = 90D;
            this.btnDocumentos.IsTab = false;
            this.btnDocumentos.Location = new System.Drawing.Point(22, 367);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Normalcolor = System.Drawing.Color.White;
            this.btnDocumentos.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnDocumentos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDocumentos.selected = false;
            this.btnDocumentos.Size = new System.Drawing.Size(192, 48);
            this.btnDocumentos.TabIndex = 8;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDocumentos.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnDocumentos.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 7;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = global::appVentas.Properties.Resources.group;
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(22, 270);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.White;
            this.btnClientes.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(192, 48);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnClientes.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 7;
            this.btnProductos.ButtonText = "Productos";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = global::appVentas.Properties.Resources.shopping_cart;
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = null;
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 90D;
            this.btnProductos.IsTab = false;
            this.btnProductos.Location = new System.Drawing.Point(22, 171);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.White;
            this.btnProductos.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(192, 48);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductos.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnProductos.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 130);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(224, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(88, 63);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(15, 13);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "- -";
            // 
            // btnPerfil
            // 
            this.btnPerfil.ActiveBorderThickness = 1;
            this.btnPerfil.ActiveCornerRadius = 20;
            this.btnPerfil.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.ActiveForecolor = System.Drawing.Color.White;
            this.btnPerfil.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.ButtonText = "Editar Perfil";
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPerfil.IdleBorderThickness = 1;
            this.btnPerfil.IdleCornerRadius = 20;
            this.btnPerfil.IdleFillColor = System.Drawing.Color.White;
            this.btnPerfil.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.Location = new System.Drawing.Point(12, 93);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(202, 41);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perfil";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 70);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panelContenedor;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelSuperior1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 650);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Ventas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelSuperior1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSuperior1;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelInferior;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnAmpliar;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label lblCorreo;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnDocumentos;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}