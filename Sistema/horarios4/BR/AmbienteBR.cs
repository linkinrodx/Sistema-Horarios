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
    public class AmbienteBR
    {
        public static DataTable GetAmbiente()
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AmbienteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AmbienteTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.Ambiente);

                return dst.Ambiente;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static AmbienteBE GetAmbientebyId(int IdAmbiente)
        {
            AmbienteBE oAmbiente;

            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AmbienteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AmbienteTableAdapter();

                dfd.GetAmbientebyId(IdAmbiente);
                dfd.FillAmbientebyId(dst.Ambiente, IdAmbiente);

                oAmbiente = new AmbienteBE(dst.Ambiente.FirstOrDefault());
            }
            catch (Exception)
            {
                throw;
            }

            return oAmbiente;
        }

        public static void InsAmbiente(AmbienteBE oAmbiente)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AmbienteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AmbienteTableAdapter();


                dfd.InsAmbiente(oAmbiente.IdTipoAmbiente, oAmbiente.Descripcion);

                dfd.GetData();
                dfd.Fill(dst.Ambiente);

                oAmbiente = new AmbienteBE(dst.Ambiente.LastOrDefault());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdAmbiente(AmbienteBE oAmbiente)
        {
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.AmbienteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.AmbienteTableAdapter();


                dfd.UpdAmbiente(oAmbiente.IdTipoAmbiente, oAmbiente.Descripcion, oAmbiente.IdAmbiente);

                dfd.GetData();
                dfd.Fill(dst.Ambiente);

                oAmbiente = GetAmbientebyId(oAmbiente.IdAmbiente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TipoAmbienteBE> GetTipoAmbiente()
        {
            List<TipoAmbienteBE> oTipoAmbiente = new List<TipoAmbienteBE>();
            try
            {
                HorariosDataSet dst = new HorariosDataSet();
                DA.HorariosDataSetTableAdapters.TipoAmbienteTableAdapter dfd = new DA.HorariosDataSetTableAdapters.TipoAmbienteTableAdapter();

                dfd.GetData();
                dfd.Fill(dst.TipoAmbiente);

                foreach (var o in dst.TipoAmbiente)
                {
                    oTipoAmbiente.Add(new TipoAmbienteBE(o));
                }

                return oTipoAmbiente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<AmbienteBE> ListAmbiente()
        {
            List<AmbienteBE> oLista = new List<AmbienteBE>();
            try
            {
                foreach (DataRow o in GetAmbiente().Rows)
                {
                    oLista.Add(new AmbienteBE(o));
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
