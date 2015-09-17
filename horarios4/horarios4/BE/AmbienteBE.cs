using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class AmbienteBE
    {
        int oIdAmbiente;
        int oIdTipoAmbiente;
        string oDescripcion;
        string oNombreTipoAmbiente;

        public AmbienteBE()
        {
            oIdAmbiente = 0;
            oIdTipoAmbiente = 0;
            oDescripcion = string.Empty;
            oNombreTipoAmbiente = string.Empty; 
        }

        public AmbienteBE(DataRow data)
        {
            oIdAmbiente = Convert.ToInt32(data["IdAmbiente"]);
            oIdTipoAmbiente = Convert.ToInt32(data["IdTipoAmbiente"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
            //oNombreTipoAmbiente = Convert.ToString(data["NombreTipoAmbiente"]); 
        }

        public int IdAmbiente
        {
            get { return oIdAmbiente; }
            set { oIdAmbiente = value; }
        }

        public int IdTipoAmbiente
        {
            get { return oIdTipoAmbiente; }
            set { oIdTipoAmbiente = value; }
        }

        public string Descripcion
        {
            get { return oDescripcion; }
            set { oDescripcion = value; }
        }

        public string NombreTipoAmbiente
        {
            get { return oNombreTipoAmbiente; }
            set { oNombreTipoAmbiente = value; }
        }

        public string Description
        {
            get { return oDescripcion; }
            set { oDescripcion = value; }
        }

        public int Value
        {
            get { return IdAmbiente; }
            set { IdAmbiente = value; }
        }
    }
}
