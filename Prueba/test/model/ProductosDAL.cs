using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace test.model
{
    public class ProductosDAL
    {
        IDbConnection _con = DBCommon.Conexion();
        //metodo de agregar

        //metodo de consultar
        public List<productosEN> ConsultarProductos()
        {
            _con.Open();
            SqlCommand _comand = new SqlCommand("ConsultarProductos",_con as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
            List<productosEN> _lista = new List<productosEN>();
            while (_reader.Read())
            {
                productosEN prodEN = new productosEN();
                prodEN.Id = _reader.GetInt64(0);
                prodEN.Nombre = _reader.GetString(1);
                prodEN.Descripcion = _reader.GetString(2);
                prodEN.Imagen = _reader.GetString(3);
                prodEN.Precio = _reader.GetDecimal(4);

                _lista.Add(prodEN);
            }
            _con.Close();
            return _lista;
        }
    }
}