using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class AsignaturaBE
    {
        int oIdAsignatura;
        int oIdCurricula;
        string oDescripcion;
        string oNombreCurricula;

        public AsignaturaBE()
        {
            oIdAsignatura = 0;
            oIdCurricula = 0;
            oDescripcion = string.Empty;
            oNombreCurricula = string.Empty; 
        }

        public AsignaturaBE(DataRow data)
        {
            oIdAsignatura = Convert.ToInt32(data["IdAsignatura"]);
            oIdCurricula = Convert.ToInt32(data["IdCurricula"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
            //oNombreCurricula = Convert.ToString(data["NombreCurricula"]); 
        }

        public int IdAsignatura
        {
            get { return oIdAsignatura; }
            set { oIdAsignatura = value; }
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

        public string NombreCurricula
        {
            get { return oNombreCurricula; }
            set { oNombreCurricula = value; }
        }

        public string Description
        {
            get { return oDescripcion; }
            set { oDescripcion = value; }
        }

        public int Value
        {
            get { return IdAsignatura; }
            set { IdAsignatura = value; }
        }
    }
}
