﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR_P1
{
    public class ProductoVendido
    {
        private int _id;
        private readonly int _idProducto;
        private int _stock;
        private readonly int _idVenta;

        public ProductoVendido()
        {
            _id = 0;
            _idProducto = 0;
            _stock = 0;
            _idVenta = 0;
        }

        public int Id
        { get { return _id; }  set { _id = value; }}

        public int IdProducto
        { get { return _idProducto; }}

        public int Stock
        { get { return _stock; } set { _stock = value; } }
        public int IdVenta 
        { get { return _idVenta; }}

    }
}
