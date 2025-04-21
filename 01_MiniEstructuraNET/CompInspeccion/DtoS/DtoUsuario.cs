using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoUsuario
    {
        public int usuario_id;
        public int perfil_id = -1;
        public String usr_nombre = String.Empty;
        public String usr_primer_apellido = String.Empty;
        public String usr_segundo_apellido = String.Empty;

        public String usr_puesto = String.Empty;
        public String usr_telefono = String.Empty;
        public String usr_lada = String.Empty;
        public String usr_password = String.Empty;
        public String usr_login = String.Empty;
        public String usr_email = String.Empty;
        public String usr_estatus = String.Empty;
        public String usr_fec_creacion = String.Empty;
        public String usr_fec_modificacion = String.Empty;
        public int? cen_cve_edorep;
        public int? cur_cve_ur;
        public int? core_usuario_id;
        public DateTime? update_data_at { get; set; }
        
        //Campo agregado para el master
        public String nombre_completo = String.Empty;
        public int participante;
        public int par_es_firmante;

        //campos agregados para módulo de seguimiento 30/08/2017 EZ
        //atributos
        public bool usr_admin = false;
        public bool usr_reporte = false;
        public bool usr_viatico = false;
        public bool usr_inspector = false;
        public bool usr_semaforo = false;

        public String correo_institucional = String.Empty;
    }

    public class DtoSusuario
    {
        public int s_usuario_id;
        public int s_perfil_id = -1;
        public String susr_nombre = String.Empty;
        public String susr_primer_apellido = String.Empty;
        public String susr_segundo_apellido = String.Empty;

        public String susr_puesto = String.Empty;
        public String susr_telefono = String.Empty;
        public String susr_lada = String.Empty;
        public String susr_password = String.Empty;
        public String susr_login = String.Empty;
        public String susr_email = String.Empty;
        public String susr_estatus = String.Empty;
        public String susr_fec_creacion = String.Empty;
        public String susr_fec_modificacion = String.Empty;
        public int? cve_edorep;
        public int? cve_ur;
        public int? core_usuario_id;

        public DateTime? update_data_at { get; set; }

        //Campo agregado para el master
        public String nombre_completo = String.Empty;
        public int participante;
        public int spar_es_firmante;

        public String correo_institucional = String.Empty;
    }

    public class DtoUsuarioEstatus
    {
        public String usr_estatus = String.Empty;
        public int? core_usuario_id;
        public String usr_email = String.Empty;
        public String usr_nombre = String.Empty;
        public String usr_primer_apellido = String.Empty;
        public String usr_segundo_apellido = String.Empty;

    }

}
