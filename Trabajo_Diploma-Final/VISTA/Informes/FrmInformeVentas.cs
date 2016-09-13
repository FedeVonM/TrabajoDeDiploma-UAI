using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace VISTA.Informes
{
    [MODELO.formulario(CLASE = "FrmInformeVentas", DESCRIPCION = "Generar informes de ventas", MENU = true, MODULO = "Informes", SUBMODULO = "Gestión de informes del sistema")]
    [MODELO.accion(CONTROL = "GenerarInforme", DESCRIPCION = "Generar informes de ventas", FORMULARIO = "FrmInformeVentas")]
    public partial class FrmInformeVentas : Form
    {
        private static FrmInformeVentas Instancia;
        MODELO.USUARIO oUsuario;
        CONTROLADORA.cInformes cInformes;

        public static FrmInformeVentas Obtener_Instancia(MODELO.USUARIO miUsuario)
        {
            if (Instancia == null)
                Instancia = new Informes.FrmInformeVentas(miUsuario);
            if (Instancia.IsDisposed)
                Instancia = new FrmInformeVentas(miUsuario);

            return Instancia;
        }
        public FrmInformeVentas(MODELO.USUARIO miUsuario)
        {
            InitializeComponent();
            cInformes = CONTROLADORA.cInformes.Obtener_Instancia();
            oUsuario = miUsuario;

            btnGENERAR.Enabled = oUsuario.VALIDAR_ACCION("FrmInformeVentas", "GenerarInforme");
        }

        private void FrmInformeVentas_Load(object sender, EventArgs e)
        {

            this.rvInformeVentas.RefreshReport();
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            cInformes.CalculaGanancias(dtpDesde.Value.Date, dtpHasta.Value.Date);
            decimal TotalVendido = cInformes.TotalVendido;
            decimal CostoTotal = cInformes.CostoTotal;
            decimal Ganancia = TotalVendido - CostoTotal;
            ReportParameter[] parameters = new ReportParameter[6];
            parameters[0] = new ReportParameter("CostoTotal", CostoTotal.ToString());
            parameters[1] = new ReportParameter("TotalVendido", TotalVendido.ToString());
            parameters[2] = new ReportParameter("Ganancia", Ganancia.ToString());
            parameters[3] = new ReportParameter("FechaDesde", dtpDesde.Text);
            parameters[4] = new ReportParameter("FechaHasta", dtpHasta.Text);
            parameters[5] = new ReportParameter("FechaEmision", DateTime.Now.ToString());
            this.rvInformeVentas.LocalReport.SetParameters(parameters);
            this.rvInformeVentas.RefreshReport();
        }

        private void rvInformeVentas_Load(object sender, EventArgs e)
        {
            decimal Monto = 0;
            ReportParameter[] parameters = new ReportParameter[6];
            parameters[0] = new ReportParameter("CostoTotal", Monto.ToString());
            parameters[1] = new ReportParameter("TotalVendido", Monto.ToString());
            parameters[2] = new ReportParameter("Ganancia", Monto.ToString());
            parameters[3] = new ReportParameter("FechaDesde", "-/-/-");
            parameters[4] = new ReportParameter("FechaHasta", "-/-/-");
            parameters[5] = new ReportParameter("FechaEmision", "-/-/-");
            this.rvInformeVentas.LocalReport.SetParameters(parameters);
            this.rvInformeVentas.RefreshReport();
        }
    }
}
