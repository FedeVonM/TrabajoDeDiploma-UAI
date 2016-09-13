using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Inicio
{
    public partial class FrmRecuperarClave : Form
    {
        CONTROLADORA.cUsuarios cUsuarios;
        public FrmRecuperarClave()
        {
            InitializeComponent();
            cUsuarios = CONTROLADORA.cUsuarios.Obtener_Instancia();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnRECUPERAR_CLAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario", "ATENCIÓN!!");
                return;
            }
            if (!CONTROLADORA.cFunciones_Compartidas.ValidarEmail(txtMAIL.Text))
            {
                MessageBox.Show("El email ingresado no tiene el formato correcto", "ATENCIÓN!!");
                return;
            }

            MODELO.USUARIO oUSUARIO = cUsuarios.Obtener_Usuario_Por_Mail(txtMAIL.Text);
            if (oUSUARIO == null)
            {
                MessageBox.Show("No se ha podido encontrar la cuenta de usuario asociada al mail ingresado", "ATENCION!!");
                return;
            }
            if (oUSUARIO.Activo == false)
            {
                MessageBox.Show("La cuenta de usuario asociada al mail ingresado se encuentra bloqueada, por favor comunicarse con el administrador del sistema", "ATENCIÓN!!");
                return;
            }
            string clave_nueva = CONTROLADORA.cFunciones_Compartidas.ClaveAleatoria();
            oUSUARIO.Clave = CONTROLADORA.cFunciones_Compartidas.EncriparClave(clave_nueva);
            oUSUARIO.Resetear_Clave = true;
            cUsuarios.Modificar_Usuario(oUSUARIO);
            if (CONTROLADORA.cFunciones_Compartidas.Enviar_Email(oUSUARIO.Email, "CAMBIO DE CONTRASEÑA", "Estimado " + oUSUARIO.Nombre + ":\n Por medio del presente le enviamos su nueva contraseña de acceso al sistema.\n La misma es: " + clave_nueva + ". \n El nombre de usuario para iniciar sesión es: " + oUSUARIO.Nombre_Usuario + ". \n Atte.\nAdministrador del Sistema"))
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
}
