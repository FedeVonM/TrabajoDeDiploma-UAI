namespace VISTA.Ventas
{
    partial class FrmFactura
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
            this.gbARTICULOS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarPorDescripcion = new System.Windows.Forms.Button();
            this.txtCANTIDAD = new System.Windows.Forms.TextBox();
            this.dgvARTICULOS = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSUBTOTAL = new System.Windows.Forms.TextBox();
            this.gbCLIENTE = new System.Windows.Forms.GroupBox();
            this.cbFORMADEPAGO = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.txtDNI_CLIENTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReseteaVenta = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnCOBRAR = new System.Windows.Forms.Button();
            this.txtTIPO = new System.Windows.Forms.TextBox();
            this.txtPUNTO_VENTA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNUMERO_FACTURA = new System.Windows.Forms.TextBox();
            this.gbARTICULOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARTICULOS)).BeginInit();
            this.gbCLIENTE.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbARTICULOS
            // 
            this.gbARTICULOS.Controls.Add(this.label1);
            this.gbARTICULOS.Controls.Add(this.txtCODIGO);
            this.gbARTICULOS.Controls.Add(this.btnEliminarArt);
            this.gbARTICULOS.Controls.Add(this.label2);
            this.gbARTICULOS.Controls.Add(this.btnBuscarPorDescripcion);
            this.gbARTICULOS.Controls.Add(this.txtCANTIDAD);
            this.gbARTICULOS.Controls.Add(this.dgvARTICULOS);
            this.gbARTICULOS.Controls.Add(this.label3);
            this.gbARTICULOS.Controls.Add(this.txtSUBTOTAL);
            this.gbARTICULOS.Location = new System.Drawing.Point(12, 164);
            this.gbARTICULOS.Name = "gbARTICULOS";
            this.gbARTICULOS.Size = new System.Drawing.Size(899, 401);
            this.gbARTICULOS.TabIndex = 5;
            this.gbARTICULOS.TabStop = false;
            this.gbARTICULOS.Text = "ARTICULOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo:";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(85, 25);
            this.txtCODIGO.Margin = new System.Windows.Forms.Padding(4);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(303, 22);
            this.txtCODIGO.TabIndex = 8;
            this.txtCODIGO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCODIGO_KeyDown);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Image = global::VISTA.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnEliminarArt.Location = new System.Drawing.Point(649, 90);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(57, 37);
            this.btnEliminarArt.TabIndex = 13;
            this.btnEliminarArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad:";
            // 
            // btnBuscarPorDescripcion
            // 
            this.btnBuscarPorDescripcion.Image = global::VISTA.Properties.Resources.search;
            this.btnBuscarPorDescripcion.Location = new System.Drawing.Point(413, 22);
            this.btnBuscarPorDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPorDescripcion.Name = "btnBuscarPorDescripcion";
            this.btnBuscarPorDescripcion.Size = new System.Drawing.Size(75, 64);
            this.btnBuscarPorDescripcion.TabIndex = 14;
            this.btnBuscarPorDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPorDescripcion.UseVisualStyleBackColor = true;
            this.btnBuscarPorDescripcion.Click += new System.EventHandler(this.btnBuscarPorDescripcion_Click);
            // 
            // txtCANTIDAD
            // 
            this.txtCANTIDAD.Location = new System.Drawing.Point(85, 60);
            this.txtCANTIDAD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCANTIDAD.Name = "txtCANTIDAD";
            this.txtCANTIDAD.Size = new System.Drawing.Size(303, 22);
            this.txtCANTIDAD.TabIndex = 9;
            this.txtCANTIDAD.Text = "1";
            this.txtCANTIDAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCANTIDAD_KeyDown);
            // 
            // dgvARTICULOS
            // 
            this.dgvARTICULOS.AllowUserToAddRows = false;
            this.dgvARTICULOS.AllowUserToDeleteRows = false;
            this.dgvARTICULOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvARTICULOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvARTICULOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvARTICULOS.Location = new System.Drawing.Point(7, 90);
            this.dgvARTICULOS.Margin = new System.Windows.Forms.Padding(4);
            this.dgvARTICULOS.Name = "dgvARTICULOS";
            this.dgvARTICULOS.ReadOnly = true;
            this.dgvARTICULOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvARTICULOS.Size = new System.Drawing.Size(629, 304);
            this.dgvARTICULOS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // txtSUBTOTAL
            // 
            this.txtSUBTOTAL.Enabled = false;
            this.txtSUBTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUBTOTAL.Location = new System.Drawing.Point(760, 358);
            this.txtSUBTOTAL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSUBTOTAL.Name = "txtSUBTOTAL";
            this.txtSUBTOTAL.Size = new System.Drawing.Size(132, 36);
            this.txtSUBTOTAL.TabIndex = 9;
            // 
            // gbCLIENTE
            // 
            this.gbCLIENTE.Controls.Add(this.cbFORMADEPAGO);
            this.gbCLIENTE.Controls.Add(this.label8);
            this.gbCLIENTE.Controls.Add(this.txtNOMBRE_CLIENTE);
            this.gbCLIENTE.Controls.Add(this.txtDNI_CLIENTE);
            this.gbCLIENTE.Controls.Add(this.label5);
            this.gbCLIENTE.Controls.Add(this.label4);
            this.gbCLIENTE.Location = new System.Drawing.Point(12, 80);
            this.gbCLIENTE.Name = "gbCLIENTE";
            this.gbCLIENTE.Size = new System.Drawing.Size(899, 78);
            this.gbCLIENTE.TabIndex = 9;
            this.gbCLIENTE.TabStop = false;
            this.gbCLIENTE.Text = "CLIENTE";
            // 
            // cbFORMADEPAGO
            // 
            this.cbFORMADEPAGO.FormattingEnabled = true;
            this.cbFORMADEPAGO.Location = new System.Drawing.Point(702, 27);
            this.cbFORMADEPAGO.Name = "cbFORMADEPAGO";
            this.cbFORMADEPAGO.Size = new System.Drawing.Size(189, 24);
            this.cbFORMADEPAGO.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Forma de Pago:";
            // 
            // txtNOMBRE_CLIENTE
            // 
            this.txtNOMBRE_CLIENTE.Location = new System.Drawing.Point(281, 27);
            this.txtNOMBRE_CLIENTE.Name = "txtNOMBRE_CLIENTE";
            this.txtNOMBRE_CLIENTE.Size = new System.Drawing.Size(287, 22);
            this.txtNOMBRE_CLIENTE.TabIndex = 3;
            // 
            // txtDNI_CLIENTE
            // 
            this.txtDNI_CLIENTE.Location = new System.Drawing.Point(51, 27);
            this.txtDNI_CLIENTE.Name = "txtDNI_CLIENTE";
            this.txtDNI_CLIENTE.Size = new System.Drawing.Size(137, 22);
            this.txtDNI_CLIENTE.TabIndex = 2;
            this.txtDNI_CLIENTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDNI_CLIENTE_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "DNI:";
            // 
            // btnReseteaVenta
            // 
            this.btnReseteaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseteaVenta.Image = global::VISTA.Properties.Resources._112_RefreshArrow_Blue_32x42_72;
            this.btnReseteaVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReseteaVenta.Location = new System.Drawing.Point(171, 572);
            this.btnReseteaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnReseteaVenta.Name = "btnReseteaVenta";
            this.btnReseteaVenta.Size = new System.Drawing.Size(121, 81);
            this.btnReseteaVenta.TabIndex = 7;
            this.btnReseteaVenta.Text = "Resetear venta";
            this.btnReseteaVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReseteaVenta.UseVisualStyleBackColor = true;
            this.btnReseteaVenta.Click += new System.EventHandler(this.btnReseteaVenta_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnSALIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSALIR.Location = new System.Drawing.Point(794, 572);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(109, 80);
            this.btnSALIR.TabIndex = 8;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnCOBRAR
            // 
            this.btnCOBRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOBRAR.Location = new System.Drawing.Point(12, 572);
            this.btnCOBRAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOBRAR.Name = "btnCOBRAR";
            this.btnCOBRAR.Size = new System.Drawing.Size(129, 80);
            this.btnCOBRAR.TabIndex = 6;
            this.btnCOBRAR.Text = "Cobrar";
            this.btnCOBRAR.UseVisualStyleBackColor = true;
            this.btnCOBRAR.Click += new System.EventHandler(this.btnCOBRAR_Click);
            // 
            // txtTIPO
            // 
            this.txtTIPO.Location = new System.Drawing.Point(19, 37);
            this.txtTIPO.Name = "txtTIPO";
            this.txtTIPO.ReadOnly = true;
            this.txtTIPO.Size = new System.Drawing.Size(83, 22);
            this.txtTIPO.TabIndex = 10;
            // 
            // txtPUNTO_VENTA
            // 
            this.txtPUNTO_VENTA.Location = new System.Drawing.Point(217, 37);
            this.txtPUNTO_VENTA.Name = "txtPUNTO_VENTA";
            this.txtPUNTO_VENTA.ReadOnly = true;
            this.txtPUNTO_VENTA.Size = new System.Drawing.Size(70, 22);
            this.txtPUNTO_VENTA.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha:";
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFECHA.Location = new System.Drawing.Point(676, 37);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(133, 22);
            this.dtpFECHA.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Punto de venta:";
            // 
            // txtNUMERO_FACTURA
            // 
            this.txtNUMERO_FACTURA.Location = new System.Drawing.Point(399, 37);
            this.txtNUMERO_FACTURA.Name = "txtNUMERO_FACTURA";
            this.txtNUMERO_FACTURA.ReadOnly = true;
            this.txtNUMERO_FACTURA.Size = new System.Drawing.Size(157, 22);
            this.txtNUMERO_FACTURA.TabIndex = 17;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(923, 665);
            this.Controls.Add(this.txtNUMERO_FACTURA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.txtPUNTO_VENTA);
            this.Controls.Add(this.txtTIPO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbARTICULOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbCLIENTE);
            this.Controls.Add(this.btnReseteaVenta);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnCOBRAR);
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..FACTURA";
            this.gbARTICULOS.ResumeLayout(false);
            this.gbARTICULOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvARTICULOS)).EndInit();
            this.gbCLIENTE.ResumeLayout(false);
            this.gbCLIENTE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbARTICULOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarPorDescripcion;
        private System.Windows.Forms.TextBox txtCANTIDAD;
        private System.Windows.Forms.DataGridView dgvARTICULOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSUBTOTAL;
        private System.Windows.Forms.GroupBox gbCLIENTE;
        private System.Windows.Forms.TextBox txtNOMBRE_CLIENTE;
        private System.Windows.Forms.TextBox txtDNI_CLIENTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReseteaVenta;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnCOBRAR;
        private System.Windows.Forms.TextBox txtTIPO;
        private System.Windows.Forms.TextBox txtPUNTO_VENTA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.ComboBox cbFORMADEPAGO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNUMERO_FACTURA;
    }
}