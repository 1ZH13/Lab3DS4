namespace Lab3DS4
{
    partial class Form1
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
            this.ResultadoDeVocal = new System.Windows.Forms.ListBox();
            this.tltVocal = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.calVocales = new System.Windows.Forms.Button();
            this.resultadoNumerico = new System.Windows.Forms.ListBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultadoDeVocal
            // 
            this.ResultadoDeVocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultadoDeVocal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoDeVocal.FormattingEnabled = true;
            this.ResultadoDeVocal.ItemHeight = 17;
            this.ResultadoDeVocal.Location = new System.Drawing.Point(468, 190);
            this.ResultadoDeVocal.Name = "ResultadoDeVocal";
            this.ResultadoDeVocal.Size = new System.Drawing.Size(174, 208);
            this.ResultadoDeVocal.TabIndex = 0;
            this.ResultadoDeVocal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tltVocal
            // 
            this.tltVocal.AutoSize = true;
            this.tltVocal.BackColor = System.Drawing.Color.White;
            this.tltVocal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tltVocal.Location = new System.Drawing.Point(251, 55);
            this.tltVocal.Name = "tltVocal";
            this.tltVocal.Size = new System.Drawing.Size(273, 23);
            this.tltVocal.TabIndex = 1;
            this.tltVocal.Text = "CALCULADOR DE VOCALES";
            this.tltVocal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(118, 190);
            this.txtPalabra.MaxLength = 30;
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(149, 22);
            this.txtPalabra.TabIndex = 2;
            this.txtPalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalabra_KeyPress);
            // 
            // calVocales
            // 
            this.calVocales.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calVocales.Location = new System.Drawing.Point(133, 279);
            this.calVocales.Name = "calVocales";
            this.calVocales.Size = new System.Drawing.Size(109, 31);
            this.calVocales.TabIndex = 3;
            this.calVocales.Text = "Calcular\r\n";
            this.calVocales.UseVisualStyleBackColor = true;
            this.calVocales.Click += new System.EventHandler(this.calVocales_Click);
            // 
            // resultadoNumerico
            // 
            this.resultadoNumerico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoNumerico.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoNumerico.FormattingEnabled = true;
            this.resultadoNumerico.ItemHeight = 17;
            this.resultadoNumerico.Location = new System.Drawing.Point(432, 133);
            this.resultadoNumerico.Name = "resultadoNumerico";
            this.resultadoNumerico.Size = new System.Drawing.Size(243, 38);
            this.resultadoNumerico.TabIndex = 4;
            this.resultadoNumerico.SelectedIndexChanged += new System.EventHandler(this.resultadoNumerico_SelectedIndexChanged);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(166, 227);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(0, 16);
            this.lblAdvertencia.TabIndex = 5;
            this.lblAdvertencia.Click += new System.EventHandler(this.lblAdvertencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 474);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.resultadoNumerico);
            this.Controls.Add(this.calVocales);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.tltVocal);
            this.Controls.Add(this.ResultadoDeVocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultadoDeVocal;
        private System.Windows.Forms.Label tltVocal;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button calVocales;
        private System.Windows.Forms.ListBox resultadoNumerico;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}

