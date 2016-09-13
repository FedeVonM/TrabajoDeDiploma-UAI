using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADORA
{
    public class cLogin
    {
        MODELO.CATALOGO oCatalogo;
        private static cLogin Instancia;

        public static cLogin Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new cLogin();
            return Instancia;
        }

        private cLogin()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
        }

        public MODELO.USUARIO VALIDAR_USUARIO(string usuario, string clave)
        {
            MODELO.USUARIO oUSUARIO = oCatalogo.USUARIOS.FirstOrDefault(a => a.Nombre_Usuario == usuario);
            if (oUSUARIO == null)
            {
                throw new Exception("No se ha encontrado el usuario ingresado");
            }

            if (oUSUARIO.Clave != cFunciones_Compartidas.EncriparClave(clave))
            {
                throw new Exception("La clave ingresada es incorrecta");
            }

            if (!oUSUARIO.Activo)
            {
                throw new Exception("El usuario actual se encuentra desactivado");
            }

            return oUSUARIO;
        }

        public void RegistraIngreso(USUARIO oUSUARIO)
        {
            MODELO.AUDITORIA_LOGIN oAuditoria = new MODELO.AUDITORIA_LOGIN();
            oAuditoria.Entrada = DateTime.Now;
            oAuditoria.USUARIO = oUSUARIO;
            oCatalogo.AUDITORIAS_LOGIN.Add(oAuditoria);
            oCatalogo.SaveChanges();
        }

        public void RegistrarEgreso(USUARIO oUSUARIO_ACTUAL)
        {
            MODELO.AUDITORIA_LOGIN oAuditoria;
            oAuditoria = (from auditoria in oCatalogo.AUDITORIAS_LOGIN
                          orderby auditoria.Id_Auditoria_Login
                          where auditoria.USUARIO.Id_Usuario == oUSUARIO_ACTUAL.Id_Usuario
                          select auditoria).ToList().Last();
            oAuditoria.Salida = DateTime.Now;
            oCatalogo.SaveChanges();
        }
    }
}
