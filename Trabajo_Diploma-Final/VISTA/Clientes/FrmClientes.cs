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
    [MODELO.formulario(CLASE = "FrmClientes", DESCRIPCION = "Gestión de clientes del sistema", MENU = true, MODULO = "Clientes", SUBMODULO = "Gestión de clientes del sistema")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos del cliente", FORMULARIO = "FrmClientes")]
    [MODELO.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar clientes del sistema", FORMULARIO = "FrmClientes")]
    [MODELO.accion(CONTROL = "btnMODIFICAR", DESCRIPCION = "Modificar datos del cliente", FORMULARIO = "FrmClientes")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar clientes al sistema", FORMULARIO = "FrmClientes")]
    public partial class FrmClientes : Form
    {
        CONTROLADORA.cClientes cClientes;
        MODELO.USUARIO oUsuario;
        private static FrmClientes Instancia;

        public static FrmClientes Obtener_Instancia(MODELO.USUARIO miUsuario)
        {
            if (Instancia == null)
                Instancia = new FrmClientes(miUsuario);
            if (Instancia.IsDisposed)
                Instancia = new FrmClientes(miUsuario);

            return Instancia;
        }
        public FrmClientes(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cClientes = CONTROLADORA.cClientes.Obtener_Instancia();
            oUsuario = miUsuario;

            btnCONSULTAR.Enabled = oUsuario.VALIDAR_ACCION("FrmClientes", "btnCONSULTAR");
            btnELIMINAR.Enabled = oUsuario.VALIDAR_ACCION("FrmClientes", "btnELIMINAR");
            btnMODIFICAR.Enabled = oUsuario.VALIDAR_ACCION("FrmClientes", "btnMODIFICAR");
            btnAGREGAR.Enabled = oUsuario.VALIDAR_ACCION("FrmClientes", "btnAGREGAR");

            if (cClientes.Filtrar_Clientes(string.Empty).Count > 0)
            {
                Arma_Grilla();
            }
        }

        private void Arma_Grilla()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = cClientes.Filtrar_Clientes(txtBUSCAR.Text);
            dgvCLIENTES.Columns[0].Visible = false;
            dgvCLIENTES.Columns[4].Visible = false;
            dgvCLIENTES.Columns[7].Visible = false;
            dgvCLIENTES.Columns[8].Visible = false;
            dgvCLIENTES.Columns[9].Visible = false;
            dgvCLIENTES.Columns[10].Visible = false;
            dgvCLIENTES.Columns[11].Visible = false;
            dgvCLIENTES.Columns[12].Visible = false;
            dgvCLIENTES.Columns[13].Visible = false;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista", "ATENCIÓN!!");
                return;
            }
            FrmCliente formUSUARIO = new FrmCliente(cClientes.Obtener_Cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formUSUARIO.ShowDialog();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista", "ATENCIÓN!!");
                return;
            }

            MODELO.CLIENTE oCliente = cClientes.Obtener_Cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
            if(oCliente.Nombre == "Mostrador")
            {
                MessageBox.Show("El cliente Mostrador no puede ser modificado", "ATENCIÓN!!");
                return;
            }

            FrmCliente formCLIENTE = new FrmCliente(cClientes.Obtener_Cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formCLIENTE.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista", "ATENCIÓN!!");
                return;
            }
            MODELO.CLIENTE oCliente = cClientes.Obtener_Cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));

            if (oCliente.DNI == 55555)
            {
                MessageBox.Show("El cliente mostrador no se puede eliminar del sistema");
                return;
            }

            if(oCliente.MOVIMIENTO.Count != 0)
            {
                MessageBox.Show("El cliente no puede ser eliminado porque posee movimientos en la cuenta corriente", "ATENCIÓN!!");
                return;
            }

            DialogResult dr = MessageBox.Show("Confirme para eliminar al cliente del sistema", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                cClientes.Eliminar_Cliente(oCliente);
                Arma_Grilla();
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmCliente formCLIENTE = new FrmCliente(new MODELO.CLIENTE(), "A");
            DialogResult dr = formCLIENTE.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }

        private void btnCUENTACORRIENTE_Click(object sender, EventArgs e)
        {
            if(dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista", "ATENCIÓN!!");
                return;
            }
            MODELO.CLIENTE oCliente = cClientes.Obtener_Cliente(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
            if(oCliente.Cuenta_Corriente == false)
            {
                MessageBox.Show("El cliente seleccionado no tiene habilitada la Cuenta Corriente", "ATENCIÓN!!");
                return;
            }
            else
            {
                FrmCuentaCorriente formCUENTACORRIENTE = new Clientes.FrmCuentaCorriente(oCliente);
                DialogResult dr = formCUENTACORRIENTE.ShowDialog();
            }
        }
    }
}
