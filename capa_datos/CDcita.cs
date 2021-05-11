using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_entidad;
using System.Data;
using System.Data.SqlClient;

namespace capa_datos
{
    public class CDcita
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_cita(CEcita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.connectar("BDHOSPITAL");
                ocmd.CommandText = "actualizar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@id_paciente", ocitas.Id_paciente);
                ocmd.Parameters.Add("@id_medico", ocitas.Id_medico);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompanante", ocitas.Nom_acompanante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }

        }
        public bool anular_cita(CEcita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.connectar("BDHOSPITAL");
                ocmd.CommandText = "anular_cita";
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_cita(CEcita ocitas)
        {
            try
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.connectar("BDHOSPITAL");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            } 
             catch (Exception err)
            {
                throw new Exception(err.Message);
            }
                  
        }
        
    }
}
