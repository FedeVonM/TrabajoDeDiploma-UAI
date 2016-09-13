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
    [MODELO.formulario(CLASE = "FrmUsuarios", DESCRIPCION = "Gestión de Usarios del sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Seguridad")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos del usuario", FORMULARIO = "FrmUsuarios")]
    [MODELO.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar usuarios del sistema", FORMULARIO = "FrmUsuarios")]
    [MODELO.accion(CONTROL = "btnMODIFICAR", DESCRIPCION = "Modificar datos del usuario", FORMULARIO = "FrmUsuarios")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar usuarios al sistema", FORMULARIO = "FrmUsuarios")]
    [MODELO.accion(CONTROL = "btnRESETEAR_CLAVE", DESCRIPCION = "Resetear contraseñas de usuarios", FORMULARIO = "FrmUsuarios")]
    public partial class FrmUsuarios : Form
    {
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        private static FrmUsuarios Instancia;

        public static FrmUsuarios Obtener_Instancia(MODELO.USUARIO oUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmUsuarios(oUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmUsuarios(oUSUARIO);

            return Instancia;
        }
        public FrmUsuarios(MODELO.USUARIO oUsuario)
        {
            InitializeComponent();

            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();
            btnCONSULTAR.Enabled = oUsuario.VALIDAR_ACCION("FrmUsuarios", "btnCONSULTAR");
            btnELIMINAR.Enabled = oUsuario.VALIDAR_ACCION("FrmUsuarios", "btnELIMINAR");
            btnMODIFICAR.Enabled = oUsuario.VALIDAR_ACCION("FrmUsuarios", "btnMODIFICAR");
            btnAGREGAR.Enabled = oUsuario.VALIDAR_ACCION("FrmUsuarios", "btnAGREGAR");
            btnRESETEAR_CLAVE.Enabled = oUsuario.VALIDAR_ACCION("FrmUsuarios", "btnRESETEAR_CLAVE");

            Armar_Grilla();
        }

        private void Armar_Grilla()
        {
            dgvUSUARIOS.DataSource = null;
            dgvUSUARIOS.DataSource = oMSeguridad.FiltrarUsuarios(txtBUSCAR.Text, chkINACTIVOS.Checked);
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Armar_Grilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmUsuario formUSUARIO = new FrmUsuario(new MODELO.USUARIO(), "A");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                Armar_Grilla();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCIÓN!!");
                return;
            }
            MODELO.USUARIO oUSUARIO = oMSeguridad.ObtenerUsuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value));
            if (oUSUARIO.Activo == false)
            {
                MessageBox.Show("El usuario seleccionado ya ha sido desactivado del sistema", "ATENCIÓN!!");
                return;
            }
            DialogResult dr = MessageBox.Show("Confirme para desactivar al usuario del sistema", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                oUSUARIO.Activo = false;
                oMSeguridad.EliminarUsuario(oUSUARIO);
                Armar_Grilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCIÓN!!");
                return;
            }
            FrmUsuario formUSUARIO = new FrmUsuario(oMSeguridad.ObtenerUsuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                Armar_Grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCIÓN!!");
                return;
            }
            FrmUsuario formUSUARIO = new FrmUsuario(oMSeguridad.ObtenerUsuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formUSUARIO.ShowDialog();
        }

        private void btnRESETEAR_CLAVE_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCIÓN!!");
                return;
            }

            FrmClaveUsuario formCLAVE_USUARIO = new FrmClaveUsuario(oMSeguridad.ObtenerUsuario(Convert.ToInt32(dgvUSUARIOS.CurrentRow.Cells[0].Value)));
            DialogResult dr = formCLAVE_USUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Se ha cambiado la clave", "CAMBIO DE CLAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
