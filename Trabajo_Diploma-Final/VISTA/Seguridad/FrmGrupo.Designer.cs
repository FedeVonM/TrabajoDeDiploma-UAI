namespace VISTA.Seguridad
{
    partial class FrmGrupo
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
            this.tcDATOS = new System.Windows.Forms.TabControl();
            this.tpDATOS = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkESTADO = new System.Windows.Forms.CheckBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpUSUARIOS = new System.Windows.Forms.TabPage();
            this.chkUSUARIOS = new System.Windows.Forms.CheckedListBox();
            this.tpPERMISOS = new System.Windows.Forms.TabPage();
            this.tvACCIONES = new System.Windows.Forms.TreeView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.tcDATOS.SuspendLayout();
            this.tpDATOS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpUSUARIOS.SuspendLayout();
            this.tpPERMISOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDATOS
            // 
            this.tcDATOS.Controls.Add(this.tpDATOS);
            this.tcDATOS.Controls.Add(this.tpUSUARIOS);
            this.tcDATOS.Controls.Add(this.tpPERMISOS);
            this.tcDATOS.Location = new System.Drawing.Point(12, 12);
            this.tcDATOS.Name = "tcDATOS";
            this.tcDATOS.SelectedIndex = 0;
            this.tcDATOS.Size = new System.Drawing.Size(611, 440);
            this.tcDATOS.TabIndex = 3;
            // 
            // tpDATOS
            // 
            this.tpDATOS.Controls.Add(this.panel1);
            this.tpDATOS.Location = new System.Drawing.Point(4, 25);
            this.tpDATOS.Name = "tpDATOS";
            this.tpDATOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpDATOS.Size = new System.Drawing.Size(603, 411);
            this.tpDATOS.TabIndex = 0;
            this.tpDATOS.Text = "Datos";
            this.tpDATOS.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkESTADO);
            this.panel1.Controls.Add(this.txtDESCRIPCION);
            this.panel1.Controls.Add(this.txtCODIGO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 128);
            this.panel1.TabIndex = 0;
            // 
            // chkESTADO
            // 
            this.chkESTADO.AutoSize = true;
            this.chkESTADO.Location = new System.Drawing.Point(96, 81);
            this.chkESTADO.Name = "chkESTADO";
            this.chkESTADO.Size = new System.Drawing.Size(68, 21);
            this.chkESTADO.TabIndex = 2;
            this.chkESTADO.Text = "Activo";
            this.chkESTADO.UseVisualStyleBackColor = true;
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(96, 46);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(367, 22);
            this.txtDESCRIPCION.TabIndex = 1;
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(96, 11);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.ReadOnly = true;
            this.txtCODIGO.Size = new System.Drawing.Size(367, 22);
            this.txtCODIGO.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tpUSUARIOS
            // 
            this.tpUSUARIOS.Controls.Add(this.chkUSUARIOS);
            this.tpUSUARIOS.Location = new System.Drawing.Point(4, 25);
            this.tpUSUARIOS.Name = "tpUSUARIOS";
            this.tpUSUARIOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpUSUARIOS.Size = new System.Drawing.Size(603, 411);
            this.tpUSUARIOS.TabIndex = 1;
            this.tpUSUARIOS.Text = "Usuarios";
            this.tpUSUARIOS.UseVisualStyleBackColor = true;
            // 
            // chkUSUARIOS
            // 
            this.chkUSUARIOS.FormattingEnabled = true;
            this.chkUSUARIOS.Location = new System.Drawing.Point(24, 7);
            this.chkUSUARIOS.Name = "chkUSUARIOS";
            this.chkUSUARIOS.Size = new System.Drawing.Size(557, 395);
            this.chkUSUARIOS.TabIndex = 0;
            this.chkUSUARIOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkUSUARIOS_ItemCheck);
            // 
            // tpPERMISOS
            // 
            this.tpPERMISOS.Controls.Add(this.tvACCIONES);
            this.tpPERMISOS.Location = new System.Drawing.Point(4, 25);
            this.tpPERMISOS.Name = "tpPERMISOS";
            this.tpPERMISOS.Padding = new System.Windows.Forms.Padding(3);
            this.tpPERMISOS.Size = new System.Drawing.Size(603, 411);
            this.tpPERMISOS.TabIndex = 2;
            this.tpPERMISOS.Text = "Permisos";
            this.tpPERMISOS.UseVisualStyleBackColor = true;
            // 
            // tvACCIONES
            // 
            this.tvACCIONES.CheckBoxes = true;
            this.tvACCIONES.Location = new System.Drawing.Point(23, 6);
            this.tvACCIONES.Name = "tvACCIONES";
            this.tvACCIONES.Size = new System.Drawing.Size(557, 395);
            this.tvACCIONES.TabIndex = 0;
            this.tvACCIONES.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvACCIONES_BeforeCheck);
            this.tvACCIONES.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvACCIONES_AfterCheck);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Error_32x42_72;
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(530, 458);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(93, 66);
            this.btnCANCELAR.TabIndex = 5;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = global::VISTA.Properties.Resources._109_AllAnnotations_Default_32x42_72;
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(409, 458);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(93, 66);
            this.btnGUARDAR.TabIndex = 4;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // FrmGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(637, 539);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.tcDATOS);
            this.Name = "FrmGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrupo";
            this.Load += new System.EventHandler(this.FrmGrupo_Load);
            this.tcDATOS.ResumeLayout(false);
            this.tpDATOS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpUSUARIOS.ResumeLayout(false);
            this.tpPERMISOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TabControl tcDATOS;
        private System.Windows.Forms.TabPage tpDATOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkESTADO;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpUSUARIOS;
        private System.Windows.Forms.CheckedListBox chkUSUARIOS;
        private System.Windows.Forms.TabPage tpPERMISOS;
        private System.Windows.Forms.TreeView tvACCIONES;
    }
}