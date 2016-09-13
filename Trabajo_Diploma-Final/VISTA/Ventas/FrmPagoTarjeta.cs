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
    public partial class FrmPagoTarjeta : Form
    {
        CONTROLADORA.cFacturas cVentas;
        MODELO.FACTURA oFactura;

        public FrmPagoTarjeta(MODELO.FACTURA miFactura)
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oFactura = miFactura;
            txtTOTAL.Text = oFactura.Importe.ToString();

            Carga_Tarjetas();
        }

        public void Carga_Tarjetas()
        {
            cmTarjetas.DataSource = cVentas.Obtener_Tarjetas();
            cmTarjetas.DisplayMember = "Descripcion";
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal ImporteTarjeta;
            if (txtImporteTarjeta.Text != "")
            {
                if (decimal.TryParse(txtImporteTarjeta.Text, out ImporteTarjeta))
                {
                    if (ImporteTarjeta > oFactura.Importe)
                    {
                        MessageBox.Show("El importe ingresado supera el importe de la factura", "ATENCIÓN!!");
                        return;
                    }
                    else
                    {
                        if (ImporteTarjeta < oFactura.Importe)
                        {
                            MessageBox.Show("El importe ingresado es insuficiente", "ATENCIÓN!!");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado es incorrecto", "ATENCIÓN!!");
                    return;
                }

                MODELO.MOVIMIENTO_CAJA oMovimiento_Caja = new MODELO.MOVIMIENTO_CAJA();
                oMovimiento_Caja.Fecha = oFactura.Fecha;
                oMovimiento_Caja.Concepto = "PAGO";
                oMovimiento_Caja.Comprobante = oFactura.Tipo_Factura;
                oMovimiento_Caja.Número_Comprobante = oFactura.Nro_Factura;
                oMovimiento_Caja.Entrada = oFactura.Importe;
                oMovimiento_Caja.Salida = 0;
                oMovimiento_Caja.CAJA = cVentas.Obtener_Caja();
                oMovimiento_Caja.Forma_de_Pago = "TARJETA" + " " + cmTarjetas.Text + " " + txtNúmeroTarjeta.Text;
                cVentas.Agregar_Movimiento_Caja(oMovimiento_Caja);

                cVentas.Modificar_Stock_Producto(oFactura);
                cVentas.Guarda_Factura(oFactura);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
