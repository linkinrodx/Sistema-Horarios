using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class TipoAmbienteBE
    {
        int oIdTipoAmbiente;
        string oDescripcion;

        public TipoAmbienteBE(DataRow data)
        {
            oIdTipoAmbiente = Convert.ToInt32(data["IdTipoAmbiente"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
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

        public string Description
        {
            get { return oDescripcion; }
            set { oDescripcion = value; }
        }

        public int Value
        {
            get { return oIdTipoAmbiente; }
            set { oIdTipoAmbiente = value; }
        }
    }
}
