using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class CeldaHorarioBE
    {
        int oIdHorario;
        int oIdDia;
        int oIdHora;
        int oIdDocente;
        int oIdAsignatura;
        int oIdAmbiente;
        int oIdTipoClase;

        public CeldaHorarioBE()
        {
            oIdHorario = 0;
            oIdDia = 0;
            oIdHora = 0;
            oIdDocente = 0;
            oIdAsignatura = 0;
            oIdAmbiente = 0;
            oIdTipoClase = 0;
        }

        public CeldaHorarioBE(DataRow data)
        {
            oIdHorario = Convert.ToInt32(data["IdHorario"]);
            oIdDia = Convert.ToInt32(data["IdDia"]);
            oIdHora = Convert.ToInt32(data["IdHora"]);
            oIdDocente = Convert.ToInt32(data["IdDocente"]);
            oIdAsignatura = Convert.ToInt32(data["IdAsignatura"]);
            oIdAmbiente = Convert.ToInt32(data["IdAmbiente"]);
            oIdTipoClase = Convert.ToInt32(data["IdTipoClase"]); 
        }

        public int IdHorario
        {
            get { return oIdHorario; }
            set { oIdHorario = value; }
        }

        public int IdDia
        {
            get { return oIdDia; }
            set { oIdDia = value; }
        }

        public int IdHora
        {
            get { return oIdHora; }
            set { oIdHora = value; }
        }

        public int IdDocente
        {
            get { return oIdDocente; }
            set { oIdDocente = value; }
        }

        public int IdAsignatura
        {
            get { return oIdAsignatura; }
            set { oIdAsignatura = value; }
        }

        public int IdAmbiente
        {
            get { return oIdAmbiente; }
            set { oIdAmbiente = value; }
        }        

        public int IdTipoClase
        {
            get { return oIdTipoClase; }
            set { oIdTipoClase = value; }
        }
    }
}
