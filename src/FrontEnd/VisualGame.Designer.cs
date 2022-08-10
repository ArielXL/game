namespace FrontEnd
{
    partial class frmVisualGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualGame));
            this.menuStripPlay = new System.Windows.Forms.MenuStrip();
            this.pbxBoard = new System.Windows.Forms.PictureBox();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPlay
            // 
            this.menuStripPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.opcioneToolStripMenuItem});
            this.menuStripPlay.Location = new System.Drawing.Point(0, 0);
            this.menuStripPlay.Name = "menuStripPlay";
            this.menuStripPlay.Size = new System.Drawing.Size(584, 24);
            this.menuStripPlay.TabIndex = 0;
            this.menuStripPlay.Text = "mnsGame";
            // 
            // pbxBoard
            // 
            this.pbxBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBoard.Location = new System.Drawing.Point(12, 27);
            this.pbxBoard.Name = "pbxBoard";
            this.pbxBoard.Size = new System.Drawing.Size(550, 550);
            this.pbxBoard.TabIndex = 1;
            this.pbxBoard.TabStop = false;
            this.pbxBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pcboxBoard_Paint);
            this.pbxBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcboxBoard_MouseClick);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salvarJuegoToolStripMenuItem,
            this.cargarJuegoToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.home;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.opcionesToolStripMenuItem.Text = "Juego";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.control;
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // salvarJuegoToolStripMenuItem
            // 
            this.salvarJuegoToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.disk;
            this.salvarJuegoToolStripMenuItem.Name = "salvarJuegoToolStripMenuItem";
            this.salvarJuegoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.salvarJuegoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salvarJuegoToolStripMenuItem.Text = "Salvar juego";
            this.salvarJuegoToolStripMenuItem.Click += new System.EventHandler(this.salvarJuegoToolStripMenuItem_Click);
            // 
            // cargarJuegoToolStripMenuItem
            // 
            this.cargarJuegoToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.blue_folder_horizontal_open;
            this.cargarJuegoToolStripMenuItem.Name = "cargarJuegoToolStripMenuItem";
            this.cargarJuegoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.cargarJuegoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cargarJuegoToolStripMenuItem.Text = "Cargar juego";
            this.cargarJuegoToolStripMenuItem.Click += new System.EventHandler(this.cargarJuegoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = global::FrontEnd.Properties.Resources.cross_circle;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // opcioneToolStripMenuItem
            // 
            this.opcioneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.créditosToolStripMenuItem});
            this.opcioneToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.icon_diagram;
            this.opcioneToolStripMenuItem.Name = "opcioneToolStripMenuItem";
            this.opcioneToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.opcioneToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.question;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.lifebuoy;
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            this.créditosToolStripMenuItem.Click += new System.EventHandler(this.créditosToolStripMenuItem_Click);
            // 
            // frmVisualGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.pbxBoard);
            this.Controls.Add(this.menuStripPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPlay;
            this.MaximizeBox = false;
            this.Name = "frmVisualGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jueguito";
            this.menuStripPlay.ResumeLayout(false);
            this.menuStripPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPlay;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxBoard;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

