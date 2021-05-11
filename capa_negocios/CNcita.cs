using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using capa_entidad;
using System.Data;

namespace capa_negocios
{
    public class CNcita
    {
        CDcita odatcitas = new CDcita();
        public bool guardar_cita(CEcita oentcita)
        {
            return odatcitas.Guardar_cita(oentcita);
        }
        public bool anular_cita(CEcita oentcita)
        {
            return odatcitas.anular_cita(oentcita);
        }
        public DataSet consulta_cita(CEcita oentcita)
        {
            return odatcitas.consultar_cita(oentcita);
        }
    }
}
