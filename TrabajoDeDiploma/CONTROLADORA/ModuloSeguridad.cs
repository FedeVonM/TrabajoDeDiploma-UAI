using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ModuloSeguridad
    {
        private static ModuloSeguridad Instancia;
        MODELO.CATALOGO oCatalogo;
        CONTROLADORA.cGrupos oCGrupos;
        CONTROLADORA.cInicio oCInicio;
        CONTROLADORA.cUsuarios oCUsuarios;
        CONTROLADORA.cLogin oCLogin;

        public static ModuloSeguridad ObtenerInstancia()
        {
            if (Instancia == null)
                Instancia = new ModuloSeguridad();

            return Instancia;
        }

        private ModuloSeguridad()
        {
            oCatalogo = MODELO.CATALOGO.Obtener_Instancia();
            oCGrupos = CONTROLADORA.cGrupos.Obtener_Instancia();
            oCInicio = CONTROLADORA.cInicio.Obtener_Instancia();
            oCUsuarios = CONTROLADORA.cUsuarios.Obtener_Instancia();
            oCLogin = CONTROLADORA.cLogin.Obtener_Instancia();
        }

        //----------------------------------------------------------------- Controladora de Grupos
        public void GestionaGrupo(string oAccion, MODELO.GRUPO oGrupo)
        {
            switch (oAccion)
            {
                case "Agrega":
                    {
                        oCGrupos.Agregar_Grupo(oGrupo);
                        break;
                    }
                case "Modifica":
                    {
                        oCGrupos.Modificar_Grupo(oGrupo);
                        break;
                    }
                case "Cancela":
                    {
                        oCGrupos.Cancelar_Cambios(oGrupo);
                        break;
                    }
                case "Elimina":
                    {
                        oCGrupos.Eliminar_Grupo(oGrupo);
                        break;
                    }
            }

        }

        public List<MODELO.GRUPO> ObtenerGrupo()
        {
            return oCGrupos.Obtener_Grupos();
        }

        public MODELO.GRUPO ObtenerGrupo(Int32 Codigo)
        {
            return oCGrupos.Obtener_Grupo(Codigo);
        }

        public System.Collections.IEnumerable FiltrarGrupos(string Descripcion, bool Inactivos)
        {
            return oCGrupos.Filtrar_Grupos(Descripcion, Inactivos);
        }

        public List<MODELO.USUARIO> ObtenerUsuarios()
        {
            return oCGrupos.Obtener_Usuarios();
        }

        public List<MODELO.MODULO> ObtenerModulos()
        {
            return oCGrupos.Obtener_Modulos();
        }

        //----------------------------------------------- Controladora De Inicio
        public void IniciaBaseDeDatos()
        {
            oCInicio.IniciaBaseDeDatos();
        }

        public void ActualizaModulo(string nombre)
        {
            oCInicio.ACTUALIZA_MODULO(nombre);
        }

        public void ActualizaFormularios(MODELO.formulario form)
        {
            oCInicio.ACTUALIZA_FORMULARIOS(form);
        }

        public void ActualizaAcciones(MODELO.accion accion)
        {
            oCInicio.ACTUALIZA_ACCIONES(accion);
        }

        //--------------------------------------------------------------------------Controladora de Login
        public MODELO.USUARIO ValidarUsuario(string usuario, string clave)
        {
            MODELO.USUARIO oUSUARIO = oCLogin.VALIDAR_USUARIO(usuario, clave);
            return oUSUARIO;
        }

        public void RegistraIngreso(MODELO.USUARIO oUSUARIO)
        {
            oCLogin.RegistraIngreso(oUSUARIO);
        }

        public void RegistrarEgreso(MODELO.USUARIO oUSUARIO_ACTUAL)
        {
            oCLogin.RegistrarEgreso(oUSUARIO_ACTUAL);
        }

        //--------------------------------------------------------------------Controladora de Usuario
        public void AgregarUsuario(MODELO.USUARIO oUSUARIO)
        {
            oCUsuarios.Agregar_Usuario(oUSUARIO);
        }

        public System.Collections.IEnumerable FiltrarUsuarios(string Nombre, bool Inactivos)
        {
            return oCUsuarios.Filtrar_Usuarios(Nombre, Inactivos);
        }

        public MODELO.USUARIO ObtenerUsuario(int codigo)
        {
            return oCUsuarios.Obtener_Usuario(codigo);
        }

        public MODELO.USUARIO ObtenerUsuarioPorMail(string Email)
        {
            return oCUsuarios.Obtener_Usuario_Por_Mail(Email);
        }

        public void EliminarUsuario(MODELO.USUARIO oUSUARIO)
        {
            oCUsuarios.Eliminar_Usuario(oUSUARIO);
        }

        public void CancelarCambios(MODELO.USUARIO oUSUARIO)
        {
            oCUsuarios.Cancelar_Cambios(oUSUARIO);
        }

        public void ModificarUsuario(MODELO.USUARIO oUSUARIO)
        {
            oCUsuarios.Modificar_Usuario(oUSUARIO);
        }

        public List<MODELO.GRUPO> ObtenerGruposActivos()
        {
            return oCUsuarios.Obtener_Grupos();
        }

        public bool ValidaNombreDeUsuario(string nombre_usuario, int codigo_usuario)
        {
            return oCUsuarios.Valida_Nombre_De_Usuario(nombre_usuario, codigo_usuario);
        }

        public bool ValidaMailUsuario(string email, int codigo_usuario)
        {
            return oCUsuarios.Valida_Mail_Usuario(email, codigo_usuario);
        }
    }
}
