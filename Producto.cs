using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR_P1
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private readonly int _idUsuario;

        public Producto() 
        {
            _id = 0;
            _descripcion = string.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsuario = 0;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public double PrecioDeVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
        }
    }

}
