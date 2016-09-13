using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cCuentaCorriente
    {
        MODELO.CATALOGO oCatalogo;
        private static cCuentaCorriente Instancia;

        public static cCuentaCorriente Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new CONTROLADORA.cCuentaCorriente();

            return Instancia;
        }

        private cCuentaCorriente()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public List<MODELO.MOVIMIENTO> Obtener_Movimientos(MODELO.CLIENTE oCliente)
        {
            var Movimientos = from Movimiento in oCatalogo.MOVIMIENTOS
                              select Movimiento;

            if(oCliente != null)
            {
                Movimientos = Movimientos.Where(m => m.CLIENTE.Id_Cliente == oCliente.Id_Cliente);
            }

            return (List<MODELO.MOVIMIENTO>)Movimientos.ToList();
        }

        public List<MODELO.MOVIMIENTO> Filtrar_Movimientos_Fecha(MODELO.CLIENTE oCliente, DateTime FechaDesde, DateTime FechaHasta)
        {
            var Movimientos = from Movimiento in oCatalogo.MOVIMIENTOS
                              select Movimiento;
            if(oCliente != null)
            {
                Movimientos = Movimientos.Where(m => m.CLIENTE.Id_Cliente == oCliente.Id_Cliente && DbFunctions.TruncateTime(m.Fecha) >= FechaDesde && DbFunctions.TruncateTime(m.Fecha) <= FechaHasta);
            }

            return Movimientos.ToList();
        }

        public List<MODELO.MOVIMIENTO> Filtrar_Movimientos(MODELO.CLIENTE oCliente)
        {
            var Movimientos = from Movimiento in oCatalogo.MOVIMIENTOS
                              select Movimiento;

            if(oCliente != null)
            {
                Movimientos = Movimientos.Where(m => m.CLIENTE.Id_Cliente == oCliente.Id_Cliente && m.Descripcion == "FACTURA" && m.Facturado != m.Importe_Cancelado);
            }

            return Movimientos.ToList();
        }

        public decimal Obtener_Saldo_Movimiento(MODELO.CLIENTE oCliente, decimal Saldo)
        {
            decimal Importe;
            MODELO.MOVIMIENTO oMovimiento = oCliente.MOVIMIENTO.Last();
            Importe = oMovimiento.Saldo - Saldo;
            return Importe;
        }

        public decimal Obtener_Saldo(MODELO.CLIENTE oCliente)
        {
            decimal Saldo;
            MODELO.MOVIMIENTO oMovimiento = oCliente.MOVIMIENTO.Last();
            Saldo = oMovimiento.Saldo;
            return Saldo;
        }

        public void Agregar_movimiento_Caja(MODELO.MOVIMIENTO_CAJA oMovCaja)
        {
            oCatalogo.MOVIMIENTOS_CAJA.Add(oMovCaja);
            oCatalogo.SaveChanges();
        }

        public MODELO.CAJA Obtener_Caja()
        {
            return oCatalogo.CAJAS.FirstOrDefault(c => c.Id_Caja == 1);
        }

        public void Modificar_Movimiento(MODELO.MOVIMIENTO oMovimiento)
        {
            oCatalogo.Entry(oMovimiento).State = System.Data.Entity.EntityState.Modified;
            oCatalogo.SaveChanges();
        }

        public List<MODELO.TARJETA> Obtener_Tarjetas()
        {
            return oCatalogo.TARJETAS.ToList();
        }

        public List<MODELO.FORMA_DE_PAGO> Obtener_Formas_Pago()
        {
            return oCatalogo.FORMAS_DE_PAGOS.ToList();
        }

        public MODELO.CLIENTE Obtener_Cliente(int Codigo)
        {
            return oCatalogo.CLIENTES.Find(Codigo);
        }

        public void Agregar_Recibo(MODELO.RECIBO oRecibo)
        {
            oCatalogo.RECIBOS.Add(oRecibo);
            oCatalogo.SaveChanges();
        }

        public void Agregar_Movimiento(MODELO.MOVIMIENTO oMovimiento)
        {
            oCatalogo.MOVIMIENTOS.Add(oMovimiento);
            oCatalogo.SaveChanges();
        }

        public MODELO.MOVIMIENTO Obtener_Movimiento(int Codigo)
        {
            return oCatalogo.MOVIMIENTOS.Find(Codigo);
        }

        public int Obtener_Numero_Recibo()
        {
            int Numero = 0;
            if (oCatalogo.RECIBOS.Count() != 0)
            {
                MODELO.RECIBO oRecibo = (from x in oCatalogo.RECIBOS select x).OrderByDescending(x => x.Nro_Recibo).First();
                Numero = oRecibo.Nro_Recibo + 1;
            }
            else
            {
                Numero = 1;
            }
            return Numero;
        }
    }
}
