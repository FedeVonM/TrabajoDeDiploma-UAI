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
    public partial class FrmMovimiento : Form
    {
        MODELO.MOVIMIENTO_CAJA oMovimiento;
        CONTROLADORA.cCaja cCaja;
        string Accion;
        public FrmMovimiento(MODELO.MOVIMIENTO_CAJA miMovimiento, string miAccion)
        {
            InitializeComponent();
            cCaja = CONTROLADORA.cCaja.Obtener_Instancia();
            oMovimiento = miMovimiento;
            Accion = miAccion;

            if(Accion == "C")
            {
                dtpFECHA.Value = oMovimiento.Fecha;
                if(oMovimiento.Entrada != 0)
                {
                    rbENTRADA.Checked = true;
                    txtIMPORTE.Text = oMovimiento.Entrada.ToString();
                }
                else
                {
                    rbSALIDA.Checked = true;
                    txtIMPORTE.Text = oMovimiento.Salida.ToString();
                }
                txtDESCRIPCION.Text = oMovimiento.Concepto;
                dtpFECHA.Enabled = false;
                txtIMPORTE.Enabled = false;
                rbENTRADA.Enabled = false;
                rbSALIDA.Enabled = false;
                txtDESCRIPCION.Enabled = false;
                btnAceptar.Visible = false;
                btnCANCELAR.Text = "Atrás";
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal Importe;
            if(!decimal.TryParse(txtIMPORTE.Text, out Importe))
            {
                MessageBox.Show("El importe ingresado es incorrecto", "ATENCIÓN!!");
                return;
            }

            if(string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar la descripción del movimiento", "ATENCIÓN!!");
                return;
            }

            oMovimiento.Concepto = txtDESCRIPCION.Text;
            if(rbENTRADA.Checked)
            {
                oMovimiento.Entrada = Importe;
                oMovimiento.Salida = 0;
            }
            else
            {
                oMovimiento.Salida = Importe;
                oMovimiento.Entrada = 0;
            }
            oMovimiento.Fecha = dtpFECHA.Value;
            oMovimiento.CAJA = cCaja.Obtener_Caja();
            oMovimiento.Forma_de_Pago = "NINGUNO";
            oMovimiento.Comprobante = "";
            oMovimiento.Número_Comprobante = 0;
            cCaja.Agregar_Movimiento(oMovimiento);

            this.DialogResult = DialogResult.OK;
        }
    }
}
