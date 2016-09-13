using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cFacturas
    {
        MODELO.CATALOGO oCatalogo;
        private static cFacturas Instancia;

        public static cFacturas Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cFacturas();

            return Instancia;
        }

        private cFacturas()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public MODELO.CLIENTE Obtener_Cliente(int DNI)
        {
            return oCatalogo.CLIENTES.FirstOrDefault(c => c.DNI == DNI);
        }

        public MODELO.CLIENTE Obtener_Cliente_Por_Codigo(int cod)
        {
            return oCatalogo.CLIENTES.Find(cod);
        }

        public System.Collections.IEnumerable ListaClientes(string miNombre, string miApellido)
        {
            var lista = from cliente in oCatalogo.CLIENTES
                        where cliente.Nombre.Contains(miNombre) && cliente.Apellido.Contains(miApellido)
                        select new { cliente.Id_Cliente, cliente.Nombre, cliente.Apellido };
            return lista.ToList();
        }

        public MODELO.PRODUCTO Obtener_Producto(int Codigo)
        {
            return oCatalogo.PRODUCTOS.FirstOrDefault(p => p.Codigo_Producto == Codigo);
        }

        public MODELO.PRODUCTO BuscarProducto(int cod)
        {
            return oCatalogo.PRODUCTOS.Find(cod);
        }

        public List<MODELO.FORMA_DE_PAGO> Obtener_Formas_Pago()
        {
            return oCatalogo.FORMAS_DE_PAGOS.ToList();
        }

        public void AgregarProducto(MODELO.FACTURA miFactura, MODELO.PRODUCTO miProducto, decimal miCant)
        {
            MODELO.DETALLE_FACTURA respDetalle = (from detalle in miFactura.DETALLE_FACTURA
                                                where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                                select detalle).SingleOrDefault();
            if (respDetalle == null)
            {
                MODELO.DETALLE_FACTURA oDetalle = new MODELO.DETALLE_FACTURA();
                oDetalle.PRODUCTO = miProducto;
                oDetalle.Cantidad = miCant;
                oDetalle.Precio = miProducto.Precio;
                miFactura.DETALLE_FACTURA.Add(oDetalle);
            }
            else
            {
                respDetalle.Cantidad = respDetalle.Cantidad + miCant;
            }
        }

        public void Modificar_Stock_Producto(MODELO.FACTURA oFactura)
        {
            List<MODELO.DETALLE_FACTURA> lista = oFactura.DETALLE_FACTURA.ToList();
            foreach (MODELO.DETALLE_FACTURA oDetalle in lista)
            {
                MODELO.PRODUCTO oProducto = null;
                oProducto = oDetalle.PRODUCTO;
                oProducto.Stock = oProducto.Stock - oDetalle.Cantidad;
                Modificar_Producto(oProducto);
            }
        }

        public void Modificar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCatalogo.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
            oCatalogo.SaveChanges();
        }

        public System.Collections.IList listaVenta(MODELO.FACTURA miFactura)
        {
            var lista = from detalle in miFactura.DETALLE_FACTURA
                        join producto in oCatalogo.PRODUCTOS on detalle.PRODUCTO.Codigo_Producto equals producto.Codigo_Producto
                        select new { producto.Codigo_Producto, producto.Descripcion, detalle.Cantidad, Precio = producto.Precio * detalle.Cantidad };
            return lista.ToList();
        }

        public void CalculaTotal(MODELO.FACTURA miFactura)
        {
            decimal acum = 0;

            foreach (MODELO.DETALLE_FACTURA item in miFactura.DETALLE_FACTURA)
            {
                acum += item.Precio * item.Cantidad;
            }

            miFactura.Importe = acum;
        }

        public void EliminarProducto(MODELO.FACTURA miFactura, MODELO.PRODUCTO miProducto)
        {
            MODELO.DETALLE_FACTURA oDetalle = (from detalle in miFactura.DETALLE_FACTURA
                                             where detalle.PRODUCTO.Codigo_Producto == miProducto.Codigo_Producto
                                             select detalle).First();
            miFactura.DETALLE_FACTURA.Remove(oDetalle);
        }

        public void Guarda_Factura(MODELO.FACTURA miFactura)
        {
            oCatalogo.FACTURAS.Add(miFactura);
            oCatalogo.SaveChanges();
        }

        public void Agregar_Movimiento(MODELO.MOVIMIENTO oMovimiento)
        {
            oCatalogo.MOVIMIENTOS.Add(oMovimiento);
            oCatalogo.SaveChanges();
        }

        public decimal Obtener_Saldo_Movimiento(MODELO.CLIENTE oCliente, decimal Saldo)
        {
            decimal Importe;
            if(oCliente.MOVIMIENTO.Count == 0)
            {
                Importe = 0 + Saldo;
            }
            else
            {
                MODELO.MOVIMIENTO oMovimiento = oCliente.MOVIMIENTO.Last();
                Importe = oMovimiento.Saldo + Saldo;
            }
            return Importe;
        }

        public MODELO.CAJA Obtener_Caja()
        {
            return oCatalogo.CAJAS.FirstOrDefault(c => c.Id_Caja == 1);
        }

        public void Agregar_Movimiento_Caja(MODELO.MOVIMIENTO_CAJA oMov)
        {
            oCatalogo.MOVIMIENTOS_CAJA.Add(oMov);
            oCatalogo.SaveChanges();
        }

        public List<MODELO.TARJETA> Obtener_Tarjetas()
        {
            return oCatalogo.TARJETAS.ToList();
        }

        public object Filtrar_Productos(string miNombre)
        {
            var oListaProductos = from producto in oCatalogo.PRODUCTOS
                                  where producto.Descripcion.Contains(miNombre)
                                  select new { producto.Codigo_Producto, producto.Descripcion, producto.Precio };
            return oListaProductos.ToList();
        }

        public int Obtener_Numero_Factura()
        {
            int Numero = 0;
            if(oCatalogo.FACTURAS.Count() != 0)
            {
                MODELO.FACTURA oFactura = (from x in oCatalogo.FACTURAS select x).OrderByDescending(x => x.Nro_Factura).First();
                Numero = oFactura.Nro_Factura + 1;               
            }
            else
            {
                Numero = 1;
            }
            return Numero;
        }

        public List<MODELO.FACTURA> Obtener_Facturas()
        {
            return oCatalogo.FACTURAS.ToList();
        }

        public List<MODELO.FACTURA> Filtrar_Facturas(string Nombre, DateTime Desde, DateTime Hasta)
        {
            var Facturas = from Factura in oCatalogo.FACTURAS
                           where Factura.CLIENTE.Nombre.Contains(Nombre) || Factura.CLIENTE.Apellido.Contains(Nombre)
                           select Factura;

            if(Desde != null && Hasta != null)
            {
                Facturas = Facturas.Where(x => DbFunctions.TruncateTime(x.Fecha) >= Desde && DbFunctions.TruncateTime(x.Fecha) <= Hasta);
            }

            return Facturas.ToList();
        }

        public List<MODELO.FACTURA> Obtener_Factura_Numero(int Nro)
        {
            var Facturas = from Factura in oCatalogo.FACTURAS
                           where Factura.Nro_Factura == Nro
                           select Factura;

            return Facturas.ToList();
        }

        public MODELO.FACTURA Obtener_Factura(int id)
        {
            return oCatalogo.FACTURAS.Find(id);
        }
    }
}
