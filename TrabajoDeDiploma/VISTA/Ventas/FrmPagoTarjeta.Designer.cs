namespace VISTA.Ventas
{
    partial class FrmPagoTarjeta
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
            this.gbTARJETA = new System.Windows.Forms.GroupBox();
            this.txtNúmeroTarjeta = new System.Windows.Forms.TextBox();
            this.cmTarjetas = new System.Windows.Forms.ComboBox();
            this.txtImporteTarjeta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.gbTARJETA.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTARJETA
            // 
            this.gbTARJETA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbTARJETA.Controls.Add(this.txtTOTAL);
            this.gbTARJETA.Controls.Add(this.label1);
            this.gbTARJETA.Controls.Add(this.txtNúmeroTarjeta);
            this.gbTARJETA.Controls.Add(this.cmTarjetas);
            this.gbTARJETA.Controls.Add(this.txtImporteTarjeta);
            this.gbTARJETA.Controls.Add(this.label10);
            this.gbTARJETA.Controls.Add(this.label9);
            this.gbTARJETA.Controls.Add(this.label8);
            this.gbTARJETA.Location = new System.Drawing.Point(13, 13);
            this.gbTARJETA.Name = "gbTARJETA";
            this.gbTARJETA.Size = new System.Drawing.Size(390, 245);
            this.gbTARJETA.TabIndex = 0;
            this.gbTARJETA.TabStop = false;
            this.gbTARJETA.Text = "TARJETA";
            // 
            // txtNúmeroTarjeta
            // 
            this.txtNúmeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNúmeroTarjeta.Location = new System.Drawing.Point(154, 185);
            this.txtNúmeroTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNúmeroTarjeta.Name = "txtNúmeroTarjeta";
            this.txtNúmeroTarjeta.Size = new System.Drawing.Size(220, 36);
            this.txtNúmeroTarjeta.TabIndex = 47;
            // 
            // cmTarjetas
            // 
            this.cmTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmTarjetas.FormattingEnabled = true;
            this.cmTarjetas.Location = new System.Drawing.Point(154, 134);
            this.cmTarjetas.Name = "cmTarjetas";
            this.cmTarjetas.Size = new System.Drawing.Size(176, 28);
            this.cmTarjetas.TabIndex = 46;
            // 
            // txtImporteTarjeta
            // 
            this.txtImporteTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteTarjeta.Location = new System.Drawing.Point(154, 75);
            this.txtImporteTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporteTarjeta.Name = "txtImporteTarjeta";
            this.txtImporteTarjeta.Size = new System.Drawing.Size(132, 36);
            this.txtImporteTarjeta.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Importe:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(54, 286);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 66);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._112_LeftArrowLong_Blue_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(206, 286);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 45;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Total:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.Location = new System.Drawing.Point(154, 20);
            this.txtTOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(132, 36);
            this.txtTOTAL.TabIndex = 49;
            // 
            // FrmPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbTARJETA);
            this.Name = "FrmPagoTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..PAGO TARJETA";
            this.gbTARJETA.ResumeLayout(false);
            this.gbTARJETA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTARJETA;
        private System.Windows.Forms.TextBox txtNúmeroTarjeta;
        private System.Windows.Forms.ComboBox cmTarjetas;
        private System.Windows.Forms.TextBox txtImporteTarjeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label label1;
    }
}