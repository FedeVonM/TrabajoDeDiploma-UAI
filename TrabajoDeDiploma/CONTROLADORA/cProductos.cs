using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cProductos
    {
        MODELO.CATALOGO oCatalogo;
        private static cProductos Instancia;

        public static cProductos Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cProductos();

            return Instancia;
        }

        private cProductos()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCatalogo.PRODUCTOS.Add(oProducto);
            oCatalogo.SaveChanges();
        }

        public void Modificar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCatalogo.Entry(oProducto).State = System.Data.Entity.EntityState.Modified;
            oCatalogo.SaveChanges();
        }

        public void Eliminar_Producto(MODELO.PRODUCTO oProducto)
        {
            oCatalogo.PRODUCTOS.Remove(oProducto);
            oCatalogo.SaveChanges();
        }

        public void Cancelar_Cambios(MODELO.PRODUCTO oProducto)
        {
            oCatalogo.Entry(oProducto).State = System.Data.Entity.EntityState.Detached;
        }

        public List<MODELO.PRODUCTO> Filtrar_Productos(string Descripcion)
        {
            var productos = from producto in oCatalogo.PRODUCTOS
                            where producto.Descripcion.Contains(Descripcion)
                            select producto;

            return productos.ToList();
        }

        public List<MODELO.PRODUCTO> Filtrar_Productos_Por_Codigo(int Codigo)
        {
            List<MODELO.PRODUCTO> productos = oCatalogo.PRODUCTOS.ToList();
            return productos.FindAll(p => p.Codigo_Producto == Codigo);
        }

        public MODELO.PRODUCTO Obtener_Producto(int Codigo)
        {
            return oCatalogo.PRODUCTOS.Find(Codigo);
        }

        public Boolean Validar_Codigo_Producto(int Codigo)
        {
            MODELO.PRODUCTO oProducto = oCatalogo.PRODUCTOS.FirstOrDefault(p => p.Codigo_Producto == Codigo);
            if (oProducto == null)
                return false;
            else
                return true;
        }
    }
}
