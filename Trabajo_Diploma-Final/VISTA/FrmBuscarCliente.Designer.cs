namespace VISTA
{
    partial class FrmBuscarCliente
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
            this.gbFILTRO = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtAPELLIDO_CLIENTE = new System.Windows.Forms.TextBox();
            this.txtNOMBRE_CLIENTE = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            this.gbFILTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.AllowUserToAddRows = false;
            this.dgvCLIENTES.AllowUserToDeleteRows = false;
            this.dgvCLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCLIENTES.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTES.Location = new System.Drawing.Point(11, 148);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.ReadOnly = true;
            this.dgvCLIENTES.RowTemplate.Height = 24;
            this.dgvCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCLIENTES.Size = new System.Drawing.Size(809, 380);
            this.dgvCLIENTES.TabIndex = 11;
            this.dgvCLIENTES.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLIENTES_CellContentDoubleClick);
            // 
            // gbFILTRO
            // 
            this.gbFILTRO.Controls.Add(this.label2);
            this.gbFILTRO.Controls.Add(this.label1);
            this.gbFILTRO.Controls.Add(this.btnBUSCAR);
            this.gbFILTRO.Controls.Add(this.txtAPELLIDO_CLIENTE);
            this.gbFILTRO.Controls.Add(this.txtNOMBRE_CLIENTE);
            this.gbFILTRO.Location = new System.Drawing.Point(12, 12);
            this.gbFILTRO.Name = "gbFILTRO";
            this.gbFILTRO.Size = new System.Drawing.Size(604, 130);
            this.gbFILTRO.TabIndex = 10;
            this.gbFILTRO.TabStop = false;
            this.gbFILTRO.Text = "FILTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::VISTA.Properties.Resources.search;
            this.btnBUSCAR.Location = new System.Drawing.Point(483, 41);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(93, 66);
            this.btnBUSCAR.TabIndex = 7;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtAPELLIDO_CLIENTE
            // 
            this.txtAPELLIDO_CLIENTE.Location = new System.Drawing.Point(94, 85);
            this.txtAPELLIDO_CLIENTE.Name = "txtAPELLIDO_CLIENTE";
            this.txtAPELLIDO_CLIENTE.Size = new System.Drawing.Size(319, 22);
            this.txtAPELLIDO_CLIENTE.TabIndex = 3;
            // 
            // txtNOMBRE_CLIENTE
            // 
            this.txtNOMBRE_CLIENTE.Location = new System.Drawing.Point(94, 31);
            this.txtNOMBRE_CLIENTE.Name = "txtNOMBRE_CLIENTE";
            this.txtNOMBRE_CLIENTE.Size = new System.Drawing.Size(319, 22);
            this.txtNOMBRE_CLIENTE.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(593, 543);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 66);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::VISTA.Properties.Resources._305_Close_32x42_72;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(727, 543);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 66);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(835, 625);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvCLIENTES);
            this.Controls.Add(this.gbFILTRO);
            this.Name = "FrmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..BUSCAR CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            this.gbFILTRO.ResumeLayout(false);
            this.gbFILTRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
        private System.Windows.Forms.GroupBox gbFILTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtAPELLIDO_CLIENTE;
        private System.Windows.Forms.TextBox txtNOMBRE_CLIENTE;
    }
}