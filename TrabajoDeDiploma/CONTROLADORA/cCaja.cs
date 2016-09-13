using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCaja
    {
        MODELO.CATALOGO oCatalogo;
        private static cCaja Instancia;

        public static cCaja Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new CONTROLADORA.cCaja();

            return Instancia;
        }

        private cCaja()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Movimiento(MODELO.MOVIMIENTO_CAJA oMovimiento)
        {
            oCatalogo.MOVIMIENTOS_CAJA.Add(oMovimiento);
            oCatalogo.SaveChanges();
        }

        public List<MODELO.MOVIMIENTO_CAJA> Filtrar_Movimientos(DateTime Fecha)
        {
            var Movimientos = from Movimiento in oCatalogo.MOVIMIENTOS_CAJA
                              select Movimiento;
            if(Fecha != null)
            {
                Movimientos = Movimientos.Where(m => DbFunctions.TruncateTime(m.Fecha) == Fecha);
            }
            return Movimientos.ToList();
        }

        public MODELO.CAJA Obtener_Caja()
        {
            return oCatalogo.CAJAS.FirstOrDefault(c => c.Id_Caja == 1);
        }

        public MODELO.MOVIMIENTO_CAJA Obtener_MovimientoCaja(int Codigo)
        {
            return oCatalogo.MOVIMIENTOS_CAJA.Find(Codigo);
        }

        public MODELO.FACTURA Obtener_Factura(int Nro)
        {
            MODELO.FACTURA oFactura = oCatalogo.FACTURAS.FirstOrDefault(x => x.Nro_Factura == Nro);
            return oFactura;
        }
    }
}
