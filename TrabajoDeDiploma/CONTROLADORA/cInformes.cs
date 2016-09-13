using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cInformes
    {
        MODELO.CATALOGO oCatalogo;
        private static cInformes Instancia;
        public decimal CostoTotal { get; set; }
        public decimal TotalVendido { get; set; }
        public static cInformes Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cInformes();

            return Instancia;
        }

        private cInformes()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void CalculaGanancias(DateTime oFechaDesde, DateTime oFechaHasta)
        {
            decimal oTotalVendido = 0;
            decimal oCostoTotal = 0;

            IEnumerable<MODELO.FACTURA> Facturas = from oFactura in oCatalogo.FACTURAS
                                                          where DbFunctions.TruncateTime(oFactura.Fecha) >= oFechaDesde
                                                          && DbFunctions.TruncateTime(oFactura.Fecha) <= oFechaHasta
                                                          select oFactura;

            foreach (MODELO.FACTURA x in Facturas)
                foreach (MODELO.DETALLE_FACTURA detalle in x.DETALLE_FACTURA)
                {
                    oTotalVendido += detalle.Precio * detalle.Cantidad;
                    oCostoTotal += detalle.PRODUCTO.Precio_Costo * detalle.Cantidad;
                };

            TotalVendido = oTotalVendido;
            CostoTotal = oCostoTotal;
        }
    }
}
