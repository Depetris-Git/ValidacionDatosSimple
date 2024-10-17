namespace ValidacionDatos.FE
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
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lb_2 = new System.Windows.Forms.Label();
            this.Mtb_CUIL = new System.Windows.Forms.MaskedTextBox();
            this.Btt_ExtraerDNI = new System.Windows.Forms.Button();
            this.Tb_Patente = new System.Windows.Forms.TextBox();
            this.Lb_3 = new System.Windows.Forms.Label();
            this.Lb_ValorDNI = new System.Windows.Forms.Label();
            this.Btt_ValidarPatente = new System.Windows.Forms.Button();
            this.Btt_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(275, 71);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(95, 29);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Patente";
            // 
            // Lb_2
            // 
            this.Lb_2.AutoSize = true;
            this.Lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_2.Location = new System.Drawing.Point(263, 240);
            this.Lb_2.Name = "Lb_2";
            this.Lb_2.Size = new System.Drawing.Size(66, 29);
            this.Lb_2.TabIndex = 1;
            this.Lb_2.Text = "CUIL";
            this.Lb_2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mtb_CUIL
            // 
            this.Mtb_CUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_CUIL.Location = new System.Drawing.Point(12, 234);
            this.Mtb_CUIL.Mask = "0-90000000-0";
            this.Mtb_CUIL.Name = "Mtb_CUIL";
            this.Mtb_CUIL.Size = new System.Drawing.Size(220, 38);
            this.Mtb_CUIL.TabIndex = 2;
            // 
            // Btt_ExtraerDNI
            // 
            this.Btt_ExtraerDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_ExtraerDNI.Location = new System.Drawing.Point(12, 296);
            this.Btt_ExtraerDNI.Name = "Btt_ExtraerDNI";
            this.Btt_ExtraerDNI.Size = new System.Drawing.Size(116, 39);
            this.Btt_ExtraerDNI.TabIndex = 3;
            this.Btt_ExtraerDNI.Text = "Extraer DNI";
            this.Btt_ExtraerDNI.UseVisualStyleBackColor = true;
            this.Btt_ExtraerDNI.Click += new System.EventHandler(this.Btt_ExtraerDNI_Click);
            // 
            // Tb_Patente
            // 
            this.Tb_Patente.Location = new System.Drawing.Point(12, 71);
            this.Tb_Patente.Name = "Tb_Patente";
            this.Tb_Patente.Size = new System.Drawing.Size(257, 22);
            this.Tb_Patente.TabIndex = 5;
            this.Tb_Patente.TextChanged += new System.EventHandler(this.Tb_Patente_TextChanged);
            // 
            // Lb_3
            // 
            this.Lb_3.AutoSize = true;
            this.Lb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_3.Location = new System.Drawing.Point(7, 352);
            this.Lb_3.Name = "Lb_3";
            this.Lb_3.Size = new System.Drawing.Size(154, 29);
            this.Lb_3.TabIndex = 6;
            this.Lb_3.Text = "DNI Extraído:";
            // 
            // Lb_ValorDNI
            // 
            this.Lb_ValorDNI.AutoSize = true;
            this.Lb_ValorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ValorDNI.Location = new System.Drawing.Point(167, 352);
            this.Lb_ValorDNI.Name = "Lb_ValorDNI";
            this.Lb_ValorDNI.Size = new System.Drawing.Size(141, 29);
            this.Lb_ValorDNI.TabIndex = 7;
            this.Lb_ValorDNI.Text = "placeholder";
            // 
            // Btt_ValidarPatente
            // 
            this.Btt_ValidarPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_ValidarPatente.Location = new System.Drawing.Point(12, 99);
            this.Btt_ValidarPatente.Name = "Btt_ValidarPatente";
            this.Btt_ValidarPatente.Size = new System.Drawing.Size(116, 39);
            this.Btt_ValidarPatente.TabIndex = 8;
            this.Btt_ValidarPatente.Text = "Validar";
            this.Btt_ValidarPatente.UseVisualStyleBackColor = true;
            this.Btt_ValidarPatente.Click += new System.EventHandler(this.Btt_ValidarPatente_Click);
            // 
            // Btt_Limpiar
            // 
            this.Btt_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btt_Limpiar.Location = new System.Drawing.Point(137, 296);
            this.Btt_Limpiar.Name = "Btt_Limpiar";
            this.Btt_Limpiar.Size = new System.Drawing.Size(116, 39);
            this.Btt_Limpiar.TabIndex = 9;
            this.Btt_Limpiar.Text = "Limpiar";
            this.Btt_Limpiar.UseVisualStyleBackColor = true;
            this.Btt_Limpiar.Click += new System.EventHandler(this.Btt_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btt_Limpiar);
            this.Controls.Add(this.Btt_ValidarPatente);
            this.Controls.Add(this.Lb_ValorDNI);
            this.Controls.Add(this.Lb_3);
            this.Controls.Add(this.Tb_Patente);
            this.Controls.Add(this.Btt_ExtraerDNI);
            this.Controls.Add(this.Mtb_CUIL);
            this.Controls.Add(this.Lb_2);
            this.Controls.Add(this.Lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lb_2;
        private System.Windows.Forms.MaskedTextBox Mtb_CUIL;
        private System.Windows.Forms.Button Btt_ExtraerDNI;
        private System.Windows.Forms.TextBox Tb_Patente;
        private System.Windows.Forms.Label Lb_3;
        private System.Windows.Forms.Label Lb_ValorDNI;
        private System.Windows.Forms.Button Btt_ValidarPatente;
        private System.Windows.Forms.Button Btt_Limpiar;
    }
}

