using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class TipoClaseBE
    {
        int oIdTipoClase;
        string oDescripcion;

        public TipoClaseBE(DataRow data)
        {
            oIdTipoClase = Convert.ToInt32(data["IdTipoClase"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
        }

        public int IdTipoClase
        {
            get { return oIdTipoClase; }
            set { oIdTipoClase = value; }
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
            get { return oIdTipoClase; }
            set { oIdTipoClase = value; }
        }
    }
}
