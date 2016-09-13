namespace VISTA.Caja
{
    partial class FrmMovimientos
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
            this.gbFILTRO = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMOVIMIENTOS_CAJA = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.gbTOTALES = new System.Windows.Forms.GroupBox();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.txtSALIDAS = new System.Windows.Forms.TextBox();
            this.txtENTRADAS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFILTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMOVIMIENTOS_CAJA)).BeginInit();
            this.gbTOTALES.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFILTRO
            // 
            this.gbFILTRO.Controls.Add(this.btnBUSCAR);
            this.gbFILTRO.Controls.Add(this.dtpFECHA);
            this.gbFILTRO.Controls.Add(this.label1);
            this.gbFILTRO.Location = new System.Drawing.Point(13, 13);
            this.gbFILTRO.Name = "gbFILTRO";
            this.gbFILTRO.Size = new System.Drawing.Size(398, 100);
            this.gbFILTRO.TabIndex = 0;
            this.gbFILTRO.TabStop = false;
            this.gbFILTRO.Text = "FILTRO";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::VISTA.Properties.Resources.search;
            this.btnBUSCAR.Location = new System.Drawing.Point(267, 21);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 66);
            this.btnBUSCAR.TabIndex = 7;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFECHA.Location = new System.Drawing.Point(77, 40);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(140, 22);
            this.dtpFECHA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dgvMOVIMIENTOS_CAJA
            // 
            this.dgvMOVIMIENTOS_CAJA.AllowUserToAddRows = false;
            this.dgvMOVIMIENTOS_CAJA.AllowUserToDeleteRows = false;
            this.dgvMOVIMIENTOS_CAJA.AllowUserToResizeColumns = false;
            this.dgvMOVIMIENTOS_CAJA.AllowUserToResizeRows = false;
            this.dgvMOVIMIENTOS_CAJA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMOVIMIENTOS_CAJA.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMOVIMIENTOS_CAJA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMOVIMIENTOS_CAJA.Location = new System.Drawing.Point(13, 129);
            this.dgvMOVIMIENTOS_CAJA.Name = "dgvMOVIMIENTOS_CAJA";
            this.dgvMOVIMIENTOS_CAJA.ReadOnly = true;
            this.dgvMOVIMIENTOS_CAJA.RowTemplate.Height = 24;
            this.dgvMOVIMIENTOS_CAJA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMOVIMIENTOS_CAJA.Size = new System.Drawing.Size(1133, 356);
            this.dgvMOVIMIENTOS_CAJA.TabIndex = 1;
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(155, 521);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(93, 66);
            this.btnCONSULTAR.TabIndex = 22;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(1053, 521);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(93, 66);
            this.btnCERRAR.TabIndex = 21;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::VISTA.Properties.Resources._112_Plus_Green_32x42_72;
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 521);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 66);
            this.btnAGREGAR.TabIndex = 17;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // gbTOTALES
            // 
            this.gbTOTALES.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbTOTALES.Controls.Add(this.txtTOTAL);
            this.gbTOTALES.Controls.Add(this.txtSALIDAS);
            this.gbTOTALES.Controls.Add(this.txtENTRADAS);
            this.gbTOTALES.Controls.Add(this.label4);
            this.gbTOTALES.Controls.Add(this.label3);
            this.gbTOTALES.Controls.Add(this.label2);
            this.gbTOTALES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTOTALES.Location = new System.Drawing.Point(316, 492);
            this.gbTOTALES.Name = "gbTOTALES";
            this.gbTOTALES.Size = new System.Drawing.Size(572, 126);
            this.gbTOTALES.TabIndex = 23;
            this.gbTOTALES.TabStop = false;
            this.gbTOTALES.Text = "TOTALES";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(388, 78);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(124, 27);
            this.txtTOTAL.TabIndex = 5;
            // 
            // txtSALIDAS
            // 
            this.txtSALIDAS.Location = new System.Drawing.Point(197, 78);
            this.txtSALIDAS.Name = "txtSALIDAS";
            this.txtSALIDAS.ReadOnly = true;
            this.txtSALIDAS.Size = new System.Drawing.Size(124, 27);
            this.txtSALIDAS.TabIndex = 4;
            // 
            // txtENTRADAS
            // 
            this.txtENTRADAS.Location = new System.Drawing.Point(6, 78);
            this.txtENTRADAS.Name = "txtENTRADAS";
            this.txtENTRADAS.ReadOnly = true;
            this.txtENTRADAS.Size = new System.Drawing.Size(124, 27);
            this.txtENTRADAS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salidas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Entradas:";
            // 
            // FrmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1158, 635);
            this.Controls.Add(this.gbTOTALES);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvMOVIMIENTOS_CAJA);
            this.Controls.Add(this.gbFILTRO);
            this.Name = "FrmMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..MOVIMIENTOS CAJA";
            this.gbFILTRO.ResumeLayout(false);
            this.gbFILTRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMOVIMIENTOS_CAJA)).EndInit();
            this.gbTOTALES.ResumeLayout(false);
            this.gbTOTALES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFILTRO;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.DataGridView dgvMOVIMIENTOS_CAJA;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.GroupBox gbTOTALES;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.TextBox txtSALIDAS;
        private System.Windows.Forms.TextBox txtENTRADAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}