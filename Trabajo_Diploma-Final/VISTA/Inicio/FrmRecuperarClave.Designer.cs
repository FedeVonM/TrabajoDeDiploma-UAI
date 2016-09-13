namespace VISTA.Inicio
{
    partial class FrmRecuperarClave
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
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnRECUPERAR_CLAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(61, 20);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(417, 22);
            this.txtMAIL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mail:";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Error_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(370, 83);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(108, 60);
            this.btnCANCELAR.TabIndex = 7;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnRECUPERAR_CLAVE
            // 
            this.btnRECUPERAR_CLAVE.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnRECUPERAR_CLAVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRECUPERAR_CLAVE.Location = new System.Drawing.Point(213, 83);
            this.btnRECUPERAR_CLAVE.Name = "btnRECUPERAR_CLAVE";
            this.btnRECUPERAR_CLAVE.Size = new System.Drawing.Size(129, 60);
            this.btnRECUPERAR_CLAVE.TabIndex = 6;
            this.btnRECUPERAR_CLAVE.Text = "Recuperar Clave";
            this.btnRECUPERAR_CLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRECUPERAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnRECUPERAR_CLAVE.Click += new System.EventHandler(this.btnRECUPERAR_CLAVE_Click);
            // 
            // FrmRecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(499, 171);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnRECUPERAR_CLAVE);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecuperarClave";
            this.Text = "::..RECUPERAR DATOS Y CLAVE DE USUARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnRECUPERAR_CLAVE;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Label label1;
    }
}