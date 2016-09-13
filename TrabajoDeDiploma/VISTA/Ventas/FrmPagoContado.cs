using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Ventas
{
    public partial class FrmPagoContado : Form
    {
        MODELO.FACTURA oFactura;
        CONTROLADORA.cFacturas cFacturas;
        public FrmPagoContado(MODELO.FACTURA miFactura)
        {
            InitializeComponent();
            cFacturas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oFactura = miFactura;
            txtTotal.Text = oFactura.Importe.ToString();
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            decimal pagaCon;
            if(e.KeyCode == Keys.Enter)
            {
                if (txtPagaCon.Text != "")
                {
                    if (decimal.TryParse(txtPagaCon.Text, out pagaCon))
                    {
                        if (pagaCon >= oFactura.Importe)
                        {
                            txtVuelto.Text = (pagaCon - oFactura.Importe).ToString();
                        }
                        else
                        {
                            MessageBox.Show("El pago es insuficiente", "ATENCIÓN!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor de dinero recibido incorrecto", "ATENCIÓN!!");
                        return;
                    }
                }
                else
                {
                    txtVuelto.Clear();
                }
            }       
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MODELO.MOVIMIENTO_CAJA oMovimiento_Caja = new MODELO.MOVIMIENTO_CAJA();
            oMovimiento_Caja.Fecha = oFactura.Fecha;
            oMovimiento_Caja.Concepto = "PAGO";
            oMovimiento_Caja.Comprobante = oFactura.Tipo_Factura;
            oMovimiento_Caja.Número_Comprobante = oFactura.Nro_Factura;
            oMovimiento_Caja.Entrada = oFactura.Importe;
            oMovimiento_Caja.Salida = 0;
            oMovimiento_Caja.CAJA = cFacturas.Obtener_Caja();
            oMovimiento_Caja.Forma_de_Pago = "CONTADO";
            cFacturas.Agregar_Movimiento_Caja(oMovimiento_Caja);

            cFacturas.Modificar_Stock_Producto(oFactura);
            cFacturas.Guarda_Factura(oFactura);
            this.DialogResult = DialogResult.OK;
        }
    }
}
