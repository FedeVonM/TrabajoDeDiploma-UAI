namespace VISTA.Clientes
{
    partial class FrmCuentaCorriente
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
            this.dgbFILTRO = new System.Windows.Forms.GroupBox();
            this.rbTODOS = new System.Windows.Forms.RadioButton();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.rbFECHA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMOVIMIENTOS = new System.Windows.Forms.DataGridView();
            this.lblCLIENTE = new System.Windows.Forms.Label();
            this.btnIngresarPago = new System.Windows.Forms.Button();
            this.btnINGRESARMOVIMIENTO = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.dgbFILTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMOVIMIENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbFILTRO
            // 
            this.dgbFILTRO.Controls.Add(this.rbTODOS);
            this.dgbFILTRO.Controls.Add(this.dtpHASTA);
            this.dgbFILTRO.Controls.Add(this.dtpDESDE);
            this.dgbFILTRO.Controls.Add(this.rbFECHA);
            this.dgbFILTRO.Controls.Add(this.label2);
            this.dgbFILTRO.Controls.Add(this.btnBUSCAR);
            this.dgbFILTRO.Controls.Add(this.label1);
            this.dgbFILTRO.Location = new System.Drawing.Point(12, 12);
            this.dgbFILTRO.Name = "dgbFILTRO";
            this.dgbFILTRO.Size = new System.Drawing.Size(678, 95);
            this.dgbFILTRO.TabIndex = 16;
            this.dgbFILTRO.TabStop = false;
            this.dgbFILTRO.Text = "FILTRO";
            // 
            // rbTODOS
            // 
            this.rbTODOS.AutoSize = true;
            this.rbTODOS.Checked = true;
            this.rbTODOS.Location = new System.Drawing.Point(23, 21);
            this.rbTODOS.Name = "rbTODOS";
            this.rbTODOS.Size = new System.Drawing.Size(69, 21);
            this.rbTODOS.TabIndex = 12;
            this.rbTODOS.TabStop = true;
            this.rbTODOS.Text = "Todos";
            this.rbTODOS.UseVisualStyleBackColor = true;
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHASTA.Location = new System.Drawing.Point(377, 65);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(117, 22);
            this.dtpHASTA.TabIndex = 11;
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDESDE.Location = new System.Drawing.Point(168, 65);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(117, 22);
            this.dtpDESDE.TabIndex = 10;
            // 
            // rbFECHA
            // 
            this.rbFECHA.AutoSize = true;
            this.rbFECHA.Location = new System.Drawing.Point(23, 65);
            this.rbFECHA.Name = "rbFECHA";
            this.rbFECHA.Size = new System.Drawing.Size(68, 21);
            this.rbFECHA.TabIndex = 9;
            this.rbFECHA.TabStop = true;
            this.rbFECHA.Text = "Fecha";
            this.rbFECHA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(322, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(108, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // dgvMOVIMIENTOS
            // 
            this.dgvMOVIMIENTOS.AllowUserToAddRows = false;
            this.dgvMOVIMIENTOS.AllowUserToDeleteRows = false;
            this.dgvMOVIMIENTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMOVIMIENTOS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMOVIMIENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMOVIMIENTOS.Location = new System.Drawing.Point(12, 113);
            this.dgvMOVIMIENTOS.Name = "dgvMOVIMIENTOS";
            this.dgvMOVIMIENTOS.ReadOnly = true;
            this.dgvMOVIMIENTOS.RowTemplate.Height = 24;
            this.dgvMOVIMIENTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMOVIMIENTOS.Size = new System.Drawing.Size(1134, 359);
            this.dgvMOVIMIENTOS.TabIndex = 17;
            // 
            // lblCLIENTE
            // 
            this.lblCLIENTE.AutoSize = true;
            this.lblCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLIENTE.ForeColor = System.Drawing.Color.White;
            this.lblCLIENTE.Location = new System.Drawing.Point(697, 33);
            this.lblCLIENTE.Name = "lblCLIENTE";
            this.lblCLIENTE.Size = new System.Drawing.Size(0, 24);
            this.lblCLIENTE.TabIndex = 18;
            // 
            // btnIngresarPago
            // 
            this.btnIngresarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPago.Location = new System.Drawing.Point(12, 478);
            this.btnIngresarPago.Name = "btnIngresarPago";
            this.btnIngresarPago.Size = new System.Drawing.Size(105, 63);
            this.btnIngresarPago.TabIndex = 19;
            this.btnIngresarPago.Text = "Ingresar Pago";
            this.btnIngresarPago.UseVisualStyleBackColor = true;
            this.btnIngresarPago.Click += new System.EventHandler(this.btnIngresarPago_Click);
            // 
            // btnINGRESARMOVIMIENTO
            // 
            this.btnINGRESARMOVIMIENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINGRESARMOVIMIENTO.Location = new System.Drawing.Point(154, 478);
            this.btnINGRESARMOVIMIENTO.Name = "btnINGRESARMOVIMIENTO";
            this.btnINGRESARMOVIMIENTO.Size = new System.Drawing.Size(120, 63);
            this.btnINGRESARMOVIMIENTO.TabIndex = 20;
            this.btnINGRESARMOVIMIENTO.Text = "Ingresar Movimiento";
            this.btnINGRESARMOVIMIENTO.UseVisualStyleBackColor = true;
            this.btnINGRESARMOVIMIENTO.Click += new System.EventHandler(this.btnINGRESARMOVIMIENTO_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Location = new System.Drawing.Point(1041, 478);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(105, 63);
            this.btnSALIR.TabIndex = 21;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // FrmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1158, 563);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnINGRESARMOVIMIENTO);
            this.Controls.Add(this.btnIngresarPago);
            this.Controls.Add(this.lblCLIENTE);
            this.Controls.Add(this.dgvMOVIMIENTOS);
            this.Controls.Add(this.dgbFILTRO);
            this.Name = "FrmCuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..CUENTA CORRIENTE";
            this.dgbFILTRO.ResumeLayout(false);
            this.dgbFILTRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMOVIMIENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dgbFILTRO;
        private System.Windows.Forms.RadioButton rbTODOS;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.RadioButton rbFECHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMOVIMIENTOS;
        private System.Windows.Forms.Label lblCLIENTE;
        private System.Windows.Forms.Button btnIngresarPago;
        private System.Windows.Forms.Button btnINGRESARMOVIMIENTO;
        private System.Windows.Forms.Button btnSALIR;
    }
}