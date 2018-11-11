using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        public List<Entidades.Producto> traerTodos()
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            return objDatosProducto.TraerTodos();
        }

        //Para modificar Producto
        public DataTable TraerParaModificar()
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            return objDatosProducto.TraerParaModificar();
        }

        public Entidades.Producto TraerUno(int pId)
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            return objDatosProducto.TraerUno(pId);
        }

        public void Modificar(Entidades.Producto pProducto)
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            objDatosProducto.Modificar(pProducto);
        }

        //Para agregar producto

        public DataTable TraerCategorias()
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            return objDatosProducto.TraerCategorias();
        }
        public void Agregar(Entidades.Producto pProducto)
        {
            Datos.Producto objDatosProducto = new Datos.Producto();
            objDatosProducto.Agregar(pProducto);
        }

    }
}
