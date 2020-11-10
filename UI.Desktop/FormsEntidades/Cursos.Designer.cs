namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.tcCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.academiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbNotas = new System.Windows.Forms.ToolStripButton();
            this.cursosTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.cursosTableAdapter();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcomision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCursos.ContentPanel.SuspendLayout();
            this.tcCursos.TopToolStripPanel.SuspendLayout();
            this.tcCursos.SuspendLayout();
            this.tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            this.tsCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCursos
            // 
            // 
            // tcCursos.ContentPanel
            // 
            this.tcCursos.ContentPanel.Controls.Add(this.tlCursos);
            this.tcCursos.ContentPanel.Size = new System.Drawing.Size(748, 298);
            this.tcCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCursos.Location = new System.Drawing.Point(0, 0);
            this.tcCursos.Name = "tcCursos";
            this.tcCursos.Size = new System.Drawing.Size(748, 323);
            this.tcCursos.TabIndex = 0;
            this.tcCursos.Text = "toolStripContainer1";
            // 
            // tcCursos.TopToolStripPanel
            // 
            this.tcCursos.TopToolStripPanel.Controls.Add(this.tsCursos);
            this.tcCursos.TopToolStripPanel.Click += new System.EventHandler(this.tcCursos_TopToolStripPanel_Click);
            // 
            // tlCursos
            // 
            this.tlCursos.ColumnCount = 2;
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlCursos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlCursos.Controls.Add(this.btnSalir, 1, 1);
            this.tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursos.Location = new System.Drawing.Point(0, 0);
            this.tlCursos.Name = "tlCursos";
            this.tlCursos.RowCount = 2;
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursos.Size = new System.Drawing.Size(748, 298);
            this.tlCursos.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cupo,
            this.id,
            this.Año,
            this.IDcomision,
            this.desc_comision,
            this.idMateria,
            this.desc_materia});
            this.tlCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(742, 263);
            this.dgvCursos.TabIndex = 0;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(589, 272);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(670, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar,
            this.tsbNotas});
            this.tsCursos.Location = new System.Drawing.Point(3, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(259, 25);
            this.tsCursos.TabIndex = 0;
            this.tsCursos.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.add_insert_plus_1588;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tbsNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.edit_modify_icon_icons_com_49882;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tbsEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.delete_delete_exit_1577;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tbsEliminar_Click);
            // 
            // tsbNotas
            // 
            this.tsbNotas.Image = global::UI.Desktop.Properties.Resources.businessapplication_edit_male_user_thepencil_theclient_negocio_2321;
            this.tsbNotas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNotas.Name = "tsbNotas";
            this.tsbNotas.Size = new System.Drawing.Size(58, 22);
            this.tsbNotas.Text = "Notas";
            this.tsbNotas.Click += new System.EventHandler(this.tsbNotas_Click);
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // Cupo
            // 
            this.Cupo.DataPropertyName = "cupo";
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.DataPropertyName = "aniocalendario";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // IDcomision
            // 
            this.IDcomision.DataPropertyName = "idcomision";
            this.IDcomision.HeaderText = "ID Comisión";
            this.IDcomision.Name = "IDcomision";
            this.IDcomision.ReadOnly = true;
            // 
            // desc_comision
            // 
            this.desc_comision.DataPropertyName = "desccomision";
            this.desc_comision.HeaderText = "Descripcion Comision";
            this.desc_comision.Name = "desc_comision";
            this.desc_comision.ReadOnly = true;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idmateria";
            this.idMateria.HeaderText = "ID Materia";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "descmateria";
            this.desc_materia.HeaderText = "Descripcion Materia";
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 323);
            this.Controls.Add(this.tcCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tcCursos.ContentPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.ResumeLayout(false);
            this.tcCursos.TopToolStripPanel.PerformLayout();
            this.tcCursos.ResumeLayout(false);
            this.tcCursos.PerformLayout();
            this.tlCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCursos;
        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private AcademiaDataSet academiaDataSet;
        private AcademiaDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcomision;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
    }
}