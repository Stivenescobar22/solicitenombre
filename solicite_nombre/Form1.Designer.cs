namespace solicite_nombre
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
            this.lblsolicitud = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblstilo = new System.Windows.Forms.Label();
            this.lbldiseño = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsolicitud
            // 
            this.lblsolicitud.AutoSize = true;
            this.lblsolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolicitud.Location = new System.Drawing.Point(283, 32);
            this.lblsolicitud.Name = "lblsolicitud";
            this.lblsolicitud.Size = new System.Drawing.Size(195, 24);
            this.lblsolicitud.TabIndex = 0;
            this.lblsolicitud.Text = "solicitud de nombre";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(167, 141);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(81, 20);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre :";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(287, 140);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(168, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // lblstilo
            // 
            this.lblstilo.AutoSize = true;
            this.lblstilo.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstilo.Location = new System.Drawing.Point(307, 213);
            this.lblstilo.Name = "lblstilo";
            this.lblstilo.Size = new System.Drawing.Size(86, 22);
            this.lblstilo.TabIndex = 3;
            this.lblstilo.Text = "Estilo nuevo";
            this.lblstilo.Visible = false;
            // 
            // lbldiseño
            // 
            this.lbldiseño.AutoSize = true;
            this.lbldiseño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiseño.Location = new System.Drawing.Point(171, 213);
            this.lbldiseño.Name = "lbldiseño";
            this.lbldiseño.Size = new System.Drawing.Size(75, 20);
            this.lbldiseño.TabIndex = 4;
            this.lbldiseño.Text = "Diseño :";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(495, 140);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(82, 25);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbldiseño);
            this.Controls.Add(this.lblstilo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblsolicitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsolicitud;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblstilo;
        private System.Windows.Forms.Label lbldiseño;
        private System.Windows.Forms.Button btnok;
    }
}

