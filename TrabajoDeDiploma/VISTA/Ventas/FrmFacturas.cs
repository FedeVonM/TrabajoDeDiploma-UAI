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
    [MODELO.formulario(CLASE = "FrmFacturas", DESCRIPCION = "Consulta Facturas", MENU = true, MODULO = "Ventas", SUBMODULO = "Consultas")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar factura", FORMULARIO = "FrmFacturas")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar nueva factura", FORMULARIO = "FrmFacturas")]
    public partial class FrmFacturas : Form
    {
        private static FrmFacturas Instancia;
        CONTROLADORA.cFacturas cVentas;
        MODELO.USUARIO oUsuario;

        public static FrmFacturas Obtener_Instancia(MODELO.USUARIO miUsuario)
        {
            if (Instancia == null)
                Instancia = new Ventas.FrmFacturas(miUsuario);
            if (Instancia.IsDisposed)
                Instancia = new Ventas.FrmFacturas(miUsuario);

            return Instancia;
        }
        public FrmFacturas(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oUsuario = miUsuario;

            btnCONSULTAR.Enabled = oUsuario.VALIDAR_ACCION("FrmFacturas", "btnCONSULTAR");
            btnAGREGAR.Enabled = oUsuario.VALIDAR_ACCION("FrmFacturas", "btnAGREGAR");

            Arma_Grilla();
        }

        public void Arma_Grilla()
        {
            if(rbTodos.Checked)
            {
                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = cVentas.Obtener_Facturas();
            }

            if(rbCliente.Checked)
            {
                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = cVentas.Filtrar_Facturas(txtCliente.Text, dtpDesde.Value.Date, dtpHasta.Value.Date);
            }

            if(rbNumero.Checked)
            {
                int Nro;
                int.TryParse(txtNumero.Text, out Nro);
                dgvFacturas.DataSource = null;
                dgvFacturas.DataSource = cVentas.Obtener_Factura_Numero(Nro);
            }
            dgvFacturas.Columns[0].Visible = false;
            dgvFacturas.Columns[6].Visible = false;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmFactura formFACTURA = new Ventas.FrmFactura(oUsuario);
            DialogResult dr = formFACTURA.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una factura de la lista", "ATENCIÓN!!");
                return;
            }

            FrmFactura formFACTURA = new FrmFactura(cVentas.Obtener_Factura(Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formFACTURA.ShowDialog();
        }
    }
}
