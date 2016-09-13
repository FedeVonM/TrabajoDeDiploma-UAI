using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cInicio
    {
        private static cInicio Instancia;
        MODELO.CATALOGO oCatalogo;

        public static cInicio Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cInicio();

            return Instancia;
        }
        private cInicio()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void IniciaBaseDeDatos()
        {
            if (oCatalogo.CLIENTES.Count() == 0)
            {
                MODELO.CLIENTE oCliente = new MODELO.CLIENTE();
                oCliente.Nombre = "Mostrador";
                oCliente.Apellido = "";
                oCliente.DNI = 55555;
                oCliente.Telefono = "";
                oCliente.Direccion = "";
                oCliente.Ciudad = "";
                oCliente.Mail = "";
                oCliente.Provincia = "";
                oCatalogo.CLIENTES.Add(oCliente);
                oCatalogo.SaveChanges();

                oCliente = new MODELO.CLIENTE();
                oCliente.Nombre = "Federico";
                oCliente.Apellido = "Von Muhlinen";
                oCliente.DNI = 38337680;
                oCliente.Telefono = "3468641609";
                oCliente.Direccion = "Salta 1050";
                oCliente.Ciudad = "Rosario";
                oCliente.Mail = "fedevonm@gmail.com";
                oCliente.Provincia = "Santa Fé";
                oCatalogo.CLIENTES.Add(oCliente);
                oCatalogo.SaveChanges();
            }

            if (oCatalogo.PRODUCTOS.Count() == 0)
            {
                MODELO.PRODUCTO oProducto = new MODELO.PRODUCTO();
                oProducto.Descripcion = "Coca-Cola 500ml";
                oProducto.Precio = 12;
                oProducto.Stock = 35;
                oProducto.Stock_Minimo = 10;
                oProducto.Precio_Costo = 7;
                oProducto.Codigo_Producto = 654;
                oCatalogo.PRODUCTOS.Add(oProducto);
                oCatalogo.SaveChanges();

                oProducto = new MODELO.PRODUCTO();
                oProducto.Descripcion = "Yerba Playadito 1kg";
                oProducto.Precio = 45;
                oProducto.Stock = 50;
                oProducto.Stock_Minimo = 10;
                oProducto.Precio_Costo = 30;
                oProducto.Codigo_Producto = 666;
                oCatalogo.PRODUCTOS.Add(oProducto);
                oCatalogo.SaveChanges();

                oProducto = new MODELO.PRODUCTO();
                oProducto.Descripcion = "Hamburguesa Paty x4U";
                oProducto.Precio = 25;
                oProducto.Stock = 45;
                oProducto.Stock_Minimo = 12;
                oProducto.Precio_Costo = 15;
                oProducto.Codigo_Producto = 555;
                oCatalogo.PRODUCTOS.Add(oProducto);

                oCatalogo.SaveChanges();

            }

            if(oCatalogo.FORMAS_DE_PAGOS.Count() == 0)
            {
                MODELO.FORMA_DE_PAGO oForma = new MODELO.FORMA_DE_PAGO();
                oForma.Descripcion = "CONTADO";
                oCatalogo.FORMAS_DE_PAGOS.Add(oForma);
                oCatalogo.SaveChanges();

                oForma = new MODELO.FORMA_DE_PAGO();
                oForma.Descripcion = "TARJETA";
                oCatalogo.FORMAS_DE_PAGOS.Add(oForma);
                oCatalogo.SaveChanges();

                oForma = new MODELO.FORMA_DE_PAGO();
                oForma.Descripcion = "CUENTA CORRIENTE";
                oCatalogo.FORMAS_DE_PAGOS.Add(oForma);
                oCatalogo.SaveChanges();

                oForma = new MODELO.FORMA_DE_PAGO();
                oForma.Descripcion = "MIXTO";
                oCatalogo.FORMAS_DE_PAGOS.Add(oForma);
                oCatalogo.SaveChanges();

            }

            if(oCatalogo.CAJAS.Count() == 0)
            {
                MODELO.CAJA oCaja = new MODELO.CAJA();
                oCaja.Descripcion = "Caja Principal";
                oCatalogo.CAJAS.Add(oCaja);
                oCatalogo.SaveChanges();
            }

            if(oCatalogo.TARJETAS.Count() == 0)
            {
                MODELO.TARJETA oTarjeta = new MODELO.TARJETA();
                oTarjeta.Descripcion = "Visa";
                oCatalogo.TARJETAS.Add(oTarjeta);
                oCatalogo.SaveChanges();

                oTarjeta = new MODELO.TARJETA();
                oTarjeta.Descripcion = "Mastercard";
                oCatalogo.TARJETAS.Add(oTarjeta);
                oCatalogo.SaveChanges();

                oTarjeta = new MODELO.TARJETA();
                oTarjeta.Descripcion = "Naranja";
                oCatalogo.TARJETAS.Add(oTarjeta);
                oCatalogo.SaveChanges();

                oTarjeta = new MODELO.TARJETA();
                oTarjeta.Descripcion = "American Express";
                oCatalogo.TARJETAS.Add(oTarjeta);
                oCatalogo.SaveChanges();
            }

            if (oCatalogo.GRUPOS.Count() == 0)
            {
                MODELO.GRUPO oGRUPO = new MODELO.GRUPO();
                oGRUPO.Activo = true;
                oGRUPO.Descripcion = "SUPERUSUARIOS";
                oCatalogo.GRUPOS.Add(oGRUPO);

                MODELO.USUARIO oUSUARIO = new MODELO.USUARIO();
                oUSUARIO.GRUPO.Add(oGRUPO);
                oUSUARIO.Activo = true;
                oUSUARIO.Clave = CONTROLADORA.cFunciones_Compartidas.EncriparClave("admin");
                oUSUARIO.DNI = 38337680;
                oUSUARIO.Email = "Definir Email";
                oUSUARIO.Nombre = "Administrador";
                oUSUARIO.Nombre_Usuario = "admin";
                oUSUARIO.Telefono = "Definir Teléfono";
                oUSUARIO.Resetear_Clave = false;
                oCatalogo.USUARIOS.Add(oUSUARIO);
            }
        }

        public void ACTUALIZA_MODULO(string nombre)
        {
            if (oCatalogo.MODULOS.Count(m => m.Descripcion == nombre) == 0)
            {
                MODELO.MODULO oMODULO = new MODELO.MODULO();
                oMODULO.Descripcion = nombre;
                oCatalogo.MODULOS.Add(oMODULO);
                oCatalogo.SaveChanges();
            }
        }

        public void ACTUALIZA_FORMULARIOS(MODELO.formulario form)
        {
            if (oCatalogo.FORMULARIOS.Count(frm => frm.Clase == form.CLASE) == 0)
            {
                MODELO.SUBMODULO oSUBMODULO = oCatalogo.SUBMODULOS.FirstOrDefault(smo => smo.Descripcion == form.SUBMODULO);
                if (oSUBMODULO == null)
                {
                    MODELO.MODULO oMODULO = oCatalogo.MODULOS.FirstOrDefault(mod => mod.Descripcion == form.MODULO);
                    oSUBMODULO = new MODELO.SUBMODULO();
                    oSUBMODULO.Descripcion = form.SUBMODULO;

                    oMODULO.SUBMODULO.Add(oSUBMODULO);
                }

                MODELO.FORMULARIO oFORMULARIO = new MODELO.FORMULARIO();
                oFORMULARIO.Descripcion = form.DESCRIPCION;
                oFORMULARIO.Clase = form.CLASE;
                oFORMULARIO.Activo = true;
                oFORMULARIO.Menu = form.MENU;

                oSUBMODULO.FORMULARIO.Add(oFORMULARIO);
                oCatalogo.SaveChanges();
            }
        }

        public void ACTUALIZA_ACCIONES(MODELO.accion accion)
        {
            if (oCatalogo.ACCIONES.Count(a => (a.Control == accion.CONTROL) && (a.FORMULARIO.Clase == accion.FORMULARIO)) == 0)
            {
                MODELO.FORMULARIO oFORMULARIO = oCatalogo.FORMULARIOS.FirstOrDefault(form => form.Clase == accion.FORMULARIO);
                MODELO.ACCION oACCION = new MODELO.ACCION();
                oACCION.Descripcion = accion.DESCRIPCION;
                oACCION.Control = accion.CONTROL;

                if (oFORMULARIO != null)
                {
                    oFORMULARIO.ACCION.Add(oACCION);
                    oCatalogo.SaveChanges();
                }
            }
        }
    }
}
