using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class USUARIO
    {
        public string GRUPOS_USUARIO
        {
            get
            {
                string gu = "";
                string separador = "";
                foreach (MODELO.GRUPO oGRUPO in this.GRUPO)
                {
                    gu += separador + oGRUPO.Descripcion;
                    separador = " | ";
                }
                return gu;
            }
        }

        public List<MODELO.MODULO> OBTENER_MODULOS()
        {
            MODELO.GRUPO oGrupo = this.GRUPO.FirstOrDefault(g => g.Descripcion == "SUPERUSUARIOS");
            if (oGrupo != null)
            {
                return CATALOGO.Obtener_Instancia().MODULOS.ToList();
            }
            else
            {
                List<MODELO.MODULO> oMODULOS = new List<MODULO>();
                foreach (MODELO.GRUPO oGRUPO in this.GRUPO)
                {
                    if (oGRUPO.Activo)
                    {
                        foreach (MODELO.ACCION oACCION in oGRUPO.ACCION)
                        {
                            if (oACCION.FORMULARIO.Menu && oACCION.FORMULARIO.Activo)
                            {
                                if (!oMODULOS.Contains(oACCION.FORMULARIO.SUBMODULO.MODULO)) oMODULOS.Add(oACCION.FORMULARIO.SUBMODULO.MODULO);
                            }
                        }
                    }

                }
                return oMODULOS;
            }
        }

        public List<MODELO.SUBMODULO> OBTENER_SUBMODULOS(MODELO.MODULO oMODULO)
        {
            if (this.GRUPO.Count(g => g.Descripcion == "SUPERUSUARIOS") > 0)
            {
                return oMODULO.SUBMODULO.ToList();
            }
            else
            {
                List<MODELO.SUBMODULO> oSUBMODULOS = new List<SUBMODULO>();
                foreach (MODELO.GRUPO oGRUPO in this.GRUPO)
                {
                    if (oGRUPO.Activo)
                    {
                        foreach (MODELO.ACCION oACCION in oGRUPO.ACCION)
                        {
                            if (oACCION.FORMULARIO.SUBMODULO.MODULO == oMODULO && oACCION.FORMULARIO.Menu && oACCION.FORMULARIO.Activo)
                            {
                                if (!oSUBMODULOS.Contains(oACCION.FORMULARIO.SUBMODULO)) oSUBMODULOS.Add(oACCION.FORMULARIO.SUBMODULO);
                            }
                        }
                    }

                }
                return oSUBMODULOS;
            }
        }

        public List<MODELO.FORMULARIO> OBTENER_FORMULARIOS(MODELO.SUBMODULO oSUBMODULO)
        {
            if (this.GRUPO.Count(g => g.Descripcion == "SUPERUSUARIOS") > 0)
            {
                var formularios = from formulario in oSUBMODULO.FORMULARIO
                                  where formulario.Menu == true
                                  select formulario;
                return (List<MODELO.FORMULARIO>)formularios.Distinct().ToList();
            }
            else
            {
                List<MODELO.FORMULARIO> oFORMULARIOS = new List<FORMULARIO>();
                foreach (MODELO.GRUPO oGRUPO in this.GRUPO)
                {
                    if (oGRUPO.Activo)
                    {
                        foreach (MODELO.ACCION oACCION in oGRUPO.ACCION)
                        {
                            if (oACCION.FORMULARIO.SUBMODULO == oSUBMODULO && oACCION.FORMULARIO.Menu && oACCION.FORMULARIO.Activo)
                            {
                                if (!oFORMULARIOS.Contains(oACCION.FORMULARIO)) oFORMULARIOS.Add(oACCION.FORMULARIO);
                            }
                        }
                    }

                }
                return oFORMULARIOS;
            }
        }

        public Boolean VALIDAR_ACCION(string formulario, string control)
        {
            bool RESULTADO = false;
            if (this.GRUPO.Count(g => g.Descripcion == "SUPERUSUARIOS") > 0)
            {
                RESULTADO = true;
            }
            else
            {
                MODELO.ACCION oACCION = CATALOGO.Obtener_Instancia().ACCIONES.FirstOrDefault(a => (a.Control == control) && (a.FORMULARIO.Clase == formulario));
                if (oACCION != null)
                {
                    foreach (MODELO.GRUPO oGRUPO in this.GRUPO)
                    {
                        if (oGRUPO.ACCION.Count(acc => acc.Id_Accion == oACCION.Id_Accion) > 0)
                            RESULTADO = true;
                    }
                }
            }
            return RESULTADO;
        }
    }
}
