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
    public class DocenteBR
    {
        public static DataTable GetDocente()
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.DocenteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.DocenteTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Docente);

                return dst.Docente;
            }
            catch (Exception)
            {
                throw;
            }             
        }


        public static DocenteBE GetDocentebyId(int IdDocente)
        {
            DocenteBE oEgresado;

            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.DocenteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.DocenteTableAdapter();

                dfd.GetDocentebyId(IdDocente);
                dfd.FillDocentebyId(dst.Docente, IdDocente);

                oEgresado = new DocenteBE(dst.Docente.FirstOrDefault());
            }
            catch (Exception)
            {
                throw;
            }

            return oEgresado;
        }

        public static void InsDocente(DocenteBE oDocente)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.DocenteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.DocenteTableAdapter();


                dfd.InsDocente(oDocente.IdCategoria, oDocente.Grado, oDocente.Nombres, oDocente.Apellidos);

                dfd.GetData();
                dfd.Fill(dst.Docente);

                oDocente = new DocenteBE(dst.Docente.LastOrDefault());                 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdDocente(DocenteBE oDocente)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.DocenteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.DocenteTableAdapter();


                dfd.UpdDocente(oDocente.IdCategoria, oDocente.Grado, oDocente.Nombres, oDocente.Apellidos, oDocente.IdDocente);

                dfd.GetData();
                dfd.Fill(dst.Docente);

                oDocente = GetDocentebyId(oDocente.IdDocente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CategoriaDocente> GetCategoria()
        {
            List<CategoriaDocente> oCategoria = new List<CategoriaDocente>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CategoriaDocenteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CategoriaDocenteTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.CategoriaDocente);

                foreach (var o in dst.CategoriaDocente)
                {
                    oCategoria.Add(new CategoriaDocente(o));
                }

                return oCategoria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DocenteBE> ListDocente()
        {
            List<DocenteBE> oLista = new List<DocenteBE>();
            try
            {
                foreach (DataRow o in GetDocente().Rows)
                {
                    oLista.Add(new DocenteBE(o));
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
