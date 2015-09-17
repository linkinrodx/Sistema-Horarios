using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Data;

namespace horarios4
{

    class ClassDB
    {
        SqlConnection MiConexion;

        public void Conectar()
        {
            MiConexion = new SqlConnection("Data Source=ALVAROSACARI-PC;Initial Catalog=horarios;Integrated Security=True");
            MiConexion.Open();
        }

        public void Desconectar()
        { 
            MiConexion.Close();
        }

        public void EjecutarSql(String Query)
        {
            SqlCommand MiComando = new SqlCommand(Query, MiConexion);

            // ejecutamos la consulta (query) sql
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
            {
                MessageBox.Show("Operación completada", "la base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operación", "error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void MostrarGrid(DataGridView dg, String Query)
        {
            // conectarnos a la base de datos
            this.Conectar();
            
            // Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            // Crear un adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);

            // Llenar en DataSet
            MiDataAdapter.Fill(MiDataSet, "profesor");

            // Asignarle el valor adecuado a las propiedades del DataSet
            dg.DataSource = MiDataSet;
            dg.DataMember = "profesor";

            // nos desconectamos de la base de datos
            this.Desconectar();

        }

        public DataTable ConsultaNueva(String Query)
        {
            // conectarnos a la base de datos
            this.Conectar();

            // Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            // Crear un adaptador de datos
            SqlDataAdapter MiDataAdapter = new SqlDataAdapter(Query, MiConexion);

            // Llenar en DataSet
            MiDataAdapter.Fill(MiDataSet, "Horas");

            //// Asignarle el valor adecuado a las propiedades del DataSet
            //dg.DataSource = MiDataSet;
            //dg.DataMember = "profesor";

            DataTableCollection nuevo = MiDataSet.Tables;
            DataTable oTabla = new DataTable();

            foreach (DataTable o in nuevo)
            {
                oTabla = o;
            }
            
            this.Desconectar();
            return oTabla;
            // nos desconectamos de la base de datos

        }
    }
}
