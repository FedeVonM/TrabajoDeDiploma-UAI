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
    [MODELO.formulario(CLASE = "FrmCambiarClave", DESCRIPCION = "Cambio de contraseña de acceso", MENU = true, MODULO = "Seguridad", SUBMODULO = "Operaciones")]
    [MODELO.accion(CONTROL = "btnGUARDAR", DESCRIPCION = "Cambiar contraseña de acceso", FORMULARIO = "FrmCambiarClave")]
    public partial class FrmCambiarClave : Form
    {
        private static FrmCambiarClave Instancia;
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.ModuloSeguridad oMSeguridad;

        public static FrmCambiarClave Obtener_Instancia(MODELO.USUARIO miUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmCambiarClave(miUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmCambiarClave(miUSUARIO);

            return Instancia;
        }
        public FrmCambiarClave(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            oUSUARIO = miUsuario;
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();

            txtCLAVE_ANTERIOR.Text = string.Empty;
            txtNUEVA_CLAVE.Text = string.Empty;
            txtREPETIR_CLAVE.Text = string.Empty;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCLAVE_ANTERIOR.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña actual", "ATENCIÓN!!");
                return;
            }
            if (oUSUARIO.Clave != CONTROLADORA.cFunciones_Compartidas.EncriparClave(txtCLAVE_ANTERIOR.Text))
            {
                MessageBox.Show("La contraseña actual ingresada no coincide con la contraseña registrada", "ATENCIÓN!!");
                return;
            }
            if (string.IsNullOrEmpty(txtNUEVA_CLAVE.Text))
            {
                MessageBox.Show("La nueva contraseña debe contener al menos un caracter", "ATENCIÓN!!");
                return;
            }
            if (txtCLAVE_ANTERIOR.Text == txtNUEVA_CLAVE.Text)
            {
                MessageBox.Show("La nueva contraseña debe ser distinta a la actual", "ATENCIÓN!!");
                return;
            }
            if (txtNUEVA_CLAVE.Text != txtREPETIR_CLAVE.Text)
            {
                MessageBox.Show("Las nuevas contraseñas deben coincidir", "ATENCIÓN!!");
                return;
            }

            oUSUARIO.Clave = CONTROLADORA.cFunciones_Compartidas.EncriparClave(txtNUEVA_CLAVE.Text);
            oUSUARIO.Resetear_Clave = false;
            oMSeguridad.ModificarUsuario(oUSUARIO);

            MessageBox.Show("Se ha establecido la nueva contraseña, la misma deberá ser usada en el próximo inicio de sesión", "CAMBIO DE CONTRASENA ACEPTADA");

            this.Close();
        }
    }
}
