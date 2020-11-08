namespace UI.Desktop
{
    partial class CursosReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AcademiaDataSet = new UI.Desktop.AcademiaDataSet();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.cursosTableAdapter();
            this.academiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKalumnosinscripcionescursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnos_inscripcionesTableAdapter = new UI.Desktop.AcademiaDataSetTableAdapters.alumnos_inscripcionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKalumnosinscripcionescursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCursos";
            reportDataSource1.Value = this.cursosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Reportes.Cursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AcademiaDataSet
            // 
            this.AcademiaDataSet.DataSetName = "AcademiaDataSet";
            this.AcademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.AcademiaDataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // academiaDataSetBindingSource
            // 
            this.academiaDataSetBindingSource.DataSource = this.AcademiaDataSet;
            this.academiaDataSetBindingSource.Position = 0;
            // 
            // fKalumnosinscripcionescursosBindingSource
            // 
            this.fKalumnosinscripcionescursosBindingSource.DataMember = "FK_alumnos_inscripciones_cursos";
            this.fKalumnosinscripcionescursosBindingSource.DataSource = this.cursosBindingSource;
            // 
            // alumnos_inscripcionesTableAdapter
            // 
            this.alumnos_inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // CursosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CursosReporte";
            this.Text = "CursosReporte";
            this.Load += new System.EventHandler(this.CursosReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcademiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKalumnosinscripcionescursosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private AcademiaDataSet AcademiaDataSet;
        private AcademiaDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.BindingSource academiaDataSetBindingSource;
        private System.Windows.Forms.BindingSource fKalumnosinscripcionescursosBindingSource;
        private AcademiaDataSetTableAdapters.alumnos_inscripcionesTableAdapter alumnos_inscripcionesTableAdapter;
    }
}