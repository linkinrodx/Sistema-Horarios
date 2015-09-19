using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class HorarioBE
    {
        int oIdHorario;
        int oIdCiclo;
        string oDescripcion;
        string oNombreCiclo;
        List<CeldaHorarioBE> oCeldas;

        public HorarioBE()
        {
            oIdHorario = 0;
            oIdCiclo = 0;
            oDescripcion = string.Empty;
            oNombreCiclo = string.Empty;
            oCeldas = new List<CeldaHorarioBE>();
        }

        public HorarioBE(DataRow data)
        {
            oIdHorario = Convert.ToInt32(data["IdHorario"]);
            oIdCiclo = Convert.ToInt32(data["IdCiclo"]);
            oDescripcion = Convert.ToString(data["Descripcion"]);
            oCeldas = new List<CeldaHorarioBE>();
        }

        public int IdHorario
        {
            get { return oIdHorario; }
            set { oIdHorario = value; }
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

        public string NombreCiclo
        {
            get { return oNombreCiclo; }
            set { oNombreCiclo = value; }
        }

        public List<CeldaHorarioBE> Celdas
        {
            get { return oCeldas; }
            set { oCeldas = value; }
        }
    }
}
