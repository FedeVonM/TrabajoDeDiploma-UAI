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
    public partial class FrmPagoMixto : Form
    {
        MODELO.FACTURA oFactura;
        CONTROLADORA.cFacturas cVentas;
        decimal PagaConAnt = 0;
        decimal ImporteTarjetaAnt = 0;
        decimal CCAnt = 0;
        decimal CC = 0;
        decimal PagaCon = 0;
        decimal ImporteTarjeta = 0;
        decimal TotalRestante;
        public FrmPagoMixto(MODELO.FACTURA miFactura)
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oFactura = miFactura;
            TotalRestante = oFactura.Importe;
            txtPagaCon.Text = PagaCon.ToString();
            lblEfectivo.Text = "$ 0";
            lblTarjeta.Text = "$ 0";
            lblCuenta.Text = "$ 0";
            txtImporteTarjeta.Text = ImporteTarjeta.ToString();
            txtCC.Text = CC.ToString();
            txtTotalFacturado.Text = oFactura.Importe.ToString();
            txtTotalRestante.Text = TotalRestante.ToString();

            Carga_Combo();
        }

        public void Carga_Combo()
        {
            cmTarjetas.DataSource = cVentas.Obtener_Tarjetas();
            cmTarjetas.DisplayMember = "Descripcion";
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal.TryParse(txtTotalRestante.Text, out TotalRestante);

                if (txtPagaCon.Text != "")
                {
                    if (decimal.TryParse(txtPagaCon.Text, out PagaCon))
                    {
                        if (PagaCon <= TotalRestante + PagaConAnt)
                        {
                            lblEfectivo.Text = "$" + " " + PagaCon;
                            txtTotalRestante.Text = (TotalRestante + PagaConAnt - PagaCon).ToString();
                            PagaConAnt = PagaCon;
                        }
                        else
                        {
                            MessageBox.Show("El importe ingresado es mayor al importe restante de la factura", "ATENCIÓN!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor de dinero recibido incorrecto.");
                    }
                }
            }
            /*decimal.TryParse(txtTotalRestante.Text, out TotalRestante);
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPagaCon.Text != "")
                {
                    if (decimal.TryParse(txtPagaCon.Text, out PagaCon))
                    {
                        if (PagaCon >= (PagaConAnt + TotalRestante))
                        {
                            if(ImporteTarjeta != 0 || CC != 0)
                            {
                                txtVuelto.Text = (PagaCon - TotalRestante).ToString();
                                lblEfectivo.Text = "$" + " " + TotalRestante;
                                txtTotalRestante.Text = (TotalRestante + PagaConAnt - TotalRestante).ToString();
                                PagaCon = TotalRestante;
                                PagaConAnt = PagaCon;
                                TotalRestanteAnt = TotalRestante;
                            }
                            else
                            {
                                txtVuelto.Text = (PagaCon - TotalRestante).ToString();
                                lblEfectivo.Text = "$" + " " + oFactura.Importe;
                                txtTotalRestante.Text = (TotalRestante + PagaConAnt - oFactura.Importe).ToString();
                                PagaConAnt = oFactura.Importe;
                                PagaCon = oFactura.Importe;
                            }
                        }
                        else
                        {
                            txtVuelto.Text = "0";
                            lblEfectivo.Text = "$" + " " + txtPagaCon.Text;
                            txtTotalRestante.Text = (TotalRestante + PagaConAnt - PagaCon).ToString();
                            PagaConAnt = PagaCon;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor de dinero recibido incorrecto.");
                    }
                }
                else
                {
                    txtVuelto.Clear();
                }
            }*/
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtTotalRestante.Text, out TotalRestante);
            if(TotalRestante != 0)
            {
                MessageBox.Show("El pago es insuficiente", "ATENCIÓN!!");
                return;
            }

            if(txtCC.Text != "0")
            {
                if (oFactura.CLIENTE.Cuenta_Corriente == false)
                {
                    MessageBox.Show("El cliente no tiene habilitada la cuenta corriente", "ATENCIÓN!!", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MODELO.MOVIMIENTO oMovimiento = new MODELO.MOVIMIENTO();
                    oMovimiento.CLIENTE = oFactura.CLIENTE;
                    oMovimiento.Fecha = DateTime.Now;
                    oMovimiento.Tipo_Comprobante = "FB";
                    oMovimiento.Nro_Comprobante = oFactura.Nro_Factura;
                    oMovimiento.Descripcion = "FACTURA";
                    oMovimiento.Saldo = cVentas.Obtener_Saldo_Movimiento(oFactura.CLIENTE, CC);
                    oMovimiento.Facturado = CC;
                    oMovimiento.Pagado = 0;
                    oMovimiento.Importe_Cancelado = 0;
                    cVentas.Agregar_Movimiento(oMovimiento);
                }
            }

            if(txtPagaCon.Text != "0")
            {
                MODELO.MOVIMIENTO_CAJA oMovimiento_Caja = new MODELO.MOVIMIENTO_CAJA();
                oMovimiento_Caja.Fecha = oFactura.Fecha;
                oMovimiento_Caja.Concepto = "PAGO";
                oMovimiento_Caja.Comprobante = oFactura.Tipo_Factura;
                oMovimiento_Caja.Número_Comprobante = oFactura.Nro_Factura;
                oMovimiento_Caja.Entrada = PagaCon;
                oMovimiento_Caja.Salida = 0;
                oMovimiento_Caja.CAJA = cVentas.Obtener_Caja();
                oMovimiento_Caja.Forma_de_Pago = "CONTADO";
                cVentas.Agregar_Movimiento_Caja(oMovimiento_Caja);
            }

            if(txtImporteTarjeta.Text != "0")
            {
                MODELO.MOVIMIENTO_CAJA oMovimiento_Caja = new MODELO.MOVIMIENTO_CAJA();
                oMovimiento_Caja.Fecha = oFactura.Fecha;
                oMovimiento_Caja.Concepto = "PAGO";
                oMovimiento_Caja.Comprobante = oFactura.Tipo_Factura;
                oMovimiento_Caja.Número_Comprobante = oFactura.Nro_Factura;
                oMovimiento_Caja.Entrada = ImporteTarjeta;
                oMovimiento_Caja.Salida = 0;
                oMovimiento_Caja.CAJA = cVentas.Obtener_Caja();
                oMovimiento_Caja.Forma_de_Pago = "TARJETA" + " " + cmTarjetas.Text + " " + txtNúmeroTarjeta.Text;
                cVentas.Agregar_Movimiento_Caja(oMovimiento_Caja);
            }

            cVentas.Modificar_Stock_Producto(oFactura);
            cVentas.Guarda_Factura(oFactura);
            this.DialogResult = DialogResult.OK;
        }

        private void txtImporteTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal.TryParse(txtTotalRestante.Text, out TotalRestante);

                if (txtImporteTarjeta.Text != "")
                {
                    if (decimal.TryParse(txtImporteTarjeta.Text, out ImporteTarjeta))
                    {
                        if (ImporteTarjeta <= TotalRestante + ImporteTarjetaAnt)
                        {
                            lblTarjeta.Text = "$" + " " + ImporteTarjeta;
                            txtTotalRestante.Text = (TotalRestante + ImporteTarjetaAnt - ImporteTarjeta).ToString();
                            ImporteTarjetaAnt = ImporteTarjeta;
                        }
                        else
                        {
                            MessageBox.Show("El importe ingresado es mayor al importe restante de la factura", "ATENCIÓN!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor de dinero recibido incorrecto.");
                    }
                }
            }
        }

        private void txtCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal.TryParse(txtTotalRestante.Text, out TotalRestante);

                if (txtCC.Text != "")
                {
                    if (decimal.TryParse(txtCC.Text, out CC))
                    {
                        if (CC <= TotalRestante + CCAnt)
                        {
                            lblCuenta.Text = "$" + " " + CC;
                            txtTotalRestante.Text = (TotalRestante + CCAnt - CC).ToString();
                            CCAnt = CC;
                        }
                        else
                        {
                            MessageBox.Show("El importe ingresado es mayor al importe restante de la factura", "ATENCIÓN!!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor de dinero recibido incorrecto.");
                    }
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
