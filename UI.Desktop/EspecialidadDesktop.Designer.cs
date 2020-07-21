namespace UI.Desktop
{
    partial class EspecialidadDesktop
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
            this.tlpEspecialidadDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.tlpEspecialidadDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEspecialidadDesktop
            // 
            this.tlpEspecialidadDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEspecialidadDesktop.ColumnCount = 4;
            this.tlpEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.57303F));
            this.tlpEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.42697F));
            this.tlpEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpEspecialidadDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            this.tlpEspecialidadDesktop.Controls.Add(this.btnCancelar, 3, 2);
            this.tlpEspecialidadDesktop.Controls.Add(this.btnAceptar, 2, 2);
            this.tlpEspecialidadDesktop.Controls.Add(this.txtDescripcion, 1, 1);
            this.tlpEspecialidadDesktop.Controls.Add(this.lDescripcion, 0, 1);
            this.tlpEspecialidadDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidadDesktop.Name = "tlpEspecialidadDesktop";
            this.tlpEspecialidadDesktop.RowCount = 3;
            this.tlpEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpEspecialidadDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpEspecialidadDesktop.Size = new System.Drawing.Size(789, 441);
            this.tlpEspecialidadDesktop.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(262, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 27);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(75, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(96, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(66, 24);
            this.lDescripcion.TabIndex = 1;
            this.lDescripcion.Text = "Descripción";
            this.lDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EspecialidadDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 375);
            this.Controls.Add(this.tlpEspecialidadDesktop);
            this.Name = "EspecialidadDesktop";
            this.Text = "Especialidades";
            this.tlpEspecialidadDesktop.ResumeLayout(false);
            this.tlpEspecialidadDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEspecialidadDesktop;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}