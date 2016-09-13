using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Caja
{
    [MODELO.formulario(CLASE = "FrmMovimientos", DESCRIPCION = "Planilla de Caja", MENU = true, MODULO = "Caja", SUBMODULO = "Gestión de Caja")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar Movimiento", FORMULARIO = "FrmMovimientos")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar movimiento de Caja", FORMULARIO = "FrmMovimientos")]
    public partial class FrmMovimientos : Form
    {
        CONTROLADORA.cCaja cCaja;
        MODELO.USUARIO oUsuario;
        private static FrmMovimientos Instancia;

        public static FrmMovimientos Obtener_Instancia(MODELO.USUARIO miUsuario)
        {
            if (Instancia == null)
                Instancia = new Caja.FrmMovimientos(miUsuario);
            if (Instancia.IsDisposed)
                Instancia = new FrmMovimientos(miUsuario);

            return Instancia;
        }
        public FrmMovimientos(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cCaja = CONTROLADORA.cCaja.Obtener_Instancia();
            oUsuario = miUsuario;
            txtENTRADAS.Text = "0";
            txtSALIDAS.Text = "0";
            txtTOTAL.Text = "0";

            btnCONSULTAR.Enabled = oUsuario.VALIDAR_ACCION("FrmMovimientos", "btnCONSULTAR");
            btnAGREGAR.Enabled = oUsuario.VALIDAR_ACCION("FrmMovimientos", "btnAGREGAR");

        }

        public void Arma_Grilla()
        {
            decimal Entradas = 0;
            decimal Salidas = 0;
            decimal Total = 0;
            List<MODELO.MOVIMIENTO_CAJA> MovsCaja = new List<MODELO.MOVIMIENTO_CAJA>();
            MovsCaja = cCaja.Filtrar_Movimientos(dtpFECHA.Value.Date);
            dgvMOVIMIENTOS_CAJA.DataSource = null;
            dgvMOVIMIENTOS_CAJA.DataSource = MovsCaja;
            dgvMOVIMIENTOS_CAJA.Columns[0].Visible = false;
            dgvMOVIMIENTOS_CAJA.Columns[8].Visible = false;

            for (int i = 0; i < MovsCaja.Count; i++)
            {
                MODELO.MOVIMIENTO_CAJA oMovCaja = MovsCaja[i];
                if (oMovCaja.Entrada != 0)
                {
                    Entradas += oMovCaja.Entrada;
                    Total += oMovCaja.Entrada;
                }
                else
                {
                    Salidas += oMovCaja.Salida;
                    Total -= oMovCaja.Salida;
                }
            }
            txtENTRADAS.Text = Entradas.ToString();
            txtSALIDAS.Text = Salidas.ToString();
            txtTOTAL.Text = Total.ToString();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmMovimiento formMOVIMIENTO = new Caja.FrmMovimiento(new MODELO.MOVIMIENTO_CAJA(), "A");
            DialogResult dr = formMOVIMIENTO.ShowDialog();

            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            MODELO.MOVIMIENTO_CAJA oMovCaja = cCaja.Obtener_MovimientoCaja(Convert.ToInt32(dgvMOVIMIENTOS_CAJA.CurrentRow.Cells[0].Value));
            if(oMovCaja.Forma_de_Pago == "NINGUNO")
            {
                FrmMovimiento formMOVIMIENTO = new Caja.FrmMovimiento(oMovCaja, "C");
                DialogResult dr = formMOVIMIENTO.ShowDialog();
            }

            if(oMovCaja.Comprobante == "FB")
            {
                Ventas.FrmFactura formFACTURA = new Ventas.FrmFactura(cCaja.Obtener_Factura(Convert.ToInt32(dgvMOVIMIENTOS_CAJA.CurrentRow.Cells[4].Value)), "C");
                DialogResult dr = formFACTURA.ShowDialog();
            }
        }
    }
}
