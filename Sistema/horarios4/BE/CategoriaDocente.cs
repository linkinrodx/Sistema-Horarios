using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class CategoriaDocente
    {
        int oIdCategoria;        
        string oDescripcion;

        public CategoriaDocente(DataRow data)
        {
            oIdCategoria = Convert.ToInt32(data["IdCategoria"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
        }

        public int IdCategoria
        {
            get { return oIdCategoria; }
            set { oIdCategoria = value; }
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
            get { return oIdCategoria; }
            set { oIdCategoria = value; }
        }
    }
}
