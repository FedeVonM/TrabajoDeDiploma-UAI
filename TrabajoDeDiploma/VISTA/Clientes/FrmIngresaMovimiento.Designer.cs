namespace VISTA.Clientes
{
    partial class FrmIngresaMovimiento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIMPORTE = new System.Windows.Forms.TextBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.txtSALDOACTUAL = new System.Windows.Forms.TextBox();
            this.txtSALDOANTERIOR = new System.Windows.Forms.TextBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.gbSALDO = new System.Windows.Forms.GroupBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblMENSJAE = new System.Windows.Forms.Label();
            this.gbSALDO.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo actual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo anterior:";
            // 
            // txtIMPORTE
            // 
            this.txtIMPORTE.Location = new System.Drawing.Point(132, 26);
            this.txtIMPORTE.Name = "txtIMPORTE";
            this.txtIMPORTE.Size = new System.Drawing.Size(171, 22);
            this.txtIMPORTE.TabIndex = 0;
            this.txtIMPORTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIMPORTE_KeyDown);
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(132, 71);
            this.txtDESCRIPCION.Multiline = true;
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(253, 157);
            this.txtDESCRIPCION.TabIndex = 1;
            // 
            // txtSALDOACTUAL
            // 
            this.txtSALDOACTUAL.Location = new System.Drawing.Point(6, 41);
            this.txtSALDOACTUAL.Name = "txtSALDOACTUAL";
            this.txtSALDOACTUAL.Size = new System.Drawing.Size(129, 22);
            this.txtSALDOACTUAL.TabIndex = 8;
            // 
            // txtSALDOANTERIOR
            // 
            this.txtSALDOANTERIOR.Location = new System.Drawing.Point(6, 109);
            this.txtSALDOANTERIOR.Name = "txtSALDOANTERIOR";
            this.txtSALDOANTERIOR.Size = new System.Drawing.Size(129, 22);
            this.txtSALDOANTERIOR.TabIndex = 9;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(132, 261);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(93, 66);
            this.btnGUARDAR.TabIndex = 2;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // gbSALDO
            // 
            this.gbSALDO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbSALDO.Controls.Add(this.label4);
            this.gbSALDO.Controls.Add(this.txtSALDOACTUAL);
            this.gbSALDO.Controls.Add(this.txtSALDOANTERIOR);
            this.gbSALDO.Controls.Add(this.label5);
            this.gbSALDO.Location = new System.Drawing.Point(413, 71);
            this.gbSALDO.Name = "gbSALDO";
            this.gbSALDO.Size = new System.Drawing.Size(155, 157);
            this.gbSALDO.TabIndex = 11;
            this.gbSALDO.TabStop = false;
            this.gbSALDO.Text = "SALDO";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._112_LeftArrowLong_Blue_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(264, 261);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 3;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // lblMENSJAE
            // 
            this.lblMENSJAE.AutoSize = true;
            this.lblMENSJAE.Location = new System.Drawing.Point(23, 341);
            this.lblMENSJAE.Name = "lblMENSJAE";
            this.lblMENSJAE.Size = new System.Drawing.Size(0, 17);
            this.lblMENSJAE.TabIndex = 13;
            // 
            // FrmIngresaMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.lblMENSJAE);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.gbSALDO);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.txtIMPORTE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmIngresaMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..INGRESA MOVIMIENTO";
            this.gbSALDO.ResumeLayout(false);
            this.gbSALDO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIMPORTE;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.TextBox txtSALDOACTUAL;
        private System.Windows.Forms.TextBox txtSALDOANTERIOR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.GroupBox gbSALDO;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label lblMENSJAE;
    }
}