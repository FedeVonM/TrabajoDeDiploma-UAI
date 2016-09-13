namespace VISTA.Seguridad
{
    partial class FrmUsuario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDATOS = new System.Windows.Forms.TabPage();
            this.chkACTIVO = new System.Windows.Forms.CheckBox();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpGRUPOS = new System.Windows.Forms.TabPage();
            this.chkGRUPOS = new System.Windows.Forms.CheckedListBox();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpDATOS.SuspendLayout();
            this.tpGRUPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDATOS);
            this.tabControl1.Controls.Add(this.tpGRUPOS);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 440);
            this.tabControl1.TabIndex = 4;
            // 
            // tpDATOS
            // 
            this.tpDATOS.Controls.Add(this.chkACTIVO);
            this.tpDATOS.Controls.Add(this.txtTELEFONO);
            this.tpDATOS.Controls.Add(this.txtEMAIL);
            this.tpDATOS.Controls.Add(this.txtNOMBRE);
            this.tpDATOS.Controls.Add(this.txtUSUARIO);
            this.tpDATOS.Controls.Add(this.txtCODIGO);
            this.tpDATOS.Controls.Add(this.label6);
            this.tpDATOS.Controls.Add(this.label5);
            this.tpDATOS.Controls.Add(this.label4);
            this.tpDATOS.Controls.Add(this.label3);
            this.tpDATOS.Controls.Add(this.label2);
            this.tpDATOS.Controls.Add(this.label1);
            this.tpDATOS.Location = new System.Drawing.Point(4, 25);
            this.tpDATOS.Name = "tpDATOS";
            this.tpDATOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpDATOS.Size = new System.Drawing.Size(603, 411);
            this.tpDATOS.TabIndex = 0;
            this.tpDATOS.Text = "Datos";
            this.tpDATOS.UseVisualStyleBackColor = true;
            // 
            // chkACTIVO
            // 
            this.chkACTIVO.AutoSize = true;
            this.chkACTIVO.Location = new System.Drawing.Point(86, 269);
            this.chkACTIVO.Name = "chkACTIVO";
            this.chkACTIVO.Size = new System.Drawing.Size(68, 21);
            this.chkACTIVO.TabIndex = 11;
            this.chkACTIVO.Text = "Activo";
            this.chkACTIVO.UseVisualStyleBackColor = true;
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(85, 215);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(336, 22);
            this.txtTELEFONO.TabIndex = 10;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(85, 164);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(336, 22);
            this.txtEMAIL.TabIndex = 9;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(85, 113);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(336, 22);
            this.txtNOMBRE.TabIndex = 8;
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(85, 62);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(336, 22);
            this.txtUSUARIO.TabIndex = 7;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(85, 11);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.ReadOnly = true;
            this.txtCODIGO.Size = new System.Drawing.Size(253, 22);
            this.txtCODIGO.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tpGRUPOS
            // 
            this.tpGRUPOS.Controls.Add(this.chkGRUPOS);
            this.tpGRUPOS.Location = new System.Drawing.Point(4, 25);
            this.tpGRUPOS.Name = "tpGRUPOS";
            this.tpGRUPOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpGRUPOS.Size = new System.Drawing.Size(603, 411);
            this.tpGRUPOS.TabIndex = 1;
            this.tpGRUPOS.Text = "Grupos";
            this.tpGRUPOS.UseVisualStyleBackColor = true;
            // 
            // chkGRUPOS
            // 
            this.chkGRUPOS.FormattingEnabled = true;
            this.chkGRUPOS.Location = new System.Drawing.Point(35, 24);
            this.chkGRUPOS.Name = "chkGRUPOS";
            this.chkGRUPOS.Size = new System.Drawing.Size(501, 378);
            this.chkGRUPOS.TabIndex = 0;
            this.chkGRUPOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkGRUPOS_ItemCheck);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Error_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(526, 458);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(394, 458);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(93, 66);
            this.btnGUARDAR.TabIndex = 5;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(639, 536);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::..GESTIÓN DE USUARIO";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpDATOS.ResumeLayout(false);
            this.tpDATOS.PerformLayout();
            this.tpGRUPOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDATOS;
        private System.Windows.Forms.CheckBox chkACTIVO;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpGRUPOS;
        private System.Windows.Forms.CheckedListBox chkGRUPOS;
    }
}