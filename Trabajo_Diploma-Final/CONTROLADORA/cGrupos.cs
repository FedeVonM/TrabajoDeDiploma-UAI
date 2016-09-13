using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cGrupos
    {
        private static cGrupos Instancia;
        MODELO.CATALOGO oCATALOGO;

        public static cGrupos Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cGrupos();

            return Instancia;
        }

        private cGrupos()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Grupo(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.GRUPOS.Add(oGRUPO);
            oCATALOGO.SaveChanges();
        }

        public void Modificar_Grupo(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.Entry(oGRUPO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Cancelar_Cambios(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.Entry(oGRUPO).State = System.Data.Entity.EntityState.Detached;
        }

        public void Eliminar_Grupo(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.GRUPOS.Remove(oGRUPO);
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.GRUPO> Obtener_Grupos()
        {
            return oCATALOGO.GRUPOS.ToList();
        }

        public List<MODELO.USUARIO> Obtener_Usuarios()
        {
            return oCATALOGO.USUARIOS.ToList();
        }

        public List<MODELO.MODULO> Obtener_Modulos()
        {
            return oCATALOGO.MODULOS.ToList();
        }

        public System.Collections.IEnumerable Filtrar_Grupos(string Descripcion, bool Inactivos)
        {
            var grupos = from grupo in oCATALOGO.GRUPOS.ToList()
                         where grupo.Descripcion.Contains(Descripcion)
                         select new { ID = grupo.Id_Grupo, DESCRIPCIÓN = grupo.Descripcion, USUARIOS = grupo.USUARIO.Count, ACTIVO = grupo.Activo };
            if (!Inactivos)
            {
                grupos = grupos.Where(gr => gr.ACTIVO == true);
            }

            return grupos.ToList();
        }

        public MODELO.GRUPO Obtener_Grupo(Int32 Codigo)
        {
            return oCATALOGO.GRUPOS.Find(Codigo);
        }
    }
}
