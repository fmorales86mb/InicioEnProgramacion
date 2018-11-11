using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica {
    public class EspecialidadDeProfesional {

        public static List<Entidades.Especialidad> TablaEspecialidadesDeProfesional(int idProfesional) {            
            return Datos.EspecialidadesDeProfesional.TablaEspecialidadesDeProfesional(idProfesional);
        }

        public static bool GuardarEspecialidadesDeProfesional(Entidades.Profesional objProfesional, Entidades.Especialidad objEspecialidad) {
            return Datos.EspecialidadesDeProfesional.GuardarEspecialidadesDeProfesional(objProfesional, objEspecialidad);
        }

        public static void Borrar(Entidades.Profesional objProfesional, Entidades.Especialidad objEspecialidad) {
            Datos.EspecialidadesDeProfesional.Borrar(objProfesional, objEspecialidad);
        }
    }
}
