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
    public partial class FrmIngresaMovimiento : Form
    {
        CONTROLADORA.cCuentaCorriente cCuentaCorriente;
        MODELO.MOVIMIENTO oMovimiento;
        string Accion;
        MODELO.CLIENTE oCliente;
        public FrmIngresaMovimiento(MODELO.MOVIMIENTO miMovimiento, string miAccion, MODELO.CLIENTE miCliente)
        {
            InitializeComponent();
            cCuentaCorriente = CONTROLADORA.cCuentaCorriente.Obtener_Instancia();
            oMovimiento = miMovimiento;
            Accion = miAccion;
            oCliente = miCliente;
            txtSALDOANTERIOR.Text = cCuentaCorriente.Obtener_Saldo(oCliente).ToString();
            txtSALDOACTUAL.Text = "0";
            lblMENSJAE.Text = "Ingrese el importe y presione ENTER para actualizar los campos";

            if(Accion == "C")
            {
                txtIMPORTE.Text = oMovimiento.Pagado.ToString();
                txtIMPORTE.Enabled = false;
                txtDESCRIPCION.Enabled = false;
                gbSALDO.Enabled = false;
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtIMPORTE_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                decimal Importe;
                decimal ImporteAnt;
                decimal.TryParse(txtIMPORTE.Text, out Importe);
                decimal.TryParse(txtSALDOANTERIOR.Text, out ImporteAnt);
                txtSALDOACTUAL.Text = (ImporteAnt - Importe).ToString();
                txtDESCRIPCION.Focus();
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            decimal Importe;
            if(!decimal.TryParse(txtIMPORTE.Text, out Importe))
            {
                MessageBox.Show("El importe ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if(string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar la descripción del movimiento", "ATENCIÓN!!");
                return;
            }

            oMovimiento.Fecha = DateTime.Now;
            oMovimiento.CLIENTE = oCliente;
            oMovimiento.Descripcion = txtDESCRIPCION.Text;
            oMovimiento.Pagado = Importe;
            oMovimiento.Saldo = cCuentaCorriente.Obtener_Saldo_Movimiento(oCliente, Importe);

            MODELO.MOVIMIENTO_CAJA oMovCaja = new MODELO.MOVIMIENTO_CAJA();
            oMovCaja.CAJA = cCuentaCorriente.Obtener_Caja();
            oMovCaja.Concepto = txtDESCRIPCION.Text;
            oMovCaja.Entrada = Importe;
            oMovCaja.Fecha = DateTime.Now;
            oMovCaja.Forma_de_Pago = "NINGUNA";
            oMovCaja.Comprobante = "";
            oMovCaja.Número_Comprobante = 0;
            oMovCaja.Salida = 0;

            cCuentaCorriente.Agregar_Movimiento(oMovimiento);
            cCuentaCorriente.Agregar_movimiento_Caja(oMovCaja);
            this.DialogResult = DialogResult.OK;
        }
    }
}
