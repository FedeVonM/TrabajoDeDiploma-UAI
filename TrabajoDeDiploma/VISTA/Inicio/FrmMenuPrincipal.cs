using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace VISTA.Inicio
{
    public partial class FrmMenuPrincipal : Form
    {
        MODELO.USUARIO oUSUARIO_ACTUAL;
        CONTROLADORA.ModuloSeguridad oMSeguridad;
        private Form miForm;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            oMSeguridad = CONTROLADORA.ModuloSeguridad.ObtenerInstancia();

            var namespaces = (from type in Assembly.GetExecutingAssembly().GetTypes()
                              where !string.IsNullOrEmpty(type.Namespace) && type.Namespace.IndexOf('.') > 0
                              let dotIndex = type.Namespace.IndexOf('.') + 1
                              let topLevel = dotIndex < 0 ? type.Namespace
                                   : type.Namespace.Substring(dotIndex, (type.Namespace.Length - dotIndex))
                              orderby topLevel
                              select topLevel).Distinct();

            foreach (var nsp in namespaces)
            {
                if (nsp != "Inicio" && nsp != "Properties")
                {
                    oMSeguridad.ActualizaModulo(nsp);
                }
            }

            foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsSubclassOf(typeof(Form)))
                {
                    object[] attrs = type.GetCustomAttributes(typeof(MODELO.formulario), true);

                    foreach (MODELO.formulario a in attrs)
                    {
                        oMSeguridad.ActualizaFormularios(a);
                    }

                    object[] acciones = type.GetCustomAttributes(typeof(MODELO.accion), true);

                    foreach (MODELO.accion ac in acciones)
                    {
                        oMSeguridad.ActualizaAcciones(ac);
                    }
                }
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Arma_Login();
        }

        private void Arma_Login()
        {
            FrmLogin formLOGIN = new FrmLogin();
            DialogResult dr = formLOGIN.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            else
            {
                oUSUARIO_ACTUAL = formLOGIN.USUARIO_ACTUAL;
                lblNOMBRE.Text = oUSUARIO_ACTUAL.Nombre;
                lblCUENTA.Text = oUSUARIO_ACTUAL.Nombre_Usuario;
                lblEMAIL.Text = oUSUARIO_ACTUAL.Email;

                if (oUSUARIO_ACTUAL.Resetear_Clave)
                {
                    Cambiar_Clave();
                }

                Arma_Modulos();
            }
        }

        private void Cambiar_Clave()
        {
            Seguridad.FrmCambiarClave formCAMBIAR_CLAVE = Seguridad.FrmCambiarClave.Obtener_Instancia(oUSUARIO_ACTUAL);
            DialogResult dr = formCAMBIAR_CLAVE.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("La contraseña ha sido cambiada exitosamente, la misma será válida a partir del próximo inicio de sesión", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Arma_Modulos()
        {
            msMENU.Items.Clear();
            ToolStripDropDownButton MENU_MODULO;
            foreach (MODELO.MODULO oMODULO in oUSUARIO_ACTUAL.OBTENER_MODULOS())
            {
                MENU_MODULO = new ToolStripDropDownButton();
                MENU_MODULO.Text = oMODULO.Descripcion;
                MENU_MODULO.Tag = "0";

                msMENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MENU_MODULO });
                Arma_Submodulos(MENU_MODULO, oMODULO);
            }
        }

        private void Arma_Submodulos(ToolStripDropDownButton M_S, MODELO.MODULO oMODULO)
        {
            ToolStripMenuItem MENU_SUBMODULOS;
            foreach (MODELO.SUBMODULO oSUBMODULO in oUSUARIO_ACTUAL.OBTENER_SUBMODULOS(oMODULO))
            {
                MENU_SUBMODULOS = new ToolStripMenuItem(oSUBMODULO.Descripcion);
                MENU_SUBMODULOS.Tag = "0";

                M_S.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MENU_SUBMODULOS });
                Arma_Formularios(MENU_SUBMODULOS, oSUBMODULO);
            }
        }

        private void Arma_Formularios(ToolStripMenuItem M_F, MODELO.SUBMODULO oSUBMODULO)
        {
            ToolStripMenuItem MENU_FORMULARIOS;
            foreach (MODELO.FORMULARIO oFORM in oUSUARIO_ACTUAL.OBTENER_FORMULARIOS(oSUBMODULO))
            {
                MENU_FORMULARIOS = new ToolStripMenuItem(oFORM.Descripcion);
                MENU_FORMULARIOS.Tag = oFORM.Clase;

                M_F.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MENU_FORMULARIOS });
                MENU_FORMULARIOS.Click += new EventHandler(this.Item_Click);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem seleccion = (ToolStripMenuItem)sender;
            if ((string)seleccion.Tag != "0")
            {
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                            try
                            {
                                Type t = type as Type;
                                miForm = (Form)t.InvokeMember("Obtener_Instancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUSUARIO_ACTUAL }) as System.Windows.Forms.Form;
                                miForm.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnCAMBIAR_CLAVE_Click(object sender, EventArgs e)
        {
            Cambiar_Clave();
        }

        private void btnCERRAR_SESION_Click(object sender, EventArgs e)
        {
            oMSeguridad.RegistrarEgreso(oUSUARIO_ACTUAL);
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "FrmMENU_PRINCIPAL")
                    Application.OpenForms[i].Close();
            }

            Arma_Login();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            oMSeguridad.RegistrarEgreso(oUSUARIO_ACTUAL);
        }
    }
}
