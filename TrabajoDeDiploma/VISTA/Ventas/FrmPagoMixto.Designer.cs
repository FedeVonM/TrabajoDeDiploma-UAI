namespace VISTA.Ventas
{
    partial class FrmPagoMixto
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
            this.tcFORMAS = new System.Windows.Forms.TabControl();
            this.tpContado = new System.Windows.Forms.TabPage();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpTarjeta = new System.Windows.Forms.TabPage();
            this.txtNúmeroTarjeta = new System.Windows.Forms.TextBox();
            this.cmTarjetas = new System.Windows.Forms.ComboBox();
            this.txtImporteTarjeta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpCuentaCorriente = new System.Windows.Forms.TabPage();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalRestante = new System.Windows.Forms.TextBox();
            this.txtTotalFacturado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.tcFORMAS.SuspendLayout();
            this.tpContado.SuspendLayout();
            this.tpTarjeta.SuspendLayout();
            this.tpCuentaCorriente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFORMAS
            // 
            this.tcFORMAS.Controls.Add(this.tpContado);
            this.tcFORMAS.Controls.Add(this.tpTarjeta);
            this.tcFORMAS.Controls.Add(this.tpCuentaCorriente);
            this.tcFORMAS.Location = new System.Drawing.Point(13, 13);
            this.tcFORMAS.Name = "tcFORMAS";
            this.tcFORMAS.SelectedIndex = 0;
            this.tcFORMAS.Size = new System.Drawing.Size(417, 246);
            this.tcFORMAS.TabIndex = 0;
            // 
            // tpContado
            // 
            this.tpContado.Controls.Add(this.txtPagaCon);
            this.tpContado.Controls.Add(this.label7);
            this.tpContado.Location = new System.Drawing.Point(4, 25);
            this.tpContado.Name = "tpContado";
            this.tpContado.Padding = new System.Windows.Forms.Padding(3);
            this.tpContado.Size = new System.Drawing.Size(409, 217);
            this.tpContado.TabIndex = 0;
            this.tpContado.Text = "Contado";
            this.tpContado.UseVisualStyleBackColor = true;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(168, 51);
            this.txtPagaCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(132, 36);
            this.txtPagaCon.TabIndex = 34;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Importe:";
            // 
            // tpTarjeta
            // 
            this.tpTarjeta.Controls.Add(this.txtNúmeroTarjeta);
            this.tpTarjeta.Controls.Add(this.cmTarjetas);
            this.tpTarjeta.Controls.Add(this.txtImporteTarjeta);
            this.tpTarjeta.Controls.Add(this.label10);
            this.tpTarjeta.Controls.Add(this.label9);
            this.tpTarjeta.Controls.Add(this.label8);
            this.tpTarjeta.Location = new System.Drawing.Point(4, 25);
            this.tpTarjeta.Name = "tpTarjeta";
            this.tpTarjeta.Padding = new System.Windows.Forms.Padding(3);
            this.tpTarjeta.Size = new System.Drawing.Size(409, 217);
            this.tpTarjeta.TabIndex = 1;
            this.tpTarjeta.Text = "Tarjeta";
            this.tpTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtNúmeroTarjeta
            // 
            this.txtNúmeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNúmeroTarjeta.Location = new System.Drawing.Point(157, 136);
            this.txtNúmeroTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNúmeroTarjeta.Name = "txtNúmeroTarjeta";
            this.txtNúmeroTarjeta.Size = new System.Drawing.Size(220, 36);
            this.txtNúmeroTarjeta.TabIndex = 41;
            // 
            // cmTarjetas
            // 
            this.cmTarjetas.FormattingEnabled = true;
            this.cmTarjetas.Location = new System.Drawing.Point(157, 92);
            this.cmTarjetas.Name = "cmTarjetas";
            this.cmTarjetas.Size = new System.Drawing.Size(176, 24);
            this.cmTarjetas.TabIndex = 40;
            // 
            // txtImporteTarjeta
            // 
            this.txtImporteTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteTarjeta.Location = new System.Drawing.Point(157, 29);
            this.txtImporteTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporteTarjeta.Name = "txtImporteTarjeta";
            this.txtImporteTarjeta.Size = new System.Drawing.Size(132, 36);
            this.txtImporteTarjeta.TabIndex = 39;
            this.txtImporteTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImporteTarjeta_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Número:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Importe:";
            // 
            // tpCuentaCorriente
            // 
            this.tpCuentaCorriente.Controls.Add(this.txtCC);
            this.tpCuentaCorriente.Controls.Add(this.label11);
            this.tpCuentaCorriente.Location = new System.Drawing.Point(4, 25);
            this.tpCuentaCorriente.Name = "tpCuentaCorriente";
            this.tpCuentaCorriente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCuentaCorriente.Size = new System.Drawing.Size(409, 217);
            this.tpCuentaCorriente.TabIndex = 2;
            this.tpCuentaCorriente.Text = "Cuenta Corriente";
            this.tpCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(196, 67);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(132, 36);
            this.txtCC.TabIndex = 40;
            this.txtCC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCC_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "A Cta. Cte:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(12, 281);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 66);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalRestante);
            this.groupBox1.Controls.Add(this.txtTotalFacturado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCuenta);
            this.groupBox1.Controls.Add(this.lblTarjeta);
            this.groupBox1.Controls.Add(this.lblEfectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 219);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen del pago:";
            // 
            // txtTotalRestante
            // 
            this.txtTotalRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRestante.Location = new System.Drawing.Point(194, 177);
            this.txtTotalRestante.Name = "txtTotalRestante";
            this.txtTotalRestante.ReadOnly = true;
            this.txtTotalRestante.Size = new System.Drawing.Size(100, 30);
            this.txtTotalRestante.TabIndex = 9;
            // 
            // txtTotalFacturado
            // 
            this.txtTotalFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFacturado.Location = new System.Drawing.Point(37, 177);
            this.txtTotalFacturado.Name = "txtTotalFacturado";
            this.txtTotalFacturado.ReadOnly = true;
            this.txtTotalFacturado.Size = new System.Drawing.Size(100, 30);
            this.txtTotalFacturado.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importe restante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total facturado:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(220, 114);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(0, 20);
            this.lblCuenta.TabIndex = 5;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(220, 72);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(0, 20);
            this.lblTarjeta.TabIndex = 4;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(220, 30);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(0, 20);
            this.lblEfectivo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A cuenta corriente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarjeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._112_LeftArrowLong_Blue_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(12, 375);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 8;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // FrmPagoMixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(444, 512);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tcFORMAS);
            this.Name = "FrmPagoMixto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPago";
            this.tcFORMAS.ResumeLayout(false);
            this.tpContado.ResumeLayout(false);
            this.tpContado.PerformLayout();
            this.tpTarjeta.ResumeLayout(false);
            this.tpTarjeta.PerformLayout();
            this.tpCuentaCorriente.ResumeLayout(false);
            this.tpCuentaCorriente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFORMAS;
        private System.Windows.Forms.TabPage tpContado;
        private System.Windows.Forms.TabPage tpTarjeta;
        private System.Windows.Forms.TabPage tpCuentaCorriente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalRestante;
        private System.Windows.Forms.TextBox txtTotalFacturado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNúmeroTarjeta;
        private System.Windows.Forms.ComboBox cmTarjetas;
        private System.Windows.Forms.TextBox txtImporteTarjeta;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCANCELAR;
    }
}