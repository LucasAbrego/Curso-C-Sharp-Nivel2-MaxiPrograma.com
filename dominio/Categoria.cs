﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public Categoria() { }
        public Categoria(int Id, string Descripcion)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }

}
