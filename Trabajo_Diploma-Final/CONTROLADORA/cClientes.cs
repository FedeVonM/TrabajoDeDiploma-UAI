using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
    public class cClientes
    {
        MODELO.CATALOGO oCatalogo;
        private static cClientes Instancia;

        public static cClientes Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new CONTROLADORA.cClientes();

            return Instancia;
        }

        private cClientes()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Cliente(MODELO.CLIENTE oCliente)
        {
            oCatalogo.CLIENTES.Add(oCliente);
            oCatalogo.SaveChanges();
        }

        public void Eliminar_Cliente(MODELO.CLIENTE oCliente)
        {
            oCatalogo.CLIENTES.Remove(oCliente);
            oCatalogo.SaveChanges();
        }

        public void Modificar_Cliente(MODELO.CLIENTE oCliente)
        {
            oCatalogo.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
            oCatalogo.SaveChanges();
        }

        public void Cancelar_Cambios(MODELO.CLIENTE oCliente)
        {
            oCatalogo.Entry(oCliente).State = System.Data.Entity.EntityState.Detached;
        }

        public MODELO.CLIENTE Obtener_Cliente(int Codigo)
        {
            return oCatalogo.CLIENTES.Find(Codigo);
        }

        public List<MODELO.CLIENTE> Filtrar_Clientes(string Nombre)
        {
            var clientes = from cliente in oCatalogo.CLIENTES
                           where cliente.Nombre.Contains(Nombre)
                           select cliente;

            return clientes.ToList();
        }

        public Boolean Validar_DNI_Cliente(int DNI)
        {
            MODELO.CLIENTE oCliente = oCatalogo.CLIENTES.FirstOrDefault(c => c.DNI == DNI);
            if (oCliente == null)
                return false;
            else
                return true;
        }
    }
}
