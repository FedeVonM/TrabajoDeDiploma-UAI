namespace VISTA.Seguridad
{
    partial class FrmClaveUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.chkMAIL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRESETEAR_CLAVE = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNUEVA_CLAVE2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNUEVA_CLAVE = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnGENERAR_CLAVE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMAIL);
            this.panel1.Controls.Add(this.chkMAIL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkRESETEAR_CLAVE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGENERAR_CLAVE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNUEVA_CLAVE2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNUEVA_CLAVE);
            this.panel1.Controls.Add(this.txtNOMBRE);
            this.panel1.Controls.Add(this.txtUSUARIO);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 335);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario:";
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(142, 287);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.ReadOnly = true;
            this.txtMAIL.Size = new System.Drawing.Size(352, 22);
            this.txtMAIL.TabIndex = 10;
            // 
            // chkMAIL
            // 
            this.chkMAIL.AutoSize = true;
            this.chkMAIL.Location = new System.Drawing.Point(142, 260);
            this.chkMAIL.Name = "chkMAIL";
            this.chkMAIL.Size = new System.Drawing.Size(225, 21);
            this.chkMAIL.TabIndex = 13;
            this.chkMAIL.Text = "Enviar clave al mail del usuario";
            this.chkMAIL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // chkRESETEAR_CLAVE
            // 
            this.chkRESETEAR_CLAVE.AutoSize = true;
            this.chkRESETEAR_CLAVE.Location = new System.Drawing.Point(142, 209);
            this.chkRESETEAR_CLAVE.Name = "chkRESETEAR_CLAVE";
            this.chkRESETEAR_CLAVE.Size = new System.Drawing.Size(234, 21);
            this.chkRESETEAR_CLAVE.TabIndex = 12;
            this.chkRESETEAR_CLAVE.Text = "Resetear clave en próximo inicio";
            this.chkRESETEAR_CLAVE.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repetir clave:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cambiar clave:";
            // 
            // txtNUEVA_CLAVE2
            // 
            this.txtNUEVA_CLAVE2.Location = new System.Drawing.Point(142, 156);
            this.txtNUEVA_CLAVE2.Name = "txtNUEVA_CLAVE2";
            this.txtNUEVA_CLAVE2.PasswordChar = '*';
            this.txtNUEVA_CLAVE2.Size = new System.Drawing.Size(352, 22);
            this.txtNUEVA_CLAVE2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enviar email:";
            // 
            // txtNUEVA_CLAVE
            // 
            this.txtNUEVA_CLAVE.Location = new System.Drawing.Point(142, 105);
            this.txtNUEVA_CLAVE.Name = "txtNUEVA_CLAVE";
            this.txtNUEVA_CLAVE.PasswordChar = '*';
            this.txtNUEVA_CLAVE.Size = new System.Drawing.Size(352, 22);
            this.txtNUEVA_CLAVE.TabIndex = 8;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(142, 3);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.ReadOnly = true;
            this.txtNOMBRE.Size = new System.Drawing.Size(352, 22);
            this.txtNOMBRE.TabIndex = 6;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(142, 54);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.ReadOnly = true;
            this.txtUSUARIO.Size = new System.Drawing.Size(352, 22);
            this.txtUSUARIO.TabIndex = 7;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Error_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(559, 364);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 19;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(413, 364);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(93, 66);
            this.btnGUARDAR.TabIndex = 18;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnGENERAR_CLAVE
            // 
            this.btnGENERAR_CLAVE.Image = global::VISTA.Properties.Resources._112_RefreshArrow_Blue_32x42_72;
            this.btnGENERAR_CLAVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGENERAR_CLAVE.Location = new System.Drawing.Point(509, 105);
            this.btnGENERAR_CLAVE.Name = "btnGENERAR_CLAVE";
            this.btnGENERAR_CLAVE.Size = new System.Drawing.Size(122, 68);
            this.btnGENERAR_CLAVE.TabIndex = 11;
            this.btnGENERAR_CLAVE.Text = "Generar Clave";
            this.btnGENERAR_CLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGENERAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnGENERAR_CLAVE.Click += new System.EventHandler(this.btnGENERAR_CLAVE_Click);
            // 
            // FrmClaveUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(668, 445);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClaveUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClaveUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.CheckBox chkMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRESETEAR_CLAVE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGENERAR_CLAVE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNUEVA_CLAVE2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNUEVA_CLAVE;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtUSUARIO;
    }
}