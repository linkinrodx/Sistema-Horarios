using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class CicloBE
    {
         int oIdCiclo;
        string oDescripcion;

        public CicloBE(DataRow data)
        {
            oIdCiclo = Convert.ToInt32(data["IdCiclo"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
        }

        public int IdCiclo
        {
            get { return oIdCiclo; }
            set { oIdCiclo = value; }
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
            get { return oIdCiclo; }
            set { oIdCiclo = value; }
        }
    }
}
