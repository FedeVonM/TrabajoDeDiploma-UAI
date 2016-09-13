using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Clientes
{
    public partial class FrmCliente : Form
    {
        CONTROLADORA.cClientes cClientes;
        string Accion;
        MODELO.CLIENTE oCliente;
        public FrmCliente(MODELO.CLIENTE miCLIENTE, string miACCION)
        {
            InitializeComponent();
            cClientes = CONTROLADORA.cClientes.Obtener_Instancia();
            oCliente = miCLIENTE;
            Accion = miACCION;

            if (Accion != "A")
            {
                txtNombre.Text = oCliente.Nombre;
                txtApellido.Text = oCliente.Apellido;
                mtxtDNI.Text = oCliente.DNI.ToString();
                mtxtTelefono.Text = oCliente.Telefono;
                txtMail.Text = oCliente.Mail;
                txtDireccion.Text = oCliente.Direccion;
                txtCiudad.Text = oCliente.Ciudad;
                txtProvincia.Text = oCliente.Provincia;
                chbCC.Checked = oCliente.Cuenta_Corriente;

                if (Accion == "C")
                {
                    btnGUARDAR.Visible = false;
                    btnCANCELAR.Text = "Cerrar";
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    mtxtDNI.Enabled = false;
                    mtxtTelefono.Enabled = false;
                    txtMail.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtProvincia.Enabled = false;
                    chbCC.Enabled = false;
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            cClientes.Cancelar_Cambios(oCliente);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar el apellido del cliente", "ATENCIÓN!!");
                return;
            }

            int dni;
            if (!int.TryParse(mtxtDNI.Text, out dni))
            {
                MessageBox.Show("El DNI ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if (cClientes.Validar_DNI_Cliente(dni) && Accion == "A")
            {
                MessageBox.Show("El DNI ingresado ya existe en el sistema", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(mtxtTelefono.Text))
            {
                MessageBox.Show("Debe ingresar el teléfono del cliente", "ATENCIÓN!!");
                return;
            }

            if (!CONTROLADORA.cFunciones_Compartidas.ValidarEmail(txtMail.Text))
            {
                MessageBox.Show("El Email ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar la dirección del cliente", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                MessageBox.Show("Debe ingresar la ciudad del cliente", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtProvincia.Text))
            {
                MessageBox.Show("Debe ingresar la provincia del cliente", "ATENCIÓN!!");
                return;
            }

            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.DNI = dni;
            oCliente.Telefono = mtxtTelefono.Text;
            oCliente.Mail = txtMail.Text;
            oCliente.Direccion = txtDireccion.Text;
            oCliente.Ciudad = txtCiudad.Text;
            oCliente.Provincia = txtProvincia.Text;
            oCliente.Cuenta_Corriente = chbCC.Checked;

            if (Accion == "A")
            {
                cClientes.Agregar_Cliente(oCliente);
            }
            else
            {
                cClientes.Modificar_Cliente(oCliente);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
