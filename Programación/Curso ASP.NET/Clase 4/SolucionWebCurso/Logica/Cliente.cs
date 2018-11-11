using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        Datos.Cliente objDatosCliente = new Datos.Cliente();
        public object TraerTodos()
        {
            return objDatosCliente.TraerTodos();
        }

        public object TraerxPais(string pPais)
        {
            return objDatosCliente.TraerxPais(pPais);
        }
        public object TraerPaises()
        {
            return objDatosCliente.TraerPaises();
        }

        public void Agregar(Entidades.Customer pCliente)
        {
            objDatosCliente.Agregar(pCliente);
        }
    }
}
