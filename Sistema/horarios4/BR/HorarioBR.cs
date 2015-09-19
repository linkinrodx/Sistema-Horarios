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
    public class HorarioBR
    {
        public static DataTable GetHorario()
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.HorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.HorarioTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Horario);

                return dst.Horario;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static HorarioBE GetHorariobyId(int IdHorario)
        {
            HorarioBE oHorario;

            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.HorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.HorarioTableAdapter();

                dfd.GetHorariobyId(IdHorario);
                dfd.FillHorariobyId(dst.Horario, IdHorario);

                oHorario = new HorarioBE(dst.Horario.FirstOrDefault());

                oHorario.Celdas = CeldaHorarioBR.GetCeldasbyIdHorario(oHorario.IdHorario);
            }
            catch (Exception)
            {
                throw;
            }

            return oHorario;
        }

        public static void InsHorario(HorarioBE oHorario)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.HorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.HorarioTableAdapter();

                dfd.InsHorario(oHorario.IdCiclo, oHorario.Descripcion);

                dfd.GetData();
                dfd.Fill(dst.Horario);

                oHorario.IdHorario = (int)dst.Horario.LastOrDefault()["IdHorario"];
                oHorario.Celdas.ForEach(o => o.IdHorario = oHorario.IdHorario);

                foreach (var o in oHorario.Celdas)
                {
                    if (o.IdAmbiente != 0 && o.IdAsignatura != 0 && o.IdDocente != 0 && o.IdTipoClase != 0)
                    {
                        CeldaHorarioBR.InsCelda(o);
                    }
                }

                oHorario = GetHorariobyId(oHorario.IdHorario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdHorario(HorarioBE oHorario)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.HorarioTableAdapter dfd = new DA.HorariosDataSetTableAdapters.HorarioTableAdapter();

                dfd.UpdHorario(oHorario.IdCiclo, oHorario.Descripcion, oHorario.IdHorario);
                
                foreach (var o in oHorario.Celdas)
                {
                    if (o.IdHorario == 0)
                    {
                        if (o.IdAmbiente != 0 && o.IdAsignatura != 0 && o.IdDocente != 0 && o.IdTipoClase != 0)
                        {
                            o.IdHorario = oHorario.IdHorario;
                            CeldaHorarioBR.InsCelda(o);
                        }
                    }
                    else
                    {
                        CeldaHorarioBR.UpdCelda(o);
                    }
                }

                oHorario = GetHorariobyId(oHorario.IdHorario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CicloBE> GetCiclo()
        {
            List<CicloBE> oCiclo = new List<CicloBE>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.CicloTableAdapter dfd = new DA.HorariosDataSetTableAdapters.CicloTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Ciclo);

                foreach (var o in dst.Ciclo)
                {
                    oCiclo.Add(new CicloBE(o));
                }
                
                return oCiclo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<HoraBE> GetHora()
        {
            List<HoraBE> oLista = new List<HoraBE>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.HoraTableAdapter dfd = new DA.HorariosDataSetTableAdapters.HoraTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Hora);

                foreach (var o in dst.Hora)
                {
                    oLista.Add(new HoraBE(o));
                }

                return oLista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TipoClaseBE> ListTipoClase()
        {
            List<TipoClaseBE> oLista = new List<TipoClaseBE>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.TipoClaseTableAdapter dfd = new DA.HorariosDataSetTableAdapters.TipoClaseTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.TipoClase);

                foreach (var o in dst.TipoClase)
                {
                    oLista.Add(new TipoClaseBE(o));
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
