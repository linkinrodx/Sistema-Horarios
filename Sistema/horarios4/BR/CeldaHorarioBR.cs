using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using horarios4.BE;
using horarios4.DA;
using System.Data;

namespace horarios4.BR
{
    public class CeldaHorarioBR
    {
        public static List<CeldaHorarioBE> GetCeldasbyIdHorario(int IdHorario)
        {
            List<CeldaHorarioBE> oLista = new List<CeldaHorarioBE>();

            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter();

                dfd.GetCeldabyId(IdHorario);
                dfd.FillCeldabyId(dst.CeldaHorario, IdHorario);

                foreach (var o in dst.CeldaHorario)
                {
                    oLista.Add(new CeldaHorarioBE(o));
                }                
            }
            catch (Exception)
            {
                throw;
            }

            return oLista;
        }

        public static void InsCelda(CeldaHorarioBE oCelda)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter();


                dfd.InsCelda(oCelda.IdHorario, oCelda.IdDia, oCelda.IdHora, oCelda.IdDocente, oCelda.IdAsignatura, oCelda.IdAmbiente, oCelda.IdTipoClase);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdCelda(CeldaHorarioBE oCelda)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CeldaHorarioTableAdapter();

                dfd.UpdCelda(oCelda.IdHorario, oCelda.IdDia, oCelda.IdHora, oCelda.IdDocente, oCelda.IdAsignatura, oCelda.IdAmbiente, oCelda.IdTipoClase);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static object valid(int x)
        {
            if (Convert.IsDBNull(x))
            {
                return Convert.DBNull;
            }
            else
            {
                return x;
            }
        }
    }
}
