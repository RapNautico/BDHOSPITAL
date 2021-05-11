using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capa_entidad;
using capa_negocios;
using System.Data;

namespace capasmiercoles
{
    public partial class formulario1 : System.Web.UI.Page
    {
        CNcita ONcita = new CNcita();
        CEcita OEcita = new CEcita();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnconsultarcita_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            OEcita.Cod_cita = Convert.ToString(txtcodcita.Text);
            OEcita.Fecha = Convert.ToDateTime(txtfecha.Text);
            OEcita.Hora = Convert.ToDateTime(txthora.Text);
            OEcita.Id_paciente = Convert.ToString(txtidpaciente.Text);
            OEcita.Id_medico = Convert.ToString(txtidmedico.Text);
            OEcita.Valor = Convert.ToInt32(txtvalor.Text);
            OEcita.Diagnostico = Convert.ToString(txtdiagnostico.Text);
            OEcita.Nom_acompanante = Convert.ToString(txtnomacomp.Text);

            if (ONcita.guardar_cita(OEcita))
            {
                lblrespuesta.Text = "Cita guardada";
            }
            else
            {
                lblrespuesta.Text = "No se pudo guardar la cita";
            }
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            OEcita.Cod_cita = Convert.ToString(txtcodcita);
            if(ONcita.anular_cita(OEcita))
            {
                lblrespuesta.Text = "La cita se ha eliminado correctamente"; 
            }
            else
            {
                lblrespuesta.Text = "No se pudo eliminar la cita";
            }
        }
    }
}