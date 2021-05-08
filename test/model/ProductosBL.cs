using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.model
{
    public class ProductosBL
    {
        ProductosDAL _dal = new ProductosDAL();
        public List<productosEN> ConsultarProductos()
        {
            return _dal.ConsultarProductos();
        }
    }
}