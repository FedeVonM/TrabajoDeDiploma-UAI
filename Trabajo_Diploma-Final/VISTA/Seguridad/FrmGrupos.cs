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
    [MODELO.formulario(CLASE = "FrmGrupos", DESCRIPCION = "Gestión de Grupos de Usuarios", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Seguridad")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos del grupo", FORMULARIO = "FrmGrupos")]
    [MODELO.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar grupos de usuarios", FORMULARIO = "FrmGrupos")]
    [MODELO.accion(CONTROL = "btnMODIFICAR", DESCRIPCION = "Modificar datos del grupo", FORMULARIO = "FrmGrupos")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar grupos de usuarios", FORMULARIO = "FrmGrupos")]
    public partial class FrmGrupos : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        private static FrmGrupos Instancia;

        public static FrmGrupos Obtener_Instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmGrupos(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmGrupos(oUSUARIO);

            return Instancia;
        }
        public FrmGrupos(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            oUSUARIO = miUSUARIO;
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();

            btnCONSULTAR.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGrupos", "btnCONSULTAR");
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGrupos", "btnELIMINAR");
            btnMODIFICAR.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGrupos", "btnMODIFICAR");
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("FrmGrupos", "btnAGREGAR");

            Arma_Grilla();
        }

        private void Arma_Grilla()
        {
            dgvGRUPOS.DataSource = null;
            dgvGRUPOS.DataSource = oMSeguridad.FiltrarGrupos(txtDESCRIPCION.Text, chkINACTIVOS.Checked);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista", "ATENCIÓN!!");
                return;
            }
            FrmGrupo formGRUPO = new FrmGrupo(oMSeguridad.ObtenerGrupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formGRUPO.ShowDialog();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista", "ATENCIÓN!!");
                return;
            }
            FrmGrupo formGRUPO = new FrmGrupo(oMSeguridad.ObtenerGrupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formGRUPO.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de la lista", "ATENCIÓN!!");
                return;
            }
            MODELO.GRUPO oGRUPO = oMSeguridad.ObtenerGrupo(Convert.ToInt32(dgvGRUPOS.CurrentRow.Cells[0].Value));
            DialogResult dr = DialogResult.No;
            if (oGRUPO.USUARIO.Count > 1)
            {
                dr = MessageBox.Show("El grupo  " + oGRUPO.Descripcion + " posee " + oGRUPO.USUARIO.Count + " usuarios asignados, por lo tanto no podrá ser eliminado pero si confirma la operación el estado del mismo será inactivo. ¿Confirma que desea desactivar el grupo?.", "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            if (oGRUPO.USUARIO.Count == 1)
            {
                dr = MessageBox.Show("El grupo  " + oGRUPO.Descripcion + " posee " + oGRUPO.USUARIO.Count + " usuario asignado, por lo tanto no podrá ser eliminado pero si confirma la operación el estado del mismo será inactivo. ¿Confirma que desea desactivar el grupo?.", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (oGRUPO.USUARIO.Count == 0)
            {
                dr = MessageBox.Show("El grupo  " + oGRUPO.Descripcion + " no posee usuarios asignado, por lo tanto será eliminado. ¿Confirma que desea eliminar el grupo?.", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (dr == DialogResult.Yes)
            {
                oMSeguridad.GestionaGrupo("Elimina", oGRUPO);
                Arma_Grilla();
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmGrupo formGRUPO = new FrmGrupo(new MODELO.GRUPO(), "A");
            DialogResult dr = formGRUPO.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }
    }
}
