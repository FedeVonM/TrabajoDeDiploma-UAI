namespace VISTA.Seguridad
{
    partial class FrmUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.chkINACTIVOS = new System.Windows.Forms.CheckBox();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUSUARIOS = new System.Windows.Forms.DataGridView();
            this.btnRESETEAR_CLAVE = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBUSCAR);
            this.groupBox1.Controls.Add(this.chkINACTIVOS);
            this.groupBox1.Controls.Add(this.txtBUSCAR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::VISTA.Properties.Resources.search;
            this.btnBUSCAR.Location = new System.Drawing.Point(565, 18);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 66);
            this.btnBUSCAR.TabIndex = 6;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // chkINACTIVOS
            // 
            this.chkINACTIVOS.AutoSize = true;
            this.chkINACTIVOS.Location = new System.Drawing.Point(78, 60);
            this.chkINACTIVOS.Name = "chkINACTIVOS";
            this.chkINACTIVOS.Size = new System.Drawing.Size(195, 21);
            this.chkINACTIVOS.TabIndex = 3;
            this.chkINACTIVOS.Text = "Mostrar usuarios inactivos";
            this.chkINACTIVOS.UseVisualStyleBackColor = true;
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(144, 18);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(343, 22);
            this.txtBUSCAR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvUSUARIOS
            // 
            this.dgvUSUARIOS.AllowUserToAddRows = false;
            this.dgvUSUARIOS.AllowUserToDeleteRows = false;
            this.dgvUSUARIOS.AllowUserToResizeColumns = false;
            this.dgvUSUARIOS.AllowUserToResizeRows = false;
            this.dgvUSUARIOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUSUARIOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIOS.Location = new System.Drawing.Point(12, 118);
            this.dgvUSUARIOS.Name = "dgvUSUARIOS";
            this.dgvUSUARIOS.ReadOnly = true;
            this.dgvUSUARIOS.RowTemplate.Height = 24;
            this.dgvUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUSUARIOS.Size = new System.Drawing.Size(1134, 359);
            this.dgvUSUARIOS.TabIndex = 8;
            // 
            // btnRESETEAR_CLAVE
            // 
            this.btnRESETEAR_CLAVE.Image = global::VISTA.Properties.Resources._157_GetPermission_32x42_72;
            this.btnRESETEAR_CLAVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRESETEAR_CLAVE.Location = new System.Drawing.Point(347, 486);
            this.btnRESETEAR_CLAVE.Name = "btnRESETEAR_CLAVE";
            this.btnRESETEAR_CLAVE.Size = new System.Drawing.Size(93, 66);
            this.btnRESETEAR_CLAVE.TabIndex = 15;
            this.btnRESETEAR_CLAVE.Text = "Resetear Clave";
            this.btnRESETEAR_CLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRESETEAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnRESETEAR_CLAVE.Click += new System.EventHandler(this.btnRESETEAR_CLAVE_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(1053, 486);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(93, 66);
            this.btnCERRAR.TabIndex = 13;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(463, 486);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(93, 66);
            this.btnCONSULTAR.TabIndex = 12;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::VISTA.Properties.Resources._126_Edit_32x42_72;
            this.btnMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICAR.Location = new System.Drawing.Point(235, 486);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(93, 66);
            this.btnMODIFICAR.TabIndex = 11;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::VISTA.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnELIMINAR.Location = new System.Drawing.Point(123, 486);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(93, 66);
            this.btnELIMINAR.TabIndex = 10;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::VISTA.Properties.Resources._112_Plus_Green_32x42_72;
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(12, 486);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 66);
            this.btnAGREGAR.TabIndex = 9;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1158, 566);
            this.Controls.Add(this.btnRESETEAR_CLAVE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvUSUARIOS);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..GESTIÓN DE USUARIOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRESETEAR_CLAVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.CheckBox chkINACTIVOS;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvUSUARIOS;
    }
}