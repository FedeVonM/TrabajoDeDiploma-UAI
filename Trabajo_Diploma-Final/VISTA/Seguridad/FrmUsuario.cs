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
    public partial class FrmUsuario : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        string ACCION;
        bool checkearA;
        public FrmUsuario(MODELO.USUARIO miUSUARIO, string miACCION)
        {
            InitializeComponent();
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();
            oUSUARIO = miUSUARIO;
            ACCION = miACCION;
            if (ACCION != "A")
            {
                txtCODIGO.Text = oUSUARIO.Id_Usuario.ToString();
                txtUSUARIO.Text = oUSUARIO.Nombre_Usuario;
                txtNOMBRE.Text = oUSUARIO.Nombre;
                txtEMAIL.Text = oUSUARIO.Email;
                txtTELEFONO.Text = oUSUARIO.Telefono;
                chkACTIVO.Checked = oUSUARIO.Activo;

                if (ACCION == "C")
                {
                    btnCANCELAR.Text = "Cerrar";
                    btnGUARDAR.Visible = false;
                    chkGRUPOS.Enabled = false;
                    tpDATOS.Enabled = false;
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            oMSeguridad.CancelarCambios(oUSUARIO);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            chkGRUPOS.DataSource = null;
            chkGRUPOS.DataSource = oMSeguridad.ObtenerGrupo();
            chkGRUPOS.DisplayMember = "Descripcion";

            checkearA = false;
            for (int i = 0; i < chkGRUPOS.Items.Count; i++)
            {
                MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.Items[i];
                foreach (MODELO.GRUPO miGrupo in oUSUARIO.GRUPO)
                {
                    if (miGrupo.Id_Grupo == oGrupo.Id_Grupo)
                    {
                        chkGRUPOS.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCIÓN!!");
                return;
            }

            int codigo_usuario;
            if (!int.TryParse(txtCODIGO.Text, out codigo_usuario))
                codigo_usuario = 0;

            if (oMSeguridad.ValidaNombreDeUsuario(txtUSUARIO.Text, codigo_usuario))
            {
                MessageBox.Show("El nombre de usuario para acceso al sistema ya existe", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario", "ATENCIÓN!!");
                return;
            }

            if (!CONTROLADORA.cFunciones_Compartidas.ValidarEmail(txtEMAIL.Text))
            {
                MessageBox.Show("EL Email ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if (oMSeguridad.ValidaMailUsuario(txtEMAIL.Text, codigo_usuario))
            {
                MessageBox.Show("El Mail ingresado ya se encuentra asignado a otro usuario", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtTELEFONO.Text))
            {
                MessageBox.Show("Debe ingresar el teléfono del usuario", "ATENCIÓN!!");
                return;
            }

            oUSUARIO.Nombre_Usuario = txtUSUARIO.Text;
            oUSUARIO.Nombre = txtNOMBRE.Text;
            oUSUARIO.Email = txtEMAIL.Text;
            oUSUARIO.Telefono = txtTELEFONO.Text;
            oUSUARIO.Activo = chkACTIVO.Checked;

            if (ACCION == "A")
            {
                oUSUARIO.Clave = CONTROLADORA.cFunciones_Compartidas.EncriparClave(txtUSUARIO.Text);
                oUSUARIO.Resetear_Clave = true;
                oMSeguridad.AgregarUsuario(oUSUARIO);
            }
            else
            {
                oMSeguridad.ModificarUsuario(oUSUARIO);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void chkGRUPOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkearA == false) return;

            MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oUSUARIO.GRUPO.Add(oGrupo);
            }
            else
            {
                oUSUARIO.GRUPO.Remove(oGrupo);
            }
        }
    }
}
