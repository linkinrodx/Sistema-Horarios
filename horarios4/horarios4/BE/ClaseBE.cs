using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horarios4
{
    public class ClaseBE
    {
        int oid;
        int oid_Hora;
        int oid_docente;       
        int oid_ciclo;
        int oid_dia;
        int oid_ambiente;
        int oid_asignatura;
        String otipo_clase;
        String ohora_inicio;
        String ohora_fin;

        int oId_Tipo_Clase;


        public int id
        {
            get { return oid; }
            set { oid = value; }
        }
    
        public int id_Hora
        {
            get { return oid_Hora; }
            set { oid_Hora = value; }
        }

        public int id_docente
        {
            get { return oid_docente; }
            set { oid_docente = value; }
        }

        public int id_ciclo
        {
            get { return oid_ciclo; }
            set { oid_ciclo = value; }
        }

        public int id_dia
        {
            get { return oid_dia; }
            set { oid_dia = value; }
        }

        public int id_ambiente
        {
            get { return oid_ambiente; }
            set { oid_ambiente = value; }
        }

        public int id_asignatura
        {
            get { return oid_asignatura; }
            set { oid_asignatura = value; }
        }

        public String tipo_clase
        {
            get { return otipo_clase; }
            set { otipo_clase = value; }
        }

        public String hora_inicio
        {
            get { return ohora_inicio; }
            set { ohora_inicio = value; }
        }

        public String hora_fin
        {
            get { return ohora_fin; }
            set { ohora_fin = value; }
        }

        public int Id_Tipo_Clase
        {
            get { return oId_Tipo_Clase; }
            set { oId_Tipo_Clase = value; }
        }

    }
}
