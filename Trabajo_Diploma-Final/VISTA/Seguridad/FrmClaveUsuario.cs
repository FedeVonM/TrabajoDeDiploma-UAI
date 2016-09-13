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
    public partial class FrmClaveUsuario : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        public FrmClaveUsuario(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            oUSUARIO = miUSUARIO;
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();

            txtNOMBRE.Text = oUSUARIO.Nombre;
            txtUSUARIO.Text = oUSUARIO.Nombre_Usuario;
            chkRESETEAR_CLAVE.Checked = oUSUARIO.Resetear_Clave;
            txtMAIL.Text = oUSUARIO.Email;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNUEVA_CLAVE.Text))
            {
                MessageBox.Show("Debe ingresar la nueva clave del usuario", "ATENCIÓN!!");
                return;
            }

            if (txtNUEVA_CLAVE.Text != txtNUEVA_CLAVE2.Text)
            {
                MessageBox.Show("Las claves ingresadas no coinciden", "ATENCIÓN!!");
                return;
            }

            oUSUARIO.Clave = CONTROLADORA.cFunciones_Compartidas.EncriparClave(txtNUEVA_CLAVE.Text);
            oUSUARIO.Resetear_Clave = chkRESETEAR_CLAVE.Checked;
            oMSeguridad.ModificarUsuario(oUSUARIO);
            if (chkMAIL.Checked)
            {
                if (CONTROLADORA.cFunciones_Compartidas.Enviar_Email(txtMAIL.Text, "CAMBIO DE CONTRASEÑA", "Estimado" + oUSUARIO.Nombre + ":\n Por medio del presente le enviamos su nueva contraseña de acceso al sistema. La misma es:" + txtNUEVA_CLAVE.Text + ". \n Atte. \nAdministrador del sistema"))
                {
                    MessageBox.Show("Se ha enviado la nueva contraseña por correo electrónico", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NO se ha enviado la nueva contraseña por correo electrónico. Revise la configuración del sistema", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnGENERAR_CLAVE_Click(object sender, EventArgs e)
        {
            txtNUEVA_CLAVE.Text = CONTROLADORA.cFunciones_Compartidas.ClaveAleatoria();
            txtNUEVA_CLAVE2.Text = txtNUEVA_CLAVE.Text;
            chkMAIL.Checked = true;
            chkMAIL.Enabled = false;
        }
    }
}
