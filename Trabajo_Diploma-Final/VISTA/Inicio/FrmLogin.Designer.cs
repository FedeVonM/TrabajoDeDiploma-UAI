namespace VISTA.Inicio
{
    partial class FrmLogin
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
            this.llRECUPERAR_CLAVE = new System.Windows.Forms.LinkLabel();
            this.lblMENSAJE = new System.Windows.Forms.Label();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.txtCLAVE = new System.Windows.Forms.TextBox();
            this.txtNOMBRE_USUARIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llRECUPERAR_CLAVE
            // 
            this.llRECUPERAR_CLAVE.AutoSize = true;
            this.llRECUPERAR_CLAVE.Location = new System.Drawing.Point(324, 215);
            this.llRECUPERAR_CLAVE.Name = "llRECUPERAR_CLAVE";
            this.llRECUPERAR_CLAVE.Size = new System.Drawing.Size(127, 17);
            this.llRECUPERAR_CLAVE.TabIndex = 13;
            this.llRECUPERAR_CLAVE.TabStop = true;
            this.llRECUPERAR_CLAVE.Text = "Olvidaste la clave?";
            this.llRECUPERAR_CLAVE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRECUPERAR_CLAVE_LinkClicked);
            // 
            // lblMENSAJE
            // 
            this.lblMENSAJE.AutoSize = true;
            this.lblMENSAJE.Location = new System.Drawing.Point(103, 185);
            this.lblMENSAJE.Name = "lblMENSAJE";
            this.lblMENSAJE.Size = new System.Drawing.Size(0, 17);
            this.lblMENSAJE.TabIndex = 12;
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINGRESAR.Image = global::VISTA.Properties.Resources._112_RightArrowLong_Blue_48x48_72;
            this.btnINGRESAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnINGRESAR.Location = new System.Drawing.Point(172, 124);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(279, 53);
            this.btnINGRESAR.TabIndex = 11;
            this.btnINGRESAR.Text = "Ingresar";
            this.btnINGRESAR.UseVisualStyleBackColor = true;
            this.btnINGRESAR.Click += new System.EventHandler(this.btnINGRESAR_Click);
            // 
            // txtCLAVE
            // 
            this.txtCLAVE.Location = new System.Drawing.Point(172, 76);
            this.txtCLAVE.Name = "txtCLAVE";
            this.txtCLAVE.PasswordChar = '*';
            this.txtCLAVE.Size = new System.Drawing.Size(279, 22);
            this.txtCLAVE.TabIndex = 10;
            // 
            // txtNOMBRE_USUARIO
            // 
            this.txtNOMBRE_USUARIO.Location = new System.Drawing.Point(172, 19);
            this.txtNOMBRE_USUARIO.Name = "txtNOMBRE_USUARIO";
            this.txtNOMBRE_USUARIO.Size = new System.Drawing.Size(279, 22);
            this.txtNOMBRE_USUARIO.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 253);
            this.Controls.Add(this.llRECUPERAR_CLAVE);
            this.Controls.Add(this.lblMENSAJE);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.txtCLAVE);
            this.Controls.Add(this.txtNOMBRE_USUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..ACCESO AL SISTEMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llRECUPERAR_CLAVE;
        private System.Windows.Forms.Label lblMENSAJE;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.TextBox txtCLAVE;
        private System.Windows.Forms.TextBox txtNOMBRE_USUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}