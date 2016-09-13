using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Productos
{
    [MODELO.formulario(CLASE = "FrmProductos", DESCRIPCION = "Gestión de Productos del sistema", MENU = true, MODULO = "Productos", SUBMODULO = "Gestión de productos del sistema")]
    [MODELO.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos del producto", FORMULARIO = "FrmProductos")]
    [MODELO.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar productos del sistema", FORMULARIO = "FrmProductos")]
    [MODELO.accion(CONTROL = "btnMODIFICAR", DESCRIPCION = "Modificar datos de un producto", FORMULARIO = "FrmProductos")]
    [MODELO.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar productos al sistema", FORMULARIO = "FrmProductos")]
    public partial class FrmProductos : Form
    {
        private static FrmProductos Instancia;
        MODELO.USUARIO oUsuario;
        CONTROLADORA.cProductos cProductos;

        public static FrmProductos Obtener_Instancia(MODELO.USUARIO miUsuario)
        {
            if (Instancia == null)
                Instancia = new FrmProductos(miUsuario);
            if (Instancia.IsDisposed)
                Instancia = new FrmProductos(miUsuario);

            return Instancia;
        }
        public FrmProductos(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cProductos = CONTROLADORA.cProductos.Obtener_Instancia();
            oUsuario = miUsuario;

            btnCONSULTAR.Enabled = oUsuario.VALIDAR_ACCION("FrmProductos", "btnCONSULTAR");
            btnELIMINAR.Enabled = oUsuario.VALIDAR_ACCION("FrmProductos", "btnELIMINAR");
            btnMODIFICAR.Enabled = oUsuario.VALIDAR_ACCION("FrmProductos", "btnMODIFICAR");
            btnAGREGAR.Enabled = oUsuario.VALIDAR_ACCION("FrmProductos", "btnAGREGAR");

            Arma_Grilla();
        }

        public void Arma_Grilla()
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = cProductos.Filtrar_Productos(txtDESCRIPCION.Text);
            dgvPRODUCTOS.Columns[6].Visible = false;
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (rbDESCRIPCION.Checked)
            {
                Arma_Grilla();
            }
            else
            {
                int codigo;
                int.TryParse(txtCODIGO.Text, out codigo);
                dgvPRODUCTOS.DataSource = null;
                dgvPRODUCTOS.DataSource = cProductos.Filtrar_Productos_Por_Codigo(codigo);
                dgvPRODUCTOS.Columns[6].Visible = false;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            FrmProducto formPRODUCTO = new FrmProducto(new MODELO.PRODUCTO(), "A");
            DialogResult dr = formPRODUCTO.ShowDialog();
            if (dr == DialogResult.OK)
                Arma_Grilla();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "ATENCIÓN!!");
                return;
            }
            MODELO.PRODUCTO oProducto = cProductos.Obtener_Producto(Convert.ToInt32(dgvPRODUCTOS.CurrentRow.Cells[0].Value));
            if (oProducto.Stock > 0)
            {
                MessageBox.Show("No se puede eliminar el producto seleccionado porque se posee stock", "ATENCIÓN!!");
                return;
            }

            DialogResult dr = MessageBox.Show("Confirme la eliminación del producto", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cProductos.Eliminar_Producto(oProducto);
                Arma_Grilla();
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "ATENCIÓN!!");
                return;
            }
            FrmProducto formPRODUCTO = new FrmProducto(cProductos.Obtener_Producto(Convert.ToInt32(dgvPRODUCTOS.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formPRODUCTO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                Arma_Grilla();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCIÓN!!");
                return;
            }
            FrmProducto formPRODUCTO = new FrmProducto(cProductos.Obtener_Producto(Convert.ToInt32(dgvPRODUCTOS.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formPRODUCTO.ShowDialog();
        }
    }
}
