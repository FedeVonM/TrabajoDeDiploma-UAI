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
    [MODELO.formulario(CLASE = "FrmFactura", DESCRIPCION = "Facturas", MENU = true, MODULO = "Ventas", SUBMODULO = "Comprobantes")]
    [MODELO.accion(CONTROL = "btnBUSCAR_POR_DESCRIPCION", DESCRIPCION = "Buscar artículo por descripción", FORMULARIO = "FrmFactura")]
    [MODELO.accion(CONTROL = "btnELIMINAR_ART", DESCRIPCION = "Eliminar artículo", FORMULARIO = "FrmFactura")]
    [MODELO.accion(CONTROL = "btnRESETEA_VENTA", DESCRIPCION = "Resetear venta", FORMULARIO = "FrmFactura")]
    [MODELO.accion(CONTROL = "btnCOBRAR", DESCRIPCION = "Cobrar venta", FORMULARIO = "FrmFactura")]
    public partial class FrmFactura : Form
    {
        CONTROLADORA.cFacturas cVentas;
        MODELO.USUARIO oUsuario;
        MODELO.FACTURA oFactura;
        MODELO.CLIENTE oCliente;
        string Accion;
        private static FrmFactura Instancia;

        public static FrmFactura Obtener_Instancia(MODELO.USUARIO miUSUARIO)
        {
            if (Instancia == null)
                Instancia = new FrmFactura(miUSUARIO);
            if (Instancia.IsDisposed)
                Instancia = new FrmFactura(miUSUARIO);

            return Instancia;
        }

        public FrmFactura(MODELO.FACTURA miFactura, string miAccion)
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oFactura = miFactura;
            Accion = miAccion;

            oFactura = miFactura;
            txtTIPO.Text = oFactura.Tipo_Factura;
            txtPUNTO_VENTA.Text = "001";
            txtNUMERO_FACTURA.Text = string.Format("{0:00000000}", oFactura.Nro_Factura);
            dtpFECHA.Value = oFactura.Fecha;
            txtNOMBRE_CLIENTE.Text = oFactura.CLIENTE.Nombre;
            txtDNI_CLIENTE.Text = oFactura.CLIENTE.DNI.ToString();
            dgvARTICULOS.DataSource = cVentas.listaVenta(oFactura);
            dgvARTICULOS.Columns[0].Visible = false;
            cVentas.CalculaTotal(oFactura);
            txtSUBTOTAL.Text = oFactura.Importe.ToString();
            txtTIPO.Enabled = false;
            txtPUNTO_VENTA.Enabled = false;
            txtNUMERO_FACTURA.Enabled = false;
            dtpFECHA.Enabled = false;
            gbCLIENTE.Enabled = false;
            gbARTICULOS.Enabled = false;
            btnCOBRAR.Visible = false;
            btnReseteaVenta.Visible = false;
        }
        public FrmFactura(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oUsuario = miUsuario;
            Resetear_Venta();

            CargaCombo();

            btnBuscarPorDescripcion.Enabled = oUsuario.VALIDAR_ACCION("FrmFactura", "btnBUSCAR_POR_DESCRIPCION");
            btnEliminarArt.Enabled = oUsuario.VALIDAR_ACCION("FrmFactura", "btnELIMINAR_ART");
            btnReseteaVenta.Enabled = oUsuario.VALIDAR_ACCION("FrmFactura", "btnRESETEA_VENTA");
            btnCOBRAR.Enabled = oUsuario.VALIDAR_ACCION("FrmFactura", "btnCOBRAR");
        }

        private void CargaCombo()
        {
            cbFORMADEPAGO.DataSource = cVentas.Obtener_Formas_Pago();
            cbFORMADEPAGO.DisplayMember = "Descripcion";
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDNI_CLIENTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int dni;
                if (!int.TryParse(txtDNI_CLIENTE.Text, out dni))
                {
                    MessageBox.Show("El DNI es incorrecto");
                    txtDNI_CLIENTE.Focus();
                    return;
                }
                oCliente = cVentas.Obtener_Cliente(dni);

                if (oCliente == null)
                {
                    MessageBox.Show("No se ha encontrado el Cliente");
                    return;
                }
                else
                {
                    txtDNI_CLIENTE.Text = oCliente.DNI.ToString();
                    txtNOMBRE_CLIENTE.Text = oCliente.Nombre;
                }
            }

            if (e.KeyCode == Keys.F5)
            {
                FrmBuscarCliente formBUSCAR_CLIENTE = new FrmBuscarCliente();
                DialogResult dr = formBUSCAR_CLIENTE.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    oCliente = formBUSCAR_CLIENTE.Obtener_Cliente;
                    txtDNI_CLIENTE.Text = oCliente.DNI.ToString();
                    txtNOMBRE_CLIENTE.Text = oCliente.Nombre;
                }
            }
        }

        private void txtCODIGO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Carga_Producto();
            }

            txtCODIGO.Focus();
        }

        private void Carga_Producto()
        {
            int codigo;
            decimal cantidad;
            MODELO.PRODUCTO oPRODUCTO = null;

            if (!int.TryParse(txtCODIGO.Text, out codigo))
            {
                MessageBox.Show("Formato de codigo incorrecto.");
                return;
            }

            if (!decimal.TryParse(txtCANTIDAD.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad no valida.");
                return;
            }

            oPRODUCTO = cVentas.Obtener_Producto(codigo);
            if (oPRODUCTO == null)
            {
                MessageBox.Show("Producto no encontrado.");
                txtCODIGO.Clear();
                return;
            }

            cVentas.AgregarProducto(oFactura, oPRODUCTO, cantidad);
            dgvARTICULOS.DataSource = cVentas.listaVenta(oFactura);
            dgvARTICULOS.Columns[0].Visible = false;
            cVentas.CalculaTotal(oFactura);
            txtSUBTOTAL.Text = oFactura.Importe.ToString();
            txtCANTIDAD.Text = "1";
            txtCODIGO.Clear();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            if (dgvARTICULOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "ATENCIÓN!!");
                return;
            }
            else
            {
                MODELO.PRODUCTO oProducto;
                int cantidad;
                oProducto = cVentas.BuscarProducto(Convert.ToInt32(dgvARTICULOS.CurrentRow.Cells[0].Value));
                cantidad = Convert.ToInt32(dgvARTICULOS.CurrentRow.Cells[2].Value);
                cVentas.EliminarProducto(oFactura, oProducto);
                dgvARTICULOS.DataSource = cVentas.listaVenta(oFactura);
                dgvARTICULOS.Columns[0].Visible = false;
                cVentas.CalculaTotal(oFactura);
                txtSUBTOTAL.Text = oFactura.Importe.ToString();
            }
        }

        private void btnReseteaVenta_Click(object sender, EventArgs e)
        {
            Resetear_Venta();
        }

        private void txtCANTIDAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Carga_Producto();
                txtCODIGO.Focus();
            }
        }

        public void Resetear_Venta()
        {
            oFactura = new MODELO.FACTURA();
            oFactura.Importe = 0;
            oFactura.Tipo_Factura = "FB";
            oFactura.Nro_Factura = cVentas.Obtener_Numero_Factura();
            txtNUMERO_FACTURA.Text = string.Format("{0:00000000}", oFactura.Nro_Factura);
            txtTIPO.Text = oFactura.Tipo_Factura;
            txtPUNTO_VENTA.Text = "001";
            dgvARTICULOS.DataSource = null;
            txtSUBTOTAL.Text = oFactura.Importe.ToString();
            oCliente = cVentas.Obtener_Cliente(55555);
            txtDNI_CLIENTE.Text = oCliente.DNI.ToString();
            txtNOMBRE_CLIENTE.Text = oCliente.Nombre;
            int index = cbFORMADEPAGO.FindString("CONTADO");
            cbFORMADEPAGO.SelectedIndex = index;
        }

        private void btnCOBRAR_Click(object sender, EventArgs e)
        {
            if (oFactura.Importe == 0)
            {
                MessageBox.Show("No hay productos en la lista.");
                return;
            }
            oFactura.CLIENTE = oCliente;
            oFactura.Fecha = dtpFECHA.Value;
            MODELO.FORMA_DE_PAGO oFP = (MODELO.FORMA_DE_PAGO)cbFORMADEPAGO.SelectedItem;

            if(oFP.Descripcion == "CONTADO")
            {
                FrmPagoContado formPAGOCONTADO = new FrmPagoContado(oFactura);
                DialogResult dr = formPAGOCONTADO.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Resetear_Venta();
                }   
            }

            if(oFP.Descripcion == "TARJETA")
            {
                FrmPagoTarjeta formPAGOTARJETA = new FrmPagoTarjeta(oFactura);
                DialogResult dr = formPAGOTARJETA.ShowDialog();
                if (dr == DialogResult.OK)
                    Resetear_Venta();
            }

            if(oFP.Descripcion == "CUENTA CORRIENTE")
            {
                if(oFactura.CLIENTE.Cuenta_Corriente == false)
                {
                    MessageBox.Show("El cliente no tiene habilitada la cuenta corriente", "ATENCIÓN!!");
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
                    oMovimiento.Saldo = cVentas.Obtener_Saldo_Movimiento(oFactura.CLIENTE, oFactura.Importe);
                    oMovimiento.Facturado = oFactura.Importe;
                    oMovimiento.Pagado = 0;
                    oMovimiento.Importe_Cancelado = 0;
                    cVentas.Agregar_Movimiento(oMovimiento);
                    cVentas.Modificar_Stock_Producto(oFactura);
                    cVentas.Guarda_Factura(oFactura);

                    Resetear_Venta();
                    MessageBox.Show("Cuenta corriente actualizada");
                    return;
                }
            }

            if(oFP.Descripcion == "MIXTO")
            {
                FrmPagoMixto formPAGOMIXTO = new FrmPagoMixto(oFactura);
                DialogResult dr = formPAGOMIXTO.ShowDialog();
                if (dr == DialogResult.OK)
                    Resetear_Venta();
            }
        }

        private void btnBuscarPorDescripcion_Click(object sender, EventArgs e)
        {
            MODELO.PRODUCTO oProducto = null;
            FrmBuscarProductos formBUSCARPRODUCTOS = new FrmBuscarProductos();
            DialogResult dr = formBUSCARPRODUCTOS.ShowDialog();

            if (dr == DialogResult.OK)
            {
                oProducto = cVentas.BuscarProducto(formBUSCARPRODUCTOS.codigo);
                cVentas.AgregarProducto(oFactura, oProducto, formBUSCARPRODUCTOS.cant);
                formBUSCARPRODUCTOS.Dispose();
                dgvARTICULOS.DataSource = cVentas.listaVenta(oFactura);
                dgvARTICULOS.Columns[0].Visible = false;
                cVentas.CalculaTotal(oFactura);
                txtSUBTOTAL.Text = oFactura.Importe.ToString();
            }
        }
    }
}
