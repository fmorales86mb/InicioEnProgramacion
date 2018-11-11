using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class Cliente {

        // Primero creo un LinQ to SQLClasses en Entidades. En el explorador sql agrego al servidor que uso si es que no aparece. Arrastro la tabla al Data Context.
        // En Datos creo la clase de la tabla que arrastré. 
        // Referenciar Datos a system.data.linq

        // Instancio un Data Context.
        Entidades.dcBDDataContext db = new Entidades.dcBDDataContext();

        // Creo un método.
        public object TraerTodos() {
            // Hago la consulta en linQ.
            var clientes = from c in db.Customers
                           select c;
            
            return clientes;
        }

        public object TraerPorPais(string pPais) {
            // LinQ
            // from (desde) c (las filas) in (en) db.Customers (tabla) 
            // where (donde) c.country (la columna country de las filas c) .equals (es igual) pPais (al string)
            // select c (seleccionar las filas c) -- podría también seleccionar columnas de las filas c
            var clientes = from c in db.Customers
                           where c.Country.Equals(pPais)
                           select c;
            return clientes;
        }

        public object TraerPaises() {
            var clientes = (from c in db.Customers
                         select new {c.Country}).Distinct();
            return clientes;
        }

    }
}
