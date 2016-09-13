using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class CATALOGO
    {
        private static CATALOGO Instancia;

        public static CATALOGO Obtener_Instancia()
        {
            if (Instancia == null)
                Instancia = new CATALOGO();

            return Instancia;
        }
    }
}
