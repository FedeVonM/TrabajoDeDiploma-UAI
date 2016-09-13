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
    public partial class FrmIngresarPago : Form
    {
        CONTROLADORA.cCuentaCorriente cCuentaCorriente;
        MODELO.CLIENTE oCliente;
        public FrmIngresarPago(MODELO.CLIENTE miCliente)
        {
            InitializeComponent();
            cCuentaCorriente = CONTROLADORA.cCuentaCorriente.Obtener_Instancia();
            oCliente = miCliente;

            Carga_Combo_Formas();
            Carga_Combo_Tarjetas();
            cbTARJETAS.Enabled = false;
            txtNUMERO.Enabled = false;
        }

        public void Carga_Combo_Tarjetas()
        {
            cbTARJETAS.DataSource = cCuentaCorriente.Obtener_Tarjetas();
            cbTARJETAS.DisplayMember = "Descripcion";
        }

        public void Carga_Combo_Formas()
        {
            cbFORMAS.DataSource = cCuentaCorriente.Obtener_Formas_Pago();
            cbFORMAS.DisplayMember = "Descripcion";
        }

        private void cbFORMAS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MODELO.FORMA_DE_PAGO Forma = (MODELO.FORMA_DE_PAGO)cbFORMAS.SelectedItem;
            if(Forma.Descripcion == "TARJETA")
            {
                cbTARJETAS.Enabled = true;
                txtNUMERO.Enabled = true;
            }

            if(Forma.Descripcion == "CUENTA CORRIENTE")
            {
                cbTARJETAS.SelectedItem = "CONTADO";
                cbTARJETAS.Enabled = false;
                txtNUMERO.Enabled = false;
                MessageBox.Show("La forma de pago Cuenta corriente no puede ser seleccionada", "ATENCIÓN!!");
                return;
            }

            if(Forma.Descripcion == "CONTADO")
            {
                cbTARJETAS.Enabled = false;
                txtNUMERO.Enabled = false;
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal ImporteRestante;
            decimal Importe;
            decimal.TryParse(txtImporte.Text, out Importe);
            decimal.TryParse(txtImporte.Text, out ImporteRestante);
            decimal ImporteFinal;
            if(cCuentaCorriente.Obtener_Saldo_Movimiento(oCliente, Importe) < 0)
            {
                MessageBox.Show("El importe ingresado es mayor a la deuda del cliente", "ATENCIÓN!!");
                return;
            }

            while (ImporteRestante != 0)
            {
                List<MODELO.MOVIMIENTO> Movimientos = cCuentaCorriente.Filtrar_Movimientos(oCliente);
                MODELO.MOVIMIENTO oMovimiento = Movimientos.First();
                if (ImporteRestante <= (oMovimiento.Facturado - oMovimiento.Importe_Cancelado))
                {
                    oMovimiento.Importe_Cancelado += ImporteRestante;
                    ImporteFinal = ImporteRestante;
                    ImporteRestante -= ImporteRestante;
                    cCuentaCorriente.Modificar_Movimiento(oMovimiento);
                }
                else
                {
                    decimal RestanteMovimiento = Convert.ToDecimal(oMovimiento.Facturado - oMovimiento.Importe_Cancelado);
                    oMovimiento.Importe_Cancelado += RestanteMovimiento;
                    ImporteFinal = RestanteMovimiento;
                    cCuentaCorriente.Modificar_Movimiento(oMovimiento);
                    ImporteRestante -= RestanteMovimiento;
                }

                MODELO.MOVIMIENTO_CAJA oMovimientoCaja = new MODELO.MOVIMIENTO_CAJA();
                oMovimientoCaja.Fecha = DateTime.Now;
                oMovimientoCaja.Concepto = "PAGO";
                oMovimientoCaja.Comprobante = oMovimiento.Tipo_Comprobante;
                oMovimientoCaja.Número_Comprobante = Convert.ToInt32(oMovimiento.Nro_Comprobante);
                oMovimientoCaja.Entrada = ImporteFinal;
                oMovimientoCaja.Salida = 0;
                oMovimientoCaja.CAJA = cCuentaCorriente.Obtener_Caja();
                if(cbFORMAS.Text == "CONTADO")
                {
                    oMovimientoCaja.Forma_de_Pago = "CONTADO";
                }
                else
                {
                    oMovimientoCaja.Forma_de_Pago = "TARJETA:" + " " + cbTARJETAS.Text + " " + txtNUMERO.Text;
                }

                cCuentaCorriente.Agregar_movimiento_Caja(oMovimientoCaja);
            }

            MODELO.RECIBO oRecibo = new MODELO.RECIBO();
            oRecibo.CLIENTE = oCliente;
            oRecibo.Nro_Recibo = cCuentaCorriente.Obtener_Numero_Recibo();
            oRecibo.Fecha = DateTime.Now;
            oRecibo.Importe = Importe;
            oRecibo.Constancia = "A Cuenta";
            cCuentaCorriente.Agregar_Recibo(oRecibo);

            MODELO.MOVIMIENTO oMov = new MODELO.MOVIMIENTO();
            oMov.CLIENTE = oCliente;
            oMov.Descripcion = "PAGO";
            oMov.Fecha = DateTime.Now;
            oMov.Importe_Cancelado = Importe;
            oMov.Nro_Comprobante = oRecibo.Nro_Recibo;
            oMov.Pagado = Importe;
            oMov.Tipo_Comprobante = "R";
            oMov.Saldo = cCuentaCorriente.Obtener_Saldo_Movimiento(oCliente, Importe);
            cCuentaCorriente.Agregar_Movimiento(oMov);
            this.DialogResult = DialogResult.OK;
        }
    }
}
