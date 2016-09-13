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
    public partial class FrmLogin : Form
    {
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        MODELO.USUARIO oUSUARIO;

        public MODELO.USUARIO USUARIO_ACTUAL
        {
            get { return oUSUARIO; }
        }
        public FrmLogin()
        {
            InitializeComponent();
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            lblMENSAJE.Text = "";
            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                lblMENSAJE.Text = "Debe ingresar el nombre de usuario";
                return;
            }

            if (string.IsNullOrEmpty(txtCLAVE.Text))
            {
                lblMENSAJE.Text = "Debe ingresar la clave";
                return;
            }

            try
            {
                oUSUARIO = oMSeguridad.ValidarUsuario(txtNOMBRE_USUARIO.Text, txtCLAVE.Text);
                oMSeguridad.RegistraIngreso(oUSUARIO);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                if (ex.Message == "No se ha encontrado el usuario ingresado")
                {
                    lblMENSAJE.Text = ex.Message;
                    txtNOMBRE_USUARIO.Text = "";
                    txtNOMBRE_USUARIO.Focus();
                }

                if (ex.Message == "La clave ingresada es incorrecta")
                {
                    lblMENSAJE.Text = ex.Message;
                    txtCLAVE.Text = "";
                    txtCLAVE.Focus();
                }
            }
        }

        private void llRECUPERAR_CLAVE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarClave formRECUPERAR_CLAVE = new FrmRecuperarClave();
            DialogResult dr = formRECUPERAR_CLAVE.ShowDialog();
        }
    }
}
