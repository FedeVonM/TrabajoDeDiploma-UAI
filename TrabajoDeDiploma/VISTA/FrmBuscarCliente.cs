using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmBuscarCliente : Form
    {
        CONTROLADORA.cFacturas cVentas;
        MODELO.CLIENTE oCliente;
        public FrmBuscarCliente()
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            oCliente = null;

            Busca_Personas();
        }

        public MODELO.CLIENTE Obtener_Cliente
        {
            get
            {
                return oCliente;
            }
        }

        private void Busca_Personas()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = cVentas.ListaClientes(txtNOMBRE_CLIENTE.Text, txtAPELLIDO_CLIENTE.Text);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            Busca_Personas();
        }

        private void dgvCLIENTES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            else
            {
                oCliente = cVentas.Obtener_Cliente_Por_Codigo(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            else
            {
                oCliente = cVentas.Obtener_Cliente_Por_Codigo(Convert.ToInt32(dgvCLIENTES.CurrentRow.Cells[0].Value));
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
