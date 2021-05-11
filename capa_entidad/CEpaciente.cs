using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
   public class CEpaciente
    {
        private string id_paciente;
        private string tp_doc;
        private string nom_paciente;
        private string dr_paciente;
        private string tel_paciente;
        private string cd_paciente;
        private byte activo;

        public string Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string Tp_doc { get => tp_doc; set => tp_doc = value; }
        public string Nom_paciente { get => nom_paciente; set => nom_paciente = value; }
        public string Dr_paciente { get => dr_paciente; set => dr_paciente = value; }
        public string Tel_paciente { get => tel_paciente; set => tel_paciente = value; }
        public string Cd_paciente { get => cd_paciente; set => cd_paciente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
