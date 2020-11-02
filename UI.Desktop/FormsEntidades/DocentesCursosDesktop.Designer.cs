namespace UI.Desktop.FormsEntidades
{
    partial class DocentesCursosDesktop
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
            this.tlpDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.tlpDocentesCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDocentesCursos
            // 
            this.tlpDocentesCursos.ColumnCount = 2;
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.49206F));
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.50794F));
            this.tlpDocentesCursos.Controls.Add(this.label6, 0, 0);
            this.tlpDocentesCursos.Controls.Add(this.btnAceptar, 0, 4);
            this.tlpDocentesCursos.Controls.Add(this.btnCancelar, 1, 4);
            this.tlpDocentesCursos.Controls.Add(this.label5, 0, 3);
            this.tlpDocentesCursos.Controls.Add(this.cmbCargos, 1, 3);
            this.tlpDocentesCursos.Controls.Add(this.label3, 0, 2);
            this.tlpDocentesCursos.Controls.Add(this.label1, 0, 1);
            this.tlpDocentesCursos.Controls.Add(this.txtID, 1, 0);
            this.tlpDocentesCursos.Controls.Add(this.cmbCursos, 1, 1);
            this.tlpDocentesCursos.Controls.Add(this.cmbDocentes, 1, 2);
            this.tlpDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpDocentesCursos.Name = "tlpDocentesCursos";
            this.tlpDocentesCursos.RowCount = 5;
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5625F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4375F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpDocentesCursos.Size = new System.Drawing.Size(286, 191);
            this.tlpDocentesCursos.TabIndex = 0;
            this.tlpDocentesCursos.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(32, 140);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(208, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCargos
            // 
            this.cmbCargos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Items.AddRange(new object[] {
            "Auxiliar",
            "Profesor"});
            this.cmbCargos.Location = new System.Drawing.Point(123, 109);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(150, 21);
            this.cmbCargos.TabIndex = 9;
            this.cmbCargos.Text = "Seleccione un cargo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Docente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 11;
            // 
            // cmbCursos
            // 
            this.cmbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(130, 45);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(135, 21);
            this.cmbCursos.TabIndex = 12;
            this.cmbCursos.Text = "Seleccione un curso";
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(137, 77);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(121, 21);
            this.cmbDocentes.TabIndex = 13;
            // 
            // DocentesCursosDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 191);
            this.Controls.Add(this.tlpDocentesCursos);
            this.Name = "DocentesCursosDesktop";
            this.Text = "DocentesCursosDesktop";
            this.tlpDocentesCursos.ResumeLayout(false);
            this.tlpDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDocentesCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.ComboBox cmbDocentes;
    }
}