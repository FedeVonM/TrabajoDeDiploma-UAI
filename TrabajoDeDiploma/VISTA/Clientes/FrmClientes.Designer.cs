namespace VISTA.Clientes
{
    partial class FrmClientes
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
            this.dgvCLIENTES = new System.Windows.Forms.DataGridView();
            this.dgbFILTRO = new System.Windows.Forms.GroupBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCUENTACORRIENTE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            this.dgbFILTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.AllowUserToAddRows = false;
            this.dgvCLIENTES.AllowUserToDeleteRows = false;
            this.dgvCLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLIENTES.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTES.Location = new System.Drawing.Point(12, 113);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.ReadOnly = true;
            this.dgvCLIENTES.RowTemplate.Height = 24;
            this.dgvCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCLIENTES.Size = new System.Drawing.Size(1134, 359);
            this.dgvCLIENTES.TabIndex = 16;
            // 
            // dgbFILTRO
            // 
            this.dgbFILTRO.Controls.Add(this.btnBUSCAR);
            this.dgbFILTRO.Controls.Add(this.txtBUSCAR);
            this.dgbFILTRO.Controls.Add(this.label1);
            this.dgbFILTRO.Location = new System.Drawing.Point(12, 12);
            this.dgbFILTRO.Name = "dgbFILTRO";
            this.dgbFILTRO.Size = new System.Drawing.Size(678, 95);
            this.dgbFILTRO.TabIndex = 15;
            this.dgbFILTRO.TabStop = false;
            this.dgbFILTRO.Text = "FILTRO";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::VISTA.Properties.Resources.search;
            this.btnBUSCAR.Location = new System.Drawing.Point(565, 21);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 66);
            this.btnBUSCAR.TabIndex = 7;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(144, 31);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(343, 22);
            this.txtBUSCAR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(1053, 482);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(93, 66);
            this.btnCERRAR.TabIndex = 21;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Image = global::VISTA.Properties.Resources._005_Task_32x42_72;
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(387, 482);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(93, 66);
            this.btnCONSULTAR.TabIndex = 20;
            this.btnCONSULTAR.Text = "Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::VISTA.Properties.Resources._126_Edit_32x42_72;
            this.btnMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICAR.Location = new System.Drawing.Point(262, 482);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(93, 66);
            this.btnMODIFICAR.TabIndex = 19;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::VISTA.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnELIMINAR.Location = new System.Drawing.Point(137, 482);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(93, 66);
            this.btnELIMINAR.TabIndex = 18;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::VISTA.Properties.Resources._112_Plus_Green_32x42_72;
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(12, 482);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 66);
            this.btnAGREGAR.TabIndex = 17;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnCUENTACORRIENTE
            // 
            this.btnCUENTACORRIENTE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCUENTACORRIENTE.Location = new System.Drawing.Point(513, 482);
            this.btnCUENTACORRIENTE.Name = "btnCUENTACORRIENTE";
            this.btnCUENTACORRIENTE.Size = new System.Drawing.Size(93, 66);
            this.btnCUENTACORRIENTE.TabIndex = 22;
            this.btnCUENTACORRIENTE.Text = "Cuenta Corriente";
            this.btnCUENTACORRIENTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCUENTACORRIENTE.UseVisualStyleBackColor = true;
            this.btnCUENTACORRIENTE.Click += new System.EventHandler(this.btnCUENTACORRIENTE_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1158, 563);
            this.Controls.Add(this.btnCUENTACORRIENTE);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvCLIENTES);
            this.Controls.Add(this.dgbFILTRO);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..GESTIÓN DE CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            this.dgbFILTRO.ResumeLayout(false);
            this.dgbFILTRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
        private System.Windows.Forms.GroupBox dgbFILTRO;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCUENTACORRIENTE;
    }
}