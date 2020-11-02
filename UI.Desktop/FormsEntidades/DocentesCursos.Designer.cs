namespace UI.Desktop.FormsEntidades
{
    partial class DocentesCursos
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
            this.academiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.academiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docentescursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docentes_cursosTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.docentes_cursosTableAdapter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDocentesCursos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentescursosBindingSource)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academiaDataSetBindingSource
            // 
            this.academiaDataSetBindingSource.DataSource = this.academiaDataSet;
            this.academiaDataSetBindingSource.Position = 0;
            // 
            // docentescursosBindingSource
            // 
            this.docentescursosBindingSource.DataMember = "docentes_cursos";
            this.docentescursosBindingSource.DataSource = this.academiaDataSet;
            // 
            // docentes_cursosTableAdapter
            // 
            this.docentes_cursosTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvDocentesCursos);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(444, 204);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(444, 229);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.20721F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.79279F));
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 27);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(286, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 21);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Inscribirse";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 21);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDocentesCursos
            // 
            this.dgvDocentesCursos.AllowUserToAddRows = false;
            this.dgvDocentesCursos.AllowUserToDeleteRows = false;
            this.dgvDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.desc_materia,
            this.desc_comision});
            this.dgvDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvDocentesCursos.Name = "dgvDocentesCursos";
            this.dgvDocentesCursos.ReadOnly = true;
            this.dgvDocentesCursos.Size = new System.Drawing.Size(444, 204);
            this.dgvDocentesCursos.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID Curso";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // desc_materia
            // 
            this.desc_materia.DataPropertyName = "descmateria";
            this.desc_materia.HeaderText = "Materia";
            this.desc_materia.Name = "desc_materia";
            this.desc_materia.ReadOnly = true;
            // 
            // desc_comision
            // 
            this.desc_comision.DataPropertyName = "desccomision";
            this.desc_comision.HeaderText = "Comision";
            this.desc_comision.Name = "desc_comision";
            this.desc_comision.ReadOnly = true;
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 229);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.Load += new System.EventHandler(this.DocentesCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentescursosBindingSource)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource academiaDataSetBindingSource;
        private AcademiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource docentescursosBindingSource;
        private AcademiaDataSetTableAdapters.docentes_cursosTableAdapter docentes_cursosTableAdapter;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvDocentesCursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_comision;
    }
}