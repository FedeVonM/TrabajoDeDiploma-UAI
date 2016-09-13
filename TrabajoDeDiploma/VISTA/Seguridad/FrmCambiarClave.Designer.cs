namespace VISTA.Seguridad
{
    partial class FrmCambiarClave
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
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtNUEVA_CLAVE = new System.Windows.Forms.TextBox();
            this.txtREPETIR_CLAVE = new System.Windows.Forms.TextBox();
            this.txtCLAVE_ANTERIOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Error_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(322, 179);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 12;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(175, 179);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(93, 66);
            this.btnGUARDAR.TabIndex = 11;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // txtNUEVA_CLAVE
            // 
            this.txtNUEVA_CLAVE.Location = new System.Drawing.Point(113, 59);
            this.txtNUEVA_CLAVE.Name = "txtNUEVA_CLAVE";
            this.txtNUEVA_CLAVE.PasswordChar = '*';
            this.txtNUEVA_CLAVE.Size = new System.Drawing.Size(302, 22);
            this.txtNUEVA_CLAVE.TabIndex = 7;
            // 
            // txtREPETIR_CLAVE
            // 
            this.txtREPETIR_CLAVE.Location = new System.Drawing.Point(113, 110);
            this.txtREPETIR_CLAVE.Name = "txtREPETIR_CLAVE";
            this.txtREPETIR_CLAVE.PasswordChar = '*';
            this.txtREPETIR_CLAVE.Size = new System.Drawing.Size(302, 22);
            this.txtREPETIR_CLAVE.TabIndex = 9;
            // 
            // txtCLAVE_ANTERIOR
            // 
            this.txtCLAVE_ANTERIOR.Location = new System.Drawing.Point(113, 8);
            this.txtCLAVE_ANTERIOR.Name = "txtCLAVE_ANTERIOR";
            this.txtCLAVE_ANTERIOR.PasswordChar = '*';
            this.txtCLAVE_ANTERIOR.Size = new System.Drawing.Size(302, 22);
            this.txtCLAVE_ANTERIOR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repetir clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nueva clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clave actual:";
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.txtNUEVA_CLAVE);
            this.Controls.Add(this.txtREPETIR_CLAVE);
            this.Controls.Add(this.txtCLAVE_ANTERIOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..CAMBIO DE CLAVE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtNUEVA_CLAVE;
        private System.Windows.Forms.TextBox txtREPETIR_CLAVE;
        private System.Windows.Forms.TextBox txtCLAVE_ANTERIOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}