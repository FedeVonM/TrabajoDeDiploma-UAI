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
    public partial class FrmBuscarProductos : Form
    {
        CONTROLADORA.cFacturas cVentas;
        public int cond { get; set; }
        public int codigo { get; set; }
        public decimal cant { get; set; }
        public FrmBuscarProductos()
        {
            InitializeComponent();
            cVentas = CONTROLADORA.cFacturas.Obtener_Instancia();
            tBCantidad.Text = "1";

            Arma_Grilla();
        }

        public void Arma_Grilla()
        {
            dGVProductos.DataSource = null;
            dGVProductos.DataSource = cVentas.Filtrar_Productos(tBNombre.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Arma_Grilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal cantidad;

            if (dGVProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "ATENCIÓN!!");
                return;
            }

            if (!decimal.TryParse(tBCantidad.Text, out cantidad))
            {
                MessageBox.Show("Indique cantidad.", "ATENCIÓN!!");
                return;
            }

            cant = cantidad;
            codigo = Convert.ToInt32(dGVProductos.CurrentRow.Cells[0].Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
