using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class HoraBE
    {
        int oIdHora;
        string oHoraInicio;
        string oHoraFin;
        string oTextoHora;

        public HoraBE(DataRow data)
        {
            oIdHora = Convert.ToInt32(data["IdHora"]);
            oHoraInicio = Convert.ToString(data["HoraInicio"]);
            oHoraFin = Convert.ToString(data["HoraFin"]);
            oTextoHora = string.Empty;
        }

        public int IdHora
        {
            get { return oIdHora; }
            set { oIdHora = value; }
        }

        public string HoraInicio
        {
            get { return oHoraInicio; }
            set { oHoraInicio = value; }
        }

        public string HoraFin
        {
            get { return oHoraFin; }
            set { oHoraFin = value; }
        }

        public string TextoHora
        {
            get { return oTextoHora = HoraInicio + " : " + HoraFin; }
            set { oTextoHora = value; }
        }
    }
}
