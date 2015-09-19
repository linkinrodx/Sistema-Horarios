using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace horarios4.BE
{
    public class DocenteBE
    {
        int oIdDocente;
        int oIdCategoria;
        string oGrado;
        string oNombres;
        string oApellidos;
        string oNombreCategoria;
        string oDescription;

        public DocenteBE()
        {
            oIdDocente = 0;
            oIdCategoria = 0;
            oGrado = string.Empty;
            oNombres = string.Empty;
            oApellidos = string.Empty;
            oNombreCategoria = string.Empty;
        }

        public DocenteBE(DataRow data)
        {
            oIdDocente = Convert.ToInt32(data["IdDocente"]);
            oIdCategoria = Convert.ToInt32(data["IdCategoria"]);
            oGrado = Convert.ToString(data["Grado"]);
            oNombres = Convert.ToString(data["Nombres"]);
            oApellidos = Convert.ToString(data["Apellidos"]);
            //try
            //{
            //    oNombreCategoria = Convert.ToString(data["NombreCategoria"]);
            //}
            //catch (Exception)
            //{
            //    oNombreCategoria = string.Empty;
            //}
        }

        public int IdDocente
        {
            get { return oIdDocente; }
            set { oIdDocente = value; }
        }

        public int IdCategoria
        {
            get { return oIdCategoria; }
            set { oIdCategoria = value; }
        }

        public string Grado
        {
            get { return oGrado; }
            set { oGrado = value; }
        }

        public string Nombres
        {
            get { return oNombres; }
            set { oNombres = value; }
        }

        public string Apellidos
        {
            get { return oApellidos; }
            set { oApellidos = value; }
        }

        public string NombreCategoria
        {
            get { return oNombreCategoria; }
            set { oNombreCategoria = value; }
        }

        public string Description
        {
            get { return Nombres + " " + Apellidos; }
            set { oDescription = value; }
        }

        public int Value
        {
            get { return oIdDocente; }
            set { oIdDocente = value; }
        }
    }
}
