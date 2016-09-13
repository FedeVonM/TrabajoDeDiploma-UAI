using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Seguridad
{
    public partial class FrmGrupo : Form
    {
        MODELO.GRUPO oGRUPO;
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        string ACCION;
        bool chekearU;
        bool chekearN;
        public FrmGrupo(MODELO.GRUPO miGRUPO, string miACCION)
        {
            InitializeComponent();
            oGRUPO = miGRUPO;
            ACCION = miACCION;
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();

            if (ACCION != "A")
            {
                txtCODIGO.Text = oGRUPO.Id_Grupo.ToString();
                txtDESCRIPCION.Text = oGRUPO.Descripcion;
                chkESTADO.Checked = oGRUPO.Activo;

                if (ACCION == "C")
                {
                    chkUSUARIOS.Enabled = false;
                    tpDATOS.Enabled = false;
                    btnGUARDAR.Visible = false;
                    btnCANCELAR.Text = "Cerrar";
                }
            }
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            chkUSUARIOS.DataSource = null;
            chkUSUARIOS.DataSource = oMSeguridad.ObtenerUsuarios();
            chkUSUARIOS.DisplayMember = "Nombre";
            chekearU = false;

            for (int i = 0; i < chkUSUARIOS.Items.Count; i++)
            {
                MODELO.USUARIO oUsuario = (MODELO.USUARIO)chkUSUARIOS.Items[i];
                foreach (MODELO.USUARIO miUsuario in oGRUPO.USUARIO.ToList())
                {
                    if (miUsuario.Id_Usuario == oUsuario.Id_Usuario)
                    {
                        chkUSUARIOS.SetItemChecked(i, true);
                    }
                }
            }
            chekearU = true;

            chekearN = false;
            foreach (MODELO.MODULO oMODULO in oMSeguridad.ObtenerModulos())
            {
                TreeNode tnM = new TreeNode();
                tnM.Text = oMODULO.Descripcion;
                tnM.Tag = null;
                foreach (MODELO.SUBMODULO oSM in oMODULO.SUBMODULO)
                {
                    TreeNode tnS = new TreeNode();
                    tnS.Text = oSM.Descripcion;
                    tnS.Tag = null;
                    tnM.Nodes.Add(tnS);
                    foreach (MODELO.FORMULARIO oFORM in oSM.FORMULARIO)
                    {
                        if (oFORM.ACCION.Count() > 0)
                        {
                            TreeNode tnf = new TreeNode();
                            tnf.Text = oFORM.Descripcion;
                            tnf.Tag = null;
                            tnS.Nodes.Add(tnf);
                            foreach (MODELO.ACCION oACCION in oFORM.ACCION)
                            {
                                TreeNode tnA = new TreeNode();
                                tnA.Text = oACCION.Descripcion;
                                tnA.Tag = oACCION;
                                if (oGRUPO.ACCION.Count(acc => acc.Id_Accion == oACCION.Id_Accion) > 0)
                                    tnA.Checked = true;
                                else
                                    tnA.Checked = false;

                                tnf.Nodes.Add(tnA);
                                HasCheckedChildNodes(tnf);
                            }
                        }
                    }
                }
                tvACCIONES.Nodes.Add(tnM);
            }
            chekearN = true;
        }

        private void HasCheckedChildNodes(TreeNode node)
        {
            chekearN = false;
            bool marca = true;
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (!childNode.Checked)
                        marca = false;
                }
                node.Checked = marca;
                if (node.Parent != null)
                    HasCheckedChildNodes(node.Parent);
            }
            chekearN = true;
        }

        private void chkUSUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chekearU == false) return;

            MODELO.USUARIO oUSUARIO = (MODELO.USUARIO)chkUSUARIOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGRUPO.USUARIO.Add(oUSUARIO);
            }
            else
            {
                oGRUPO.USUARIO.Remove(oUSUARIO);
            }
        }

        private void tvACCIONES_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (chekearN == false)
                return;

            TreeNode seleccion = e.Node;
            if (seleccion.Nodes.Count > 0)
            {
                checkChildNodes(seleccion, seleccion.Checked);
            }
            else
            {
                if (seleccion.Tag != null)
                {
                    MODELO.ACCION oACCION = (MODELO.ACCION)seleccion.Tag;
                    if (seleccion.Checked)
                    {
                        oGRUPO.ACCION.Add(oACCION);
                    }
                    else
                    {
                        oGRUPO.ACCION.Remove(oACCION);
                    }
                }
            }
            chekearN = false;
            if (seleccion.Parent != null)
            {
                HasCheckedChildNodes(seleccion.Parent);
            }
            chekearN = true;
        }

        private void checkChildNodes(TreeNode node, bool nodeChecked)
        {
            chekearN = false;
            foreach (TreeNode tnS in node.Nodes)
            {
                if (tnS.Nodes.Count > 0)
                {
                    tnS.Checked = nodeChecked;
                    checkChildNodes(tnS, nodeChecked);
                }
                else
                {
                    if (tnS.Checked != node.Checked)
                    {
                        tnS.Checked = node.Checked;
                        if (tnS.Tag != null)
                        {
                            MODELO.ACCION oACCION = (MODELO.ACCION)tnS.Tag;
                            if (tnS.Checked)
                            {
                                oGRUPO.ACCION.Add(oACCION);
                            }
                            else
                            {
                                oGRUPO.ACCION.Remove(oACCION);
                            }
                        }
                    }
                }
            }
            chekearN = true;
        }

        private void tvACCIONES_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (ACCION == "C") e.Cancel = true;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oMSeguridad.GestionaGrupo("Cancela", oGRUPO); //Cancelar_Cambios(oGRUPO);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar la descripción del grupo", "ATENCIÓN!!");
                return;
            }

            oGRUPO.Descripcion = txtDESCRIPCION.Text;
            oGRUPO.Activo = chkESTADO.Checked;

            if (ACCION == "A")
                oMSeguridad.GestionaGrupo("Agrega", oGRUPO);  //Agregar_Grupo(oGRUPO);
            else
                oMSeguridad.GestionaGrupo("Modifica", oGRUPO);  //Modificar_Grupo(oGRUPO);

            this.DialogResult = DialogResult.OK;
        }
    }
}
