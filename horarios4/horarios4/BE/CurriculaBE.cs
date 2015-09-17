using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class CurriculaBE
    {
        int oIdCurricula;        
        string oDescripcion;

        public CurriculaBE(DataRow data)
        {
            oIdCurricula = Convert.ToInt32(data["IdCurricula"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
        }

        public int IdCurricula
        {
            get { return oIdCurricula; }
            set { oIdCurricula = value; }
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
            get { return oIdCurricula; }
            set { oIdCurricula = value; }
        }
    }
}
