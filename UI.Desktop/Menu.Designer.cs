namespace UI.Desktop
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tipo = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultas = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbReportes = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbRUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbREspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbInscripcion = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.tipo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fecha, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tipo
            // 
            this.tipo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tipo.AutoSize = true;
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.Location = new System.Drawing.Point(402, 229);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(24, 13);
            this.tipo.TabIndex = 17;
            this.tipo.Text = "tipo";
            // 
            // fecha
            // 
            this.fecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fecha.AutoSize = true;
            this.fecha.ForeColor = System.Drawing.Color.Black;
            this.fecha.Location = new System.Drawing.Point(392, 6);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(34, 13);
            this.fecha.TabIndex = 18;
            this.fecha.Text = "fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(125, 128);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(222, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menu ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 67);
            this.label2.TabIndex = 14;
            this.label2.Text = "\"La Academia\"";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultas,
            this.tsbReportes,
            this.tsbInscripcion});
            this.toolStrip1.Location = new System.Drawing.Point(143, 159);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConsultas
            // 
            this.tsbConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarios,
            this.tsbPersonas,
            this.tsbPlanes,
            this.tsbMaterias,
            this.tsbComisiones,
            this.tsbEspecialidades,
            this.tsbCursos});
            this.tsbConsultas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbConsultas.Image = global::UI.Desktop.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.tsbConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultas.Name = "tsbConsultas";
            this.tsbConsultas.Size = new System.Drawing.Size(88, 22);
            this.tsbConsultas.Text = "Consultas";
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbPersonas
            // 
            this.tsbPersonas.Name = "tsbPersonas";
            this.tsbPersonas.Size = new System.Drawing.Size(180, 22);
            this.tsbPersonas.Text = "Personas";
            this.tsbPersonas.Click += new System.EventHandler(this.tsbPersonas_Click);
            // 
            // tsbPlanes
            // 
            this.tsbPlanes.Name = "tsbPlanes";
            this.tsbPlanes.Size = new System.Drawing.Size(180, 22);
            this.tsbPlanes.Text = "Planes";
            this.tsbPlanes.Click += new System.EventHandler(this.tsbPlanes_Click);
            // 
            // tsbMaterias
            // 
            this.tsbMaterias.Name = "tsbMaterias";
            this.tsbMaterias.Size = new System.Drawing.Size(180, 22);
            this.tsbMaterias.Text = "Materias";
            this.tsbMaterias.Click += new System.EventHandler(this.tsbMaterias_Click);
            // 
            // tsbComisiones
            // 
            this.tsbComisiones.Name = "tsbComisiones";
            this.tsbComisiones.Size = new System.Drawing.Size(180, 22);
            this.tsbComisiones.Text = "Comisiones";
            this.tsbComisiones.Click += new System.EventHandler(this.tsbComisiones_Click);
            // 
            // tsbEspecialidades
            // 
            this.tsbEspecialidades.Name = "tsbEspecialidades";
            this.tsbEspecialidades.Size = new System.Drawing.Size(180, 22);
            this.tsbEspecialidades.Text = "Especialidades";
            this.tsbEspecialidades.Click += new System.EventHandler(this.tsbEspecialidades_Click);
            // 
            // tsbCursos
            // 
            this.tsbCursos.Name = "tsbCursos";
            this.tsbCursos.Size = new System.Drawing.Size(180, 22);
            this.tsbCursos.Text = "Cursos";
            this.tsbCursos.Click += new System.EventHandler(this.tsbCursos_Click);
            // 
            // tsbReportes
            // 
            this.tsbReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRUsuarios,
            this.tsbRCursos,
            this.tsbREspecialidades});
            this.tsbReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbReportes.Image = global::UI.Desktop.Properties.Resources.admin_person_user_man_2839;
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(82, 22);
            this.tsbReportes.Text = "Reportes";
            // 
            // tsbRUsuarios
            // 
            this.tsbRUsuarios.Name = "tsbRUsuarios";
            this.tsbRUsuarios.Size = new System.Drawing.Size(150, 22);
            this.tsbRUsuarios.Text = "Usuarios";
            this.tsbRUsuarios.Click += new System.EventHandler(this.tsbRUsuarios_Click);
            // 
            // tsbRCursos
            // 
            this.tsbRCursos.Name = "tsbRCursos";
            this.tsbRCursos.Size = new System.Drawing.Size(150, 22);
            this.tsbRCursos.Text = "Cursos";
            this.tsbRCursos.Click += new System.EventHandler(this.tsbRCursos_Click);
            // 
            // tsbREspecialidades
            // 
            this.tsbREspecialidades.Name = "tsbREspecialidades";
            this.tsbREspecialidades.Size = new System.Drawing.Size(150, 22);
            this.tsbREspecialidades.Text = "Especialidades";
            this.tsbREspecialidades.Click += new System.EventHandler(this.tsbREspecialidades_Click);
            // 
            // tsbInscripcion
            // 
            this.tsbInscripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tsbInscripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsbInscripcion.Image = global::UI.Desktop.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.tsbInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInscripcion.Name = "tsbInscripcion";
            this.tsbInscripcion.Size = new System.Drawing.Size(85, 22);
            this.tsbInscripcion.Text = "Inscripcion";
            this.tsbInscripcion.Click += new System.EventHandler(this.tsbInscripciones_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label txtidalum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbConsultas;
        private System.Windows.Forms.ToolStripDropDownButton tsbReportes;
        private System.Windows.Forms.ToolStripButton tsbInscripcion;
        private System.Windows.Forms.ToolStripMenuItem tsbRUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsbRCursos;
        private System.Windows.Forms.ToolStripMenuItem tsbREspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsbUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsbPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsbPlanes;
        private System.Windows.Forms.ToolStripMenuItem tsbMaterias;
        private System.Windows.Forms.ToolStripMenuItem tsbComisiones;
        private System.Windows.Forms.ToolStripMenuItem tsbEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsbCursos;
    }
}