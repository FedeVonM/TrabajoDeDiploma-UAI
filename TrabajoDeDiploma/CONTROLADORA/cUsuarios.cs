using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cUsuarios
    {
        private static cUsuarios Instancia;
        MODELO.CATALOGO oCATALOGO;

        public static cUsuarios Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cUsuarios();

            return Instancia;
        }

        private cUsuarios()
        {
            oCATALOGO = MODELO.CATALOGO.Obtener_Instancia();
        }

        public void Agregar_Usuario(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.USUARIOS.Add(oUSUARIO);
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.USUARIO> Obtener_Usuarios()
        {
            return oCATALOGO.USUARIOS.ToList();
        }

        public System.Collections.IEnumerable Filtrar_Usuarios(string Nombre, bool Inactivos)
        {
            var usuarios = from usuario in oCATALOGO.USUARIOS.ToList()
                           where usuario.Nombre.Contains(Nombre)
                           select new { ID = usuario.Id_Usuario, USUARIO = usuario.Nombre_Usuario, NOMBRE = usuario.Nombre, GRUPOS = usuario.GRUPOS_USUARIO, ACTIVO = usuario.Activo };

            if (!Inactivos)
                usuarios = usuarios.Where(usu => usu.ACTIVO == true);

            return usuarios.ToList();
        }

        public MODELO.USUARIO Obtener_Usuario(int codigo)
        {
            return oCATALOGO.USUARIOS.Find(codigo);
        }

        public MODELO.USUARIO Obtener_Usuario_Por_Mail(string Email)
        {
            return oCATALOGO.USUARIOS.FirstOrDefault(u => u.Email.ToLower() == Email.ToLower());
        }

        public void Eliminar_Usuario(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void Cancelar_Cambios(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Detached;
        }

        public void Modificar_Usuario(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.GRUPO> Obtener_Grupos()
        {
            var grupos = from grupo in oCATALOGO.GRUPOS
                         where grupo.Activo == true
                         select grupo;

            return grupos.ToList();
        }

        public bool Valida_Nombre_De_Usuario(string nombre_usuario, int codigo_usuario)
        {
            MODELO.USUARIO oUSUARIO = oCATALOGO.USUARIOS.FirstOrDefault(u => (u.Nombre_Usuario == nombre_usuario) && (u.Id_Usuario != codigo_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }

        public bool Valida_Mail_Usuario(string email, int codigo_usuario)
        {
            MODELO.USUARIO oUSUARIO = oCATALOGO.USUARIOS.FirstOrDefault(u => (u.Email == email) && (u.Id_Usuario != codigo_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }
    }
}
