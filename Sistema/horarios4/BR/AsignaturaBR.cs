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
    public class AsignaturaBR
    {
        public static DataTable GetAsignatura()
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Asignatura);

                return dst.Asignatura;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static AsignaturaBE GetAsignaturabyId(int IdAsignatura)
        {
            AsignaturaBE oAsignatura;

            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter();

                dfd.GetAsignaturabyId(IdAsignatura);
                dfd.FillAsignaturabyId(dst.Asignatura, IdAsignatura);

                oAsignatura = new AsignaturaBE(dst.Asignatura.FirstOrDefault());
            }
            catch (Exception)
            {
                throw;
            }

            return oAsignatura;
        }

        public static void InsAsignatura(AsignaturaBE oAsignatura)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter();

                dfd.InsAsignatura(oAsignatura.IdCurricula, oAsignatura.Descripcion);

                dfd.GetData();
                dfd.Fill(dst.Asignatura);

                oAsignatura = new AsignaturaBE(dst.Asignatura.LastOrDefault());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdAsignatura(AsignaturaBE oAsignatura)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AsignaturaTableAdapter();

                dfd.UpdAsignatura(oAsignatura.IdCurricula, oAsignatura.Descripcion, oAsignatura.IdAsignatura);

                dfd.GetData();
                dfd.Fill(dst.Asignatura);

                oAsignatura = GetAsignaturabyId(oAsignatura.IdAsignatura);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CurriculaBE> GetCurricula()
        {
            List<CurriculaBE> oCurricula = new List<CurriculaBE>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CurriculaTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CurriculaTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Curricula);

                foreach (var o in dst.Curricula)
                {
                    oCurricula.Add(new CurriculaBE(o));
                }

                return oCurricula;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<AsignaturaBE> ListAsignatura()
        {
            List<AsignaturaBE> oLista = new List<AsignaturaBE>();
            try
            {
                foreach (DataRow o in GetAsignatura().Rows)
                {
                    oLista.Add(new AsignaturaBE(o));
                }

                return oLista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
