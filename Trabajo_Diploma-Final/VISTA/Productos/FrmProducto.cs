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
    public partial class FrmProducto : Form
    {
        CONTROLADORA.cProductos cProductos;
        MODELO.PRODUCTO oProducto;
        string Accion;
        public FrmProducto(MODELO.PRODUCTO miProducto, string miAccion)
        {
            InitializeComponent();
            cProductos = CONTROLADORA.cProductos.Obtener_Instancia();
            oProducto = miProducto;
            Accion = miAccion;

            if (Accion != "A")
            {
                txtCODIGO.Text = oProducto.Codigo_Producto.ToString();
                txtDESCRIPCION.Text = oProducto.Descripcion;
                txtPRECIO.Text = oProducto.Precio.ToString();
                txtPRECIO_COSTO.Text = oProducto.Precio_Costo.ToString();
                txtSTOCK.Text = oProducto.Stock.ToString();
                txtSTOCK_MINIMO.Text = oProducto.Stock_Minimo.ToString();

                if (Accion == "C")
                {
                    btnGUARDAR.Visible = false;
                    btnCANCELAR.Text = "Cerrar";
                    txtCODIGO.Enabled = false;
                    txtDESCRIPCION.Enabled = false;
                    txtPRECIO.Enabled = false;
                    txtPRECIO_COSTO.Enabled = false;
                    txtSTOCK.Enabled = false;
                    txtSTOCK_MINIMO.Enabled = false;
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            cProductos.Cancelar_Cambios(oProducto);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            int Codigo;
            if (!int.TryParse(txtCODIGO.Text, out Codigo))
            {
                txtCODIGO.Text = "";
                txtCODIGO.Focus();
                MessageBox.Show("El código ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if (cProductos.Validar_Codigo_Producto(Codigo) && Accion == "A")
            {
                txtCODIGO.Text = "";
                txtCODIGO.Focus();
                MessageBox.Show("El código ingresado ya existe", "ATENCIÓN!!");
                return;
            }

            if (string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                txtDESCRIPCION.Text = "";
                txtDESCRIPCION.Focus();
                MessageBox.Show("Debe ingresar la descripción del producto", "ATENCIÓN!!");
                return;
            }

            decimal Precio;
            if (!decimal.TryParse(txtPRECIO.Text, out Precio))
            {
                txtPRECIO.Focus();
                MessageBox.Show("El precio ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            decimal PrecioCosto;
            if (!decimal.TryParse(txtPRECIO_COSTO.Text, out PrecioCosto))
            {
                txtPRECIO_COSTO.Focus();
                MessageBox.Show("El precio de costo ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            int Stock;
            if (!int.TryParse(txtSTOCK.Text, out Stock))
            {
                txtSTOCK.Focus();
                MessageBox.Show("El stock ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            int StockMinimo;
            if (!int.TryParse(txtSTOCK_MINIMO.Text, out StockMinimo))
            {
                txtSTOCK_MINIMO.Focus();
                MessageBox.Show("El stock mínimo ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            oProducto.Codigo_Producto = Codigo;
            oProducto.Descripcion = txtDESCRIPCION.Text;
            oProducto.Precio = Precio;
            oProducto.Precio_Costo = PrecioCosto;
            oProducto.Stock = Stock;
            oProducto.Stock_Minimo = StockMinimo;

            if (Accion == "A")
            {
                cProductos.Agregar_Producto(oProducto);
            }
            else
            {
                cProductos.Modificar_Producto(oProducto);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
