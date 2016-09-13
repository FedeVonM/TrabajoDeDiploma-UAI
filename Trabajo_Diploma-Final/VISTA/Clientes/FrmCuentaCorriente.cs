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
    public partial class FrmCuentaCorriente : Form
    {
        MODELO.CLIENTE oCliente;
        CONTROLADORA.cCuentaCorriente cCuentaCorriente;
        public FrmCuentaCorriente(MODELO.CLIENTE miCLIENTE)
        {
            InitializeComponent();
            cCuentaCorriente = CONTROLADORA.cCuentaCorriente.Obtener_Instancia();
            oCliente = miCLIENTE;
            lblCLIENTE.Text = "Cuenta Corriente:" + " " + oCliente.Nombre + " " + oCliente.Apellido;
        }

        public void Arma_Grilla()
        {
            if (rbTODOS.Checked)
            {
                dgvMOVIMIENTOS.DataSource = null;
                dgvMOVIMIENTOS.DataSource = cCuentaCorriente.Obtener_Movimientos(oCliente);
            }
            else
            {
                dgvMOVIMIENTOS.DataSource = null;
                dgvMOVIMIENTOS.DataSource = cCuentaCorriente.Filtrar_Movimientos_Fecha(oCliente, dtpDESDE.Value.Date, dtpHASTA.Value.Date);
            }

            foreach (DataGridViewRow row in dgvMOVIMIENTOS.Rows)
            {
                int Linea = row.Index;
                if (row.Cells[4].Value.ToString() == "FACTURA")
                {
                    MODELO.MOVIMIENTO oMovimiento = cCuentaCorriente.Obtener_Movimiento(Convert.ToInt32(row.Cells[0].Value));
                    if (oMovimiento.Facturado != oMovimiento.Importe_Cancelado)
                    {
                        dgvMOVIMIENTOS.Rows[Linea].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }

            dgvMOVIMIENTOS.Columns[0].Visible = false;
            dgvMOVIMIENTOS.Columns[7].Visible = false;
            //dgvMOVIMIENTOS.Columns[8].Visible = false;
            dgvMOVIMIENTOS.Columns[10].Visible = false;
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            if(cCuentaCorriente.Filtrar_Movimientos(oCliente).Count == 0)
            {
                MessageBox.Show("El cliente no posee deudas", "ATENCIÓN!!");
                return;
            }

            FrmIngresarPago formINGRESARPAGO = new Clientes.FrmIngresarPago(oCliente);
            DialogResult dr = formINGRESARPAGO.ShowDialog();
            
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnINGRESARMOVIMIENTO_Click(object sender, EventArgs e)
        {
            FrmIngresaMovimiento formINGRESAMOVIMIENTO = new Clientes.FrmIngresaMovimiento(new MODELO.MOVIMIENTO(), "A", oCliente);
            DialogResult dr = formINGRESAMOVIMIENTO.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }
    }
}
