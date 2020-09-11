namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.tcMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tlMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_semanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hs_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMaterias.ContentPanel.SuspendLayout();
            this.tcMaterias.TopToolStripPanel.SuspendLayout();
            this.tcMaterias.SuspendLayout();
            this.tlMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMaterias
            // 
            // 
            // tcMaterias.ContentPanel
            // 
            this.tcMaterias.ContentPanel.Controls.Add(this.tlMaterias);
            this.tcMaterias.ContentPanel.Size = new System.Drawing.Size(650, 216);
            this.tcMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMaterias.Location = new System.Drawing.Point(0, 0);
            this.tcMaterias.Name = "tcMaterias";
            this.tcMaterias.Size = new System.Drawing.Size(650, 241);
            this.tcMaterias.TabIndex = 0;
            this.tcMaterias.Text = "toolStripContainer1";
            // 
            // tcMaterias.TopToolStripPanel
            // 
            this.tcMaterias.TopToolStripPanel.Controls.Add(this.tsMaterias);
            // 
            // tlMaterias
            // 
            this.tlMaterias.ColumnCount = 2;
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.9567F));
            this.tlMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0433F));
            this.tlMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tlMaterias.Controls.Add(this.btnActualizar, 0, 1);
            this.tlMaterias.Controls.Add(this.btnSalir, 1, 1);
            this.tlMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlMaterias.Name = "tlMaterias";
            this.tlMaterias.RowCount = 2;
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.54546F));
            this.tlMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tlMaterias.Size = new System.Drawing.Size(650, 216);
            this.tlMaterias.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.desc_materia,
            this.hs_semanales,
            this.hs_totales,
            this.id_plan,
            this.desc_plan});
            this.tlMaterias.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(644, 165);
            this.dgvMaterias.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(493, 174);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(587, 174);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMaterias.Location = new System.Drawing.Point(3, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(201, 25);
            this.tsMaterias.TabIndex = 0;
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
            // id_materia
            // 
            this.id_materia.DataPropertyName = "ID";
            this.id_materia.HeaderText = "ID";
            this.id_materia.Name = "id_materia";
            this.id_materia.ReadOnly = true;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "Descripcion";
            this.desc_materia.HeaderText = "Descripcion";
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            // 
            // hs_semanales
            // 
            this.hs_semanales.DataPropertyName = "HSSemanales";
            this.hs_semanales.HeaderText = "Horas semanales";
            this.hs_semanales.Name = "hs_semanales";
            this.hs_semanales.ReadOnly = true;
            // 
            // hs_totales
            // 
            this.hs_totales.DataPropertyName = "HSTotales";
            this.hs_totales.HeaderText = "Horas totales";
            this.hs_totales.Name = "hs_totales";
            this.hs_totales.ReadOnly = true;
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "IdPlan";
            this.id_plan.HeaderText = "ID Plan";
            this.id_plan.Name = "id_plan";
            this.id_plan.ReadOnly = true;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "descPlan";
            this.desc_plan.HeaderText = "Plan";
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 241);
            this.Controls.Add(this.tcMaterias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.tcMaterias.ContentPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.PerformLayout();
            this.tcMaterias.ResumeLayout(false);
            this.tcMaterias.PerformLayout();
            this.tlMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcMaterias;
        private System.Windows.Forms.TableLayoutPanel tlMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_semanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn hs_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
    }
}