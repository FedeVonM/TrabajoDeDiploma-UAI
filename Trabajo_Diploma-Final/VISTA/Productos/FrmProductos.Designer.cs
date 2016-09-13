namespace VISTA.Productos
{
    partial class FrmProductos
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
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.rbCODIGO = new System.Windows.Forms.RadioButton();
            this.rbDESCRIPCION = new System.Windows.Forms.RadioButton();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.AllowUserToAddRows = false;
            this.dgvPRODUCTOS.AllowUserToDeleteRows = false;
            this.dgvPRODUCTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPRODUCTOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(13, 119);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.ReadOnly = true;
            this.dgvPRODUCTOS.RowTemplate.Height = 24;
            this.dgvPRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(1133, 359);
            this.dgvPRODUCTOS.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCODIGO);
            this.groupBox1.Controls.Add(this.rbCODIGO);
            this.groupBox1.Controls.Add(this.rbDESCRIPCION);
            this.groupBox1.Controls.Add(this.btnBUSCAR);
            this.groupBox1.Controls.Add(this.txtDESCRIPCION);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 101);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(144, 59);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.Size = new System.Drawing.Size(343, 22);
            this.txtCODIGO.TabIndex = 9;
            // 
            // rbCODIGO
            // 
            this.rbCODIGO.AutoSize = true;
            this.rbCODIGO.Location = new System.Drawing.Point(31, 60);
            this.rbCODIGO.Name = "rbCODIGO";
            this.rbCODIGO.Size = new System.Drawing.Size(77, 21);
            this.rbCODIGO.TabIndex = 8;
            this.rbCODIGO.Text = "Código:";
            this.rbCODIGO.UseVisualStyleBackColor = true;
            // 
            // rbDESCRIPCION
            // 
            this.rbDESCRIPCION.AutoSize = true;
            this.rbDESCRIPCION.Checked = true;
            this.rbDESCRIPCION.Location = new System.Drawing.Point(31, 21);
            this.rbDESCRIPCION.Name = "rbDESCRIPCION";
            this.rbDESCRIPCION.Size = new System.Drawing.Size(107, 21);
            this.rbDESCRIPCION.TabIndex = 7;
            this.rbDESCRIPCION.TabStop = true;
            this.rbDESCRIPCION.Text = "Descripción:";
            this.rbDESCRIPCION.UseVisualStyleBackColor = true;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::VISTA.Properties.Resources.search;
            this.btnBUSCAR.Location = new System.Drawing.Point(556, 21);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 66);
            this.btnBUSCAR.TabIndex = 6;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(144, 20);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(343, 22);
            this.txtDESCRIPCION.TabIndex = 2;
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(1053, 485);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(93, 66);
            this.btnCERRAR.TabIndex = 20;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(355, 484);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(93, 66);
            this.btnCONSULTAR.TabIndex = 19;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::VISTA.Properties.Resources._126_Edit_32x42_72;
            this.btnMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICAR.Location = new System.Drawing.Point(241, 484);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(93, 66);
            this.btnMODIFICAR.TabIndex = 18;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::VISTA.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnELIMINAR.Location = new System.Drawing.Point(127, 484);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(93, 66);
            this.btnELIMINAR.TabIndex = 17;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::VISTA.Properties.Resources._112_Plus_Green_32x42_72;
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(13, 484);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 66);
            this.btnAGREGAR.TabIndex = 16;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1158, 563);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..GESTIÓN DE PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.RadioButton rbCODIGO;
        private System.Windows.Forms.RadioButton rbDESCRIPCION;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
    }
}